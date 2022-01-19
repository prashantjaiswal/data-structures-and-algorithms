using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Leetcode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// Given a signed 32-bit integer x, return x with its digits reversed.
    /// If reversing x causes the value to go outside the signed 32-bit integer range [-2^31, 2^31 - 1], then return 0.
    /// </summary>
    public class Problem3
    {
        public int Reverse(int x)
        {
            var numberCharArray = x.ToString().ToCharArray();
            if (x < 0)
            {
                numberCharArray = x.ToString().Substring(1).ToCharArray();
            }
            int length = numberCharArray.Length;
            for (int i = 0; i < length / 2; i++)
            {
                (numberCharArray[length - i - 1], numberCharArray[i]) = (numberCharArray[i], numberCharArray[length - i - 1]);
            }

            var reversed = new string(numberCharArray);
            int.TryParse(reversed, out var returnValue);
            if (x < 0 && returnValue != 0)
                return -returnValue;
            return returnValue;
        }

        public int ReverseOption(int x)
        {
            long res = 0;
            while (x != 0)
            {
                res = res * 10 + x % 10;
                x = x / 10;
            }

            if (res < Int32.MinValue || res > Int32.MaxValue)
            {
                return 0;
            }
            else
            {
                return (int) res;
            }
        }
    }
}
