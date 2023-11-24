using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1512.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._1512._Number_of_Good_Pairs.Solution Solution;

        [SetUp]
        public void SetUp()
        {
            Solution = new leetcode.Arrays._1512._Number_of_Good_Pairs.Solution();
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new int[] { 1, 1, 1, 1 }, 6)]
        public void NumIdenticalPairs_InputNonEmptyArray_ReturnNumberofGoodPairs(int[] inputArr, int expectedAns)
        {
            var ans = Solution.NumIdenticalPairs(inputArr);

            Assert.That(ans, Is.GreaterThan(0));
            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(expectedAns));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3})]
        public void NumIdenticalPairs_InputNonEmptyArrayWithNoGoodPairs_ReturnNumberofGoodPairsAsZero(int[] inputArr)
        {
            var ans = Solution.NumIdenticalPairs(inputArr);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(0));
        }
    }
}
