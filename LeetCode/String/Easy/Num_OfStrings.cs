using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
    internal class Num_OfStrings
    {
        public int NumOfStrings(string[] patterns, string word)
        {
            int ans = 0;
            foreach (var pattern in patterns) {
                if (word.Contains(pattern))
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}
