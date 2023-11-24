using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1512._Number_of_Good_Pairs
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (i<j && nums[j] == nums[i]) count++;
                }
            }

            return count;
        }
    }
}
