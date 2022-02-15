using System;
namespace DataStructuresAlgorithms.Practice
{
    public class Practice01
    {
        public int SquareRoot(int A)
        {
            for(int i = 0; i*i <= A; i++)
            {
                if (i * i == A) return i;
            }
            return -1;
        }

        public int SquareRoot02(int A)
        {
            for (int i = 0; i * i <= A; i++)
            {
                if (i * i == A) return i;
            }
            return -1;
        }
    }
}
