using DataStructuresAlgorithms.Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Easy
{
    public class TestProblem4
    {
        [Fact]
        public void TestProblem4WithExample1()
        {
            Problem4 problem4 = new Problem4();

            //Input: nums = [1, 2, 3, 1]
            //Output: true
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var solution = problem4.MaxSubArray(nums);
            Assert.Equal(6, solution);

            //Input: nums = [1, 2, 3, 4]
            //Output: false
            nums = new int[] { 1 };
            var solution2 = problem4.MaxSubArray(nums);
            Assert.Equal(1, solution2);

            //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
            //Output: true
            nums = new int[] { 5, 4, -1, 7, 8 };
            var solution3 = problem4.MaxSubArray(nums);
            Assert.Equal(23, solution3);

        }
    }
}
