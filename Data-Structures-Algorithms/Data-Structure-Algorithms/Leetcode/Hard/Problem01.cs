using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Leetcode.Hard
{
    public class Problem01
    {
        /*
        You are given a string s and an array of strings words of the same length.
        Return all starting indices of substring(s) in s that is a concatenation of
        each word in words exactly once, in any order, and without any intervening characters.

        You can return the answer in any order.
        Example 1:

        Input: s = "barfoothefoobarman", words = ["foo","bar"]
        Output: [0,9]
        Explanation: Substrings starting at index 0 and 9 are "barfoo" and "foobar" respectively.
        The output order does not matter, returning [9,0] is fine too.
        Example 2:

        Input: s = "wordgoodgoodgoodbestword", words = ["word","good","best","word"]
        Output: []
        Example 3:

        Input: s = "barfoofoobarthefoobarman", words = ["bar","foo","the"]
        Output: [6,9,12]
         */

        public IList<int> FindSubstring(string s, string[] words)
        {
            var list = new List<int>();
            var map = new Dictionary<string, int>();
            var word = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                if (map.ContainsKey(words[i])) map[words[i]] += 1;
                else map.Add(words[i], 1);
            }

            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            {
                word.Append(s[windowEnd]);
                
            }

            return list;
        }
    }
}
