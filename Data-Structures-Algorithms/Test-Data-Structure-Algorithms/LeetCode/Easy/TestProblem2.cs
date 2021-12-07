using DataStructuresAlgorithms.Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Easy
{
    public class TestProblem2
    {

        [Fact]
        public void TestProblem2WithExample1()
        {
            Problem2 problem2 = new Problem2();

            //Input: x = 121
            //Output: true
            var solution = problem2.IsPalindrome(121);
            Assert.True(solution);

            //Input: x = -121
            //Output: false
            var solution2 = problem2.IsPalindrome(-121);
            Assert.False(solution2);

            //Input: x = 10
            //Output: false
            var solution3 = problem2.IsPalindrome(10);
            Assert.False(solution3);

        }

        [Fact]
        public void TestProblem2WithExample2()
        {
            Problem2 problem2 = new Problem2();

            //Input: x = 121
            //Output: true
            var solution = problem2.LeetcodeSolution(121);
            Assert.True(solution);

            //Input: x = -121
            //Output: false
            var solution2 = problem2.LeetcodeSolution(-121);
            Assert.False(solution2);

            //Input: x = 10
            //Output: false
            var solution3 = problem2.LeetcodeSolution(10);
            Assert.False(solution3);

            //Input: x = 1001
            //Output: true
            var solution4 = problem2.LeetcodeSolution(10);
            Assert.True(solution4);
        }
    }
}
