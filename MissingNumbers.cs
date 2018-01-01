using System.Collections.Generic;

namespace HackerRankCode
{
    class MissingNumbers
    {
        /*
         * Given 2 arrays, size of B > A.
         * A does not have either few elements from B or it has but the frequency is less.
         * Need to identify those numbers, and return just once(irrespective of freq. difference)
         * in increasing order.
         */ 
        public int[] missingNumbers(int[] arr, int[] brr)
        {
            Dictionary<int, int> myDictA = new Dictionary<int, int>();
            Dictionary<int, int> myDictB = new Dictionary<int, int>();
            
            //Creating a dictionary with elements in A
            foreach(int i in arr)
            {
                if (myDictA.ContainsKey(i))
                    myDictA[i]++;
                else
                    myDictA[i] = 1;
            }

            //Creating a dictionary with elements in B
            foreach (int i in brr)
            {
                if (myDictB.ContainsKey(i))
                    myDictB[i]++;
                else
                    myDictB[i] = 1;
            }

            //Adding the mismatched elements in A and B to a list
            List<int> list = new List<int>();
            foreach(int i in myDictB.Keys)
            {
                if (myDictA.ContainsKey(i) && myDictB[i] == myDictA[i])
                    continue;
                else
                    list.Add(i); 
            }

            //Sort and return the list as an array
            list.Sort();
            return list.ToArray();
        }
    }
}
