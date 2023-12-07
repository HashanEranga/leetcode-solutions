using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String._1221._Split_a_String_in_Balanced_Strings
{
    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            var charArr = s.ToCharArray();

            var countL = 0;
            var countR = 0;
            var balancedStringCount = 0;

            foreach (var c in charArr)
            {
                if (c == 'L') countL++;
                if (c == 'R') countR++;
                if (countL == countR) balancedStringCount++;
            }

            return balancedStringCount;
        }
    }
}
