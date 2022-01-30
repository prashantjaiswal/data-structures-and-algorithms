using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Sorting
{
    public class Sorting
    {
        public void BubbleSort(int[] array)
        {
            // int [] {3,5,6,2,4,6}
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength-1; i++)
            {
                for (int j = 0; j < arrayLength- i -1; j++)
                {
                    if(array[j +1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void InsertionSort(int[] array)
        {
            // int [] {3,5,7,2,4,6}
            int arrayLength = array.Length;
            for (int i = 1; i < arrayLength; i++)
            {
                int j = i - 1;
                int x = array[i];
                while (j > -1 && array[j] > x)
                {
                    int temp = array[j + 1];
                    array[j+1] = array[j];
                    array[j] = temp;
                    j--;
                }
                array[j + 1] = x;
            }
        }

        public void SelectionSort(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                int j = i, k = i;
                while (j < length - 1)
                {
                    if (array[j] < array[k])
                        k = j;
                    j++;
                }
                int temp = array[i];
                array[i] = array[k];
                array[k] = temp;
            }
        }

        public void QuickSort(int [] array, int low, int high)
        {
            if(low < high)
            {
                int j = Partition(array, low, high);
                QuickSort(array, low, j);
                QuickSort(array, j+1, high);
            }
        }

        private int Partition(int [] array, int low, int high)
        {
            int pivot = array[low];
            int i = low, j = high, temp = 0;
            do
            {
                do { i++; } while (array[i] <= pivot);
                do { j--; } while (array[j] > pivot);
                if (i < j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            } while (i < j);
            temp = array[low];
            array[low] = array[j];
            array[j] = temp;
            return j;
        }

        public void IterativeMergeSort(int [] array)
        {
            int pair = 0, low = 0, mid = 0, high = 0, i =0, length = array.Length;
            for (pair = 2; pair <= length; pair= 2*pair)
            {
                for (i = 0; i + pair -1  < length; i = i+pair)
                {
                    low = i;
                    high = i + pair - 1;
                    mid = (low + high) / 2;
                    Merge(ref array, low, mid, high);
                }
            }
            if (pair / 2 < length)
                Merge(ref array, low, (pair / 2) - 1, high - 1);
        }

        private void Merge(ref int[] Array, int low, int mid, int high)
        {
            int i = low, j = mid + 1;
            var mergedCollection = new List<int>();

            while (i<= mid && j<=high)
            {
                if (Array[i] < Array[j])
                    mergedCollection.Add(Array[i++]);
                else
                    mergedCollection.Add(Array[j++]);
            }
            for (; i <= mid; i++)
                mergedCollection.Add(Array[i]);
            for (; j <= high; j++)
                mergedCollection.Add(Array[j]);
            Array = mergedCollection.ToArray();
        }
    }
}
