using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class Transform_Array
    {
        public int[] TransformArray(int[] nums)
        {
            int odd=0, even=0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if(even != 0)
                {
                    ans[i] = 0;
                    even--;
                }
                else
                {
                    ans[i] = 1;
                    odd--;
                }
            }
                return ans;
        }
    }
}
