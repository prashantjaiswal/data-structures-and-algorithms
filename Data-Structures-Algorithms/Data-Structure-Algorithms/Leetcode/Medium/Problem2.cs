using System;
using System.Collections.Generic;
using System.Text;
/*
    Given a string s, find the length of the longest substring without repeating characters.

    Example 1:

    Input: s = "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.
    Example 2:

    Input: s = "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.
    Example 3:

    Input: s = "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.
    Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
    Example 4:

    Input: s = ""
    Output: 0
 

    Constraints:

    0 <= s.length <= 5 * 104
    s consists of English letters, digits, symbols and spaces.
 */


namespace DataStructuresAlgorithms.Leetcode.Medium
{
    class Problem2
    {
        public Dictionary<string, int> substring { get; set; }
        public int LengthOfLongestSubstring(string s)
        {
            substring = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            //Add each forward substring
            //s = "abcabcbb"

            for (int i = 0; i < s.Length; i++)
            {
                var item = s.Substring(0, i);
                if (!substring.ContainsKey(item))
                {
                    substring.Add(item, item.Length);
                    RecurseAndAddSubstring(item);
                }
            }
            string str = RecurseAndAddSubstring(s);

            return 0;
        }

        private string RecurseAndAddSubstring(string s)
        {
            return "";
        }
    }
}
