using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using leetcode;

namespace TestLeetcode._1920.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._1920___Build_Array_from_Permutation.Solution buildArray;

        [SetUp]
        public void SetUp()
        {
            buildArray = new leetcode.Arrays._1920___Build_Array_from_Permutation.Solution();
        }

        [Test]
        [TestCase(new int[] { }, new int[] { })]
        public void BuildArray_WhenEmptyArrayPassed_ReturnAnEmptyArray(int[] input, int[] expectedOutcome)
        {
            var ans = buildArray.BuildArray(input);

            Assert.That(ans.Length, Is.EqualTo(expectedOutcome.Length));
            Assert.That(ans, Is.InstanceOf(expectedOutcome.GetType()));
        }

        [Test]
        [TestCase(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] {0, 1, 2, 4, 5, 3})]
        [TestCase(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
        public void BuildArray_WhenNonEmptyArrayPassed_ReturnAnProcessedArray(int[] input, int[] expectedOutcome)
        {
            var ans = buildArray.BuildArray(input);

            Assert.That(ans.Length, Is.EqualTo(expectedOutcome.Length));
            Assert.That(ans, Is.InstanceOf(expectedOutcome.GetType()));
            Assert.That(ans, Is.EqualTo(expectedOutcome));
        }

        [Test]
        [TestCase(new int[] {0,1,2,3,4}, new int[] {0,1,2,3,4})]
        [TestCase(new int[] {0,1,2,3,4,5,6,7,8}, new int[] {0,1,2,3,4,5,6,7,8})]
        public void BuildArray_WhenIdenticalArrayIsPassed_ReturnSameArray(int[] input, int[] expectedOutcome)
        {
            var ans = buildArray.BuildArray(input);

            Assert.That(ans.Length, Is.EqualTo(expectedOutcome.Length));
            Assert.That(ans, Is.InstanceOf(expectedOutcome.GetType()));
            Assert.That(ans, Is.EqualTo(expectedOutcome));
        }
    }
}
