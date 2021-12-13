using System;
using DataStructuresAlgorithms.Leetcode.Easy;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Easy
{
    public class TestProblwm6
    {
        [Fact]
        public void TestProblem5WithExample1()
        {
            Problem6 problem6 = new Problem6();

            //Input: nums = [1, 2, 3, 1]
            //Output: true
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2= new int[] { 2, 5, 6 };
            var n = 3;
            problem6.Merge(nums1, m, nums2, n);
        }
    }
}
