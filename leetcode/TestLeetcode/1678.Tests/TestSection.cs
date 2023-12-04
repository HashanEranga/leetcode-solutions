using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1678.Tests
{
    public class TestSection
    {
        private leetcode.String._1678._Goal_Parser_Interpretation.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.String._1678._Goal_Parser_Interpretation.Solution();
        }

        [Test]
        [TestCase("G()(al)", "Goal")]
        [TestCase("G()()()()(al)", "Gooooal")]
        [TestCase("(al)G(al)()()G", "alGalooG")]
        public void Interpret_DefaultCase_ReturnCorrectWord(string input, string expectedResult)
        {
            var ans = solution.Interpret(input);

            Assert.That(ans, Is.Not.Empty);
            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.EqualTo(expectedResult));
        }
    }
}
