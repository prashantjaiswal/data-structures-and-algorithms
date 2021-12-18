using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    public class ArrayChallenge
    {
        public int[] MissingNumber(int[] arrayParam)
        {
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
    }
}
