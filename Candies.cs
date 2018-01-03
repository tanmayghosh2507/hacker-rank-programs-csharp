namespace HackerRankCode
{
    class Candies
    {
        /*  All the children each of them has a rating score as per the input array.
         *  And they sit in the class in that order. We wants to give at least 1 candy to each child. 
         *  If two children sit next to each other, then the one with the higher rating must
         *  get more candies. We needs to minimize the total number of candies given to the children.
         */ 
        public long candies(int n, int[] arr)
        {
            int[] dp = new int[n];

            //Initialize all elements with 1. At least one candy given.
            for (int i = 0; i < n; i++)
                dp[i] = 1;

            //Forward Pass: If the next has higher rating, give 1 candy more than previous.
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                    dp[i] = dp[i - 1] + 1;
            }

            //Backward Pass: If the next has higher rating, and he/she had received less candy than 
            //the previous in forward pass, give 1 candy more this time.
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1] && dp[i] < dp[i + 1] + 1)
                    dp[i] = dp[i + 1] + 1;
            }

            long sum = 0;
            for (int i = 0; i < n; i++)
                sum += dp[i];
            return sum;
        }
    }
}
