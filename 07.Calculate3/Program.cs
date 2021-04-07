using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _07.Calculate3
{
    class Program
    {
        static void Main()
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/07.%20Calculate%203!/README.md
            //input values
            uint n = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());
            //calculate
            BigInteger nFactur = 1;
            BigInteger kFactur = 1;
            BigInteger nkFactur = 1;
            long nMinusK = n - k;
            BigInteger formula = 0;
            for (uint i = 1; true; i++)
            {
                if (!(i > n)) //N!
                {
                    nFactur *= i;
                }
                if (!(i > k)) //K!
                {
                    kFactur *= i;
                }
                if (!(i > (n - k))) //(N-K)!
                {
                    nkFactur *= nMinusK;
                    nMinusK--;
                }
                if ((i > n) && (i > k))
                {
                    formula = nFactur / (kFactur * nkFactur);
                    Console.WriteLine(formula);
                    return;
                }
            }
        }
    }
}
