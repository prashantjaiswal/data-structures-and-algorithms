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
    }
}
