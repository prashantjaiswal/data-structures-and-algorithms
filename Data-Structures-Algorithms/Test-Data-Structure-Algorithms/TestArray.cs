using DataStructuresAlgorithms.Arrays;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test_Data_Structure_Algorithms
{
    public class TestArray
    {
        [Fact]
        public void TestReverseArrayOperation()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            arrayOperation.ReverseArray(param);
        }

        [Fact]
        public void TestLeftShiftArrayOperation()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            arrayOperation.LeftShiftOperation(param);
        }


        [Fact]
        public void TestCheckifSortedOperation()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            var isSorted = arrayOperation.CheckifSorted(param);
            Assert.True(!isSorted);
        }

        [Fact]
        public void TestArrangeNegativeToLeftOperation()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] param = new int[] { -2, 6, -5, 7, 8, -9 };
            arrayOperation.ArrangeNegativeToLeft(param);
        }
    }
}
