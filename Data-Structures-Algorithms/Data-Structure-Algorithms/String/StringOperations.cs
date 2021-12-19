using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAlgorithms.String
{
    public class StringOperations
    {
        public int CountWords(string statement)
        {
            int count = 0;
            char lastChar = '1';
            foreach (var charElement in statement.Where(t => t == ' ' && lastChar != ' '))
            {
                lastChar = charElement;
                count++;
            }
            return count;
        }

        public Dictionary<char, int> CheckDuplicateCharsUsingBitwise(string word)
        {
            int charCountBit = 0;
            var dictionary = new Dictionary<char, int>();
            foreach (var charElement in word)
            {
                var charBit = 1;
                charBit = charBit << charElement - 97;
                if ((charBit & charCountBit) > 0)
                {
                    if (dictionary.ContainsKey(charElement)) dictionary[charElement] += 1;
                    else dictionary.Add(charElement, 1);
                }
                else
                {
                    charCountBit = charBit | charCountBit;
                }
            }

            return dictionary;
        }
    }
}
