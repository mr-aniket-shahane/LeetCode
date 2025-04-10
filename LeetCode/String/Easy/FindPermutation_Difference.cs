using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
//    Input: s = "abcde", t = "edbac"

//Output: 12

//Explanation: The permutation difference between s and t is equal to
//|0 - 3| + |1 - 2| + |2 - 4| + |3 - 1| + |4 - 0| = 12.
    internal class FindPermutation_Difference
    {
        public int FindPermutationDifference(string s, string t)
        {
            int ans = 0;
            for(int i=0; i<s.Length;i++)
            {
                var index = t.IndexOf(s[i]);
                if (index > i)
                {
                    ans += index - i;
                }
                else
                {
                    ans +=i-index;

                }
            }
            return ans;
        }
    }
}
