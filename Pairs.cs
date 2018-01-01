using System.Collections.Generic;

namespace HackerRankCode
{
    class Pairs
    {
        /*
         * Given an array of n unique integers, count the number of 
         * pairs of integers whose difference is k.
         */ 
        public int pairs(int k, int[] arr)
        {
            int count = 0;
            HashSet<int> set = new HashSet<int>();
            
            // Index all the elements of the array into a HashSet.
            foreach (int i in arr)
                set.Add(i);

            //Checking for such pair for each element one by one.
            foreach(int i in arr)
            {
                if (set.Contains(i - k))
                    count++;
            }

            return count;
        }
    }
}
