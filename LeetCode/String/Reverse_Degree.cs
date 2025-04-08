using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class Reverse_Degree
    {
        public int ReverseDegree(string s)
        {
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var loc = 'z'-s[i]+1;
                ans += loc * (i + 1);
            }
            return ans;
        }
    }
}

