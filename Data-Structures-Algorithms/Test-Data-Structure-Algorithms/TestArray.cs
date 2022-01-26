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

        [Fact]
        public void TestMergeArrayOperation()
        {
            ArrayOperation arrayOperation = new ArrayOperation();
            int[] firstArray = new int[] { 2, 4, 6, 9, 10, 40 };
            int[] secondArray = new int[] { 1, 3, 6, 7, 9, 34, 67, 76, 87 };
            var mergedArray = arrayOperation.MergeArray(firstArray, secondArray);
        }

        [Fact]
        public void TestMissingNumberOperation()
        {
            ArrayChallenge arrayChallenge = new ArrayChallenge();
            int[] arrayParam = new int[] { 2, 3, 5, 8, 9, 10 };
            var missingNumbers = arrayChallenge.MissingNumber(arrayParam);
        }


        [Fact]
        public void TestSumOfNumbersEqualToKOperation()
        {
            ArrayChallenge arrayChallenge = new ArrayChallenge();
            int[] arrayParam = new int[] { 2, 3, 5, 8, 9, 10, 4, 6 };
            var missingNumbers = arrayChallenge.SumOfNumbersEqualToK(9, arrayParam);
        }

        [Fact]
        public void TestFindMaxMinOperation()
        {
            ArrayChallenge arrayChallenge = new ArrayChallenge();
            int[] arrayParam = new int[] { 2, 3, 5, 8, 9, 10, 4, 6 };
            var minMaxArray = arrayChallenge.FindMaxMin(arrayParam);
            Assert.Equal(new int[] { 2, 10 }, minMaxArray);
        }
    }
}
