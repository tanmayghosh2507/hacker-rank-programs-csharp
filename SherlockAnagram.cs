using System;
using System.Collections.Generic;

namespace HackerRankCode
{
    //To find the number of all anagrams formed by the substring of a string.
    //Note: Not the most efficient algorithm.
    class SherlockAnagram
    {
        public int sherlockAndAnagrams(string s)
        {
            int count = 0;
            for (int len = 1; len < s.Length; len++)
            {
                for (int i = 0; i < s.Length - len; i++)
                {
                    for (int j = i + 1; j < s.Length - len; i++)
                    {
                        if (checkAnagram(s.Substring(i, len), s.Substring(j, len)))
                           count++;
                    }
                }
            }
            return count;
        }

        private bool checkAnagram(String s1, String s2)
        {
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            foreach (char c in s1)
            {
                if (dict1.ContainsKey(c))
                    dict1[c]++;
                else
                    dict1.Add(c, 1);
            }

            foreach (char c in s2)
            {
                if (!dict1.ContainsKey(c))
                    return false;
                else if(dict1[c]>1)
                    dict1[c]--;
                else
                    dict1.Remove(c);
            }

            if (dict1.Count == 0)
                return true;
            else
                return false;
        }
    }
}
