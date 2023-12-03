using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String._771._Jewels_and_Stones
{
    public class Solution
    {
        public int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;
            foreach(var jewel in jewels)
            {
                var currentCount = stones.Count(x=>x.Equals(jewel));
                count += currentCount;
            }

            return count;
        }
    }
}
