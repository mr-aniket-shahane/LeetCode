using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class MergeAlternately
    {

        ////Merge Strings Alternately


        public string Merge_Alternately(string word1, string word2)
        {
            int size = Math.Max(word2.Length, word1.Length);


            char[] chars = word1.ToCharArray();
            char[] chars2 = word2.ToCharArray();
            int counter = 0;
            string resp = "";
            for (int i = 0; i < size; i++)
            {
                if (i < word1.Length)
                {
                    resp += (chars[i]);
                }
                if (i < word2.Length)
                {
                    resp += (chars2[i]);
                }
            }
            Console.WriteLine(resp);
            return resp;
        }
        //public static void Main()
        //{
        //    MergeAlternately obj = new();
        //    string word1 = "abc", word2 = "q";
        //    obj.Merge_Alternately(word1, word2);
        //}
    }
}
