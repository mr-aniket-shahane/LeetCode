using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class IntTo_Roman
    {

   

        string IntToRoman(int num)
        {
            var resp = "";
            List<Roman> sd = new List<Roman> { new Roman { Key= "I", value = 1 },
                    new Roman { Key= "V", value = 5 },
                    new Roman { Key= "X", value = 10 },
                    new Roman { Key= "L", value = 50},
                    new Roman { Key= "C", value = 100 },
                    new Roman { Key= "D", value = 500 },
                    new Roman { Key= "M", value = 1000 },
                    new Roman { Key= "IV", value = 4 },
                    new Roman { Key= "IX", value = 9 },
                    new Roman { Key= "XL", value = 40 },
                    new Roman { Key= "XC", value = 90 },
                    new Roman { Key= "CD", value = 400 },
                    new Roman { Key= "CM", value = 900 },
                };
            sd = sd.OrderByDescending(a => a.value).ToList();
            Console.WriteLine(sd);
            for (int i = 0; i < sd.Count; i++)
            {
                if (num >= sd[i].value)
                {
                    var no = num / sd[i].value;
                    while (no > 0)
                    {
                        num = num - sd[i].value;
                        resp += sd[i].Key;
                        no--;
                    }

                }
                else
                {
                    continue;
                }
            }

            return resp;

        }
      


        public static void Main()
        {
            IntTo_Roman obj = new();
            var r = obj.IntToRoman(1994);
            Console.WriteLine(r);
        }
    }
}
public class Roman
{
    public int value { get; set; }
    public string Key { get; set; }
}
