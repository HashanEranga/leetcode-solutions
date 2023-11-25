using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1108.Tests
{
    public class TestSection
    {
        private leetcode.String._1108._Defanging_an_IP_Address.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.String._1108._Defanging_an_IP_Address.Solution();
        }

        [Test]
        [TestCase("1.1.1.1", "1[.]1[.]1[.]1")]
        [TestCase("255.100.50.0", "255[.]100[.]50[.]0")]
        public void DefangIPaddr_AddAddress_ReturnWithReplacedChars(string address, string expectedAddress)
        {
            var ans = solution.DefangIPaddr(address);

            Assert.That(ans, Is.Not.Null);
            Assert.That(ans, Is.EqualTo(expectedAddress));
        }
    }
}
