using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._771.Tests
{
    public class TestSection
    {
        private leetcode.String._771._Jewels_and_Stones.Solution _solution;
        [SetUp]
        public void SetUp()
        {
            _solution = new leetcode.String._771._Jewels_and_Stones.Solution();
        }

        [Test]
        [TestCase("aA", "aAAbbbb", 3)]
        [TestCase("z", "ZZ", 0)]
        public void NumJewelsInStones_EnterJewels_ReturnNumberOfJewelStones(string jewels, string stones, int expectedOutput)
        {
            var ans = _solution.NumJewelsInStones(jewels, stones);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(expectedOutput));
        }
    }
}
