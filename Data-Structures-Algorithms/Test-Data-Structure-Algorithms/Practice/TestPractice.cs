using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice
    {
        [Fact]
        public void TestReverseArrayOperation()
        {
            Practice01 practice = new Practice01();
          
            int param = int.MaxValue;
            //int result = practice.SquareRoot(param);
            //Assert.Equal(-1, result);

            param = 829702;
            int result = practice.SquareRoot(param);
            Assert.Equal(10000, result);

            param = 16;
            result = practice.SquareRoot(param);
            Assert.Equal(4, result);

            //100000000
        }

        [Fact]
        public void TestIsItPrime()
        {
            Practice01 practice = new Practice01();

            int param = 829702;
            int result = practice.SquareRoot(param);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestIsPerfectNumber()
        {
            Practice01 practice = new Practice01();

            var result = practice.IsPerfectNumber(4);
            Assert.Equal("NO", result);

            result = practice.IsPerfectNumber(8129);
            Assert.Equal("NO", result);

            result = practice.IsPerfectNumber(6);
            Assert.Equal("YES", result);

            result = practice.IsPerfectNumber(496);
            Assert.Equal("YES", result);

            result = practice.IsPerfectNumber(8128);
            Assert.Equal("YES", result); 
        }

        [Fact]
        public void TestFindAllArmstrongNumber()
        {
            Practice01 practice = new Practice01();

            int param = 200;
            var result = practice.FindAllArmstrongNumber(param);
            result = practice.FindAllArmstrongNumberOrderNForThreeDigit(param);
        }

        [Fact]
        public void TestTable()
        {
            Practice01 practice = new Practice01();

            int param = 200;
            practice.CreateTable(param);
        }

        [Fact]
        public void TestSolveMaxMod()
        {
            Practice01 practice = new Practice01();
            var t = practice.SolveMaxMod(new List<int> { 1, 2, 44, 3 });
            Assert.Equal(3, t);

            t = practice.SolveMaxMod(new List<int> { 2, 6, 4 });
            Assert.Equal(4, t);

             t = practice.SolveMaxMod01(new List<int> { 1, 2, 44, 3 });
            Assert.Equal(3, t);

            t = practice.SolveMaxMod01(new List<int> { 2, 6, 4 });
            Assert.Equal(4, t);
        }

        [Fact]
        public void TestComplexity()
        {
            Practice01 practice = new Practice01();
            var t = practice.TimeComplexity(10);
            Assert.Equal(t, t);
        }
    }
}
