using System;

namespace _16.SpiralMatrix
{
    class Program
    {
        static void Main()
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/Topics/06.%20Loops/homework/17.%20Spiral%20Matrix/README.md

            //input
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int matrixValueCounter = 1;
            int row = 0;
            int col = 0;

            //algorithm
            for (int depth = 0; depth < n; depth++)
            {

                for (int top = col; top < (n - depth); top++)
                {
                    if (matrix[row, top] != 0)
                    {
                        break;
                    }
                    matrix[row, top] = matrixValueCounter;
                    matrixValueCounter++;
                }
                for (int rightSide = row + 1; rightSide < ((matrix.Length / n) - depth); rightSide++)
                {
                    if (matrix[rightSide, ((col + (n - depth * 2)) - 1)] != 0)
                    {
                        break;
                    }
                    matrix[rightSide, ((col + (n - depth * 2)) - 1)] = matrixValueCounter;
                    matrixValueCounter++;
                }
                for (int bottom = (col + (n - depth * 2)) - 2; bottom >= 0; bottom--)   //"((col + (n - depth * 2)) - 1)" --> the last column. 
                {                                                                       //ВАЖНО!: Всъщност "col +.." и "row +.." реално не играят роля в тази част от алгоритъама "((col + (n - depth * 2)) - 1)" --> depth * 2, нулира действието им. Оставени са за улеснение при четене на кода!
                    if (matrix[((row + (n - depth * 2)) - 1), bottom] != 0)
                    {
                        break;
                    }
                    matrix[((row + (n - depth * 2)) - 1), bottom] = matrixValueCounter;
                    matrixValueCounter++;
                }
                for (int leftSide = ((row + (n - depth * 2)) - 2); leftSide > 0; leftSide--)
                {
                    if (matrix[leftSide, col] != 0)
                    {
                        break;
                    }
                    matrix[leftSide, col] = matrixValueCounter;
                    matrixValueCounter++;
                }
                row++;
                col++;
            }
            //print
            for (int rowToPrint = 0; rowToPrint < matrix.GetLength(0); rowToPrint++)
            {
                for (int colToPrint = 0; colToPrint < matrix.GetLength(1); colToPrint++)
                {
                    Console.Write("{0} ", matrix[rowToPrint, colToPrint]);
                }
                Console.WriteLine();
            }
        }
    }
}

//Кратко разяснение:
//
//Прочитаме числото от входа и инициализираме двумерен масив с ширина и дължина равни на входнот число. 
//Декларираме и едно число num което увеличаваме с единица след всяко запълване на клетка от матрицата 
//и го поставяме в следващата клетка. Правим един for цикъл със една променлива depth,  която определя 
//на каква дълбочина в матрицата се намираме. След това със четири for цикъла обхождаме всяка страна 
//на матризата като започваме от най-горе, най-ляво и продължаваме – на дясно, на долу, на ляво и нагоре. 
//След завъртане на четирите цикъла се връщаме във външният цикъл и и увеличаваме дълбочината. При което 
//продължаваме обхождането н аматрицата едно ниво по-надолу. Така обхождаме цялата матрица до самият център. 
//След подреждане на числата в масива го принтираме по стандартният начин със два вложени for цикъла.
