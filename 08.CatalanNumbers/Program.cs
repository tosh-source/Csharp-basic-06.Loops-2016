using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        static void Main()
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/08.%20Catalan%20Numbers/README.md
            //input
            ulong n = ulong.Parse(Console.ReadLine());
            //calculate
            BigInteger nFactur = 1;
            BigInteger nFacturPlus1 = 1;
            BigInteger twoNFactur = 1;
            bool readyToPrint = false;
            BigInteger catalan = 0;
            for (ulong i = 1; true; i++)
            {
                if (!(i > n)) //N!
                {
                    nFactur *= i;
                }
                if (!(i > (n + 1))) //(n+1)!
                {
                    nFacturPlus1 *= i;
                }
                if (!(i > (n * 2))) //(2n)!
                {
                    twoNFactur *= i;
                }
                else
                {
                    readyToPrint = true; //(2n)! is biggest factorial
                }
                if (readyToPrint)
                {
                    catalan = twoNFactur / (nFacturPlus1 * nFactur);
                    Console.WriteLine(catalan);
                    return;
                }
            }
        }
    }
}
