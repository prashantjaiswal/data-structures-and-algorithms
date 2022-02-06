using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Challenge03
    {
        #region  Smallest Window containing Substring (hard)
        /*
        Given a string and a pattern, find the smallest substring in the given string
        which has all the characters of the given pattern.

        Example 1:

        Input: String="aabdec", Pattern="abc"
        Output: "abdec"
        Explanation: The smallest substring having all characters of the pattern is "abdec"
        Example 2:

        Input: String="abdabca", Pattern="abc"
        Output: "abc"
        Explanation: The smallest substring having all characters of the pattern is "abc".
        Example 3:

        Input: String="adcad", Pattern="abc"
        Output: ""
        Explanation: No substring in the given string has all characters of the pattern.
         */
        #endregion

        public string FindMinumumWindowSubstring(string str, string pattern)
        {
            var map = new Dictionary<char, int>();
            int minLength = str.Length + 1;
            int matched = 0;
            int windowStart = 0;
            int subStrStart = 0;

            for (int i = 0; i < pattern.Length; i++)
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
                    if (map[rightChar] >= 0) matched++;
                }

                while(matched == pattern.Length)
                {
                    if (minLength > windowEnd - windowStart + 1)
                    {
                        minLength = windowEnd - windowStart + 1;
                        subStrStart = windowStart;
                    }
                    char leftChar = str[windowStart++];
                    if (map.ContainsKey(leftChar))
                    {
                        if (map[leftChar] == 0) matched--;
                        map[leftChar] += 1;
                    }
                }
            }
            return minLength > str.Length ? "" : str.Substring(subStrStart, minLength);
        }
    }
}
