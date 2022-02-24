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
    }
}
