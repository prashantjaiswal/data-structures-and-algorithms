using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice10
    {
        public int TitleToNumber(string A)
        {
            int number = 0;
            var pow = (int)Math.Pow(26, A.Length -1);
            int asciiBase = 0;
            foreach (char c in A)
            {
                asciiBase = char.IsUpper(c) ? 64 : 89;
                number += ((((int)c) - asciiBase) % 27) * pow ;
                pow /= 26;
            }
            
            return number;
        }

        public int GreatestMForEqualModulous(int A, int B)
        {
            if (A > B) return A - B;
            return B - A;
        }

        public int FindDivisibilityby8(string A)
        {
            int number = 0;
            if (A.Length < 3) number = int.Parse(A);
            else number = int.Parse(A.Substring(A.Length - 3, 3));
            return (number % 8) > 0 ? 0 : 1;
        }

        public int FindMod(string A, int B)
        {
            long num = 0, rem =0;
            
            foreach(var c in A)
            {
                num = rem * 10 + (c - '0');
                rem = num % B;
            }
            return (int)rem;
        }
        public int FindMinimum(int A, int B, int C)
        {
            int min = int.MaxValue;
            int minMod = Math.Min(C%10, Math.Min(A % 10, B % 10));

            return min;
        }
    }
}
