using System;

namespace HackerRankCode
{
    class FunnyString
    {
        /*
         * Input is a string s of length n, that is indexed from 0 to n-1.
         * If r is the reverse of String s, then s is funny if the condition 
         * |s[i]-s[i-1]| = |r[i]-r[i-1]| is true for every character i from 1 to n-1.
        */
        public string CheckFunnyString(String s)
        {
            int n = s.Length;
            for(int i=1; i<n; i++)
            {
                //num1 is the difference from the front of the string.
                int num1 = s[i] - s[i - 1];

                //num2 is difference from the back of the string.
                int num2 = s[n-i] - s[n - i - 1];

                //Checking whether the modulus of the difference is same or not!
                //If there is a single mismatch, we return Not Funny.
                if (num1 != num2 && num1 * -1 != num2)
                    return "Not Funny";
            }
            //If it comes out of the loop. implying all conditions matched, we return Funny.
            return "Funny";
        }
    }
}
