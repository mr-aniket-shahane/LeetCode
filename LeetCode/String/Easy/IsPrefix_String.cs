using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
    internal class IsPrefix_String
    {
        public bool IsPrefixString(string s, string[] words)
        {
            string ans = "";
            foreach (var word in words)
            {
                ans += word;
                if (ans == s)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
