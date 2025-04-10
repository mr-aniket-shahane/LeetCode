using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
    internal class FindWords_Containing
    {
        public IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    result.Add(i);
                }
            }
            return result;
        }

    }
}
