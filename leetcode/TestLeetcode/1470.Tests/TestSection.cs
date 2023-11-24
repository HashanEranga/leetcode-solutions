using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1470.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._1470._Shuffle_the_Array.Solution solution;

        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.Arrays._1470._Shuffle_the_Array.Solution();
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 3, new int[] { 1, 4, 2, 5, 3, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [TestCase(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        public void Shuffle_InputArray_ReturnShuffleArray(int[] inputArray, int n, int[] expectedArray)
        {
            var ans = solution.Shuffle(inputArray, n);

            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.EqualTo(expectedArray));
        }
    }
}
