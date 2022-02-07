using System;
namespace DataStructuresAlgorithms.AlgoPatterns.TwoPointers
{
    public class Problem02
    {
        #region Remove Duplicates (easy)
        /*
        Given an array of sorted numbers, remove all duplicates from it. You should not use
        any extra space; after removing the duplicates in-place return the new length of the array.

        Example 1:

        Input: [2, 3, 3, 3, 6, 9, 9]
        Output: 4
        Explanation: The first four elements after removing the duplicates will be [2, 3, 6, 9].
        Example 2:

        Input: [2, 2, 2, 11]
        Output: 2
        Explanation: The first two elements after removing the duplicates will be [2, 11].
         */
        #endregion

        public int RemoveOptimized(int[] arr)
        {
            int nextNonDuplicate = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[nextNonDuplicate -1] != arr[i])
                {
                    arr[nextNonDuplicate] = arr[i];
                    nextNonDuplicate++;
                }
            }
            return nextNonDuplicate;
        }

        public int Remove(int[] arr)
        {
            int left = arr[0];
            int right = 0;
            int counter = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                right = arr[i];
                if (left != right)
                {
                    left = right;
                    counter++;
                }
            }
            return counter;
        }
    }
}
