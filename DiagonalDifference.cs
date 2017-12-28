using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankCode
{
    /*
     * This program takes the size and the 2D array itself as input.
     * It returns the modulus(|x|) of the difference of the elements of right diagonal and left diagonal. 
     */
    class DiagonalDifference
    {
        public int DiagonalDiff(int n, int[][] ar)
        {
            int diff = 0;
            // Adding up the array elements from top left to bottom right diagonal.
            for(int i=0; i<n; i++)
                diff += ar[i][i];

            // Subtracting the array elements from top right to bottom left diagonal.
            for(int i=n-1, j=0; i>=0 && j<n; i--, j++)
                diff -= ar[i][j];

            //Modulo operation
            if (diff > 0)
                return diff;
            else
                return -1 * diff;
        }
    }
}
