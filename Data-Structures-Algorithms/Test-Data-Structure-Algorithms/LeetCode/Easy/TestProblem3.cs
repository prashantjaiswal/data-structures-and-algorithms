using DataStructuresAlgorithms.Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Easy
{
    public class TestProblem3
    {
        [Fact]
        public void TestProblem2WithExample1()
        {
            Problem3 problem3 = new Problem3();

            //Input: nums = [1, 2, 3, 1]
            //Output: true
            var nums = new int[] { 1, 2, 3, 1 };
            var solution = problem3.ContainsDuplicate(nums);
            Assert.True(solution);

            //Input: nums = [1, 2, 3, 4]
            //Output: false
            nums = new int[] { 1, 2, 3, 4 };
            var solution2 = problem3.ContainsDuplicate(nums);
            Assert.False(solution2);

            //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
            //Output: true
            nums = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            var solution3 = problem3.ContainsDuplicate(nums);
            Assert.True(solution3);

        }
    }
}
