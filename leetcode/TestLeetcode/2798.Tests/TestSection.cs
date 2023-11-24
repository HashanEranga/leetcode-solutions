using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._2798.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._2798._Number_of_Employees_Who_Met_the_Target.Solution solution;
        [SetUp]
        public void SetUp()
        {
            solution = new leetcode.Arrays._2798._Number_of_Employees_Who_Met_the_Target.Solution();
        }

        [Test]
        [TestCase(new int[] { 0, 1, 2, 3, 4 }, 2, 3)]
        [TestCase(new int[] { 5, 1, 4, 2, 2 }, 6, 0)]
        [TestCase(new int[] { }, 6, 0)]
        public void NumberOfEmployeesWhoMetTargetTest_InputHours_ReturnCountOfEmployeeWhoGotTarget(int[] hours, int target, int expectedOutcome)
        {
            var ans = solution.NumberOfEmployeesWhoMetTarget(hours, target);

            Assert.That(ans, Is.TypeOf<int>());
            Assert.That(ans, Is.EqualTo(expectedOutcome));
        }
    }
}
