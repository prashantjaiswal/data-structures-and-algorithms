using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice05
    {
        [Fact]
        public void TestFindSubarraySum()
        {
            Practice05 practice = new Practice05();
            var result = practice.FindSubarraySum(new List<int> { 1, 2, 3 });
            Assert.Equal(20, result);

            result = practice.FindSubarraySum(new List<int> { 2, 1, 3 });
            Assert.Equal(19, result);
        }

        [Fact]
        public void TestFindMaxSubArray()
        {
            Practice05 practice = new Practice05();
            var result = practice.FindMaxSubArray(new List<int> { 1, 2, 3, 4, -10 });
            Assert.Equal(10, result);

            result = practice.FindMaxSubArray(new List<int> { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.Equal(6, result);

            result = practice.FindMaxSubArray(new List<int> { -2, -1, -3, -4, -1, -2, -1, -5 });
            Assert.Equal(-1, result);
        }

        [Fact]
        public void TestFindMaxSubarray()
        {
            Practice05 practice = new Practice05();
            var result = practice.FindMaxSubarray(5, 7 , new List<int> { 3, 8, 8, 9, 7 });
            Assert.Equal(7, result);

            result = practice.FindMaxSubarray(5, 12 , new List<int> { 2, 1, 3, 4, 5 });
            Assert.Equal(12, result);

            result = practice.FindMaxSubarray(3, 1, new List<int> { 2, 2, 2});
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestFindLeastAvgOfSize()
        {
            Practice05 practice = new Practice05();//

            var result = practice.FindLeastAvgOfSize(new List<int> { 20, 3, 13, 5, 10, 14, 8, 5, 11, 9, 1, 11 }, 9);
            Assert.Equal(3, result);


            result = practice.FindLeastAvgOfSize(new List<int> { 3, 7, 90, 20, 10, 50, 40 }, 3);
            Assert.Equal(3, result);

            result = practice.FindLeastAvgOfSize( new List<int> { 3, 7, 5, 20, -10, 0, 12 }, 2);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestCountingSubarrays()
        {
            Practice05 practice = new Practice05();//
            //
            var result = practice.CountingSubarrays(new List<int> { 3, 12, 11, 11, 11, 15 }, 12);
            Assert.Equal(4, result);

            result = practice.CountingSubarrays(new List<int> { 2, 5, 6 }, 10);
            Assert.Equal(4, result);

            result = practice.CountingSubarrays(new List<int> { 1, 11, 2, 3, 15 }, 10);
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestFindSubarraysEvenOdd()
        {
            Practice05 practice = new Practice05();//
            //
            var result = practice.FindSubarraysEvenOdd(new List<int> { 1, 2, 3, 4, 5 }, 4);
            Assert.Equal(6, result);

            result = practice.FindSubarraysEvenOdd(new List<int> { 13, 16, 16, 15, 9, 16, 2, 7, 6, 17, 3, 9 }, 65);
            Assert.Equal(36, result);
        }
    }
}
