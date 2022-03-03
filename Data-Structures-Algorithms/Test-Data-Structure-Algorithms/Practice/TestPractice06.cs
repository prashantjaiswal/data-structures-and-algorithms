using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice06
    {
        [Fact]
        public void TestFindSubarraysEvenOdd()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.SumOfTwoMatrices(new List<List<int>> {new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> {7,8,9 } },
                new List<List<int>> { new List<int> { 9,8,7 }, new List<int> {6,5,4 }, new List<int> { 3,2,1 } });
            //Assert.Equal(6, result);
        }

        [Fact]
        public void TestMultiplyTwoMatrices()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.MultiplyTwoMatrices(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3,4} },
                new List<List<int>> { new List<int> { 5, 6 }, new List<int> { 7 ,8 } });

            result = practice.MultiplyTwoMatrices(new List<List<int>> { new List<int> { 1, 1 } },
                new List<List<int>> { new List<int> { 2 }, new List<int> { 3 } });
            //Assert.Equal(6, result);
        }

        [Fact]
        public void TestSumRowWiseMatrix()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.SumRowWiseMatrix(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int>{ 9, 2, 3, 4 } });
        }
    }
}
