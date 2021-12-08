using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Leetcode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// Dynamic Programming, Kadane's Algorithm
    /// </summary>
    public class Problem4
    {
        public int MaxSubArray(int[] nums)
        {
            int max_so_far = int.MinValue, max_here = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max_here += nums[i];
                if (max_here > max_so_far)
                    max_so_far = max_here;

                if (max_here < 0)
                    max_here = 0;
            }
            return max_so_far;
        }
    }
}
