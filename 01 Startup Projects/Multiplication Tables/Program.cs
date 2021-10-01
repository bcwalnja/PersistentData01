using System;

namespace Multiplication_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,");
            Console.WriteLine("Time To Practice Your Multiplication Tables!");

            while (true)
            {
                Random iNumber = new Random();
                Random iiNumber = new Random();
                int firstNumber = iNumber.Next(1, 12);
                int secondNumber = iiNumber.Next(1, 12);

                Console.WriteLine("What is {0}x{1}?", firstNumber, secondNumber);
                int correctAnswer = firstNumber * secondNumber;
                string input = Console.ReadLine();
                int guess = 0;

                if (!int.TryParse(input, out guess))
                {
                    input = WrongAnswer();
                    guess = Int32.Parse(input);
                }

                guess = Int32.Parse(input);

                while (guess != correctAnswer)
                {
                    input = WrongAnswer();
                    guess = Int32.Parse(input);
                }

                if (guess == correctAnswer)
                {
                    PrintColorMessage(ConsoleColor.Green, "CORRECT");
                }

                Console.WriteLine();
                PrintColorMessage(ConsoleColor.Yellow, "Do You Want To Play Again?");
                PrintColorMessage(ConsoleColor.Yellow, "Enter               Y or N.");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain != "Y" && playAgain != "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Please Choose Option Y or N!");
                    playAgain = Console.ReadLine().ToUpper();
                }

                if (playAgain == "N")
                {
                    break;
                }

                static string WrongAnswer()
                {
                    PrintColorMessage(ConsoleColor.Red, "Sorry Wrong Answer, Guess Again!");
                    string input = Console.ReadLine();
                    int guess = 0;

                    if (!int.TryParse(input, out guess))
                    {
                        return WrongAnswer();
                    }

                    return input;

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
    
}
