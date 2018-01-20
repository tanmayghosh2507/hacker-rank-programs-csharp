using System;

namespace HackerRankCode
{
    class GreedyFlorist
    {
        /* A florist has n flowers with cost of ith flower as c[i]. A group of k friends want to
         * buy those n flowers with minimum cost. The cost increases for a repeated customer for
         * each flower as (number of flowers already bought by that customer + 1) * c[i].
         */ 
        public int getMinimumCost(int n, int k, int[] c)
        {
            Array.Sort(c);
            //Define a customer array which stores the number of flowers already bought by each
            // customer (for all k friends), initialize it with 0.
            int[] customer = new int[k];
            for (int i = 0; i < k; i++)
                customer[i] = 0;
            int sum = 0;
            // Repeat the customer in round robin fashion, Start from max cost flowers, so as to avoid buying them as repeated customer for as long as possible.
            for (int i = n - 1, j = 0; i >= 0; i--, j++)
            {
                if (j > k - 1)
                    j = 0;
                sum += (++customer[j]) * c[i];
            }
            return sum;
        }
    }
}
