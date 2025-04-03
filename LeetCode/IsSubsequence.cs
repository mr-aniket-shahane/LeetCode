using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class Is_Subsequence
    {


        bool IsSubsequence(string s, string t)
        {


            List<char> list = new List<char>(s.ToCharArray());
            List<char> tList = new List<char>(t.ToCharArray());
            int isfound = list.Count();
            int counter = 0;
            foreach (char c in tList)
            {
                if (counter < list.Count())
                {
                    if (c == list[counter])
                    {
                        counter++;
                        isfound--;
                    }
                }
                if (isfound == 0)
                {
                    return true;
                }
            }

            return false;
        }
        public static void Main()
        {
            Is_Subsequence obj = new();

            Console.WriteLine(obj.IsSubsequence("abxc", "ahbgdc"));
        }
    }
}
