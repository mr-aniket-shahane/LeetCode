using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class productExceptSelf
    {
        //*************************************************** Pro
        public int[] ProductExceptSelf(int[] nums)
        {

            int n = nums.Length;
            int[] ans = new int[n];
            int prodcut = 1;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                    prodcut *= nums[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                    ans[i] = prodcut / nums[i];
                else
                    ans[i] = 0;
                Console.WriteLine(ans[i]);
            }
            return ans;
        }
        //public static void Main()
        //{
        //    int[] citations = { -1, 1, 0, -3, 3 };
        //    productExceptSelf obj = new();

        //    obj.ProductExceptSelf(citations);
        //}
    }
}
