using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Leetcode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/contains-duplicate/
    /// </summary>
    public class Problem3
    {
        public bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> catalog = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (!catalog.ContainsKey(current))
                    catalog[current] = current;
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}
