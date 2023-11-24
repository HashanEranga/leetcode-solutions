using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._2798._Number_of_Employees_Who_Met_the_Target
{
    public class Solution
    {
        public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            var count = 0;
            foreach(var item in hours)
            {
                if(item >= target) count++;
            }
            return count;
        }
    }
}
