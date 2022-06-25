using System;
using System.Collections.Generic;
using System.Text;
namespace DataStructuresAlgorithms.Practice
{
	/// <summary>
    /// Day53
    /// </summary>
	public class PracticeString
	{

        public int BoringSubstring(string A)
        {
            char[] arr1 = new char[26];
            char[] arr2 = new char[26];
            for (int i = 0; i < A.Length; ++i)
            {
                char c = A[i];
                if (c % 2 == 0)
                    arr1[c - 'a']++;
                else
                    arr2[c - 'a']++;
            }
            StringBuilder s1 = new StringBuilder();
            for (int i = 0; i < 26; i++)
                for (int j = 0; j < arr1[i]; j++)
                    s1.Append((char)(i + 'a'));
            StringBuilder s2 = new StringBuilder();
            for (int i = 0; i < 26; i++)
                for (int j = 0; j < arr2[i]; j++)
                    s2.Append((char)(i + 'a'));

            string odd = s1.ToString();
            string even = s2.ToString();
            if (check(odd + even))
                return 1;
            else if (check(even + odd))
                return 1;
            return 0;
        }
        public bool check(string s)
        {
            bool ok = true;
            for (int i = 0; i + 1 < s.Length; ++i)
                ok &= (Math.Abs(s[i] - s[i + 1]) != 1);
            return ok;
        }

        public string minWindow(string A, string B)
        {
            var d = new Dictionary<char, int>();
            foreach(var c in B)
            {
                if (d.ContainsKey(c)) d[c]++;
                else d.Add(c, 1);
            }

            int l = B.Length;
            int min_len = -1;
            int index = -1;
            int start = 0;
            int end = 0;
            while (end < A.Length)
            {
                char ch = A[end];
                if (d.ContainsKey(ch))
                {
                    if (d[ch] > 0) l--;
                    d[ch] = d[ch] - 1;
                }
                while (l == 0)
                {
                    int len = end - start + 1;
                    if (index == -1 || min_len > len)
                    {
                        min_len = len;
                        index = start;
                    }
                    char ch1 = A[start];
                    if (d.ContainsKey(ch1))
                    {
                        if (d[ch1] >= 0)
                            l++;
                        d[ch1] = d[ch1] + 1;
                    }
                    start++;
                }
                end++;
            }

            if (index == -1)
                return "";
            return A.Substring(index, min_len);
        }
    }
}

