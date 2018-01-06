namespace HackerRankCode
{
    class CoinChange
    {
        /* The standard coin change problem, where we want to find the number of ways of making
         * a change of n, given coins of values as c array.
         */ 
        public long getWays(long n, long[] c, int m)
        {
            // Complete this function
            long[] table = new long[n + 1];

            // Initialize all table values as 0
            for (int i = 1; i < n + 1; i++)
                table[i] = 0;

            // Base case (If given value is 0)
            table[0] = 1;

            // Pick all coins one by one and update the table[]
            // values after the index greater than or equal to
            // the value of the picked coin
            for (int i = 0; i < m; i++)
                for (long j = c[i]; j <= n; j++)
                    table[j] += table[j - c[i]];

            return table[n];
        }
    }
}
