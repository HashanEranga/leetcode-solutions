using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1920___Build_Array_from_Permutation
{
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Count()];
            for (int i = 0; i < nums.Count(); i++)
            {
                ans[i] = nums[nums[i]];
            }

            return ans;
        }
    }
}
