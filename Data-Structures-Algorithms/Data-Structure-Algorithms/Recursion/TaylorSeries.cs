using System;
namespace DataStructuresAlgorithms.Recursion
{
    /// <summary>
    /// 1+ x/1 + x^2/2! + x^3/3! + x^4/4! + ..... + x^n/n!
    /// </summary>
    public class TaylorSeries
    {
        public double TaylorSeriesImp1(int x, int n)
        {
            int power = 0, factorial = 0;
            double returnValue = 0;
            if (n == 0) return 1;
            returnValue = TaylorSeriesImp1(x, n - 1);
            power *= x;
            factorial *= factorial;
            return returnValue + power / factorial;
        }


        private double storage = 1;
        /// <summary>
        /// Taylor series using Horner's rule
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public double TaylorSeriesImp2(int x, int n)
        {
            if (n == 0) return storage;
            storage = 1 + (x / n) * storage;
            return TaylorSeriesImp2(x, n - 1);
        }
    }
}
