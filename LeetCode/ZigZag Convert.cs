using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class ZigZag_Convert
    {

        //*************************************************** ZigZag Convert

       
        string Convert(string s, int numRows)
        {
            string resp = "";
            if (numRows > 1)
            {
                var ar = s.ToCharArray();

                int skip = ((numRows - 1) + (numRows - 2)) + 1;
                int max_Skip = skip;

                int f_skip = 0; int l_skip = 0;
                bool isSkipped = false;
                for (int i = 0; i < numRows; i++)
                {
                    isSkipped = false;
                    if (i == 0 || i == numRows - 1)
                    {
                        l_skip = f_skip = max_Skip;
                        skip = i;
                        //Console.WriteLine(f_skip + "-" + l_skip);
                        for (int j = i; j < ar.Length; j++)
                        {
                            if (j == skip)
                            {
                                resp += ar[j];
                                skip = isSkipped ? j + l_skip : j + f_skip;
                                isSkipped = !isSkipped;
                                //Console.WriteLine(ar[i]);
                            }
                        }
                    }
                    else
                    {
                        f_skip = max_Skip - i;
                        l_skip = 2 * i == 0 ? f_skip : 2 * i;
                        skip = i;
                        //Console.WriteLine(f_skip + "-" + l_skip);
                        for (int j = i; j < ar.Length; j++)
                        {
                            if (j == skip)
                            {
                                resp += ar[j];
                                skip = isSkipped ? j + l_skip : j + f_skip - i;
                                isSkipped = !isSkipped;
                                //Console.WriteLine(ar[i]);
                            }
                        }
                    }

                }
            }
            else
                resp = s;
            Console.WriteLine(resp);
            return resp;
        }
        public static void Main()
        { 
            ZigZag_Convert obj = new();
            string s = "AB"; int numRows = 1;
            obj.Convert(s, numRows);  
        }
    }
}
