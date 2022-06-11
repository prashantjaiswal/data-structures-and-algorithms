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
        public string longestCommonPrefix(List<string> A)
        {
            var minStr = "";
            var prefix = "";
            var minLength = int.MaxValue;
            for (int i = 0; i < A.Count; i++)
            {
                if (minLength > A[i].Length)
                {
                    minLength = A[i].Length;
                    minStr = A[i];
                }
            }
            bool pref = true;
            for (int i = 1; i <= minStr.Length && pref; i++){
                int j = 0;
                for (; j < A.Count; j++)
                {
                    if (!(A[j].Substring(0, i) == minStr.Substring(0, i)))
                            pref = false;
                }
                if (pref) prefix = minStr.Substring(0, i);
            }
            return prefix;
        }

        public List<int> FindCommon(List<int> A, List<int> B)
        {
            var list = new List<int>();
            var d2 = new Dictionary<int, int>();
            foreach (var num in B)
            {
                if (d2.ContainsKey(num)) d2[num]++;
                else d2.Add(num, 1);
            }

            foreach(var key in A)
            {
                if (d2.ContainsKey(key) && d2[key] > 0)
                {
                    list.Add(key);
                    d2[key]--;
                }
            }
            return list;
        }

        public int solve(List<int> A)
        {
            var list = new List<int>();
            list.Add(A[0]);
            for (int i = 1; i < A.Count; i++)
            {
                var num = list[i - 1] + A[i];
                list.Add(num);
            }

            var d2 = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                if (d2.ContainsKey(num) || (num == 0 && i > 0)) return 1;
                else d2.Add(num, 1);
            }
            return 0;
        }

        public List<int> lszero(List<int> A)
        {
            int len = A.Count;
            int answer = 0;

            var pf = new int[len];
            pf[0] = A[0];
            for (int i = 1; i < len; i++)
                pf[i] = pf[i - 1] + A[i];

            var hm = new Dictionary<int, int>();
            hm.Add(0, -1);
            int l = -1;

            for (int i = 0; i < len; i++)
            {
                if (hm.ContainsKey(pf[i]))
                {
                    int firstIndex = hm[pf[i]];
                    int length = i - firstIndex;
                    int previousAnswer = answer;
                    answer = Math.Max(answer, length);
                    if (answer > previousAnswer)
                    {
                        l = firstIndex + 1;
                    }
                }
                else
                    hm.Add(pf[i], i);
            }
            if (answer > 0)
            {
                var result = new List<int>();
                int i = 0;
                while (i < answer)
                {
                    result.Add(A[l + i]);
                    i++;
                }
                return result;
            }

            return new List<int>();
        }

        public int colorful(int A)
        {
            var d2 = new HashSet<int>();
            int prev = -1;
            int n = 10;
            while (A > 0)
            {
                int currDigit = A % n;
                A = A / n;
                if (d2.Count ==0)
                {
                    d2.Add(currDigit);
                    prev = currDigit;
                    continue;
                }
                if (d2.Contains(currDigit)) return 0;
                d2.Add(currDigit);

                if (d2.Contains(currDigit * prev)) return 0;
                d2.Add(currDigit * prev);
                prev = currDigit;
            }

            return 1;
        }

        public int ChangeCharacter(string A, int B)
        {
            var d = new Dictionary<char, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (d.ContainsKey(A[i])) d[A[i]]++;
                else d.Add(A[i], 1);
            }
            int count = 0;
            foreach (var key in d.Keys)
            {
                if (count <= B && d[key] <= B) count += d[key];
            }
            return count;
        }

        public int DiffPossible(List<int> A, int B)
        {
            var d = new HashSet<int>();
            foreach (var num in A)
            {
                if (d.Contains(num + B)|| d.Contains(num - B))
                {
                    return 1;
                }
                else d.Add(num);
            }
            return 0;
        }

        public List<int> dNums(List<int> A, int B)
        {
            var d = new Dictionary<int, int>();
            var list = new List<int>();
            int L = 0, R = 0;
            while (R < A.Count)
            {
                if (d.ContainsKey(A[R])) d[A[R]]++;
                else d.Add(A[R], 1);

                if (R >= B - 1)
                {
                    list.Add(d.Count);
                    d[A[L]]--;
                    if (d[A[L]] == 0) d.Remove(A[L]);
                    L++;
                }
                R++;
            }
            return list;
        }

        public List<int> TwoSum(List<int> A, int B)
        {
            // Input: [2, 7, 11, 15], target=9
            var d = new Dictionary<int, int>();
            var list = new List<int>();
            for (int i = 0; i < A.Count; i++)
            {
                if (d.ContainsKey(B - A[i]))
                {
                    list.Add(d[B - A[i]]);
                    list.Add(i);
                    return list;
                }
                else if (!d.ContainsKey(A[i])) d.Add(A[i], i);

            }
            return list;
        }

        public int solve(List<int> A, int B)
        {
            int count = 0;
            var d = new Dictionary<int, int>();
            for (int i = 0; i < A.Count; i++)
            {
                int current = A[i];
                for (int j = i + 1; j < A.Count; j++)
                {
                    int next = A[j];
                    if ((current ^ next) == B) count++;
                }
            }
            return count;
        }

        public int IsDictionary(List<string> A, string B)
        {
            var d = new Dictionary<char, int>();
            int serial = 0;
            foreach (char c in B) d.Add(c, serial++);
            for (int j = 1 ; j < A.Count; j++)
            {
                var s1 = A[j - 1];
                var s2 = A[j];
                if (!IsLex(s1, s2, d)) return 0;
            }
            return 1;
        }

        public bool IsLex(string s1, string s2, Dictionary<char,int> d)
        {
            int l1 = s1.Length;
            int l2 = s2.Length;
            for (int i = 0; i < Math.Min(l1,l2); i++)
            {
                int s1Value = d[s1[i]];
                int s2Value = d[s2[i]];

                if (s1Value < s2Value)
                    return true;

                if (s2Value < s1Value)
                    return false;
            }
            return l1 <= l2;
        }

        public static string reverse(string s)
        {
            if (string.IsNullOrEmpty(s)) return s;
            return reverse(s.Substring(1)) + s[0];
        }

        /*  public int IsValidSudoku(List<string> A)
          {
              var d = new HashSet<string>();
              for(int i = 0; i < 10; i++)
              {
                  for (int j = 0; j < 10; j++)
                  {
                      var current = A[i][j];
                      if(current != '.')
                          if(current + "rows" + )

                  }
              }
                  if (curr_val != '.'):
                      if (curr_val + " rows " + str(i)) in myset or(curr_val +" columns " + str(j)) in myset or(curr_val +" box " + str(i//3) + "-" + str(j//3)) in myset:
                          return 0
                      myset.add(curr_val + " rows " + str(i))
                      myset.add(curr_val + " columns " + str(j))
                      myset.add(curr_val + " box " + str(i//3) + "-" + str(j//3))

          return 1
          }*/

        

        public int bar(int x, int y)
        {
            if (y == 0) return 0;
            return (x + bar(x, y - 1));
        }

        public int foo(int x, int y)
        {
            if (y == 0) return 1;
            return bar(x, foo(x, y - 1));
        }

        public List<int> SubarraySum(List<int> A, int B)
        {
            int sum = 0;
            int r = 0;
            int l = 0;
            bool flag = false;

            while (r < A.Count && l < A.Count)
            {
                while (sum < B && r < A.Count)
                {
                    sum += A[r];
                    r++;
                }
                if (sum == B)
                {
                    flag = true;
                    break;
                }
                while (sum > B && l < A.Count)
                {
                    sum -= A[l];
                    l++;
                }
                if (sum == B)
                {
                    flag = true;
                    break;
                }
            }
            List<int> result = new List<int>();
            if (flag)
            {
                for (int i = l; i < r; i++) result.Add(A[i]);
                return result;
            }
            result.Add(-1);
            return result;
        }

        public string longestPalindrome(string A)
        {
            string rtrn = "";
            for (int i = 0; i < A.Length; i++)
            {
                string tempMax1 = (expandSearch(A, i, i));
                string tempMax2 = (expandSearch(A, i, i + 1));
                if (rtrn.Length < tempMax1.Length || rtrn.Length < tempMax2.Length)
                    rtrn = (tempMax1.Length < tempMax2.Length) ? tempMax2 : tempMax1;
            }
            return rtrn;
        }

        public string expandSearch(string A, int sInd, int eInd)
        {
            while (sInd >= 0 && eInd < A.Length && (A[sInd] == A[eInd]))
            {
                sInd--;
                eInd++;
            }
            return A.Substring(sInd + 1, eInd - sInd -1);
        }

       
    }
}
