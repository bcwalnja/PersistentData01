using System;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                PrintColorMessage(ConsoleColor.DarkYellow, "                 Five Number Average Calculator");
                Console.WriteLine();
                var numbers = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    PrintColorMessage(ConsoleColor.Blue, $"Type Number {i}.      Press Enter.");
                    numbers[i] = GetInput();
                }
                int NumA = numbers[0];
                int NumB = numbers[1];
                int NumC = numbers[2];
                int NumD = numbers[3];
                int NumE = numbers[4];

                int Average = (NumA + NumB + NumC + NumD + NumE) / 5;
                PrintColorMessage(ConsoleColor.Green, $"The Average Of ({NumA}, {NumB}, {NumC}, {NumD}, {NumE}) Is {Average}!");
                PrintColorMessage(ConsoleColor.Green, $"The Average Of ({NumA}, {NumB}, {NumC}, {NumD}, {NumE}) Is {Average}!");

                PrintColorMessage(ConsoleColor.Gray, string.Format("The Average Of ({0}, {1}, {2}, {3}, {4}) Is {5}!", NumA, NumB, NumC, NumD, NumE, Average));

                NumA = 1;
                NumB = 2;

                var v = "The Average Of({0},";

                var x = string.Format(v, NumA);
                var y = string.Format(v, NumB);

                Console.WriteLine(v);
                Console.WriteLine(x);
                Console.WriteLine(y);

                Console.WriteLine("The Average Of(" + NumA + ",");
                Console.WriteLine("The Average Of(" + NumB + ",");

                for (int i = 0; i < 1_000_000; i++)
                {
                    v += i.ToString();
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 1_000_000; i++)
                {
                    
                    sb.Append(i.ToString());
                }

                Console.WriteLine(sb.ToString());

                PrintColorMessage(ConsoleColor.Yellow, "Do You Want To Calculate " +
                    "More Averages?      Enter Y or N.");


                var z = AskTheUserIfTheyWantToPlayAgain();
                if (z)
                {
                    break;
                }

                static int GetInput()
                {
                    string input = Console.ReadLine();
                    int integer = 0;

                    while (!int.TryParse(input, out integer))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please Enter A Number!");
                        input = Console.ReadLine();
                    }
                    return integer;
                }

                static void PrintColorMessage(ConsoleColor color, string message)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(message);
                    Console.ResetColor();
                }
            }
        }

        private static bool AskTheUserIfTheyWantToPlayAgain()
        {
            return true;
            //string PlayAgain = Console.ReadLine().ToUpper();

            //while (PlayAgain != "Y" && PlayAgain != "N")
            //{
            //    PrintColorMessage(ConsoleColor.Red, "Please Enter Y or N!");
            //    PlayAgain = Console.ReadLine().ToUpper();
            //}

            //if (PlayAgain == "Y")
            //{
            //    continue;
            //}

            //else
            //    break;
        }
    }
}
