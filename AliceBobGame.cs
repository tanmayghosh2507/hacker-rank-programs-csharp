namespace HackerRankCode
{
    /*
     * This program takes 6 integers as input.
     * First three are for scores of Alice. Next three are respective scores for Bob.
     * If ai > bi for i = {1,2,3}, then Alice gets 1 point, else Bob gets 1 point.
     * Finally the points of Alice and Bob are returned as the 2 elements of an array.
    */
    class AliceBobGame
    {
        public int[] Solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int a = 0;
            int b = 0;

            if (a0 > b0)
                a++;
            else if (a0 < b0)
                b++;
            if (a1 > b1)
                a++;
            else if (a1 < b1)
                b++;
            if (a2 > b2)
                a++;
            else if (a2 < b2)
                b++;

            int[] results = { a, b };
            return results;
        }
    }
}

