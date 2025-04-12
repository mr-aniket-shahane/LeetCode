using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    internal class Min_Operations
    {
        public int[] MinOperations(string boxes)
        {
            int len = boxes.Length;
            int[] ar = new int[len];
            char[] chars = boxes.ToCharArray();

            int counter = 0;
            int pointer = 0;
            for (int j = 0; j < len; j++)
            {
                for (int i = 0; i < len; i++)
                {
                    if (i != pointer)
                    {
                        if (chars[i] == '1')
                        {
                            counter = counter + Math.Abs(pointer - i);
                        }
                    }

                }
                ar[pointer] = counter;
                pointer++;
                counter = 0;
            }

            return ar;
        }
    }
}
