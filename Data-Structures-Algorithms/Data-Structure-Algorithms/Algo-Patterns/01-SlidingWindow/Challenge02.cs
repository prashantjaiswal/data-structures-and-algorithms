using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Challenge02
    {

        #region String Anagrams (hard)
        /*
        Given a string and a pattern, find all anagrams of the pattern in the given string.

        Anagram is actually a Permutation of a string. For example, “abc” has the following six anagrams:

        abc
        acb
        bac
        bca
        cab
        cba
        Write a function to return a list of starting indices of the anagrams of the pattern in the given string.

        Example 1:

        Input: String="ppqp", Pattern="pq"
        Output: [1, 2]
                Explanation: The two anagrams of the pattern in the given string are "pq" and "qp".
        Example 2:

        Input: String="abbcabc", Pattern="abc"
        Output: [2, 3, 4]
        Explanation: The three anagrams of the pattern in the given string are "bca", "cab", and "abc".
         */
        #endregion
        public int[] FindStringAnagrams(string str, string pattern)
        {
            var indices = new List<int>();
            int windowStart = 0;
            var map = new Dictionary<char, int>();
            int lengthOfPattern = pattern.Length;
            int matched = 0;

            for (int i = 0; i < lengthOfPattern; i++)
            {
                if (map.ContainsKey(pattern[i])) map[pattern[i]] += 1;
                else map.Add(pattern[i], 1);
            }

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                char rightChar = str[windowEnd];
                if (map.ContainsKey(rightChar))
                {
                    map[rightChar] -= 1;
                    if (map[rightChar] == 0) matched++;
                }
                if (matched == map.Keys.Count) indices.Add(windowStart);

                if (windowEnd >= pattern.Length - 1)
                {
                    char leftChar = str[windowStart++];
                    if (map.ContainsKey(leftChar))
                    {
                        if (map[leftChar] == 0)
                            matched--;
                        map[leftChar] += 1;
                    }
                }
            }
            return indices.ToArray();
        }
    }
}
