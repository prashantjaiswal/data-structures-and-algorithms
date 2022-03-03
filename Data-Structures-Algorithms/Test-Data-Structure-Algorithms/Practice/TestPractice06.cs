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
    }
}
