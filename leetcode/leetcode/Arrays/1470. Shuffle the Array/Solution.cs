using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1470._Shuffle_the_Array
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var ans = new int[2*n];
            int index = 0;
            for(int i = 0; i < n; i++) 
            {
                ans[index] = nums[i]; index++;
                ans[index] = nums[n+i]; index++;
            }

            return ans;
        }
    }
}
