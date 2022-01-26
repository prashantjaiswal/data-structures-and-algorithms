using System;
using DataStructuresAlgorithms.Leetcode.Medium;
using Xunit;

namespace Test_Data_Structure_Algorithms.LeetCode.Medium
{
    public class TestProblem4
    {
        [Fact]
        public void TestProblem4WithExample1()
        {
            var solution = new Problem4().lengthOfLongestSubstringSolution1("abcabcbb");
            Assert.True(solution == 3);
        }

        [Fact]
        public void TestProblem4WithExample2()
        {
            var solution = new Problem4().lengthOfLongestSubstringSolution2("abcabcbb");
            Assert.True(solution == 3);
        }

        [Fact]
        public void TestProblem4WithExample3()
        {
            var solution = new Problem4().lengthOfLongestSubstringSolution3("abcabcbb");
            Assert.True(solution == 3);
        }
    }
}
