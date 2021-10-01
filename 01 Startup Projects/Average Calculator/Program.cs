using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Average_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintColorMessage(ConsoleColor.Blue, "                     THE AVERAGE CALCULATOR");
            Console.WriteLine();

            while (true)
            {
                PrintColorMessage(ConsoleColor.Yellow, "Type A List Of Numbers You Would Like To Average, Seperated By Spaces.");

                double avg  = CheckAnswer();
                static double CheckAnswer()
                {
                    string A = Console.ReadLine();

                    if (string.IsNullOrEmpty(A))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please Enter Numbers!");
                        return CheckAnswer();
                    }
               
                    var numbers = Regex.Matches(A, @"[0-9]+").OfType<Match>().Select(m => m.Groups[0].Value).ToArray();

                    int[] ints = Array.ConvertAll(numbers, s => int.Parse(s));

                    if (ints == null || ints.Length == 0)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please Enter Numbers!");
                        return CheckAnswer();
                    }

                    double avg = ints.Average();

                    return avg;
                }

                PrintColorMessage(ConsoleColor.Green, $"Your AVG. Is {avg}!");                   
                
                PrintColorMessage(ConsoleColor.Yellow, "Do You Want To Calculate More Averages   Enter Y or N");

                string YorN = Console.ReadLine().ToUpper();

                while(YorN != "Y" && YorN != "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Please Enter Y or N!");
                    YorN = Console.ReadLine().ToUpper();
                }

                switch (YorN)
                {
                    case "Y":
                        continue;
                    case "N":
                        break;
                }
                break;
            }
         
            static void PrintColorMessage(ConsoleColor color, string message)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }
    }
}
