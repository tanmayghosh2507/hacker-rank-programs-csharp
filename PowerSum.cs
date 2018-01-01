using System;

namespace HackerRankCode
{
    class PowerSum
    {
        /*
         * Given an integer X, we need to return the number of ways
         * X can be represented as sum of N square numbers.
         */ 
        public int NumPowerSum(int X, int N, int num)
        {
            //Recursively solving it.
            if (Math.Pow(num, N) < X)
                return NumPowerSum(X, N, num + 1) + NumPowerSum(Convert.ToInt32(X - Math.Pow(num, N)), N, num + 1);
            else if (Math.Pow(num, N) == X)
                return 1;
            else
                return 0;
        }
    }
}
