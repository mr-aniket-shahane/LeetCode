using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class Reverse_Vowels_of_a_String
    {

        //345. Reverse Vowels of a String

        string ReverseVowels(string s)
        {
            List<char> list = new List<char>(['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U']);
            List<char> currentChar = new List<char>();

            int totalVovels = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i]))
                {
                    totalVovels++;
                    currentChar.Add(s[i]);
                }
            }
            var ch = s.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (list.Contains(ch[i]))
                {
                    if (totalVovels > 0)
                    {
                        ch[i] = currentChar[totalVovels - 1];
                        totalVovels--;
                    }
                }
            }
            return new string(ch);
        }






        public static void Main()
        {
            Reverse_Vowels_of_a_String obj = new();

            var r = obj.ReverseVowels("IceCreAm");
            Console.WriteLine(r);
        }
    }
}
