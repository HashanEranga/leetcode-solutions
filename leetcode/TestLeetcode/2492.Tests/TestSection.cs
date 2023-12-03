using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._2492.Tests
{
    public class TestSection
    {
        private leetcode.String._2942._Find_Words_Containing_Character.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.String._2942._Find_Words_Containing_Character.Solution();
        }

        [Test]
        [TestCase(new string[] { "leet", "code" }, "e", new int[] {0,1})]
        [TestCase(new string[] { "abc", "bcd", "aaaa", "cbc" }, "a", new int[] {0,2})]
        public void FindWordsContaining_EnterWordsContainingLetters_ReturnIndexOfEachContainingWord(string[] words, char x, int[] expectedResult)
        {
            var ans = solution.FindWordsContaining(words, x);

            Assert.That(ans, Is.EqualTo(expectedResult));
            Assert.That(ans, Is.Not.Empty);
            Assert.That(ans, Is.Not.Null);
        }

        [Test]
        [TestCase(new string[] { "abc", "bcd", "aaaa", "cbc" }, "z", new int[] {})]
        public void FindWordsContaining_EnterWordsNotContainingLetters_ReturnAnEmptyArray(string[] words, char x, int[] expectedResult)
        {
            var ans = solution.FindWordsContaining(words, x);

            Assert.That(ans, Is.EqualTo(expectedResult));
            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.Empty);
        }

        [Test]
        [TestCase(new string[] { }, "e", new int[] { })]
        public void FindWordsContaining_EnterEmptyArray_ReturnAnEmptyArray(string[] words, char x, int[] expectedResult)
        {
            var ans = solution.FindWordsContaining(words, x);

            Assert.That(ans, Is.EqualTo(expectedResult));
            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.Empty);
        }
    }
}
