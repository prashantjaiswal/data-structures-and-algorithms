using DataStructuresAlgorithms.Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Easy
{
    public class TestProblem5
    {
        [Fact]
        public void TestProblem5WithExample1()
        {
            Problem5 problem5 = new Problem5();

            //Input: nums = [1, 2, 3, 1]
            //Output: true
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;
            var solution = problem5.TwoSum(nums, target);
            Assert.Equal(new int[] { 0, 1 }, solution);

            //Input: nums = [1, 2, 3, 4]
            //Output: false
            nums = new int[] { 3, 2, 4 };
            target = 6;
            var solution2 = problem5.TwoSum(nums, target);
            Assert.Equal(new int[] { 1, 2 }, solution2);

            //Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]
            //Output: true
            nums = new int[] { 3, 3 };
            target = 6;
            var solution3 = problem5.TwoSum(nums, target);
            Assert.Equal(new int[] { 0, 1 }, solution3);

        }
    }
}

