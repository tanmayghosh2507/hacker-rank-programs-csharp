using System;
using System.Collections.Generic;
using System.Numerics;

namespace HackerRankCode
{
    class ModifiedFibonacci
    {
        /*
         * Modified Fibonacci Number by Dynamic Programming Approach.
         * t(i+2) = t(i) + t(i+1)^2
         */ 
        public BigInteger fibonacciModified(int t1, int t2, int n)
        {
            //Saving all the computed fibaonacci numbers in an array to avoid re-computations.
            BigInteger[] dp = new BigInteger[20];
            dp[0] = t1;
            dp[1] = t2;

            //Applying the formula to compute the next fibonacci number in the series.
            for (int i = 2; i < n; i++)
                dp[i] = dp[i - 2] + (dp[i - 1] * dp[i - 1]);

            return dp[n - 1];
        }
    }
}
