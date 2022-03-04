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
        /*
         You are given a 2D integer matrix A, return a 1D integer vector containing column-wise sums of original matrix.
         */
        public List<int> SumRowWiseMatrix(List<List<int>> A)
        {
            if (A.Count <= 0 && A[0].Count <= 0) return null;
            var sumMatrix = new List<int>();
            for (int i = 0; i < A[0].Count; i++)
            {
                int sum = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    sum += A[j][i];
                }
                sumMatrix.Add(sum);
            }

            return sumMatrix;
        }

        /*
         Give a N * N square matrix A, return an array of its anti-diagonals. Look at the example for more details.
            1 2 3
            4 5 6
            7 8 9
         */
        public List<List<int>> AntiDiagonalArray(List<List<int>> A)
        {
            var array = new List<List<int>>();
            int n = A.Count;
            for (int j = 0; j < n; j++)
            {
                int I = 0, J = j;
                var row = new List<int>();
                while(I < n && J >= 0)
                {
                    row.Add(A[I][J]);
                    I++;
                    J--;
                }
                while (n - row.Count > 0) row.Add(0);
                array.Add(row);
            }

            for(int i=1;i< n; i++)
            {
                int I = i, J = n-1;
                var row = new List<int>();
                while (I < n && J >= 0)
                {
                    row.Add(A[I][J]);
                    I++;
                    J--;
                }
                while (n - row.Count > 0) row.Add(0);
                array.Add(row);
            }

            return array;
        }


        /*
         You are given two integer matrices A(having M X N size) and B(having N X P). 
         You have to multiply matrix A with B and return the resultant matrix. (i.e. return the matrix AB).
         */
        public List<List<int>> MultiplyTwoMatrices(List<List<int>> A, List<List<int>> B)
        {
            if ((A.Count <= 0 && A[0].Count <= 0) || B.Count <= 0 && B[0].Count <= 0) return null;
            // A = M X N, B = N X P
            var multipliedMatrix = new List<List<int>>();
            int n = B.Count;
            int m = A.Count;
            int p = B[0].Count;
            for (int k = 0; k < n; k++)
            {
                int i = 0, j= 0, sum =0;
                var row = new List<int>();
                while ( i < m)
                {
                    while (j < p)
                    {
                        sum += A[i][k] * B[k][j];
                        j++;
                    }
                    row.Add(sum);
                    i++;
                }
                multipliedMatrix.Add(row);
            }

            return multipliedMatrix;
        }

        public List<List<int>> Substract(List<List<int>> A, List<List<int>> B)
        {
            if(A != null && A.Count >= 0 )
            {
                var diffMatrix = new List<List<int>>();
                int cols = A[0].Count;
                int rows = A.Count;
                for (int i = 0; i < rows; i++)
                {
                    var row = new List<int>();
                    for (int j = 0; j < cols; j++)
                    {
                        row.Add(A[i][j] - B[i][j]);
                    }
                    diffMatrix.Add(row);
                }
                return diffMatrix;
            }
            return null;
        }
    }
}
