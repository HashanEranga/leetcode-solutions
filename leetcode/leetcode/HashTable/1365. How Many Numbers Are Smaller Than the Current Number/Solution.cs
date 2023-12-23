using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.HashTable._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var NumCountDict = new Dictionary<int, int>();
            var result = new int[nums.Length];

            var sortedArr = (int[])nums.Clone();
            Array.Sort(sortedArr);

            for (int i = 0; i < sortedArr.Length; i++)
            {
                if (!NumCountDict.ContainsKey(sortedArr[i])) NumCountDict.Add(sortedArr[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = NumCountDict[nums[i]];
            }

            return result;
        }
    }
}
