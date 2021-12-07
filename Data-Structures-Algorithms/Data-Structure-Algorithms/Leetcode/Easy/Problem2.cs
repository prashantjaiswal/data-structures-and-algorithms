using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Leetcode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class Problem2
    {

        public bool IsPalindrome(int x)
        {
            var xstring = x.ToString();
            int charLength = xstring.Length;

            if (charLength == 1) return true;
            // check if first character is not integer then not a palindrome
            int isNotInt = -1;
            if (int.TryParse(xstring[0].ToString(), out isNotInt))
            {
                // sum of first half should be equal to second half
                for (int i = 0; i < charLength / 2;)
                {
                    if (!(xstring[i] == xstring[charLength - i - 1])) return false;
                    ++i;
                    if (i == charLength / 2) return true;
                }
                return false;
            }
            return false;
        }

        public bool LeetcodeSolution(int x)
        {
            // Special cases:
            // As discussed above, when x < 0, x is not a palindrome.
            // Also if the last digit of the number is 0, in order to be a palindrome,
            // the first digit of the number also needs to be 0.
            // Only 0 satisfy this property.
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
