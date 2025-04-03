using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _189
    {
        ///  *************************************************189. Rotate Array
        public static void Main()
        {
            int[] nums = { -1, -100, 3, 99 };
            int k = 2;

            _189 obj = new _189();
            obj.Rotate(nums, k);

            Console.WriteLine(string.Join(", ", nums));
        }
        public void Rotate(int[] nums, int k)
        {
            List<int> list = new List<int>();
            int rotateTill = nums.Length;
            for (int i = k + 1; i < rotateTill; i++)
            {
                list.Add(nums[i]);
                Console.WriteLine(nums[i]);
                if (i == rotateTill - 1 && rotateTill != k + 1)
                {
                    i = -1;
                    rotateTill = k + 1;
                }
            }
            nums = [];
            nums = list.ToArray();
        }

    }
}
