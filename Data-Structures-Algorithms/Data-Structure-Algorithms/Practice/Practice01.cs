using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Practice
{
    public class Practice01
    {
        public int SquareRoot(int A)
        {
            for (int i = 0; i * i <= A; i++)
            {
                if (i * i == A) return i;
            }
            return -1;
        }

        public int IsItPrime(int N)
        {
            if (N == 1)
                Console.WriteLine("NO");
            var sqrtN = Math.Sqrt(N);
            for (int i = 2; i < sqrtN; i++)
            {
                if (N % i == 0)
                {
                    Console.WriteLine("NO");
                    return 1;
                };
            }
            Console.WriteLine("YES");
            return -1;
        }

        public int SumOfNaturalNumbers(int N)
        {
            return (N * (N + 1)) / 2;
        }

        public string IsPerfectNumber(int N)
        {
            int sum = 1;
            var halfOfN = N/2;
            for (int i = 2; i <= halfOfN; i++)
            {
                if (N % i == 0) sum += i;
            }

            if (sum == N) return "YES";
            return "NO";
        }

        public int[] FindAllArmstrongNumber(int range)
        {
            var list = new List<int>();
            list.Add(1);
            for (int i = 2; i <= range; i++)
            {
                int sum = 0;
                int x = i % 10;
                int y = i;
                while (y > 0)
                {
                    sum += x * x * x;
                    y = y / 10;
                    x = y % 10;
                }
                if (sum == i) list.Add(i);
            }
            return list.ToArray();
        }

        // Above performed better 
        public int[] FindAllArmstrongNumberOrderNForThreeDigit(int range)
        {
            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;
            int sum = 0;
            var list = new List<int>();

            for (int number = 1; number <= range; number++)
            {
                digit1 = number - ((number / 10) * 10);
                digit2 = (number / 10) - ((number / 100) * 10);
                digit3 = (number / 100) - ((number / 1000) * 10);
                sum = (digit1 * digit1 * digit1) + (digit2 * digit2 * digit2) + (digit3 * digit3 * digit3);
                if (sum == number) list.Add(number);
            }
            return list.ToArray();
        }
    }
}
