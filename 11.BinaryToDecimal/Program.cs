using System;
using System.Numerics;

namespace _11.BinaryToDecimal
{
    class Program
    {
        static void Main()
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/11.%20Binary%20to%20Decimal/README.md

            string binAsString = Console.ReadLine();
            BigInteger binary = BigInteger.Parse(binAsString);
            BigInteger output = 0;
            for (int i = 0; i < binAsString.Length; i++)
            {
                BigInteger bit = binary % 10;
                binary = binary / 10;
                output = output + (bit * (BigInteger)(Math.Pow(2, i)));
            }
            Console.WriteLine(output);
        }
    }
}
