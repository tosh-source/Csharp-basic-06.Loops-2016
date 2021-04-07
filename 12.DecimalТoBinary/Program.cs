using System;
using System.Collections.Generic;

namespace _12.DecimalТoBinary
{
    class Program
    {
        static void Main(string[] args)
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/12.%20Decimal%20to%20Binary/README.md
            //input
            long input = long.Parse(Console.ReadLine());
            List<string> output = new List<string>();
            //calculate
            for (int i = 0; input >= 1; i++)
            {
                if (input % 2 == 1)
                {
                    output.Add("1");
                }
                else //(input % 2 == 0)
                {
                    output.Add("0");
                }
                input = input / 2;
            }
            //print
            for (int i = output.Count; i > 0; i--)
            {
                Console.Write(output[i - 1]);
            }
            Console.WriteLine();
        }
    }
}
