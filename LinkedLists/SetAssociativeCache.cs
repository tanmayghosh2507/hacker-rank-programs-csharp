using System;
using System.Collections.Generic;
using System.Threading;

namespace InterviewPractice.LinkedLists
{
    // Enum for choosing Cache replacement algo
    public enum Algorithms
    {
        LRU,
        MRU
    }

    // Interface for Using multiple cache replacement strategy
    public interface ICacheReplacementStrategy
    {
        // Replaces the cache in a case of a cache miss
        public void UpdateCache(int key);

        // Implementation of the key to cache set mapping
        public int GetIndexToUpdate();
    }

    public class LRUCacheReplacementStrategy : ICacheReplacementStrategy
    {
        private int[] usageTimestamp;
        private int currentTimestamp;
        private readonly object lockObj = new object();

        public LRUCacheReplacementStrategy(int N) {
            usageTimestamp = new int[N];
            currentTimestamp = 0;
        }

        // Update the usage timestamp of the corresponding cache
        public void UpdateCache(int setIndex)
        {
            lock(lockObj) {
                usageTimestamp[setIndex] = currentTimestamp++;
            }
        }

        // Find a cache with the lowest LastUsed time
        public int GetIndexToUpdate()
        {
            lock(lockObj) {
                int minLastUsed = int.MaxValue;
                int index = 0;

                for(int i=0; i<usageTimestamp.Length; i++)
                {
                    if(usageTimestamp[i] < minLastUsed)
                    {
                        minLastUsed = usageTimestamp[i];
                        index = i;
                    }
                }

                return index;
            }
        }
    }

    public class MRUCacheReplacementStrategy : ICacheReplacementStrategy
    {
        private int[] usageTimestamp;
        private int currentTimestamp;
        private readonly object lockObj = new object();

        public MRUCacheReplacementStrategy(int N) {
            usageTimestamp = new int[N];
            currentTimestamp = 0;
        }

        // Update the usage timestamp of the corresponding cache
        public void UpdateCache(int setIndex)
        {
            lock(lockObj) {
                usageTimestamp[setIndex] = currentTimestamp++;
            }
        }

        // Find a cache with the lowest LastUsed time
        public int GetIndexToUpdate()
        {
            lock(lockObj) {
                int maxLastUsed = int.MinValue;
                int index = 0;

                for(int i=0; i<usageTimestamp.Length; i++)
                {
                    if(usageTimestamp[i] > maxLastUsed)
                    {
                        maxLastUsed = usageTimestamp[i];
                        index = i;
                    }
                }

                return index;
            }
        }
    }

    // Single unit of information. A Cache with Key value pair and a flag to maintain it's validity.
    public class Cache
    {
        public bool Valid { get; set; }
        public int Key { get; set; }
        public int Value { get; set; }
    }

    public class SetAssociativeCache
    {
        private readonly int S; // S no of sets
        private readonly int N; // n-sized sets
        private readonly Cache[][] cacheSet;  // This holds the cache List
        private readonly Dictionary<int, int> keySet;   // This holds the key-set mapping for a quick lookup
        private readonly ICacheReplacementStrategy replacementAlgorithm;    // Replacement algo
        private readonly ReaderWriterLockSlim cacheLock;

        public SetAssociativeCache(int numSets, int sizeOfSet, Algorithms algorithm)
        {
            S = numSets;
            N = sizeOfSet;
            cacheSet = new Cache[S][];  // Contains S*N spaces for keeping caches
            keySet = new();    // Contains all keys(just the keys) in a set

            if(algorithm == Algorithms.MRU) {
                replacementAlgorithm = new MRUCacheReplacementStrategy(S*N);
            } else {
                replacementAlgorithm = new LRUCacheReplacementStrategy(S*N);
            }
            cacheLock = new();
        }

        public int GetValue(int key)
        {
            cacheLock.EnterReadLock();

            try {
                if(keySet.ContainsKey(key))
                {
                    foreach (Cache c in cacheSet[key])
                    {
                        if (c.Valid && c.Key == key)
                        {
                            // Cache hit; update timestamp
                            return c.Value;
                        }
                    }
                }

                // Cache miss
                return -1;
            }
            finally
            {
                cacheLock.ExitReadLock();
            }
        }

        public void AddOrUpdate(int key, int value)
        {
            cacheLock.EnterUpgradeableReadLock();

            try {
                int setIndex = GetSetIndex(key);
                if(setIndex != -1)
                {
                    cacheLock.EnterWriteLock();
                    try {
                        cacheSet[setIndex][key].Value = value;
                        replacementAlgorithm.UpdateCache(setIndex);
                    }
                    finally
                    {
                        cacheLock.ExitWriteLock();
                    }
                }
                else
                {
                    if (keySet.Count == S*N)
                    {
                        cacheLock.EnterWriteLock();
                        try {
                            int replaceIndex = replacementAlgorithm.GetIndexToUpdate();
                            int keyToRemove = cacheSet[replaceIndex][key].Key;
                            setIndex = GetSetIndex(keyToRemove);

                            keySet.Remove(keyToRemove);
                            cacheSet[replaceIndex].Valid = false;
                        }
                        finally
                        {
                            cacheLock.ExitWriteLock();
                        }
                    }
                    else
                    {
                        for(int i=0; i<cacheSet.Length; i++)
                        {
                            Cache c = cacheSet[i];
                            if (!c.Valid)
                            {
                                setIndex = i;
                            }
                        }
                    }

                    cacheLock.EnterWriteLock();
                    try {
                        cacheSet[setIndex].Key = key;
                        cacheSet[setIndex].Value = value;
                        cacheSet[setIndex].Valid = true;
                        keySet.Add(key);

                        replacementAlgorithm.UpdateCache(setIndex);
                    }
                    finally
                    {
                        cacheLock.ExitWriteLock();
                    }
                    
                }
            }
            finally
            {
                cacheLock.ExitUpgradeableReadLock();
            }
        }

        // Finds a key in cache set. Returns -1 if not found.
        private int GetSetIndex(int key) 
        {
            for(int i=0; i<cacheSet.Length; i++)
            {
                Cache c = cacheSet[i];
                if (c.Valid && c.Key == key)
                {
                    return i;
                }
            }

            return -1;
        }

        // Helper method to print the cache content
        public void PrintCache() {
            for (int i = 0; i < cacheSet.Length; i++)
            {
                Console.WriteLine(cacheSet[i].Key + " : " + cacheSet[i].Value + " : " + cacheSet[i].Valid);
            }
        }
    }
}
