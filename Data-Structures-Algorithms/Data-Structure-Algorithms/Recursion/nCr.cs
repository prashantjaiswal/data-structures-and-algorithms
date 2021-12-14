using System;
using System.Collections.Generic;

namespace DataStructuresAlgorithms.Recursion
{
    public class nCr
    {
        /// <summary>
        /// Without Pascals triangle
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int NCrWithoutPascalsTriangle(int n, int r)
        {
            int nominator = Factorial(n);
            int denominator_1 = Factorial(r), denominator_2 = Factorial(n - r);
            return nominator / (denominator_1 * denominator_2);
        }

        private int Factorial(int n)
        {
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// nCr = n-1Cr-1 + n-1Cr
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public int NCrWithPascalsTriangle(int n, int r)
        {
            if (r == 0 || n == r) return 1;
            return NCrWithPascalsTriangle(n - 1, r - 1) + NCrWithPascalsTriangle(n - 1, r);
        }

        /// <summary>
        /// nCr = n-1Cr-1 + n-1Cr
        /// </summary>
        /// <param name="n"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        Dictionary<string, int> storage = new Dictionary<string, int>();
        public int NCrWithPascalsTriangleMemoization(int n, int r)
        {
            if (r == 0 || n == r) return 1;
            string key1 = $"NCrWithPascalsTriangle({n - 1},{r - 1})";
            string key2 = $"NCrWithPascalsTriangle({n - 1},{r})";

            if (!storage.ContainsKey(key1))
                storage[key1] = NCrWithPascalsTriangle(n - 1, r - 1);
            if (!storage.ContainsKey(key2))
                storage[key1] = NCrWithPascalsTriangle(n - 1, r);

            return storage[key1] + storage[key2];
        }
    }
}
