using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace LeetCode
{
    internal class Can_Place_Flowers
    {

        //  605. Can Place Flowers

        bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int noOfPlant = 0;

            if (flowerbed.Length > 1)
            {
                if (flowerbed.Length > n)
                {
                    for (int i = 0; i < flowerbed.Length; i++)
                    {
                        if (flowerbed[i] == 0)
                        {
                            if (i - 1 >= 0 && i + 1 < flowerbed.Length)
                            {
                                if (flowerbed[i - 1] == 0 && flowerbed[i + 1] == 0)
                                {
                                    flowerbed[i] = 1;
                                    noOfPlant += 1;
                                    i++;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    if (flowerbed[i + 1] == 0)
                                    {
                                        flowerbed[i] = 1;
                                        noOfPlant += 1;
                                        i++;
                                    }
                                    //noOfPlant = flowerbed[i + 1] == 0 ? noOfPlant + 1 : noOfPlant;
                                }
                                if (i == flowerbed.Length - 1)
                                {
                                    noOfPlant = flowerbed[i - 1] == 0 ? noOfPlant + 1 : noOfPlant;
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                if (flowerbed[0] == 0)
                {
                    noOfPlant++;
                }
            }
            return noOfPlant >= n ? true : false;
        }
        public static void Main()
        {
            Can_Place_Flowers obj = new();
            Console.WriteLine(obj.CanPlaceFlowers([0, 0, 0, 0], 3));
        }
    }
}
