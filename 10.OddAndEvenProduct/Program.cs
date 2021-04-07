using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main(string[] args)
        {   //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/10.%20Odd%20and%20Even%20Product/README.md
            //разаснение: Не се гледат числата дали са четни или нечетни като СТОЙНОСТ, а в зависимост от ПОЗИЦИЯТА на която сав редицата (първа цифра НЕЧЕТНА, втора ЧЕТНА, трета НЕЧЕТНА,.. и т.н.). Пример: "2 1 1 6 3" --> нечетни/odd(2, 1, 3) и четни/even(1, 6) --> 2x1x3=6 и 1x6=6 => призведенията са равни на "6" 
            //разяснителен видео материял: https://softuni.bg/trainings/resources/video/6200/video-odd-and-even-product-20-october-2015-c-programming-october-2015

            int howMany = int.Parse(Console.ReadLine());
            string[] userValues = Console.ReadLine().Split(' ');
            int[] n = new int[howMany];
            int mask = 1;
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 1; i <= howMany; i++)
            {
                n[i - 1] = int.Parse(userValues[i - 1]);
                if (((i & mask) == 1)) //odd
                {
                    odd.Add(n[i - 1]);
                }
                else //(((i & mask) == 0)) --> even
                {
                    even.Add(n[i - 1]);
                }
            }
            long productOfOdd = 1;
            long productOfEven = 1;
            for (int i = 0; i < odd.Count; i++) //productOfOdd
			{
			    productOfOdd *= odd[i];
			}
            for (int i = 0; i < even.Count; i++) //productOfEven
			{
			    productOfEven *= even[i];
			}

            if (productOfOdd == productOfEven) //compare
            {
                Console.WriteLine("yes {0}", productOfOdd);
            }
            else
            {
                Console.WriteLine("no {0} {1}", productOfOdd, productOfEven);
            }
        }
    }
}
