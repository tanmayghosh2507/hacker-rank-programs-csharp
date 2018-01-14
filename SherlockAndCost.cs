using System;

namespace HackerRankCode
{
    class SherlockAndCost
    {
        /* Dynamic Programming approach to find max difference of consecutive elements if 
         * each element can be between 1 and arr[i].
         */
        public int cost(int[] arr)
        {
            int n = arr.Length;
            int hi = 0, low = 0;

            for (int i = 1; i < n; i++)
            {
                int high_to_low_diff = Math.Abs(arr[i - 1] - 1);
                int low_to_high_diff = Math.Abs(arr[i] - 1);

                int low_next = Math.Max(low, hi + high_to_low_diff);
                hi = Math.Max(hi, low + low_to_high_diff);
                low = low_next;
            }

            return Math.Max(hi, low);
        }
    }
}
