using System;
using System.Collections.Generic;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice07
    {
        [Fact]
        public void TestGenerateMatrix()
        {
            Practice07 practice = new Practice07();//
            var result = practice.NobleNumbers(new List<int> { -4, -2, 0, -1, -6 });
        }

        [Fact]
        public void TestRemovalCost()
        {
            Practice07 practice = new Practice07();//
            var result = practice.RemovalCost(new List<int> { 8, 0, 10 });
        }

        [Fact]
        public void TestReverseString()
        {
            Practice07 practice = new Practice07();//
            var result = practice.ReverseString("scaler");
        }

        [Fact]
        public void TestReverseSentence()
        {
            Practice07 practice = new Practice07();//
            var result = practice.ReverseSentence("the sky is blue");
        }

        [Fact]
        public void TestlongestPalindrome()
        {
            Practice07 practice = new Practice07();//
            var result = practice.longestPalindrome("abb");
        }

        [Fact]
        public void TestCountOccurrence()
        {
            Practice07 practice = new Practice07();//
            var result = practice.CountOccurrence("bobob");
        }
    }
}
