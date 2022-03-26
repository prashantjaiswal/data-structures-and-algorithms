using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice06
    {
        public List<List<int>> MarkZero(List<List<int>> A)
        {
            int R = A.Count;
            int C = A[0].Count;
            var rows = new HashSet<int>();
            var cols = new HashSet<int>();

            // Essentially, we mark the rows and columns that are to be made zero
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (A[i][j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            // Iterate over the array once again and using the rows and cols sets, update the elements.
            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        A[i][j] = 0;
                    }
                }
            }
            return A;
        }

        //TODO: Understand it 
        public List<List<int>> GenerateMatrix(int A)
        {
            var result = new int[A,A];
            int cnt = 1;
            for (int layer = 0; layer < (A + 1) / 2; layer++)
            {
                // direction 1 - traverse from left to right
                for (int ptr = layer; ptr < A - layer; ptr++)
                {
                    result[layer,ptr] = cnt++;
                }
                // direction 2 - traverse from top to bottom
                for (int ptr = layer + 1; ptr < A - layer; ptr++)
                {
                    result[ptr, A - layer - 1] = cnt++;
                }
                // direction 3 - traverse from right to left
                for (int ptr = layer + 1; ptr < A - layer; ptr++)
                {
                    result[A - layer - 1,A - ptr - 1] = cnt++;
                }
                // direction 4 - traverse from bottom to top
                for (int ptr = layer + 1; ptr < A - layer - 1; ptr++)
                {
                    result[A - ptr - 1 ,layer] = cnt++;
                }
            }
            var list = new List<List<int>>();
            
            for (int i = 0; i < A; i++)
            {
                var row = new List<int>();
                for (int j = 0; j < A; j++)
                    row.Add(result[i,j]);
                list.Add(row);
            }
            return list;
        }

        //TODO:
        public void rotate(List<List<int>> a)
        {
            transpose(a);
            reflect(a);
        }

        public void transpose(List<List<int>> matrix)
        {
            int n = matrix.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int tmp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = tmp;
                }
            }
        }

        public void reflect(List<List<int>> matrix)
        {
            int n = matrix.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = tmp;
                }
            }
        }
    }
}
