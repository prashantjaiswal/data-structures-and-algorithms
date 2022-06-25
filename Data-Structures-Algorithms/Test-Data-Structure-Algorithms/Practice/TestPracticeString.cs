using System;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
	public class TestPracticeString
	{
        [Fact]
        public void TestReverseBetween()
        {
            //1 -> 2 -> 3 -> 4 -> 5
            //2, 4

            PracticeString practice = new PracticeString();
            var result = practice.BoringSubstring("gihhfjjejgh");

        }

        [Fact]
        public void TestminWindow()
        {
            //1 -> 2 -> 3 -> 4 -> 5
            //2, 4

            PracticeString practice = new PracticeString();
            var result = practice.minWindow("ADOBECODEBANC", "ABC");

        }
    }
}

