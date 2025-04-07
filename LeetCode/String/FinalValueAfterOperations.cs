using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String
{
    internal class Final_ValueAfterOperations
    {
//        Console.WriteLine(FinalValueAfterOperations(["--X", "X++", "X++"]));
//Console.WriteLine(FinalValueAfterOperations(["++X", "++X", "X++"]));
//Console.WriteLine(FinalValueAfterOperations(["X++", "++X", "--X", "X--"]));
int FinalValueAfterOperations(string[] operations)
        {
            int i = 0;
            foreach (string operation in operations)
            {
                if (operation.Contains("++"))
                {
                    i++;
                }
                else
                {
                    i--;
                }

            }
            return i;
        }
    }
}
