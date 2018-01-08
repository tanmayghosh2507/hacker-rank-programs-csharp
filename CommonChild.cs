namespace HackerRankCode
{
    class CommonChild
    {
        //Standard program of finding the largest common subsequence (LCS) of 2 strings.
        public int commonChild(string s1, string s2)
        {
            int[,] dp = new int[s1.Length+1, s2.Length+1];

            /* Following steps build L[m+1][n+1] in bottom up fashion. Note
            that L[i][j] contains length of LCS of X[0..i-1] and Y[0..j-1] */
            for (int i=0; i<=s1.Length; i++)
            {
                for(int j=0; j<=s2.Length; j++)
                {
                    if (i == 0 || j == 0)
                        dp[i, j] = 0;
                    else if (s1[i - 1] == s2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    else
                        dp[i, j] = dp[i - 1, j] > dp[i, j - 1] ? dp[i - 1, j] : dp[i, j - 1];
                }
            }
            return dp[s1.Length, s2.Length];
        }
    }
}
