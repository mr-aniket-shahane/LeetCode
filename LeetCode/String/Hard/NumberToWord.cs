using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Hard
{
    internal class NumberToWord
    {
        public string NumberToWords(int num)
        {
            if (num % 10 > 00)
            {
                return num % 10+"ten";
            }

            //string strnum = num.ToString();
            //if (strnum.Length == 5 || strnum.Length == 4)
            //{// Thousand
            //    if (strnum.Length == 5)
            //    {
            //        var th = strnum[0] + strnum[1];

            //    }

            //}
            return "";
        }
    }
}
