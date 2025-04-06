using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Candy
    {
        public static void main(string[] args)
        {
            Candy obj = new();
            Console.WriteLine(obj.rCandy([60, 80, 100, 100, 100, 100, 100]));
            Console.WriteLine(obj.rCandy([60, 80, 100, 100, 100, 100, 100]));
        }
        public int rCandy(int[] ratings)
        {
            List<int> result = new List<int>();
            int count = 0;
            for (int i = 0; i < ratings.Length; i++)
            {
                if (i == 0)
                {
                    if (ratings[i + 1] < ratings[i])
                    {
                        result.Add(result[i - 1] + 1);
                        count++;
                    }
                }
                else if (i == ratings.Length - 1)
                {
                    if (ratings[i - 1] < ratings[i])
                    {
                        count++;
                    }
                }
                else if (i - 1 >= 0 && i + 1 < ratings.Length)
                {
                    if (ratings[i - 1] < ratings[i] || ratings[i + 1] < ratings[i])
                    {
                        count++;
                    }
                }
                else
                {
                    result.Add(1);
                }
            }
            return count + ratings.Length;
        }
    }
}
