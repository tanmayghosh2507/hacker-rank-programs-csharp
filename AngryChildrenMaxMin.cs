using System;

namespace HackerRankCode
{
    class AngryChildrenMaxMin
    {
        /* Program to take an array as input and return minimum unfairness for k elements
         * defined as max of k selected numbers - min of k selected numbers from arr.
         */ 
        public int angryChildren(int k, int[] arr)
        {
            Array.Sort(arr);
            int unfairness = arr[k - 1] - arr[0];
            //After sorting, looping through each k consecutive pair. Max is last element of set and
            //min is first element of the set.
            for (int i = 0; i < arr.Length - k + 1; i++)
            {
                if (arr[i + k - 1] - arr[i] < unfairness)
                    unfairness = arr[i + k - 1] - arr[i];
            }
            return unfairness;
        }
    }
}
