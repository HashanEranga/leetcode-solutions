using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1929.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._1929._Concatenation_of_Array.Solution concatArray;

        [SetUp]
        public void SetUp()
        {
            concatArray = new leetcode.Arrays._1929._Concatenation_of_Array.Solution();
        }

        [Test]
        public void GetConcatenation_WhenEmptyArrayInput_ReturnAnEmptyArray()
        {
            var emptyArray = new int[] { };
            var ans = concatArray.GetConcatenation(emptyArray);
            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.InstanceOf(new int[] { }.GetType()));
            Assert.That(ans.Length, Is.EqualTo(0));
        }

        [Test]
        [TestCase(new int[] {1,2,3}, new int[] {1,2,3,1,2,3})]
        [TestCase(new int[] {1,2,3,4,5,6}, new int[] {1,2,3,4,5,6,1,2,3,4,5,6})]
        public void GetConcatenation_WhenAnArrayPassed_ReturnConcatArray(int[] input, int[] expectedOutcome)
        {
            var ans = concatArray.GetConcatenation(input);
            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.InstanceOf(new int[] { }.GetType()));
            Assert.That(ans.Length, Is.EqualTo(expectedOutcome.Length));
            Assert.That(ans, Is.EqualTo(expectedOutcome));
        }
    }
}
