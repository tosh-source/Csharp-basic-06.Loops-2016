using System;
using System.Collections.Generic;
using System.Linq;


class PrintADeckOf52Cards
{
    static void Main()
    { //условие: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/04.%20Print%20a%20Deck/README.md

        //input values and check type
        string userValue = Console.ReadLine();
        int userValueAsInt = 0;
        int maxCardToPrint = 0;
        if (int.TryParse(userValue, out userValueAsInt))
        {
            maxCardToPrint = (userValueAsInt - 1) * 4;
        }
        else
        {
            switch (userValue)
            {
                case "J": maxCardToPrint = 40; break;
                case "Q": maxCardToPrint = 44; break;
                case "K": maxCardToPrint = 48; break;
                case "A": maxCardToPrint = 52; break;
            }
        }
        //algorithm and results
        int rankOfCards = 0;
        int colorOfCards = 1;

        for (int i = 1; i <= maxCardToPrint; i++)
        {   //1.Rank of Cards
            rankOfCards = i;
            switch (rankOfCards)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.Write("2 ");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                    Console.Write("3 ");
                    break;
                case 9:
                case 10:
                case 11:
                case 12:
                    Console.Write("4 ");
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                    Console.Write("5 ");
                    break;
                case 17:
                case 18:
                case 19:
                case 20:
                    Console.Write("6 ");
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                    Console.Write("7 ");
                    break;
                case 25:
                case 26:
                case 27:
                case 28:
                    Console.Write("8 ");
                    break;
                case 29:
                case 30:
                case 31:
                case 32:
                    Console.Write("9 ");
                    break;
                case 33:
                case 34:
                case 35:
                case 36:
                    Console.Write("10 ");
                    break;
                case 37:
                case 38:
                case 39:
                case 40:
                    Console.Write("J ");
                    break;
                case 41:
                case 42:
                case 43:
                case 44:
                    Console.Write("Q ");
                    break;
                case 45:
                case 46:
                case 47:
                case 48:
                    Console.Write("K ");
                    break;
                case 49:
                case 50:
                case 51:
                case 52:
                    Console.Write("A ");
                    break;
            }
            //2.Color of Cards
            if (colorOfCards > 4)
            {
                colorOfCards = 1;
            }
            switch (colorOfCards)
            {
                case 1:
                    Console.Write("of spades, ");
                    break;
                case 2:
                    Console.Write("of clubs, ");
                    break;
                case 3:
                    Console.Write("of hearts, ");
                    break;
                case 4:
                    Console.Write("of diamonds\n");
                    break;
            }
            colorOfCards++;
        }
    }
}
