using System;
using DataStructuresAlgorithms.AlgoPatterns.SlidingWindow;
using Xunit;

namespace Test_Data_Structure_Algorithms.AlgoPatterns
{
    public class TestChallenge
    {
        #region Sliding Challenge
        //FindPermutation
        [Fact]
        public void TestFindLengthLongestOnesSubstring()
        {
            Challenge01 problem = new Challenge01();
            bool hasSubstring = problem.FindPermutation("ppp", "pq");
            Assert.False(hasSubstring);

            hasSubstring = problem.FindPermutation("oidbcaf", "abc");
            Assert.True(hasSubstring);

            hasSubstring = problem.FindPermutation("odicf", "dc");
            Assert.False(hasSubstring);

            hasSubstring = problem.FindPermutation("bcdxabcdy", "bcdyabcdx");
            Assert.True(hasSubstring);

            hasSubstring = problem.FindPermutation("aaacb", "abc");
            Assert.True(hasSubstring);
        }

        //FindStringAnagrams
        [Fact]
        public void TestFindStringAnagrams()
        {
            Challenge02 problem = new Challenge02();

            var array = problem.FindStringAnagrams("ppqp", "pq");
            Assert.Equal(array, new int [] { 1, 2 });

            array = problem.FindStringAnagrams("abbcabc", "abc");
            Assert.Equal(array, new int[] { 2, 3, 4 });
        }

        //FindMinumumWindowSubstring
        [Fact]
        public void TestFindMinumumWindowSubstring()
        {
            Challenge03 problem = new Challenge03();

            var matched = problem.FindMinumumWindowSubstring("aabdec", "abc");
            Assert.Equal("abdec", matched);

            matched = problem.FindMinumumWindowSubstring("abdabca", "abc");
            Assert.Equal("abc", matched);

            matched = problem.FindMinumumWindowSubstring("adcad", "abc");
            Assert.Equal("", matched);
        }
        #endregion

        #region Two pointer
        
        #endregion
    }
}
