namespace HackerRankCode
{
    class SherlockArray
    {
        /*
         * To determine if there exists an element in the array such that the sum 
         * of the elements on its left is equal to the sum of the elements on its right.
         */ 
        public string solve(int[] a)
        {
            int suml = 0;
            int sumr = 0;

            //Base Case: Array of size 1: YES
            if (a.Length == 1)
                return "YES";

            //Count total
            for (int i = 1; i < a.Length; i++)
                sumr += a[i];

            //Count left sum adding one element, and right sum by removing one element.
            for (int i = 1; i < a.Length; i++)
            {
                suml += a[i-1];
                sumr -= a[i];

                //If equal, return YES.
                if (suml == sumr)
                    return "YES";
            }
            //If finally, came out of the loop after checking at each index, return NO.
            return "NO";
        }
    }
}
