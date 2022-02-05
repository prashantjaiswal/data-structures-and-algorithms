using System;
using DataStructuresAlgorithms.AlgoPatterns.SlidingWindow;
using Xunit;

namespace Test_Data_Structure_Algorithms.AlgoPatterns
{
    public class TestChallenge
    {
        //FindPermutation
        [Fact]
        public void TestFindLengthLongestOnesSubstring()
        {
            Challenge01 problem = new Challenge01();
            bool hasSubstring = problem.FindPermutation("oidbcaf", "abc");
            Assert.True(hasSubstring);

            hasSubstring = problem.FindPermutation("odicf", "dc");
            Assert.False(hasSubstring);

            hasSubstring = problem.FindPermutation("bcdxabcdy", "bcdyabcdx");
            Assert.True(hasSubstring);

            hasSubstring = problem.FindPermutation("aaacb", "abc");
            Assert.True(hasSubstring);
        }
    }
}
