using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._2433._Find_The_Original_Array_of_Prefix_Xor
{
    public class Solution
    {
        public int[] FindArray(int[] pref)
        {
            var ans = new int[pref.Length];
            int rem = 0;
            for(int i=0; i< pref.Length; i++)
            {
                if (i == 0) {
                    ans[i] = pref[i];
                    rem = ans[i];
                }
                else
                {
                    ans[i] = rem ^ pref[i];
                    rem = rem ^ ans[i];
                }
            }
            return ans;
        }
    }
}
