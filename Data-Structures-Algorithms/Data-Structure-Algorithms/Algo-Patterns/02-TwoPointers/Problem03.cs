using System;
namespace DataStructuresAlgorithms.AlgoPatterns.TwoPointers
{
    public class Problem03
    {
        #region Squaring a Sorted Array
        /*
        Given a sorted array, create a new array containing squares of all the number
        of the input array in the sorted order.

        Example 1:

        Input: [-2, -1, 0, 2, 3]
        Output: [0, 1, 4, 4, 9]
        Example 2:

        Input: [-3, -1, 0, 1, 2]
        Output: [0 1 1 4 9]
         */
        #endregion
        public int[] MakeSortedArray(int[] arr)
        {
            int[] sortedArray = new int[arr.Length];
            int length = arr.Length;
            int left = 0;
            int right = length - 1;
            int highestIndex = length-1;
            while (left < right)
            {
                int leftSquare = arr[left] * arr[left];
                int rightSquare = arr[right] * arr[right];
                if(leftSquare > rightSquare)
                {
                    sortedArray[highestIndex--] = leftSquare;
                    left++;
                }
                else
                {
                    sortedArray[highestIndex--] = rightSquare;
                    right--;
                }
            }
            return sortedArray;
        }
    }
}
