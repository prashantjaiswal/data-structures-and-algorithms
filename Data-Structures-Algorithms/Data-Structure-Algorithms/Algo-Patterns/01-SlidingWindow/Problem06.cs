using System;
using System.Collections.Generic;
namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Problem06
    {
        /*
         * Longest Substring with Same Letters after Replacement (hard)
         * 
            Given a string with lowercase letters only, if you are allowed to replace no more than ‘k’
            letters with any letter, find the length of the longest substring having the same letters
            after replacement.

            Example 1:

            Input: String="aabccbb", k=2
            Output: 5
            Explanation: Replace the two 'c' with 'b' to have a longest repeating substring "bbbbb".
            Example 2:

            Input: String="abbcb", k=1
            Output: 4
            Explanation: Replace the 'c' with 'b' to have a longest repeating substring "bbbb".
            Example 3:

            Input: String="abccde", k=1
            Output: 3
            Explanation: Replace the 'b' or 'd' with 'c' to have the longest repeating substring "ccc".
         */

        public int FindLengthLongestSubstring(string str, int k)
        {
            var map = new Dictionary<char, int>();
            int maxLetterRepeatCount = int.MinValue;
            int windowStart = 0;
            int maxLength = 0;
            for (int windowEnd = 0; windowEnd < str.Length; windowEnd++)
            {
                if (map.ContainsKey(str[windowEnd]))
                {
                    map[str[windowEnd]] +=1;
                    maxLetterRepeatCount = Math.Max(maxLetterRepeatCount, map[str[windowEnd]]);
                }
                else
                {
                    map.Add(str[windowEnd], 1);
                }
                if(windowEnd - windowStart + 1 -maxLetterRepeatCount > k)
                {
                    char leftChar = str[windowStart];
                    map[leftChar] -= 1;
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
    }
}
