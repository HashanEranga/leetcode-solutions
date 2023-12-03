using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.String._2942._Find_Words_Containing_Character
{
    public class Solution
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            var ans = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    ans.Add(i);
                }
            }

            return ans;
        }
    }
}
