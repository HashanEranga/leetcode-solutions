using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1929._Concatenation_of_Array
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            var ans = new int[2 * nums.Count()];
            for (int i = 0; i < nums.Count(); i++)
            {
                ans[i] = nums[i];
                ans[i + nums.Count()] = nums[i];
            }
            return ans;
        }
    }
}
