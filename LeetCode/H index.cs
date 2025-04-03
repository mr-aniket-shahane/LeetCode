using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class H_index
    {
        //*************************************************** H index

        public int HIndex(int[] citations)
        {
            var f = 0;
            var cit = 0;
            List<int> result = new List<int>();
            result.AddRange(citations);
            for (int i = 0; i < citations.Length; i++)
            {
                cit = Math.Max(cit, citations[i]);
                var a = citations[i];
                var found = result.FindAll(x => x >= a).Count;
                if (found > citations.Length / 2)
                {
                    if (a >= cit)
                    {
                        f = a;
                        Console.WriteLine(f);
                    }
                }
            }

            return f;
        }
        public static void Main()
        {
            int[] citations = { 3, 0, 6, 1, 5 };
            H_index c = new();
             
            c.HIndex(citations);
        }
    }
}
