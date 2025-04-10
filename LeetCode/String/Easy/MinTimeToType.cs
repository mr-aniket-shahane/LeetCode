using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.String.Easy
{
    internal class MinTime_ToType
    {
        public int MinTimeToType(string word)
        {
            char initial = 'a';
            int counter = 0;
            foreach (char c in word)
            {
                if (c == initial)
                {
                    counter++;
                }
                else
                { 
                    char new1 = initial;
                        int time = 0;
                        while (initial != c)
                        {
                            if (initial == 'a')
                            {
                                initial = 'z';
                            }
                            else
                            {
                                initial--;
                            }
                            time++;
                        }
                    initial = new1;
                        int time1 = 0;
                        while (initial != c)
                        {
                            if (initial == 'z')
                            {
                                initial = 'a';
                            }
                            else
                            {
                                initial++;
                            }
                            time1++;
                        }
                        counter+=Math.Min(time,time1);

                        if (c == initial)
                        {
                            counter++;
                        }
                    

                }

            }
            return counter;
        }
    }
}
