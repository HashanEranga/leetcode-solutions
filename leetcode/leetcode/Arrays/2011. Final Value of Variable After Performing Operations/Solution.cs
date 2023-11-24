using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Arrays._2011._Final_Value_of_Variable_After_Performing_Operations
{
    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            var currentValue = 0;
            foreach(var item in operations)
            {
                switch (item)
                {
                    case "++X":
                        currentValue++; break;
                    case "X++":
                        currentValue++; break;
                    case "--X":
                        currentValue--; break;
                    case "X--":
                        currentValue--; break;
                    default:
                        break;
                }
            }
            return currentValue;
        }

        public int FinalValueAfterOperations_Alternative(string[] operations)
        {
            var currentValue = 0;
            foreach(var item in operations)
            {
                if (item == "++X" || item == "X++") currentValue++;
                else if (item == "--X" || item == "X--") currentValue--;
            }
            return currentValue;
        }
    }
}
