using System;
using DataStructuresAlgorithms.AlgoPatterns.TwoPointers;
using Xunit;

namespace Test_Data_Structure_Algorithms.AlgoPatterns
{
    public class TestTwoPointer
    {
        [Fact]
        public void TestMaxSubArraySum()
        {
            Problem01 problem01 = new Problem01();

            int[] param = new int[] { 1, 2, 3, 4, 6 };
            var indices = problem01.Search(param, 6);
            Assert.Equal(new[] {1,3 }, indices);

            param = new int[] { 2, 5, 9, 11 };
            indices = problem01.Search(param, 11);
            Assert.Equal(new[] { 0, 2 }, indices);
        }
    }
}
