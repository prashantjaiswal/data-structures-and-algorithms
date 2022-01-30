﻿using System;
using DataStructuresAlgorithms.Sorting;
using Xunit;

namespace Test_Data_Structure_Algorithms
{
    public class TestSorting
    {
        [Fact]
        public void TestBubbleSorting()
        {
            Sorting sorting = new Sorting();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            sorting.BubbleSort(param);
        }

        [Fact]
        public void TestInsertionSorting()
        {
            Sorting sorting = new Sorting();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            sorting.InsertionSort(param);
        }

        [Fact]
        public void TestSelectionSorting()
        {
            Sorting sorting = new Sorting();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            sorting.SelectionSort(param);
        }

        [Fact]
        public void TestQuickSorting()
        {
            Sorting sorting = new Sorting();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            sorting.QuickSort(param, 0, param.Length -1);
        }

        [Fact]
        public void TestIMergeSorting()
        {
            Sorting sorting = new Sorting();
            int[] param = new int[] { 2, 6, 5, 7, 8, 9 };
            sorting.IterativeMergeSort(param);
        }
    }
}
