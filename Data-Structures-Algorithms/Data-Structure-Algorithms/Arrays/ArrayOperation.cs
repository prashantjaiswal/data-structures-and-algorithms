using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    public class ArrayOperation
    {
        public void ReverseArray(int[] arrayParam)
        {
            int length = arrayParam.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int swap = arrayParam[length - i - 1];
                arrayParam[length - i - 1] = arrayParam[i];
                arrayParam[i] = swap;
            }
        }

        public void LeftShiftOperation(int[] param)
        {
            int length = param.Length;
            for (int i = 0; i < length - 1; i++)
            {
                param[i] = param[i + 1];
            }
        }

        public bool CheckifSorted(int[] param)
        {
            int length = param.Length;
            int i = 0;
            while (i < length - 1)
            {
                if (param[i] > param[i + 1]) return false;
                i++;
            }
            return true;
        }

        public void ArrangeNegativeToLeft(int[] param)
        {
            int i = 0;
            int j = param.Length - 1;
            int swappingBag = 0;
            while (i < j)
            {
                while (param[i] < 0) i++;
                while (param[j] >= 0) j--;
                if (i < j)
                {
                    swappingBag = param[i];
                    param[i] = param[j];
                    param[j] = swappingBag;
                }
            }
        }

        public int[] MergeArray(int[] arrayFirst, int[] arraySecond)
        {
            int i = 0, j = 0;
            var mergedCollection = new List<int>();

            while (i < arrayFirst.Length && j < arraySecond.Length)
            {
                if (arrayFirst[i] < arraySecond[j])
                {
                    mergedCollection.Add(arrayFirst[i]);
                    i++;
                }
                else
                {
                    mergedCollection.Add(arraySecond[j]);
                    j++;
                }
            }
            while(i< arrayFirst.Length)
            {
                mergedCollection.Add(arrayFirst[i]);
                i++;
            }
            while (j < arraySecond.Length)
            {
                mergedCollection.Add(arraySecond[j]);
                j++;
            }
            return mergedCollection.ToArray();
        }
    }
}
