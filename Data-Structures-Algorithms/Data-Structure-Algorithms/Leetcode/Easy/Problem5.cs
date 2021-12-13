using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Leetcode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// Example 1:
    /// Input: nums = [2, 7, 11, 15], target = 9
    /// Output: [0,1]
    /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public class Problem5
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dictionary.ContainsValue(diff))
                {
                    foreach (var d in dictionary)
                    {
                        if (d.Value == diff)
                            return new int[] { d.Key, i };
                    }
                }
                dictionary.Add(i, nums[i]);
            }
            return new int[] { };
        }
    }
}
