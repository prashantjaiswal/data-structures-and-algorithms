using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice06
    {
        /*
        [Fact]
        public void TestFindSubarraysEvenOdd()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.SumOfTwoMatrices(new List<List<int>> {new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> {7,8,9 } },
                new List<List<int>> { new List<int> { 9,8,7 }, new List<int> {6,5,4 }, new List<int> { 3,2,1 } });
        }

        [Fact]
        public void TestMultiplyTwoMatrices()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.MultiplyTwoMatrices(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3,4} },
                new List<List<int>> { new List<int> { 5, 6 }, new List<int> { 7 ,8 } });

            result = practice.MultiplyTwoMatrices(new List<List<int>> { new List<int> { 1, 1 } },
                new List<List<int>> { new List<int> { 2 }, new List<int> { 3 } });
        }

        [Fact]
        public void TestSumRowWiseMatrix()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.SumRowWiseMatrix(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 8 }, new List<int>{ 9, 2, 3, 4 } });
        }

        [Fact]
        public void TestAntiDiagonalArray()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.AntiDiagonalArray(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6}, new List<int> { 7, 8, 9} });
        }

        [Fact]
        public void TestSubstract()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.Substract(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } },
                new List<List<int>> { new List<int> { 9, 8, 7 }, new List<int> { 6, 5, 4 }, new List<int> { 3, 2, 1 } });

            result = practice.Substract(new List<List<int>> { new List<int> { -5, 7}, new List<int> { 3,1}, new List<int> { 4, -10} },
                new List<List<int>> { new List<int> { 3,4 }, new List<int> { 2,3}, new List<int> { 10,1} });
        }
        [Fact]
        public void TestTranspose()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.Transpose(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } });
        }
        */
        [Fact]
        public void TestMarkZeroMatrix()
        {
            Practice06 practice = new Practice06();//
            //
            //var result = practice.MarkZero(new List<List<int>> { new List<int> { 1, 2, 3, 4 }, new List<int> { 5, 6, 7, 0 }, new List<int> { 9, 2, 0, 4 } });

            var result = practice.MarkZero(new List<List<int>> {
                new List<int> { 97, 18, 55, 1, 50, 17, 16, 0, 22, 14},
                new List<int> { 58, 14, 75, 54, 11, 23, 54, 95, 33, 23 },
                new List<int> { 61, 22, 23, 68, 23, 73, 85, 91, 25, 7 },
                new List<int> { 6, 83, 22, 81, 89, 85, 56, 43, 32, 89 },
                new List<int> { 0, 6, 1, 69, 86, 7, 64, 5, 90, 37 },
                new List<int> { 10, 3, 11, 33, 71, 86, 6, 56, 78, 31 },
                new List<int> { 16, 36, 66, 90, 17, 55, 27, 26, 99, 59 },
                new List<int> { 67, 18, 65, 68, 87, 3, 28, 52, 9, 70 },
                new List<int> { 41, 19, 73, 5, 52, 96, 91, 10, 52, 21 }
            });
        }
        [Fact]
        public void TestGenerateMatrix()
        {
            Practice06 practice = new Practice06();//
            //
            var result = practice.GenerateMatrix(2);

        }
    }
}
