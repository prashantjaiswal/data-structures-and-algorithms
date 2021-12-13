using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Recursion
{
    public class Fibonacci
    {
        public Fibonacci()
        {
        }
        /// <summary>
        /// Complexity O(2^n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibonacci_1(int n)
        {
            if (n <= 1) return n;
            return Fibonacci_1(n - 1) + Fibonacci_1(n - 2);
        }

        Dictionary<int,int> storage = new Dictionary<int,int>();
        /// <summary>
        /// Fibonacci using Memoization having complexity O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fibonacci_2(int n)
        {
            if (n <= 1)
            {
                storage[n] = n;
                return n;
            }
            if (!storage.ContainsKey(n - 1))
                storage[n - 1] = Fibonacci_2(n - 1);
            if (!storage.ContainsKey(n - 2))
                storage[n - 2] = Fibonacci_2(n - 2);
            return storage[n - 1] + storage[n - 2];
        }
    }
}
