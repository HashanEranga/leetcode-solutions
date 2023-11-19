using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLeetcode._2433.Tests
{
    public class TestSection
    {
        private leetcode.Arrays._2433._Find_The_Original_Array_of_Prefix_Xor.Solution findArray;
        [SetUp]
        public void SetUp() 
        { 
            findArray = new leetcode.Arrays._2433._Find_The_Original_Array_of_Prefix_Xor.Solution();
        }

        [Test]
        [TestCase(new int[] { 5, 2, 0, 3, 1 }, new int[] { 5, 7, 2, 3, 2 })]
        [TestCase(new int[] { 13 }, new int[] { 13 })]
        [TestCase(new int[] { }, new int[] { })]
        public void FindArray_WhenPrefArrayAdded_ReturnOriginalArrayOfXOR(int[] input, int[] expectedOutput)
        {
            var ans = findArray.FindArray(input);

            Assert.That(ans, Is.Not.Null);
            Assert.That(ans.Length, Is.EqualTo(expectedOutput.Length));
            Assert.That(ans, Is.EqualTo(expectedOutput));
        }


    }
}
