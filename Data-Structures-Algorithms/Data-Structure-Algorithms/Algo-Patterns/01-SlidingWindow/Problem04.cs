using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.AlgoPatterns.SlidingWindow
{
    public class Problem04
    {
        /*  Problem Statement 
            Given an array of characters where each character represents a fruit tree, you are given two 
            baskets and your goal is to put maximum number of fruits in each basket.The only restriction 
            is that each basket can have only one type of fruit.

            You can start with any tree, but once you have started you can’t skip a tree. You will pick 
            one fruit from each tree until you cannot, i.e., you will stop when you have to pick from a third fruit type.

            Write a function to return the maximum number of fruits in both the baskets.

            Example 1:

            Input: Fruit=['A', 'B', 'C', 'A', 'C']
            Output: 3
            Explanation: We can put 2 'C' in one basket and one 'A' in the other from the subarray['C', 'A', 'C']
            Example 2:

            Input: Fruit=['A', 'B', 'C', 'B', 'B', 'C']
            Output: 5
            Explanation: We can put 3 'B' in one basket and two 'C' in the other basket.
            This can be done if we start with the second letter: ['B', 'C', 'B', 'B', 'C']*/

        public int FindLength(char[] fruits)
        {
            int maxFruits = int.MinValue;
            int windowStart = 0;
            var map = new Dictionary<char, int>();

            for (var windowEnd = 0; windowEnd < fruits.Length; windowEnd++)
            {
                var fruit = fruits[windowEnd];
                if (map.ContainsKey(fruit))
                    map[fruit] += 1;
                else
                    map.Add(fruit, 1);

                while (map.Keys.Count > 2)
                {
                    map[fruits[windowStart]] -= 1;
                    if (map[fruits[windowStart]] == 0) map.Remove(fruits[windowStart]);
                    windowStart++;
                }

                maxFruits = Math.Max(maxFruits, windowEnd - windowStart + 1);
            }

            return maxFruits;
        }
    }
}
