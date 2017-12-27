using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankCode
{
    class DiagonalDifference
    {
        public int DiagonalDiff(int n, int[][] ar)
        {
            int diff = 0;
            for(int i=0; i<n; i++)
            {
                diff += ar[i][i];
            }

            for(int i=n-1, j=0; i>=0 && j<n; i--, j++)
            {
                diff -= ar[i][j];
            }

            if (diff > 0)
                return diff;
            else
                return -1 * diff;
        }
    }
}
