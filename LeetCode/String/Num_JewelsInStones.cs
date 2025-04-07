using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class Num_JewelsInStones
    {
        //Console.WriteLine(NumJewelsInStones("z", "ZZ"));
        int NumJewelsInStones(string jewels, string stones)
        {
            List<char> stones_List = new List<char>(stones);
            int ans = 0;
            foreach (var jewel in jewels)
            {
                ans += stones_List.Count(x => x.Equals(jewel));
            }
            return ans;
        }
    }
}
