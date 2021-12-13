
using System;
namespace DataStructuresAlgorithms.Recursion
{
    public class Recursion
    {
        public Recursion()
        {
        }
        public int PowerOfNImplementation1(int variable, int number)
        {
            if (number == 0) return 1;
            return variable * PowerOfNImplementation1(variable, number - 1);
        }

        public int PowerOfNImplementation2(int variable, int number)
        {
            if (number == 0) return 1;

            if (number % 2 == 0)
            {
                return PowerOfNImplementation2(variable * variable, number / 2);
            }
            return variable * PowerOfNImplementation1(variable * variable, (number - 1) / 2);
        }

        public int factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        }

        public int SumOfNaturalNumber(int number)
        {
            if (number == 0) return 1;
            return number + SumOfNaturalNumber(number - 1);
        }
    }
}
