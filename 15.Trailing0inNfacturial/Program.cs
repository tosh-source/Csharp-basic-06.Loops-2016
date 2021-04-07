using System;

namespace _15.Trailing0inNfacturial
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/16.%20Trailing%200%20in%20N!/README.md

            uint n = uint.Parse(Console.ReadLine());
            uint counter = 0;
            uint totalNumbsOf5inNFactur = 5;
            for (uint i = totalNumbsOf5inNFactur; i <= n; i = i * 5)
            {
                counter += n / i;
            }
            Console.WriteLine(counter);
        }
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////
//Explanation of Trailing Zeroes in N!
//====================================
//The simple method (first calculate factorial of number, then count trailing 0s in 
//the result) can cause overflow for a slightly bigger numbers as factorial of a 
//number is a big number.
//The idea is to consider prime factors of a factorial n. A trailing zero is always 
//produced by prime factors 2 and 5. If we can count the number of 5s and 2s, our 
//task is done. We can easily observe that the number of 2s in prime factors is 
//always more than or equal to the number of 5s. So if we count 5s in prime factors, 
//we are done.
//
//How to count total number of 5s in prime factors of n!?
//=======================================================
//A simple way is to calculate floor(n/5). For example, 7! has one 5; 10! has two 5s. But 
//there is one more thing to consider. Numbers like 25, 125, etc have more than one 5. For 
//example if we consider 28!, we get one extra 5 and number of 0s become 6. 
//
//Handling this is simple, first divide n by 5 and remove all single 5s, then divide 
//by 25 to remove extra 5s and so on. Following is the summarized formula for counting trailing 0s.
//
//Trailing 0s in N! = Count of 5s in prime factors of N! ==> Floor(n/5) + Floor(n/25) + Floor(n/125) + ....
//======================================================
///////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////////////////////////////////////////////////////////////////////////////
//БГ-т.е., за всяко покачване 5 (5, 10, 15, 20), зададения N! (факториел) добавя по една нула към резултата. 
//Но при достигайки чистла, които са произведение на 5-ца х 5 (5х5=25, 25х5=125, 125х5=625), освен стандартното 
//добавяне се добавя и ДОПЪЛНИТЕЛНА нула, която освен това РАСТЕ в аритметична прогресия за всяко следващо 
//произведение на 5-цата х 5 (5->+0 ; 25->+00-ли вместо една 0-ла; 125->+000 вместо една 625->+0000 вместо една и т.н.).
///////////////////////////////////////////////////////////////////////////////////////////////////////////
