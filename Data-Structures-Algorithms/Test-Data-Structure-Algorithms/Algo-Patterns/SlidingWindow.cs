﻿using System;
using DataStructuresAlgorithms.AlgoPatterns.SlidingWindow;
using Xunit;

namespace Test_Data_Structure_Algorithms.AlgoPatterns
{
    public class SlidingWindow
    {
        [Fact]
        public void TestMaxSubArraySum()
        {
            Problem01 problem01 = new Problem01();
            int[] param = new int[] { 2, 1, 5, 1, 3, 2 };
            int max = problem01.MaxSubArraySum(param,3);
            Assert.Equal(9, max);

            param = new int[] { 2, 3, 4, 1, 5 };
            max = problem01.MaxSubArraySum(param, 2);
            Assert.Equal(7, max);
        }

        [Fact]
        public void TestFindMinSubArray()
        {
            Problem02 problem01 = new Problem02();
            int[] param = new int[] { 2, 1, 5, 2, 3, 2 };
            int max = problem01.FindMinSubArray(7, param);
            Assert.Equal(2, max);

            param = new int[] { 2, 1, 5, 2, 8 };
            max = problem01.FindMinSubArray( 2, param);
            Assert.Equal(1, max);
        }

    }
}
