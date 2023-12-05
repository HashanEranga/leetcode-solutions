using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String._2114._Maximum_Number_of_Words_Found_in_Sentences
{
    public class Solution
    {
        public int MostWordsFound(string[] sentences)
        {
            int maxWords = 0;
            foreach (string sentence in sentences)
            {
                if (sentence != null)
                {
                    if(sentence.Trim().Split(' ').Count() > maxWords) maxWords = sentence.Trim().Split(" ").Count();
                }
            }
            return maxWords;
        }
    }
}
