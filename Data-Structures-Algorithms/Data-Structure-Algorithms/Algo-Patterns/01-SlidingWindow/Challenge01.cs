using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Challenge01
    {
        #region Permutation in a String (hard) #
        /*
        Given a string and a pattern, find out if the string contains any permutation of the pattern.

        Permutation is defined as the re-arranging of the characters of the string.
        For example, “abc” has the following six permutations:

        abc
        acb
        bac
        bca
        cab
        cba
        If a string has ‘n’ distinct characters it will have n!n! permutations.

        Example 1:

        Input: String="oidbcaf", Pattern="abc"
        Output: true
        Explanation: The string contains "bca" which is a permutation of the given pattern.
        Example 2:

        Input: String="odicf", Pattern="dc"
        Output: false
        Explanation: No permutation of the pattern is present in the given string as a substring.
        Example 3:

        Input: String="bcdxabcdy", Pattern="bcdyabcdx"
        Output: true
        Explanation: Both the string and the pattern are a permutation of each other.
        Example 4:

        Input: String="aaacb", Pattern="abc"
        Output: true
        Explanation: The string contains "acb" which is a permutation of the given pattern.
         */
        #endregion

        public bool FindPermutation(string str, string pattern)
        {
            int lengthOfPattern = pattern.Length;
            var map = new Dictionary<char, int>();
            int windowStart = 0;
            bool hasSubstring = false;
            if (hasSubstring) return true;

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
                    while (windowEnd - windowStart + 1 <= lengthOfPattern)
                    {
                        if (!map.ContainsKey(str[windowEnd]))
                        {
                            hasSubstring = false;
                            break;
                        }
                        hasSubstring = true;
                        windowEnd++;
                    }
                }
                else
                    windowStart++;
            }
            return hasSubstring;
        }

        public bool FindPermutation02(string str, string pattern)
        {
            int lengthOfPattern = pattern.Length;
            var map = new Dictionary<char, int>();
            int windowStart = 0;
            bool hasSubstring = false;

            for (int i = 0; i < lengthOfPattern; i++)
            {
                if (map.ContainsKey(pattern[i])) map[pattern[i]] += 1;
                else map.Add(pattern[i], 1);
            }

            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                
            }
            return hasSubstring;
        }
    }
}
