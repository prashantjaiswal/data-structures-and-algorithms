using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice02
    {
        [Fact]
        public void TestSumOfTwoIndices()
        {
            Practice02 practice = new Practice02();
            int result = practice.solve(new List<int> { 1, 2, 3, 4 }, 7);
            Assert.Equal(1, result);

            result = practice.solve(new List<int> { 1, 2, 4 }, 4);
            Assert.Equal(0, result);

            result = practice.solve(new List<int> { 1, 2, 2 }, 4);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestMinMax()
        {
            Practice02 practice = new Practice02();
            int result = practice.MaxMinOfArray(new [] { 1, 2, 3, 4, 5 });
            Assert.Equal(1, result);

            result = practice.MaxMinOfArray(new[] { 10, 20, 30, 40});
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestRotate()
        {
            Practice02 practice = new Practice02();
            int result = practice.Rotate(new List<int> { 1, 2, 3, 4, 5 }, 2);
            Assert.Equal(0, result);

            result = practice.Rotate(new List<int> { 10, 20, 30, 40 }, 3);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestRotate01()
        {
            Practice02 practice = new Practice02();
            int result = practice.Rotate02(new List<int> { 1, 2, 3, 4, 5 }, 2);
            Assert.Equal(0, result);

            result = practice.Rotate02(new List<int> { 10, 20, 30, 40 }, 3);
            Assert.Equal(0, result);
        }
    }
}
