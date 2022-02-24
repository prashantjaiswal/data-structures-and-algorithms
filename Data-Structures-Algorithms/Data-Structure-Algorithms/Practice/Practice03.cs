using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
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
            throw new NotImplementedException();
        }
    }
}
