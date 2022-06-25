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
        public void TestCountOccurrence()
        {
            Practice07 practice = new Practice07();//
            var result = practice.CountOccurrence("bobob");
        }

        [Fact]
        public void TestlongestCommonPrefix()
        {
            Practice07 practice = new Practice07();//
            var result = practice.longestCommonPrefix(new List<string> { "abcd", "abcd", "efgh"});
        }

        [Fact]
        public void Testlszero()
        {
            Practice07 practice = new Practice07();//
            var result = practice.lszero(new List<int> { 1, 2, -2, 4, -4 });
        }

        [Fact]
        public void Testcolorful()
        {
            Practice07 practice = new Practice07();//
            var result = practice.colorful(3245);
        }

        [Fact]
        public void TestChangeCharacter()
        {
            Practice07 practice = new Practice07();//
            var result = practice.ChangeCharacter("hq",0);
        }

        [Fact]
        public void TestDiffPossible()
        {
            Practice07 practice = new Practice07();//
            var result = practice.DiffPossible(new List<int> { 11, 85, 100, 44, 3, 32, 96, 72, 93, 76, 67, 93, 63, 5, 10, 45, 99, 35, 13 }, 60);
        }

        [Fact]
        public void TestIsDictionary()
        {
            Practice07 practice = new Practice07();//
            var result = practice.IsDictionary(new List<string> { "fine", "none", "no" }, "qwertyuiopasdfghjklzxcvbnm");
        }

        [Fact]
        public void Testfun()
        {
            Practice07 practice = new Practice07();//
            var result = practice.foo(3, 5);
        }
        [Fact]
        public void TestlongestPalindrome()
        {
            Practice07 practice = new Practice07();//
            var result = practice.longestPalindrome("aaaabaaa");
        }

       /* [Fact]
        public void Testpow()
        {
            Practice07 practice = new Practice07();//
            var result = practice.pow(-1,1,20);
        }*/
    }
}
