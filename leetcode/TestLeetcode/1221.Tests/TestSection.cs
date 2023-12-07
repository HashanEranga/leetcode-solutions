using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1221.Tests
{
    public class TestSection
    {
        private leetcode.String._1221._Split_a_String_in_Balanced_Strings.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.String._1221._Split_a_String_in_Balanced_Strings.Solution();
        }

        [Test]
        [TestCase("RLRRLLRLRL", 4)]
        [TestCase("RLRRRLLRLL", 2)]
        [TestCase("LLLLRRRR", 1)]
        public void BalancedStringSplit_DefaultCaseTesting_ReturnBlancedStringSplit(string s, int expectedValue)
        {
            var ans = solution.BalancedStringSplit(s);

            Assert.That(ans, Is.EqualTo(expectedValue));
        }
    }
}
