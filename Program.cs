﻿using System;
using System.Numerics;
using System.Collections.Generic;

namespace HackerRankCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAlice();
            //RunDiagonalDiff();
            //RunMilitary();
            //RunIceCreamParlor();
            //RunFunnyString();
            //RunGemStone();
            //RunFibonacci();
            //RunJourneyToMoon();
            //RunPrincessGame();
            //RunPowerSum();
            //RunMissingNumbers();
            //RunPairs();
            //RunSherlockArray();
            //RunSamSubstring();
            //RunCoinChange();
            // var num = Console.ReadLine();
            MinHeapImpl();

            // QuickSortImpl();

            // LRUCacheImpl();
        }

        static void MinHeapImpl()
        {
            MinHeap heap = new();
            heap.Insert(4);
            heap.Insert(7);
            heap.Insert(10);
            heap.Insert(6);
            heap.Insert(15);

            Console.WriteLine("Heap Size: " + heap.size);
            Console.WriteLine("Min Element: " + heap.GetMin());

            while(heap.size > 0)
            {
                Console.WriteLine("Deleted " + heap.DeleteMin());
            }
        }

        static void QuickSortImpl()
        {
            QuickSort qSort = new();
            int[] arr = new int[] {2, 5, 8, 4, 1, 7, 1, 9, 3};
            qSort.QSort(arr);
            foreach(int i in arr) {
                Console.WriteLine(i);
            }
        }

        static void LRUCacheImpl()
        {
            LRUCache lruCache = new(4);
            lruCache.Put(7, 5);
            lruCache.Put(5, 4);
            lruCache.Put(4, 8);
            lruCache.Put(2, 1);
            lruCache.Put(7, 3);
            lruCache.Get(5);
        }

        static void SetAssociativeCacheImpl() {
            // SetAssociativeCache saCache = new(3,3);
            // saCache.AddOrUpdate(10,5);
            // saCache.AddOrUpdate(4,6);
            // saCache.AddOrUpdate(6,2);
            // saCache.AddOrUpdate(3,4);
            // saCache.AddOrUpdate(5,1);
            // saCache.AddOrUpdate(6,7);
            // Console.WriteLine(saCache.GetValue(6));
            // Console.WriteLine(saCache.GetValue(7));
            // Console.WriteLine(saCache.GetValue(3));
            // saCache.AddOrUpdate(7,9);
            // saCache.AddOrUpdate(13,6);
            // saCache.PrintCache();

            SetAssociativeCache cache = new SetAssociativeCache(4, 2);

            // Add some key-value pairs to the cache
            cache.AddOrUpdate(1, 1);
            cache.AddOrUpdate(2, 2);
            cache.AddOrUpdate(3, 3);

            // Retrieve values from the cache
            Console.WriteLine("Value 1 found: " + cache.GetValue(1));
            Console.WriteLine("Value 2 found: " + cache.GetValue(2));

            // Add a new key-value pair that exceeds the cache capacity
            cache.AddOrUpdate(4, 4);
            cache.AddOrUpdate(5, 5);

            // Retrieve values from the cache
            Console.WriteLine("Value 3 found: " + cache.GetValue(3));
            Console.WriteLine("Value 4 found: " + cache.GetValue(4));
            Console.WriteLine("Value 5 found: " + cache.GetValue(5));

            // Update an existing key-value pair
            cache.AddOrUpdate(2, 22);

            // Retrieve updated value from the cache
            Console.WriteLine("Value 2 found: " + cache.GetValue(2));

            cache.PrintCache();
        }

        // Utility method to run the Alice and Bob game program.
        static void RunAlice()
        {
            AliceBobGame abGame = new AliceBobGame();
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = abGame.Solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
        }

        // Utility method to run Diagonal Difference Program.
        static void RunDiagonalDiff()
        {
            DiagonalDifference dDifference = new DiagonalDifference();
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            Console.WriteLine(dDifference.DiagonalDiff(n, a));
        }

        // Utility method to run Time Conversion Program.
        static void RunMilitary()
        {
            TimeConversion timeConversion = new TimeConversion();
            string s = Console.ReadLine();
            string result = timeConversion.timeConversion(s);
            Console.WriteLine(result);
        }

        // Utility Method to run Ice Cream Parlor Program.
        static void RunIceCreamParlor()
        {
            int trips = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<trips; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(temp, Int32.Parse);
                IceCreamParlor iceCreamParlor = new IceCreamParlor();
                int[] result = iceCreamParlor.getCombination(a, m, n);
                Console.WriteLine(result[0] + " " + result[1]);
            }
        }

        // Utility method to run Funny String Program.
        static void RunFunnyString()
        {
            int q = Convert.ToInt32(Console.ReadLine());
            FunnyString funnyString = new FunnyString();
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                string result = funnyString.CheckFunnyString(s);
                Console.WriteLine(result);
            }
        }

        // Utility method to run GemStone Program.
        static void RunGemStone()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
                arr[arr_i] = Console.ReadLine();

            GemStone gemStone = new GemStone();
            int result = gemStone.findGemStoneElements(arr);
            Console.WriteLine(result);
        }

        // Utility method to run Modified Fibonacci Program.
        static void RunFibonacci()
        {
            ModifiedFibonacci modifiedFibonacci = new ModifiedFibonacci();
            string[] tokens_t1 = Console.ReadLine().Split(' ');
            int t1 = Convert.ToInt32(tokens_t1[0]);
            int t2 = Convert.ToInt32(tokens_t1[1]);
            int n = Convert.ToInt32(tokens_t1[2]);
            BigInteger result = modifiedFibonacci.fibonacciModified(t1, t2, n);
            Console.WriteLine(result);
        }

        // Utility method to run Journey to the Moon Program.
        static void RunJourneyToMoon()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int p = Convert.ToInt32(tokens_n[1]);
            int[][] astronaut = new int[p][];
            JourneyToMoon journeyToMoon = new JourneyToMoon();
            for (int astronaut_i = 0; astronaut_i < p; astronaut_i++)
            {
                string[] astronaut_temp = Console.ReadLine().Split(' ');
                astronaut[astronaut_i] = Array.ConvertAll(astronaut_temp, Int32.Parse);
            }
            int result = journeyToMoon.journeyToMoon(n, astronaut);
            Console.WriteLine(result);
        }

        // Utility method to run SavePrincess Game.
        static void RunPrincessGame()
        {
            int m;
            m = int.Parse(Console.ReadLine());

            String[] grid = new String[m];
            for (int i = 0; i < m; i++)
                grid[i] = Console.ReadLine();

            SavePrincess savePrincess = new SavePrincess();
            savePrincess.displayPathtoPrincess(m, grid);
        }

        // Utility method to run PowerSum Program.
        static void RunPowerSum()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            PowerSum powerSum = new PowerSum();
            int result = powerSum.NumPowerSum(X, N, 1);
            Console.WriteLine(result);
        }

        // Utility method to run Missing Numbers Program.
        static void RunMissingNumbers()
        {
            MissingNumbers missingNumbers = new MissingNumbers();
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int m = Convert.ToInt32(Console.ReadLine());
            string[] brr_temp = Console.ReadLine().Split(' ');
            int[] brr = Array.ConvertAll(brr_temp, Int32.Parse);
            int[] result = missingNumbers.missingNumbers(arr, brr);
            Console.WriteLine(String.Join(" ", result));
        }

        // Utility method to run Pairs Program.
        static void RunPairs()
        {
            Pairs pairs = new Pairs();
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = pairs.pairs(k, arr);
            Console.WriteLine(result);
        }

        // Utility method to run Sherlock Array Program.
        static void RunSherlockArray()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < T; a0++)
            {
                SherlockArray sherlockArray = new SherlockArray();
                int n = Convert.ToInt32(Console.ReadLine());
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = sherlockArray.solve(a);
                Console.WriteLine(result);
            }
        }

        /* Program to Run Jim and Cake Order Program. In Jim's Burgers shop has n burger customers 
         * waiting in line, each unique order i is placed by a customer at time ti and the order 
         * takes di units of time to process. Given the information for all  orders, we need to 
         * find the order in which all n customers will receive their burgers. If two or more orders 
         * are fulfilled at the exact same time t, we need to sort them by ascending order number.
         */
        static void RunJimCakeOrder()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            //We will use SortedList Data Structure.
            SortedList<int, List<int>> sortedList = new SortedList<int, List<int>>();

            /* While reading the input, we sum the placing time ti and process time di 
             * for each customer's order i, to get the fulfilment time. It's automatically 
             * sorted due to Data Structure chosen. If there are multiple orders for 
             * a single fulfilment time, we keep it as a List of order numbers.
             */ 
            for (int i = 1; i <= n; i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                int releaseTime = a[0] + a[1];
                if (!sortedList.ContainsKey(releaseTime))
                    sortedList.Add(releaseTime, new List<int>());

                sortedList[releaseTime].Add(i);
            }

            /* While printing, for the multiple orders with same fulfilment time, 
             * we sort the list based on order number and then print it.
             */
            foreach(int key in sortedList.Keys)
            {
                List<int> valueSet = sortedList[key];
                valueSet.Sort();
                foreach(int i in valueSet)
                    Console.Write(i+" ");
            }
        }

        // Utility method to Run Candies Program. 
        static void RunCandies()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int arr_i = 0; arr_i < n; arr_i++)
                arr[arr_i] = Convert.ToInt32(Console.ReadLine());

            Candies candies = new Candies();
            long result = candies.candies(n, arr);
            Console.WriteLine(result);
        }

        // Utility program to run Sam and SUbstring Program. 
        static void RunSamSubstring()
        {
            SamSubstring samSubstring = new SamSubstring();
            string balls = Console.ReadLine();
            long result = samSubstring.substrings(balls);
            Console.WriteLine(result);
        }

        // Utility method to run coin change problem.
        static void RunCoinChange()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            long[] c = Array.ConvertAll(c_temp, Int64.Parse);

            CoinChange coinChange = new CoinChange();
            // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
            long ways = coinChange.getWays(n, c, m);
            Console.WriteLine(ways);
        }

        /*
         * Utility method to run Recursive Digit Sum.
         * We are given two numbers n and k. We have to calculate the super digit of p,
         * which is created when number n is concatenated k times.
         */ 
        static void RunDigitSum()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string n = tokens_n[0];
            int k = Convert.ToInt32(tokens_n[1]);
            long sum = 0;
            foreach (char c in n)
                sum += Convert.ToInt64(c - '0');
            RecursiveDigitSum recursiveDigitSum = new RecursiveDigitSum();
            int result = recursiveDigitSum.digitSum(sum);
            int final = recursiveDigitSum.digitSum(result * k);
            Console.WriteLine(final);
        }

        // Utility method to run Common Child Code.
        static void RunCommonChild()
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            CommonChild commonChild = new CommonChild();
            int result = commonChild.commonChild(s1, s2);
            Console.WriteLine(result);
        }

        // Utility method to run K Factorization Program.
        public static void RunKFactorization(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);
            int x = 1;

            Array.Sort(A);
            List<int> comb = new List<int>();
            List<List<int>> res = new List<List<int>>();

            KFactorization kFactorization = new KFactorization();
            kFactorization.generateSeries(n, A, comb, res, 1);

            if (res.Count==0)
                Console.WriteLine(-1);
            else
            {
                res[0].Add(1);
                for (int i = res[0].Count - 1; i >= 0; i--)
                {
                    x = x * res[0][i];
                    Console.WriteLine(x + "\t");
                }
            }
        }

        /* Find the largest decent number formed by n digits for T test cases.
         * A Decent Number has the following properties:
         * 1. Its digits can only be 3's and/or 5's.
         * 2. The number of 3's it contains is divisible by 5.
         * 3. The number of 5's it contains is divisible by 3.
         * 4. If there are more than one such number, we pick the largest one.
         */ 
        static void RunSherlockAndBeast(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int x = n;
                while (x % 3 != 0)
                    x -= 5;
                if (x < 0)
                    Console.Write(-1);
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(i<x)
                            Console.Write(5);
                        else
                            Console.Write(3);
                    }
                }
                Console.WriteLine();
            }
        }

        // Utility method to run Connected Cells Program.
        static void RunConnectedCells()
        {
            ConnectedCells connectedCells = new ConnectedCells();
            connectedCells.Run();
        }

        // Utility method to run Sherlock and Cost Program
        static void RunSherlockAndCost(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                SherlockAndCost sherlockAndCost = new SherlockAndCost();
                int result = sherlockAndCost.cost(arr);
                Console.WriteLine(result);
            }
        }

        // Utility method to run RemoveDuplicateLinkList Program
        static void RunRemoveDuplicateLinkList()
        {
            Node head = null;
            RemoveDuplicateLinkList removeDuplicateLinkList = new RemoveDuplicateLinkList();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = removeDuplicateLinkList.insert(head, data);
            }
            head = removeDuplicateLinkList.removeDuplicates(head);
            removeDuplicateLinkList.display(head);
        }
    }
}
