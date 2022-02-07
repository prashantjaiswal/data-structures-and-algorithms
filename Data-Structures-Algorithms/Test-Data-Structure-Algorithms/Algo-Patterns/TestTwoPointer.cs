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
       
        [Fact]
        public void TestRemoveDuplicateLength()
        {
            Problem02 problem = new Problem02();

            var param = new int[] { 2, 3, 3, 3, 6, 9, 9 };
            var indices = problem.Remove(param);
            Assert.Equal(4, indices);

            param = new int[] { 2, 2, 2, 11 };
            indices = problem.Remove(param);
            Assert.Equal(2, indices);
        }

        [Fact]
        public void TestMakeSortedArray()
        {
            Problem03 problem = new Problem03();

            var param = new int[] { -2, -1, 0, 2, 3 };
            var indices = problem.MakeSortedArray(param);
            Assert.Equal(new[] { 0, 1, 4, 4, 9 }, indices);

            param = new int[] { -3, -1, 0, 1, 2 };
            indices = problem.MakeSortedArray(param);
            Assert.Equal(new[] { 0, 1, 1, 4, 9 }, indices);
        }
    }
}
