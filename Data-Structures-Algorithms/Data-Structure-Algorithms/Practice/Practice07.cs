using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice07
    {
        public string AddBinary(string A, string B)
        {
            // Initialize result
            var result = new StringBuilder();

            // Initialize digit sum
            int s = 0;

            // Traverse both strings starting
            // from last characters
            int i = A.Length - 1, j = B.Length - 1;
            while (i >= 0 || j >= 0 || s == 1)
            {

                // Comput sum of last
                // digits and carry
                s += ((i >= 0) ? A[i] - '0' : 0);
                s += ((j >= 0) ? B[j] - '0' : 0);

                // If current digit sum is
                // 1 or 3, add 1 to result
                result.Append((char)(s % 2 + '0'));

                // Compute carry
                s /= 2;

                // Move to next digits
                i--; j--;
            }
            var final = new StringBuilder();
            var res = result.ToString();
            for (int k = 0; k < res.Length; k++)
            {
                final.Append(res[res.Length - 1 - i]);
            }
            return final.ToString();
        }

        /* public int NumSetBits(int A)
         {
             int count = 0;
             while((A << 1).CompareTo(0))
             {
                 if (A % 2 == 1) count++;
             }
             return count;
         }*/

        /*
         * Given an integer array A, find if an integer p exists in the array such 
         * that the number of integers greater than p in the array equals p.
         */
        public int NobleNumbers(List<int> A)
        {
            A.Sort((a, b) => b.CompareTo(a));
            if (A[0] == 0) return 1;
            int cnt = 0;
            for (int i =0; i < A.Count ; i++)
            {
                if (A[i] != A[i - 1])
                {
                    cnt = i;
                }
                if (cnt == A[i])
                {
                    return 1;
                }
            }
            return -1;
        }

        public int CheckIfAP(List<int> A)
        {
            A.Sort();
            int diff = 0;
            if (A.Count > 2) diff = A[1] - A[0];
            for (int i = 0; i < A.Count -1; i++)
            {
                if (A[i + 1] - A[i] != diff) return 0;
            }
            return 1;
        }
        public List<int> sortColors(List<int> A)
        {
            int zeroes = 0;
            int ones = 0;
            int twos = 0;
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] == 0) zeroes++;
                else if (A[i] == 1) ones++;
                else twos++;
            }
            for (int j = 0; j < A.Count; j++)
            {
                if (j < zeroes) A[j] = 0;
                else if (j >= zeroes && j < zeroes + ones) A[j] = 1;
                else A[j] = 2;
            }
            return A;
        }

        public int RemovalCost(List<int> A)
        {
            A.Sort();
            int cost = 0;
            for (int i = 1; i < A.Count; i++)
            {
                A[i] += A[i - 1];
            }
            A.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < A.Count; j++)
            {
                cost += A[j];
            }
            return cost;
        }

        public string LargestNumber(List<int> A)
        {
            A.Sort((a, b) => {
                long v1 = long.Parse(a.ToString() + b.ToString());
                long v2 = long.Parse(b.ToString() + a.ToString());
                if (v1 <= v2)
                {
                    return 1;
                }
                return -1;
            });
            var str = new StringBuilder();
            long sum = 0;
            for (int i = 0; i < A.Count; i++)
            {
                str.Append(A[i]);
                sum += A[i];
            }
            if (sum == 0) return "0";
            return str.ToString();
        }

        public long reverse(long A)
        {

            long sum = 0;
            int p = 31;
            while (A > 0)
            {

                long rem = A % 2;
                sum += rem * (long)Math.Pow(2, p);
                p--;
                A /= 2;
            }

            return sum;
        }

        public string ReverseString(string A)
        {
            var s = new StringBuilder();
            int i = 0;
            while (i < A.Length)
            {
                s.Append(A[A.Length - 1 - i]);
                i++;
            }
            return s.ToString();
        }
        public List<char> to_lower(List<char> A)
        {
            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] >= 'A' && A[i] <= 'Z') A[i] = (char)(A[i] + 'a' - 'A');
            }
            return A;
        }

        public string ReverseSentence(string A)
        {
            char[] arr = A.ToCharArray();
            int n = arr.Length - 1;
            for (int i = 0; i < n / 2; i++)
            {
                char c = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - i - 1] = c;
            }
            int L = 0;
            for (int r = 0; r < n; r++)
            {
                if (arr[r] == ' ')
                {
                    int R = r - 1;
                    while (L < R)
                    {
                        char c = arr[L];
                        arr[L] = arr[R];
                        arr[R] = c;
                        L++;
                        R--;
                    }
                    L = r + 1;
                }
                if (r == n - 1)
                {
                    int R = r;
                    while (L < R)
                    {
                        char c = arr[L];
                        arr[L] = arr[R];
                        arr[R] = c;
                        L++;
                        R--;
                    }
                }

            }
            return new string(arr).Trim();
        }

        public string longestPalindrome(string A)
        {
            string answer = string.Empty;
            for (int i = 0; i < A.Length; i++)
            {
                if ((i & 1) == 0)
                {
                    var s = findlongest(A, i, i + 1);
                    answer = answer.Length > s.Length ? answer : s;
                }
                else
                {
                    var se = findlongest(A, i, i);
                    answer = answer.Length > se.Length ? answer : se;
                }
            }
            return answer;
        }
        public string findlongest(string s, int p1, int p2)
        {
            while (p1 >= 0 && p2 < s.Length)
            {
                if (s[p1] != s[p2]) break;
                p1--;
                p2++;
            }
            
            return s.Substring(p1+1, p2-p1-1);
        }

        public int CountOccurrence(string A)
        {
            int start = 0;
            int count = 0;
            for (int i = 0; i < A.Length;)
            {
                if (i < 2) i++;
                else
                {
                    i++;
                    if (A.Substring(start, 3).Contains("bob")) count++;
                    start++;
                }
            }
            return count;
        }
    }

}
