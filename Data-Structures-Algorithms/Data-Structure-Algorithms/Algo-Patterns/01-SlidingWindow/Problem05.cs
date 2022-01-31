using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Problem05
    {
        /*
         * Problem Statement #
            Given a string, find the length of the longest substring which has no repeating characters.

            Example 1:

            Input: String="aabccbb"
            Output: 3
            Explanation: The longest substring without any repeating characters is "abc".
            Example 2:

            Input: String="abbbb"
            Output: 2
            Explanation: The longest substring without any repeating characters is "ab".
            Example 3:

            Input: String="abccde"
            Output: 3
            Explanation: Longest substrings without any repeating characters are "abc" & "cde".
         */

        public int FindLenghtNoRepeatSubString(string str)
        {
            var map = new Dictionary<char, int>();
            int length = int.MinValue;
            int windowStart = 0;
            for (int windowsEnd = 0; windowsEnd < str.Length; windowsEnd++)
            {
                char rightChar = str[windowsEnd];
                if (map.ContainsKey(rightChar))
                {
                    windowStart = Math.Max(windowStart, map[rightChar]) + 1;
                    map[rightChar] = windowsEnd;
                }
                else
                    map.Add(rightChar, windowsEnd);
                length = Math.Max(length, windowsEnd - windowStart + 1);

            }
            return length;
        }
    }
}
