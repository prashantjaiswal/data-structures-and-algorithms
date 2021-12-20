using DataStructuresAlgorithms.String;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms
{
    public class TestString
    {
        [Fact]
        public void TestReverseArrayOperation()
        {
            StringOperations operation = new StringOperations();
            int result = operation.CountWords("Prashi is my  life");
            Assert.Equal(4, result);
        }

        [Fact]
        public void TestCheckDuplicateCharsUsingBitwiseOperation()
        {
            StringOperations operation = new StringOperations();
            var result = operation.CheckDuplicateCharsUsingBitwise("prashantjaiswal");
        }
    }
}
