using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Problem07
    {
        /*
        Problem Statement #
        Given an array containing 0s and 1s, if you are allowed to replace no more than ‘k’
        0s with 1s, find the length of the longest contiguous subarray having all 1s.

        Example 1:

        Input: Array=[0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1], k=2
        Output: 6
        Explanation: Replace the '0' at index 5 and 8 to have the longest contiguous subarray
        of 1s having length 6.
        Example 2:

        Input: Array=[0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1], k=3
        Output: 9
        Explanation: Replace the '0' at index 6, 9, and 10 to have the longest contiguous
        subarray of 1s having length 9.
         */

        public int FindLengthLongestOnesSubstring(int[] array, int k)
        {
            int windowStart = 0;
            int maxOnesCount = 0;
            int maxLength = int.MinValue;
            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                if (array[windowEnd] == 1) maxOnesCount++;
                if (windowEnd - windowStart + 1 - maxOnesCount > k)
                {
                    int leftChar = array[windowStart];
                    if(leftChar == 1) maxOnesCount--;
                    windowStart++;
                }
                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);
            }
            return maxLength;
        }
    }
}
