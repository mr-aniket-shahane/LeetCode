using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Jump_2
    {
        public static void Main()
        {
            Jump_2 c = new();
            int[] nums = { 2, 1, 1, 1, 4 };
            Console.WriteLine(c.Jump(nums));
        }
        ///************************************************ Jump 2
       
        public int Jump(int[] nums)
        {
            int MaxR = 0;
            int totalJump = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > MaxR)
                {
                    return 0;
                }
                MaxR += nums[i];
                if (MaxR >= nums.Length - 1)
                {
                    return totalJump;
                }
                totalJump++;
            }
            return 0;
        }
    }
}
