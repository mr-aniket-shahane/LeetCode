using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class Maximum_Wealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            int ans = 0;
            foreach (var account in accounts)
            {
                List<int> list = new List<int>(account);
                var an = list.Sum(a => a);
                if (ans <= an)
                {
                    ans = an;
                }
            }
            return ans;
        }
    }
}
