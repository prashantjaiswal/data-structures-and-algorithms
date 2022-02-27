using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    /// <summary>
    /// Prefix Sum
    /// Sum[L,R] = PS[R] - PS[L-1] where L -1> 0 
    /// </summary>
    public class Practice03
    {
        /*
         * You are given an array A of integers of size N.

            Your task is to find the equilibrium index of the given array

            Equilibrium index of an array is an index such that the sum of elements at lower indexes is equal to the sum of elements at higher indexes.

            NOTE:

            Array indexing starts from 0.
            If there is no equilibrium index then return -1.
            If there are more than one equilibrium indexes then return the minimum index.
         */
        public int EquilibriumIndex(List<int> A)
        {
            int n = A.Count;
            for (int i = 1; i < n; i++)
            {
                A[i] += A[i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                if (i != 0 && (A[i - 1] == A[n - 1] - A[i]))
                    return i;
                if (i == 0 && (A[n - 1] - A[0] == 0))
                    return 0;

            }
            return -1;
        }

        /*
        Given an array, arr[] of size N, the task is to find the count of
        array indices such that removing an element from these indices makes
        the sum of even-indexed and odd-indexed array elements equal.
         */
        public int SumOfOddEvenByRemovingOneElement(List<int> A)
        {
            int count = A.Count;
            var listOdd = new List<int>();
            var listEven = new List<int>();
            int indexCount = 0;

            for(int j = 0; j< count; j++)
            {
                if(j%2 == 0)
                {
                    listEven.Add(A[j]);
                    listOdd.Add(0);
                }
                else
                {
                    listOdd.Add(A[j]);
                    listEven.Add(0);
                }
            }

            for (int i = 0; i < count - 1; i++)
            {
                listOdd[i + 1] += listOdd[i];
                listEven[i + 1] += listEven[i];
            }

            for(int i = 0; i < count; i++)
            {
                if (i == 0 &&
                    listOdd[count - 1] - listOdd[i] == listEven[count - 1] - listEven[i])
                {
                    indexCount++;
                }
                else if (i != 0 && listEven[i - 1] + listOdd[count - 1] - listOdd[i] ==
                    listOdd[i - 1] + listEven[count - 1] - listEven[i])
                {
                    indexCount++;
                }
            }
            return indexCount;
        }

        /*
        You are given an integer array A of length N.
        You are also given a 2D integer array B with dimensions M x 2, where each row denotes a [L, R] query.
        For each query, you have to find the sum of all elements from L to R indices in A (1 - indexed).
        More formally, find A[L] + A[L + 1] + A[L + 2] +... + A[R - 1] + A[R] for each query.



        Problem Constraints
        1 <= N, M <= 105
        1 <= A[i] <= 109
        1 <= L <= R <= N
         */
        public List<long> RangeSum(List<int> A, List<List<int>> B)
        {
            int n = A.Count;
            var listA = new List<long>();
            for (int i = 0; i < n; i++)
            {
                if (i == 0) listA.Add(A[i]);
                else listA.Add(A[i] + listA[i-1]);
            }
            var list = new List<long>();
            for (int i = 0; i < B.Count; i++)
            {
                int L = B[i][0] -1;
                int R = B[i][1] -1;
                if (L > 0)
                    list.Add(listA[R] - listA[L - 1]);
                else
                    list.Add(listA[R]);
            }
            return list;
        }

        /*
        Given an integer array A of size N.
        You can pick B elements from either left or right end of the array A to get maximum sum.
        Find and return this maximum possible sum.
        NOTE: Suppose B = 4 and array A contains 10 elements then
        You can pick first four elements or can pick last four elements or can pick 1 from
        front and 3 from back etc . you need to return the maximum possible sum of elements you can pick.
        Problem Constraints
        1 <= N <= 105
        1 <= B <= N
        -103 <= A[i] <= 103
         */
        //[5, -2, 3 , 1, 2] -> [5, 3, 6, 7, 8] -> rotate 7 8 5 3 6
       
        public int MaximumPossibleSum(List<int> A, int B)
        {
            int max = int.MinValue;
            int n = A.Count;
            var frontArr = new int[B +1 ];
            var rearArr = new int[B + 1];

            for (int i = 0; i < B; i++)
            {
                frontArr[i + 1] = A[i] + frontArr[i];
                rearArr[i + 1] = A[n - i - 1] + rearArr[i];
            }

            for (int i = 0; i <= B; i++)
            {
                int m = frontArr[i] + rearArr[B - i];
                max = Math.Max(max, m);
            }
            return max;
        }

        /*
         You are given an integer array A. You have to find the second
        largest element/value in the array or report that no such element exists.
         */
        public int SecondLargest(List<int> A)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int current = 0;
            int third = int.MinValue;
            if (A.Count <= 1) return -1;

            for (int i = 0; i < A.Count; i++)
            {
                current = A[i];
                if (current > first) first = current;
                if (current > second && current < first) second = current;
                else third = current;
            }
            if(third > int.MinValue)
                return second;
            return -1;
        }
    }
}
