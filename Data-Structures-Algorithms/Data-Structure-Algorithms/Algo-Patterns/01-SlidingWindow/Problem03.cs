using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Problem03
    {
        /* Problem Statement#
        Given a string, find the length of the longest substring in it with no more than K distinct characters.

        Example 1:

        Input: String= "araaci", K= 2
        Output: 4
        Explanation: The longest substring with no more than '2' distinct characters is "araa".
        Example 2:

        Input: String= "araaci", K= 1
        Output: 2
        Explanation: The longest substring with no more than '1' distinct characters is "aa".
        Example 3:

        Input: String= "cbbebi", K= 3
        Output: 5
        Explanation: The longest substrings with no more than '3' distinct characters are "cbbeb" & "bbebi".
        Example 4:

        Input: String= "cbbebi", K= 10
        Output: 6
        Explanation: The longest substring with no more than '10' distinct characters is "cbbebi".*/

        public int FindLength(string str, int k)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            int windowStart = 0;
            int length = int.MinValue; ;
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                if (dictionary.ContainsKey(str[windowEnd]))
                    dictionary[str[windowEnd]] += 1;
                else
                    dictionary.Add(str[windowEnd], 1);

                if(dictionary.Keys.Count > k)
                {
                    dictionary.Clear();
                    windowStart = windowEnd + 1;
                }
                length = Math.Max(length, windowEnd - windowStart + 1);
            }
            return length;
        }
    }
}
