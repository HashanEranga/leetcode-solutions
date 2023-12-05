using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._2114.Tests
{
    public class TestSection
    {
        private leetcode.String._2114._Maximum_Number_of_Words_Found_in_Sentences.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.String._2114._Maximum_Number_of_Words_Found_in_Sentences.Solution();
        }

        [Test]
        public void MostWordsFound_DefaultScenario_ReturnMaxWordCount()
        {
            var strArr = new string[] { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            var ans = solution.MostWordsFound(strArr);

            Assert.That(ans, Is.TypeOf<int>()); 
            Assert.That(ans, Is.EqualTo(6));
        }

        [Test]
        public void MostWordsFound_DefaultScenario2_ReturnMaxWordCount()
        {
            var strArr = new string[] { "please wait", "continue to fight", "continue to win" };
            var ans = solution.MostWordsFound(strArr);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(3));
        }

        [Test]
        public void MostWordsFound_EmptyList_ReturnZero()
        {
            var strArr = new string[] { };
            var ans = solution.MostWordsFound(strArr);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(0));
        }
    }
}
