namespace HackerRankCode
{
    class IceCreamParlor
    {
        /*This method takes a unsorted integer array, an integer m and another integer n. 
         * The array is of size n and has all unique values.
         * We need to check, whether any two elements from the array add up to m.
         * If so we return the two elements in form of an array.
        */ 
        public int[] getCombination(int[] arr, int m, int n)
        {
            //Initializing the optput array
            int[] combo = new int[2];
            combo[0] = -1;
            combo[1] = -1;

            for (int i = 0; i < n; i++)
            {
                //select each element one by one
                for (int j = i + 1; j < n; j++)
                {
                    //check whether for the selcted element, there exist another element 
                    //such that the sum becomes equal to the desired quantity.
                    if (arr[i] + arr[j] == m)
                    {
                        combo[0] = i + 1;
                        combo[1] = j + 1;
                        return combo;
                    }
                }
            }

            return combo;
        }
    }
}