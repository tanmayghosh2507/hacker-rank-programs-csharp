namespace HackerRankCode
{
    class SamSubstring
    {
        /* Given a string N, each character is a digit from 0 to 9, except first which is 1-9, 
         * We need to find the sum of all sub-strings of N. If T is the sum, we need to find
         * (T%10^9+7)
         */ 
        public long substrings(string balls)
        {
            long res = 0;
            long f = 1;
            int l = balls.Length;
            long MOD = 1000000007;
            /*
             * Consider an example with string "6789" to understand the logic. 
             * The sub-strings of "6789" are 6, 7, 8, 9, 67, 78, 89, 678, 789, 6789.
             * Now, sub-string "789" can be expressed as 700 + 80 + 9. 
             * If all the substrings are expressed in similar way, we just need to know position and 
             * frequency of each digit in all the substrings combined, to get the total sum.
             */ 
            for (int i = l - 1; i >= 0; i--)
            {
                res = (res + (balls[i] - '0') * f * (i + 1)) % MOD;
                f = (f * 10 + 1) % MOD;
            }
            return res;
        }
    }
}
