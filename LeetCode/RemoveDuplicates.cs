using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 1, 2 };
            Console.WriteLine(RemoveDuplicate1s(nums)); // 2 [1,2]
        }

        public static int RemoveDuplicate1s(int[] nums)
        {
            List<int> list = new List<int>();
            int counter = 0;
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    temp = nums[i];
                    counter++;
                }
                else
                {
                    if (temp == nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        temp = nums[i];
                        nums[counter] = temp;
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
