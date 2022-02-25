using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice03
    {
        [Fact]
        public void TestEquilibrium()
        {
            Practice03 practice = new Practice03();
            int result = practice.EquilibriumIndex(new List<int> { -7, 1, 5, 2, -4, 3, 0 });
            Assert.Equal(3, result);

            result = practice.EquilibriumIndex(new List<int> { 1, 2, 3 });
            Assert.Equal(-1, result);

            result = practice.EquilibriumIndex(new List<int> { 0, 0, 0 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestSumOfOddEvenByRemovingOneElement()
        {
            Practice03 practice = new Practice03();
            int result = practice.SumOfOddEvenByRemovingOneElement(new List<int> { 2, 1, 6, 4 });
            Assert.Equal(1, result);

            result = practice.SumOfOddEvenByRemovingOneElement(new List<int> { 1, 1, 1 });
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestRangeSum()
        {
            Practice03 practice = new Practice03();
            
            var result = practice.RangeSum(new List<int> { 1, 2, 3, 4, 5 }, new List<List<int>> { new List<int> { 1, 4 }, new List<int> { 2, 3 } });
            //[10, 5]
            result = practice.RangeSum(new List<int> { 2,2,2 }, new List<List<int>> { new List<int> { 1, 1 }, new List<int> { 2, 3 } });
            //[2,4]
        }
        [Fact]
        public void TestMaximumPossibleSum()
        {
            Practice03 practice = new Practice03();
            int result = practice.MaximumPossibleSum(new List<int> { 5, -2, 3, 1, 2 }, 3);
            Assert.Equal(8, result);
        
            result = practice.MaximumPossibleSum(new List<int> { 1, 2 }, 1);
            Assert.Equal(2, result);
        }

        [Fact]
        public void TestSecondLargest()
        {
            Practice03 practice = new Practice03();
            int result = practice.SecondLargest(new List<int> { 2, 1, 2});
            Assert.Equal(2, result);

            result = practice.SecondLargest(new List<int> { 2 });
            Assert.Equal(-1, result);

            result = practice.SecondLargest(new List<int> { 5, -2, 3, 1, 2 });
            Assert.Equal(3, result);
        }
    }
}
