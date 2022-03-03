using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice06
    {
        /*
        You are given two matrices A & B of same size, you have to return
        another matrix which is the sum of A and B.
         */
        public List<List<int>> SumOfTwoMatrices(List<List<int>> A, List<List<int>> B)
        {
            if (A.Count <= 0 && A[0].Count <= 0) return null;
            int rows = A.Count;
            int cols = A[0].Count;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    A[i][j] = A[i][j] + B[i][j];
                }
            }
            return A;
        }
    }
}
