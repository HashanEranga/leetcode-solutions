using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._2011.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._2011._Final_Value_of_Variable_After_Performing_Operations.Solution _solution;

        [SetUp]
        public void SetUp()
        {
            _solution = new leetcode.Arrays._2011._Final_Value_of_Variable_After_Performing_Operations.Solution();
        }

        [Test]
        [TestCase(new string[] {"++X", "++X", "++X"}, 3)]
        [TestCase(new string[] { "--X", "X++", "X++" }, 1)]
        [TestCase(new string[] { "++X", "++X", "X++" }, 3)]
        [TestCase(new string[] { "X++", "++X", "--X", "X--" }, 0)]
        [TestCase(new string[] {}, 0)]
        public void FinalValueAfterOperations_AddedAnOperationArray_ReturnTheValueAfterOperations(string[] operations, int expectedAns)
        {
            var ans = _solution.FinalValueAfterOperations(operations);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(expectedAns));
        }

        [Test]
        [TestCase(new string[] { "++X", "++X", "++X" }, 3)]
        [TestCase(new string[] { "--X", "X++", "X++" }, 1)]
        [TestCase(new string[] { "++X", "++X", "X++" }, 3)]
        [TestCase(new string[] { "X++", "++X", "--X", "X--" }, 0)]
        [TestCase(new string[] { }, 0)]
        public void FinalValueAfterOperationsAlternate_AddedAnOperationArray_ReturnTheValueAfterOperations(string[] operations, int expectedAns)
        {
            var ans = _solution.FinalValueAfterOperations_Alternative(operations);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(expectedAns));
        }
    }
}
