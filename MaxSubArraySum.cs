namespace HackerRankCode
{
    class MaxSubArraySum
    {
        /*
         * Find max subarray sum of array a modulo m.
         * It is not the most efficinet algorithm. But is correct.
         */
        public long maximumSum(long[] a, long m)
        {
            long max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                long sum = 0;
                for (int j = i; j < a.Length; j++)
                {
                    sum += a[j];
                    if (sum % m == m - 1)
                    {
                        max = m - 1;
                        break;
                    }
                    else if (max < sum % m)
                        max = sum % m;
                }
            }
            return max;
        }
    }
}
