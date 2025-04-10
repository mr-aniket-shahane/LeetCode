using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Mid
{
    internal class Divisibility_Array
    {
        public int[] DivisibilityArray(string word, int m)
        {
            List<int> result = new List<int>();
            string w = "";
            long remainder = 0;
            for (int i = 0; i < word.Length; i++)
            {
                remainder = (remainder * 10 + (word[i] - '0')) % m;
                if (remainder == 0)
                {
                    result.Add(1);
                    Console.WriteLine(1);
                }
                else
                {
                    result.Add(0);
                    Console.WriteLine(0);
                }
            }
            return result.ToArray();
        }
    }
}
