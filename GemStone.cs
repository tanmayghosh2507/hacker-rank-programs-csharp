using System;

namespace HackerRankCode
{
    class GemStone
    {
        public int findGemStoneElements(String[] arr)
        {
            int[] hash = new int[256];
            int count = 0;
            
            //Initializing the array ith all 0 count.
            for (int i = 0; i < 256; i++)
                hash[i] = 0;

            foreach (string s in arr)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Boolean flag = true;
                    //Checking for duplicates, since we only have to consider one occurence,
                    //so last occurence will be considered.
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[i] == s[j])
                        {
                            flag = false;
                            break;
                        }
                    }
                    //Incrementing the value of the hash array corresponding to that character
                    if (flag)
                        hash[s[i]]++;
                }
            }

            //If a character appears in all the strings,
            //it's count will be equal to the number of strings.
            for (int i = 90; i < 130; i++)
                if (hash[i] == arr.Length)
                    count++;

            return count;
        }
    }
}
