using System;
namespace DataStructuresAlgorithms.AlgoPatterns.TwoPointers
{
    public class Problem01
    {
        #region Pair with Target Sum (easy)
        /*
        Given an array of sorted numbers and a target sum, find a pair in the array
        whose sum is equal to the given target.

        Write a function to return the indices of the two numbers (i.e. the pair) such
        that they add up to the given target.

        Example 1:

        Input: [1, 2, 3, 4, 6], target=6
        Output: [1, 3]
        Explanation: The numbers at index 1 and 3 add up to 6: 2+4=6
        Example 2:

        Input: [2, 5, 9, 11], target=11
        Output: [0, 2]
        Explanation: The numbers at index 0 and 2 add up to 11: 2+9=11
         */
        #endregion

        public int[] Search(int[] arr, int targetSum)
        {
            int left = 0;
            int right = arr.Length -1;
         
            while(left < right)
            {
                int currentSum = arr[left] + arr[right];
                if (currentSum == targetSum) return new int[] { left, right };
                if (currentSum > targetSum) right--;
                if (currentSum < targetSum) left++;
            }
            return new int[] { -1, -1};
        }
    }
}
