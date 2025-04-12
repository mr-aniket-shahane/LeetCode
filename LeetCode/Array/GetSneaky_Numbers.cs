using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class GetSneaky_Numbers
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            List<int> ans = new List<int>();
            List<int> result = new List<int>(nums);
            foreach (int num in nums)
            {
                if (result.Where(a => a.Equals(num)).Count() > 1)
                {
                    ans.Add(num);
                }
            }
            return ans.Distinct().ToArray();
        }
    }
}
