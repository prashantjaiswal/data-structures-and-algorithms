using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    public class ArrayChallenge
    {
        public int[] MissingNumber(int[] arrayParam)
        {
            //TODO: Missing numbers can also be find using Hashing with less time complexity but a bit higher space complexity

            int diff = arrayParam[0];
            var missingNUmber = new List<int>();
            for (int i = 0; i < arrayParam.Length; i++)
            {
                if (arrayParam[i] - i != diff)
                {
                    while (diff < arrayParam[i] - i)
                    {
                        missingNUmber.Add(i + diff);
                        diff++;
                    }
                }
            }
            return missingNUmber.ToArray();
        }


        public Dictionary<int, int> SumOfNumbersEqualToK(int k, int[] arrayOfNumbers)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (dictionary.ContainsKey(k - arrayOfNumbers[i]))
                {
                    dictionary[k - arrayOfNumbers[i]] = arrayOfNumbers[i];
                }
                else
                {
                    dictionary.Add(arrayOfNumbers[i], -1);
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value == -1) dictionary.Remove(item.Key);
            }
            return dictionary;
        }

        public int[] FindMaxMin(int[] arrayOfNumber)
        {
            int min = arrayOfNumber[0];
            int max = arrayOfNumber[0];

            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                if (arrayOfNumber[i] > max) max = arrayOfNumber[i];
                else if (arrayOfNumber[i] < min) min = arrayOfNumber[i];
            }
            return new int[] { min, max };
        }
    }
}
