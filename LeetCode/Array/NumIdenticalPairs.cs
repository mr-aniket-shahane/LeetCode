using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class NumIdentical_Pairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int ans = 0;
            List<int> list = new List<int>(nums);
            List<int> bklist = new List<int>(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                bool isAvailable = true;
                list = bklist.Skip(i + 1).ToList();
                while (isAvailable)
                {
                    var index = list.IndexOf(nums[i]);
                    if (list.Contains(nums[i]))
                    {
                        ans++;
                        list.RemoveAt(index);
                    }
                    else
                    {
                        isAvailable = false;
                    }
                }
            }
            return ans;
        }
    }
}