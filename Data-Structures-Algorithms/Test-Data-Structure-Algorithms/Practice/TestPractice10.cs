using System;
using DataStructuresAlgorithms.Practice;
using Xunit;

namespace Test_Data_Structure_Algorithms.Practice
{
    public class TestPractice10
    {
        [Fact]
        public void TestGenerateMatrix()
        {
            Practice10 practice = new Practice10();//
            
            var result = practice.TitleToNumber("AAA");
            Assert.Equal(703, result);
        }   

        [Fact]
        public void TestFindDivisibilityby8()
        {
            Practice10 practice = new Practice10();//

            var result = practice.FindDivisibilityby8("40897237111816995922805307737859413552091006514927603847883130124746756767426237849396480087733429432861339411285568084588535007444731");
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestFindMod()
        {
            Practice10 practice = new Practice10();//

            var result = practice.FindMod("6562800446546751053033681283622332585949169375825307419010747907087102529693988502714663897293527240363734284937813181135000995192664742291904645171438423695200374401117403", 36173);
            Assert.Equal(3312, result);
        }

        [Fact]
        public void TestBalancedParantheses()
        {
            Practice10 practice = new Practice10();//

            var result = practice.BalancedParantheses("(()())");
            Assert.Equal(1, result);
        }
    }
}
