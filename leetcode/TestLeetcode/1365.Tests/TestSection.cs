using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.Arrays._1365;
using leetcode.HashTable._1365;
namespace TestLeetcode._1365.Tests
{
    public class TestSection
    {
        //private leetcode.Arrays._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number.Solution solution;
        private leetcode.HashTable._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number.Solution solution;
        [SetUp]
        public void SetUp()
        {
            //solution = new leetcode.Arrays._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number.Solution();
            solution = new leetcode.HashTable._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number.Solution();
        }

        [Test]
        [TestCase(new int[] {6,5,4,8}, new int[] {2,1,0,3})]
        [TestCase(new int[] {7,7,7,7}, new int[] {0,0,0,0})]
        public void SmallerNumbersThanCurrent_PassNumsArray_ReturnCountArray(int[] inputArray, int[] expectedResults)
        {
            var result = solution.SmallerNumbersThanCurrent(inputArray);

            Assert.That(result, Is.EqualTo(expectedResults));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Length, Is.EqualTo(expectedResults.Length));
        }
    }
}
