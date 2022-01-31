using System;
using DataStructuresAlgorithms.AlgoPatterns.SlidingWindow;
using Xunit;

namespace Test_Data_Structure_Algorithms.AlgoPatterns
{
    public class TestSlidingWindow
    {
        [Fact]
        public void TestMaxSubArraySum()
        {
            Problem01 problem01 = new Problem01();
            int[] param = new int[] { 2, 1, 5, 1, 3, 2 };
            int max = problem01.MaxSubArraySum(param, 3);
            Assert.Equal(9, max);

            param = new int[] { 2, 3, 4, 1, 5 };
            max = problem01.MaxSubArraySum(param, 2);
            Assert.Equal(7, max);
        }

        [Fact]
        public void TestFindMinSubArray()
        {
            Problem02 problem01 = new Problem02();
            int[] param = new int[] { 2, 1, 5, 2, 3, 2 };
            int max = problem01.FindMinSubArray(7, param);
            Assert.Equal(2, max);

            param = new int[] { 2, 1, 5, 2, 8 };
            max = problem01.FindMinSubArray(2, param);
            Assert.Equal(1, max);
        }

        [Fact]
        public void TestFindLength()
        {
            Problem03 problem = new Problem03();
            int max = problem.FindLength("araaci", 2);
            Assert.Equal(4, max);

            max = problem.FindLength("cbbebi", 3);
            Assert.Equal(5, max);

            max = problem.FindLength("araaci", 1);
            Assert.Equal(2, max);

            max = problem.FindLength("cbbebi", 10);
            Assert.Equal(6, max);
        }

        [Fact]
        public void TestFindFruitLength()
        {
            Problem04 problem = new Problem04();
            int max = problem.FindLength(new[] { 'A', 'B', 'C', 'A', 'C' });
            Assert.Equal(3, max);

            max = problem.FindLength(new []{'A', 'B', 'C', 'B', 'B', 'C'});
            Assert.Equal(5, max);
        }

        [Fact]
        public void TestFindLengthNoRepeatSubstring()
        {
            Problem05 problem = new Problem05();
            int length = problem.FindLenghtNoRepeatSubString("aabccbb");
            Assert.Equal(3, length);

            length = problem.FindLenghtNoRepeatSubString("abbbb");
            Assert.Equal(2, length);

            length = problem.FindLenghtNoRepeatSubString("abccde");
            Assert.Equal(3, length);
        }
    }
}
