using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._1672.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._1672._Richest_Customer_Wealth.Solution solution;
        [SetUp]
        public void SetUp() 
        {
            solution = new leetcode.Arrays._1672._Richest_Customer_Wealth.Solution();
        }

        [Test]
        public void MaximumWealth_EnterAccounts1_ReturnMaximumWealth()
        {
            int[][] accounts1 = new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } };
            var ans = solution.MaximumWealth(accounts1);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(6));
        }

        [Test]
        public void MaximumWealth_EnterAccounts2_ReturnMaximumWealth()
        {
            int[][] accounts2 = new int[][] { new int[] { 1,5 }, new int[] { 7,3 }, new int[] { 2, 5 } };
            var ans = solution.MaximumWealth(accounts2);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(10));
        }

        [Test]
        public void MaximumWealth_EnterAccounts3_ReturnMaximumWealth()
        {
            int[][] accounts3 = new int[][] { new int[] {2,8,7 }, new int[] { 7,1,3 }, new int[] { 1, 9, 5 } };
            var ans = solution.MaximumWealth(accounts3);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(17));
        }

    }
}
