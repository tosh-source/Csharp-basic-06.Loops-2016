using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/14.%20Hex%20to%20Decimal/README.md
          //wiki: https://bg.wikipedia.org/wiki/%D0%A8%D0%B5%D1%81%D1%82%D0%BD%D0%B0%D0%B4%D0%B5%D1%81%D0%B5%D1%82%D0%B8%D1%87%D0%BD%D0%B0_%D0%B1%D1%80%D0%BE%D0%B9%D0%BD%D0%B0_%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B0

            string user = Console.ReadLine();
            string[] input = new string[user.Length];
            for (int i = 0; i < user.Length; i++)
            {
                input[user.Length - i - 1] = user.Substring(i, 1);
            }
            long temp = 0;
            List<long> output = new List<long>();
            //calculate
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case "0": temp = 0; break;
                    case "1": temp = 1; break;
                    case "2": temp = 2; break;
                    case "3": temp = 3; break;
                    case "4": temp = 4; break;
                    case "5": temp = 5; break;
                    case "6": temp = 6; break;
                    case "7": temp = 7; break;
                    case "8": temp = 8; break;
                    case "9": temp = 9; break;
                    case "A": temp = 10; break;
                    case "B": temp = 11; break;
                    case "C": temp = 12; break;
                    case "D": temp = 13; break;
                    case "E": temp = 14; break;
                    case "F": temp = 15; break;
                }
                temp = temp * (long)(Math.Pow(16, (double)i));
                output.Add(temp);
            }
            Console.WriteLine(output.Sum());
        }
    }
}
