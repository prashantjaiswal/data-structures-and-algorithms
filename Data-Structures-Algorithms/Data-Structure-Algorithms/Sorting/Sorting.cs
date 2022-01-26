using System;
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
    }
}
