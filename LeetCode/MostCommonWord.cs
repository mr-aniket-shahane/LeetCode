using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class Most_CommonWord
    {

        //Most_CommonWord


        string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = paragraph.Trim().Replace(",", " ");
            paragraph = paragraph.Trim().Replace("?", " ");
            paragraph = paragraph.Trim().Replace("','", " ");
            paragraph = paragraph.Trim().Replace(".", " ");
            paragraph = paragraph.Trim().Replace("!", " ");
            Console.WriteLine(paragraph);
            var sArray = paragraph.Split(" ");
            var MaxCount = 0;
            char a = '.';
            char.IsPunctuation(a);

            var word = "";
            for (int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i].Trim().Length > 0)
                {
                    sArray[i] = checkPunctualtion(sArray[i].Trim());


                    if (!banned.Contains(sArray[i]))
                    {
                        var count = sArray.Where(a => a.ToLower() == (sArray[i].ToLower())).Count();
                        if (MaxCount < count)
                        {
                            MaxCount = count;
                            word = sArray[i];
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(word);
            return word.ToLower();

        }
        string checkPunctualtion(string a)
        {

            if (char.IsPunctuation(a[a.Length - 1]))
            {
                return a.Remove(a.Length - 1).ToLower();
            }
            return a.ToLower();
        }
        public static void Main()
        {
            Most_CommonWord obj = new(); 
            Console.WriteLine(   obj.MostCommonWord("a, a, a, a, b,b,b,c, c", ["a"]));

        }
    }
}
