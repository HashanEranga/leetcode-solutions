using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1365._How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                var count = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i != j && nums[i] > nums[j]) count++;
                }
                result[i] = count;
            }
            return result;
        }
    }
}
