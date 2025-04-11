using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    public  class GcdOf_Strings
    {

        //1071. Greatest Common Divisor of Strings

        public string GcdOfStrings(string str1, string str2)
        {
            string my_sub = "";
            string my_sub2 = "";
            char[] my_str = str2.ToCharArray();
            for (int i = 0; i < my_str.Length; i++)
            {
                my_sub += my_str[i];
                var sub = str1.Split(my_sub);
                var sub1 = str2.Split(my_sub);
                if (sub[0] == str1)
                {
                    my_sub = "";
                    break;
                }
                if (sub.Count(s => s != "") == 0 && sub1.Count(s => s != "") == 0)
                {
                    my_sub2 = my_sub;
                }
                else if (sub.Count(s => s != "") == 0 || sub1.Count(s => s != "") == 0)
                {
                    my_sub = "";
                }

            }
            return my_sub2;
        }
       
    }
}
