using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class Score_OfString
    {
//        Console.WriteLine(ScoreOfString("zaz") );
//Console.WriteLine(ScoreOfString("hello") );
int ScoreOfString(string s)
        {
            int ans = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                var e = (int)s[i] - (int)s[i + 1];
                if (e < 0)
                {
                    e = e * (-1);
                }
                ans += e;

            }
            return ans;
        }
    }
}
