using System;

namespace _15.GCD //Greatest Common Divisor 
{
    class Program
    {
        static void Main(string[] args)
        {   //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/15.%20GCD/README.md
            //решение по алгоритъма на Евклид (Euclidean): https://en.wikipedia.org/wiki/Euclidean_algorithm
            //input
            string[] fromUser = Console.ReadLine().Split(' ');
            long a = Math.Abs(long.Parse(fromUser[0])); //Math.Abs() if some of input values is negative
            long b = Math.Abs(long.Parse(fromUser[1]));

            //algorithm --> dividend / divisor = result + remainder
            long dividend = Math.Max(a, b); //bigger of "a" and "b"
            long divisor = Math.Min(a, b);  //smaller of "a" and "b"
            long remainder = 1;
            long result = 0;
            while (true)
            {
                if (remainder == 0)
                {
                    Console.WriteLine(result);
                    return;
                }
                remainder = dividend % divisor;
                dividend = divisor;
                result = divisor;
                divisor = remainder;
            }
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////////
//Worked example --> from wikipedia(see link above)
//=================================================
//For illustration, the Euclidean algorithm can be used to find the greatest common 
//divisor of a = 1071 and b = 462. To begin, multiples of 462 are subtracted 
//from 1071 until the remainder is less than 462. Two such multiples can be 
//subtracted (q0 = 2), leaving a remainder of 147:
//
//    1071 = 2 × 462 + 147.
//
//Then multiples of 147 are subtracted from 462 until the remainder is less 
//than 147. Three multiples can be subtracted (q1 = 3), leaving a remainder of 21:
//
//    462 = 3 × 147 + 21.
//
//Then multiples of 21 are subtracted from 147 until the remainder is less 
//than 21. Seven multiples can be subtracted (q2 = 7), leaving no remainder:
//
//    147 = 7 × 21 + 0.
//
//Since the last remainder is zero, the algorithm ends with 21 as the greatest 
//common divisor (GCD) of 1071 and 462. This agrees with the gcd(1071, 462) found by 
//prime factorization above. In tabular form, the steps are
//////////////////////////////////////////////////////////////////////////////////////