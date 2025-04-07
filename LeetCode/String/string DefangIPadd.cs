using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class string_DefangIPadd
    { 
 
//Console.WriteLine(DefangIPaddr("1.1.1.1"));
  string DefangIPaddr(string address)
    {
        address = address.Replace(".", "[.]");
        return address;
    }

}
}
