using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class Minimum_Operations
    {
        public int MinimumOperations(int[] nums)
        {
            int ans = 0;
            foreach (int n in nums)
            {
                if (n % 3 != 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
}
