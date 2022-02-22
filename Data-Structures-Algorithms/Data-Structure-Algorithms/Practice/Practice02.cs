using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice02
    {
        public int solve(List<int> A, int B)
        {
            int count = A.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (A[i] + A[j] == B) return 1;
                }
            }
            return 0;
        }

        public int MaxMinOfArray(int[] A)
        {
            int count = A.Length;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < count; i++)
            {
                max = Math.Max(max, A[i]);
                min = Math.Min(min, A[i]);
            }

            return 0;
        }
        public List<int> Reverse(List<int> A)
        {
            int temp = 0;
            int length = A.Count;
            for (int i = 0; i < length / 2; i++)
            {
                temp = A[i];
                A[i] = A[length - i - 1];
                A[length - i - 1] = temp;
            }
            return A;
        }

        public int Rotate(List<int> A, int B)
        {
            int count = A.Count;
            int temp = 0;
            int range = count / 2;
            for (int i = 0; i < range; i++)
            {
                temp = A[i];
                A[i] = A[count - i - 1];
                A[count - i - 1] = temp;
            }

            range = B / 2;
            for (int i = 0; i < range; i++)
            {
                temp = A[i];
                A[i] = A[B - i - 1];
                A[B - i - 1] = temp;
            }

            temp = 0;
            range = (count - B) / 2;
            for (int i = 0; i < range; i++)
            {
                temp = A[B + i];
                A[B + i] = A[count - i - 1];
                A[count - i - 1] = temp;
            }
            return 0;
        }


        public int Rotate01(List<int> A, int B)
        {
            int[] a = new int[A.Count];
            for (int i = 0; i < A.Count; i++)
            {
                a[(i + B) % A.Count] = A[i];
            }
            for (int i = 0; i < A.Count; i++)
            {
                A[i] = a[i];
            }
            return 0;
        }

        public int Rotate02(List<int> A, int B)
        {
            var a = "1 2 3 4 5".Split(" ").Select(Int32.Parse).ToList();
            for (int i = 0; i < A.Count; i++)
            {
                a[(i + B) % A.Count] = A[i];
            }
            for (int i = 0; i < A.Count; i++)
            {
                A[i] = a[i];
            }
            return 0;
        }
    }
}
