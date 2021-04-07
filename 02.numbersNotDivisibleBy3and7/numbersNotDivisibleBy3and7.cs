using System;


class numbersNotDivisibleBy3and7
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else if (i % 7 == 0)
            {
                continue;
            }
            else
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}
