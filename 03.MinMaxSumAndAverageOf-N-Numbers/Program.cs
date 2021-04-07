using System;
using System.Linq;
using System.Threading;
using System.Globalization;


class MinMaxSumAndAverageOf_N_Numbers
{
    static void Main()
    { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/03.%20MMSA%20of%20N%20Numbers/README.md

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        //1.how many numbers will be inputted 
        uint numbOfValues = uint.Parse(Console.ReadLine()); 
        //2.values of each N numbers
        double[] arrayOfnNumbers = new double[numbOfValues];  
        for (int i = 0; i < numbOfValues; i++)
        {
            arrayOfnNumbers[i] = double.Parse(Console.ReadLine());
        }
        //3
        double minN = arrayOfnNumbers.Min();           //minimal value of N numbers
        double maxN = arrayOfnNumbers.Max();           //maximal value of N numbers
        double sumN = arrayOfnNumbers.Sum();           //the sum of N numbers
        double avrN = arrayOfnNumbers.Average();       //averave value of N numbers
        //4
        Console.WriteLine("min={0:F2}", minN);
        Console.WriteLine("max={0:F2}", maxN);
        Console.WriteLine("sum={0:F2}", sumN);
        Console.WriteLine("avg={0:F2}", avrN);
    }
}