using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice10
    {
        public int TitleToNumber(string A)
        {
            int number = 0;
            var pow = (int)Math.Pow(26, A.Length -1);
            int asciiBase = 0;
            foreach (char c in A)
            {
                asciiBase = char.IsUpper(c) ? 64 : 89;
                number += ((((int)c) - asciiBase) % 27) * pow ;
                pow /= 26;
            }
            
            return number;
        }

        public int GreatestMForEqualModulous(int A, int B)
        {
            if (A > B) return A - B;
            return B - A;
        }

        public int FindDivisibilityby8(string A)
        {
            int number = 0;
            if (A.Length < 3) number = int.Parse(A);
            else number = int.Parse(A.Substring(A.Length - 3, 3));
            return (number % 8) > 0 ? 0 : 1;
        }

        public int FindMod(string A, int B)
        {
            long num = 0, rem =0;
            
            foreach(var c in A)
            {
                num = rem * 10 + (c - '0');
                rem = num % B;
            }
            return (int)rem;
        }
        public int FindMinimum(int A, int B, int C)
        {
            int min = int.MaxValue;
            int minMod = Math.Min(C%10, Math.Min(A % 10, B % 10));

            return min;
        }

        private void grayCodeHelper(List<int> result, int n)
        {
            if (n == 0)
            {
                result.Add(0);
                return;
            }
            // we derive the n bits sequence from the (n - 1) bits sequence.
            grayCodeHelper(result, n - 1);
            int currentSequenceLength = result.Count;
            // Set the bit at position n - 1 (0 indexed) and assign it to mask.
            int mask = 1 << (n - 1);
            for (int i = currentSequenceLength - 1; i >= 0; i--)
            {
                // mask is used to set the (n - 1)th bit from the LSB of all the numbers present in the current sequence.
                result.Add(result[i] | mask);
            }
        }

        public int BalancedParantheses(string A)
        {
            int count = 0;
            var stack = new Stack();
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == '(') stack.Push(A['(']);
                else
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else return 0;
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }

        public int isValidSudoku(List<string> A)
        {
            var myset = new HashSet<string>();

            for(int i = 0;i< 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var curr_val = A[i][j];
                    if (curr_val != '.')
                    {
                        if (myset.Contains(curr_val + " rows " + i.ToString()) ||
                            myset.Contains(curr_val + " columns " + j.ToString()) ||
                            myset.Contains(curr_val + " box " + (i / 3).ToString() + "-" + (j / 3).ToString()))
                        {
                            return 0;
                        }
                        myset.Add(curr_val + " rows " + i.ToString());
                        myset.Add(curr_val + " columns " + j.ToString());
                        myset.Add(curr_val + " box " + (i / 3).ToString() + "-" + (j / 3).ToString());
                    }
                }
            }
            return 1;
        }

        public int Tree(List<int> A, List<int>B)
        {

            int n = A.Count;
            int minCost = int.MaxValue;
            for (int q = 1; q < n - 1; q++)
            {
                int cost = 0;
                int minB1 = int.MaxValue;
                int minB2 = int.MaxValue;

                for (int p = 0; p < q; p++)
                {
                    if (A[p] < A[q])
                    {
                        minB1 = Math.Min(minB1, B[p]);
                    }
                }

                for (int r = q + 1; r < n; r++)
                {
                    if (A[q] < A[r])
                    {
                        minB2 = Math.Min(minB2, B[r]);
                    }
                }

                if (minB1 == int.MaxValue || minB2 == int.MaxValue) continue;
                else cost = minB1 + B[q] + minB2;

                minCost = Math.Min(minCost, cost);
            }

            return minCost == int.MaxValue ? -1 : minCost;
        }
    }
}
