using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String._1678._Goal_Parser_Interpretation
{
    public class Solution
    {
        public string Interpret(string command)
        {
            if (command.Contains("()")) command = command.Replace("()", "o");
            if (command.Contains("(al)")) command = command.Replace("(al)", "al");

            return command;
        }
    }
}
