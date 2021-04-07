using System;
using System.Numerics;

class CalculateNandK
{
    static void Main()
    { //Условието на тази задача е от сезон 2015: https://github.com/TelerikAcademy/CSharp-Part-1/blob/2015/6.%20Loops/README.md
        Console.Title = "simple program";
        //1
        Console.WriteLine("Please enter \'N\' and \'K\' value in this range: 1 < k < n < 100");
        Console.Write("Please enter \'N\': ");
        uint n = 0;
        string nAsString = Console.ReadLine();
        bool tryparseCheckN = uint.TryParse(nAsString, out n);
        Console.Write(tryparseCheckN ? "" : "Invalid value of \'N\'! Please start program again!\n");

        Console.Write("Please enter \'K\': ");
        uint k = 0;
        string kAsString = Console.ReadLine();
        bool tryparseCheckK = uint.TryParse(kAsString, out k);
        Console.Write(tryparseCheckK ? "" : "Invalid value of \'K\'! Please start program again!\n");

        if ((k == 0) || (k > n))
        {
            Console.WriteLine("\nError!!! \n1th - K and/or N is equal to \'0\'!\n2nd - K is equal or bigger than N! \nPlease start program again!");
            return;
        }
        //2
        BigInteger nFactur = 1;
        BigInteger kFactur = 1;
        BigInteger nDivideK = 0;
        for (uint i = 1; i < 100; i++)
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
                Console.WriteLine("N!/K! = {0}", nDivideK);
                return;
            }
        }
    }
}
