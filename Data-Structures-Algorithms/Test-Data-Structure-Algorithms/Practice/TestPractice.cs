using System;
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
    }
}
