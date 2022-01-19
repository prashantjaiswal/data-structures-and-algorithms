using System;
using DataStructuresAlgorithms.Leetcode.Medium;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Medium
{
    public class TestProlem3_2
    {
        [Fact]
        public void TestProblem3WithExample1()
        {
            var solution = new Problem3().lengthOfLongestSubstringSolution1("abcabcbb");
            Assert.True(solution == 3);
        }

        [Fact]
        public void TestProblem3WithExample2()
        {
            var solution = new Problem3().lengthOfLongestSubstringSolution2("abcabcbb");
            Assert.True(solution == 3);
        }

        [Fact]
        public void TestProblem3WithExample3()
        {
            var solution = new Problem3().lengthOfLongestSubstringSolution3("abcabcbb");
            Assert.True(solution == 3);
        }
    }
}
