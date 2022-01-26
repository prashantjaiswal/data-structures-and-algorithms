using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DataStructuresAlgorithms.Leetcode.Medium
{
    /*https://leetcode.com/problems/longest-substring-without-repeating-characters/
     * Given a string s, find the length of the longest substring without repeating characters.

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
     */
    public class Problem3
    {
        public int lengthOfLongestSubstringSolution1(String s)
        {
            int n = s.Length;

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (checkRepetition(s, i, j))
                    {
                        res = Math.Max(res, j - i + 1);
            }
                }
            }

            return res;
        }

        private bool checkRepetition(String s, int start, int end)
        {
            int[] chars = new int[128];

            for (int i = start; i <= end; i++)
            {
                char c = s[i];
                chars[c]++;
                if (chars[c] > 1)
            {
                    return false;
                }
            }

            return true;
        }


        public int lengthOfLongestSubstringSolution2(String s)
        {
            int[] chars = new int[128];

            int left = 0;
            int right = 0;

            int res = 0;
            while (right < s.Length)
        {
                char r = s[right];
                chars[r]++;

                while (chars[r] > 1)
            {
                    char l = s[left];
                    chars[l]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);

                right++;
            }
            return res;
            }

        public int lengthOfLongestSubstringSolution3(String s)
        {
            int n = s.Length, ans = 0;
            var map = new Dictionary<char,int>(); // current index of character
                                                           // try to extend the range [i, j]
            for (int j = 0, i = 0; j < n; j++)
            {
                if (map.ContainsKey(s[j]))
            {
                    i = Math.Max(map.GetValueOrDefault(s[j]), i);
            }
                ans = Math.Max(ans, j - i + 1);
                if (map.ContainsKey(s[j]))
                    map[s[j]] = j + 1;
            else
                    map.Add(s[j], j + 1);
            }
            return ans;
        }
    }
}
