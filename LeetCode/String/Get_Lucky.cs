using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class Get_Lucky
    {
//        Console.WriteLine(GetLucky("iiii", 1));
//Console.WriteLine(GetLucky("leetcode", 2));
//Console.WriteLine(GetLucky("zbax", 2));
int GetLucky(string s, int k)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            //List<alpha> list = new List<alpha>();
            char c = 'a';
            for (int i = 1; i <= 26; i++)
            {
                map.Add(c, i);
                c++;
            }
            string stringtoInt = "";
            foreach (var chr in s)
            {
                stringtoInt += map.First(alpha => alpha.Key == chr).Value;

            }
            int ans = 0;
            for (int i = 0; i < k; i++)
            {

                int a = 0;
                foreach (var x in stringtoInt)
                {
                    a = a + Int32.Parse(x.ToString());
                }
                ans = a;
                stringtoInt = a.ToString();
            }
            return ans;
        }

    }
}
