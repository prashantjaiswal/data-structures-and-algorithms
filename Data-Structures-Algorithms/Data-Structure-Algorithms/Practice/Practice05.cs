using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice05
    {
        /*
        Problem Description
        Find the contiguous non empty subarray within an array, A of length N which has the largest sum.
         */
        public int FindMaxSubArray(List<int> A)
        {
            int size = A.Count;
            int max = int.MinValue;
            int maxTillCurrent = 0;

            for (int i = 0; i < size; i++)
            {
                maxTillCurrent += A[i];

                if (max < maxTillCurrent)
                    max = maxTillCurrent;

                if (maxTillCurrent < 0)
                    maxTillCurrent = 0;
            }

            return max;
        }

        /*
        Problem Description
        You are given an integer array A of length N.
        You have to find the sum of all subarray sums of A.
        More formally, a subarray is a defined as a contiguous part of an array,
        which we can obtain by deleting zero or more elements from either end of the array.
        A subarray sum denotes the sum of all the elements of that subarray.
         */
        public long FindSubarraySum(List<int> A)
        {
            long sum = 0;
            long length = A.Count;
            for (int i = 0; i < length; i++)
            {
                sum += (i + 1) * (length - i) * A[i];
            }

            return sum;
        }

        /*
        You are given an integer array C of size A. Now you need to find a subarray
        (contiguous elements) so that the sum of contiguous elements is maximum.
        But the sum must not exceed B.
         */

        public int FindMaxSubarray(int A, int B, List<int> C)
        {
            int maxSum = int.MinValue;
            for (int i = 0; i < A; i++)
            {
                int sum = 0;
                for (int j = i; j < A; j++)
                {
                    sum += C[j];
                    if (sum <= B && sum > maxSum)
                        maxSum = sum;
                }
            }
            return (maxSum == int.MinValue) ? 0 : maxSum;
        }

        /*
         Return the index of the first element of the subarray of size k that has least average.
         Array indexing starts from 0
         */

        public int FindLeastAvgOfSize(List<int> A, int B)
        {
            int length = A.Count;
            for (int i = 0; i < length - 1; i++)
            {
                A[i + 1] += A[i];
            }
            //20, 3, 13, 5, 10, 14, 8, 5, 11, 9, 1, 11
            //20, 23, 36, 41, 51, 65, 73, 78, 89, 98, 99, 110
            int startIndex = 0;
            decimal minAvg = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < length; i++)
            {
                if(i - startIndex >= B -1)
                {
                    int diff = startIndex == 0 ? A[i] : A[i] - A[startIndex -1];
                    decimal avg = Math.Round(Average(diff, B), 5);
                    if (minAvg > avg)
                    {
                        minAvg = avg;
                        minIndex = startIndex;
                    }
                    startIndex++;
                }
            }
            return minIndex;
        }
        public decimal Average(int numerator, int denominator)
        {
            return (decimal)(numerator) / denominator;
        }


        /*
        Given an array A of N non-negative numbers and you are also given non-negative number B.
        You need to find the number of subarrays in A having sum less than B. We may assume that there is no overflow.
        */
        public int CountingSubarrays(List<int> A, int B)
        {
            int count = 0;
            int length = A.Count;
            for (int i = 0; i < length; i++)
            {
                int sum = 0;
                for (int j = i; j < length; j++)
                {
                    sum += A[j];
                    if (sum < B)
                        count++;
                }
            }
            return count;
        }

        /*
        Given an array of integers A.
        A subarray of an array is said to be good if it fulfils any one of the criteria:
        1. Length of the subarray must be even and the sum of all the elements of the subarray must be less than B.
        2. Length of the subarray must be odd and the sum of all the elements of the subarray must be greater than B.
        Your task is to find the count of good subarrays in A.
         */
        public int FindSubarraysEvenOdd(List<int> A, int B)
        {
            int goodArrayCount = 0;
            //1, 2, 3, 4, 5
            //1, 3, 6, 10, 15
            for (int i = 0; i < A.Count -1; i++)
            {
                A[i + 1] += A[i];
            }
            
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < A.Count; j++)
                {
                    int sum = i == 0 ? A[j] : A[j] - A[i-1];
                    if (sum < B && (j + 1 - i) % 2 == 0) goodArrayCount++;
                    if (sum > B && (j + 1 - i) % 2 != 0) goodArrayCount++;
                }
            }
            return goodArrayCount;
        }
    }
}
