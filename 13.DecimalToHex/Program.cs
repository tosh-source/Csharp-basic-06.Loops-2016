using System;
using System.Collections.Generic;

namespace _13.DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/13.%20Decimal%20to%20Hex/README.md
          //wiki: https://bg.wikipedia.org/wiki/%D0%A8%D0%B5%D1%81%D1%82%D0%BD%D0%B0%D0%B4%D0%B5%D1%81%D0%B5%D1%82%D0%B8%D1%87%D0%BD%D0%B0_%D0%B1%D1%80%D0%BE%D0%B9%D0%BD%D0%B0_%D1%81%D0%B8%D1%81%D1%82%D0%B5%D0%BC%D0%B0

            //input
            long input = long.Parse(Console.ReadLine());
            long temp = 0;
            List<string> output = new List<string>();
            //calculate
            for (int i = 0; input >= 1; i++)
            {
                temp = input % 16;
                switch (temp)
                {
                    case 0: output.Add("0"); break;
                    case 1: output.Add("1"); break;
                    case 2: output.Add("2"); break;
                    case 3: output.Add("3"); break;
                    case 4: output.Add("4"); break;
                    case 5: output.Add("5"); break;
                    case 6: output.Add("6"); break;
                    case 7: output.Add("7"); break;
                    case 8: output.Add("8"); break;
                    case 9: output.Add("9"); break;
                    case 10: output.Add("A"); break;
                    case 11: output.Add("B"); break;
                    case 12: output.Add("C"); break;
                    case 13: output.Add("D"); break;
                    case 14: output.Add("E"); break;
                    case 15: output.Add("F"); break;
                }
                input = input / 16;
            }
            //print
            for (int i = output.Count - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}
