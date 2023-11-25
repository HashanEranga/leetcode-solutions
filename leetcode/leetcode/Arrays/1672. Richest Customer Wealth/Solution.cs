using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._1672._Richest_Customer_Wealth
{
    public class Solution
    {
        public int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            foreach (var account in accounts)
            {
                var sum = account.Sum();
                maxWealth = (sum > maxWealth) ? sum : maxWealth;
            }
            return maxWealth;
        }
    }
}
