using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CanJump
    {
        //*************************************************** jump 
        //public static void Main()
        //{
        //    int[] nums = { 2, 0, 0 };
        //    CanJump c = new();
        //    Console.WriteLine(CanJumpMethod(nums));
        //}

        public static bool CanJumpMethod(int[] nums)
        {
            int MaxR = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > MaxR)
                {
                    return false;
                }
                MaxR = Math.Max(MaxR, i + nums[i]);
                if (MaxR >= nums.Length - 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
