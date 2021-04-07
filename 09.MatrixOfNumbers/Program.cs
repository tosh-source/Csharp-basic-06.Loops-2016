using System;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/09.%20Matrix%20of%20Numbers/README.md
            uint n = uint.Parse(Console.ReadLine());
            uint counter = 0;
            for (int row = 1; row <= n; row++)
            {
                for (int cow = row; cow < n + row; cow++)
                {
                    Console.Write(cow);
                    if (cow + 1 < (n + row))
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
