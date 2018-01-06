using System;

namespace HackerRankCode
{
    /* We need to find the super digit of a number x, which is equal to the super digit 
     * of the digit-sum of x. Here, digit-sum of a number is defined as the sum of its digits.
     */ 
    class RecursiveDigitSum
    {
        public int digitSum(long n)
        {
            //Base case
            if (n <= 9)
                return Convert.ToInt32(n);

            //Find sum of it's digits
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            //Recursively call digit Sum.
            return digitSum(sum);
        }
    }
}
