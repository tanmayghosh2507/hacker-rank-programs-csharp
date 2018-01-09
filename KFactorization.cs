using System.Collections.Generic;

namespace HackerRankCode
{
    class KFactorization
    {
        //Recursive solution to the K Factorization Program.
        public void generateSeries(int n, int[] a, List<int> comb, List<List<int>> res, long prod)
        {
            if (n == 0)
                return;
            if (n == 1)
            {
                res.Add(new List<int>(comb));
                return;
            }
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == 1 || a[i] == 0 || n % a[i] != 0)
                    continue;
                comb.Add(a[i]);
                generateSeries(n / a[i], a, comb, res, prod);
                if (res.Count == 1)
                    break;
                n *= a[i];
                comb.Remove(comb.Count - 1);
            }
        }
    }
}
