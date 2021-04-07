using System;
using System.Globalization;
using System.Threading;
using System.Numerics;

class CalculateTheSumOfNandX
{
    static void Main()
    { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/05.%20Calculate!/README.md

        //settings
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //input values
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        //calculate
        double sum = 1;
        BigInteger nFactorial = 1;
        double xPowerOfN = 0;
        for (int i = 1; i <= n; i++)
        {
            nFactorial = nFactorial * i;
            xPowerOfN = (Math.Pow(x, i));
            sum += ((double)nFactorial / xPowerOfN);
        }
        //print
        Console.WriteLine("{0:f5}", sum);
    }
}