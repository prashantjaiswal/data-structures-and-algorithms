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

        public void CreateTable(int n)
        {
            var list = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add($"{n} * {i} = {n * i}");
            }
            var str = "";
        }

        /*
        Given an array A of size N, groot wants you to pick 2 indices i and j such that

        1 <= i, j <= N
        A[i] % A[j] is maximum among all possible pairs of (i, j).
        Help Groot in finding the maximum value of A[i] % A[j] for some i, j.

        [1, 2, 44, 3]
         */
        public int SolveMaxMod(List<int> A)
        {
            int max = int.MinValue;
            int mod = 0;
            int modRevert = 0;
            int maxMod = 0;

            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i; j < A.Count; j++)
                {
                    mod = A[i] % A[j];
                    modRevert = A[j] % A[i];
                    maxMod = Math.Max(mod, modRevert);
                    max = Math.Max(max, maxMod);
                }
            }

            return max;
        }

        public int SolveMaxMod01(List<int> A)
        {
            int i, first, second;
            if (A.Count < 2)
            {
                return 0;
            }

            first = second = int.MinValue;
            for (i = 0; i < A.Count; i++)
            {
                if (A[i] > first)
                {
                    second = first;
                    first = A[i];
                }
                else if (A[i] > second &&
                         A[i] != first)
                {
                    second = A[i];
                }
            }
            if (second == int.MinValue)
            {
                return 0;
            }
            else
            {
                return second;
            }
        }

        public int TimeComplexity(int N)
        {
            int count = 0;
            
            for (int i = 0; i < (1 << N); i++)
            {
                int j = i;
                while (j > 0)
                {
                    j -= 1;
                    count++;
                }
            }

            return count;
        }

        public int FindSecondHighest(List<int> A)
        {
            int highest = int.MinValue;
            int indexofHighest = -1;
            int secondHighest = int.MinValue;
            if (A.Count < 2) return -1;

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > highest)
                {
                    highest = A[i];
                    indexofHighest = i;
                }
            }
            for (int i = 0; i < A.Count; i++)
            {
                if(A[i] < highest && A[i] > secondHighest)
                {
                    secondHighest = A[i];
                }
                else if(A[i] == highest && i != indexofHighest)
                {
                    secondHighest = A[i];
                }
            }

            return secondHighest;
        }
    }
}
