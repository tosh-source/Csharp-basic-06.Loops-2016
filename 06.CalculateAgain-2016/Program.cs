using System;
using System.Numerics;

namespace _06.CalculateAgain_2016
{
    class Program
    {
        static void Main(string[] args)
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/06.%20Calculate%20Again!/README.md
            //1
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            //2
            BigInteger nFactur = 1;
            BigInteger kFactur = 1;
            BigInteger nDivideK = 0;
            for (uint i = 1; true; i++)
            {
                if (!(i > n))
                {
                    nFactur *= i;
                }
                if (!(i > k))
                {
                    kFactur *= i;
                }
                if ((i > n) && (i > k))
                {
                    nDivideK = nFactur / kFactur;
                    Console.WriteLine(nDivideK);
                    return;
                }
            }
        }
    }
}
