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

            param = 100000000;
            int result = practice.SquareRoot(param);
            Assert.Equal(10000, result);

            param = 16;
            result = practice.SquareRoot(param);
            Assert.Equal(4, result);

            //100000000
        }
    }
}
