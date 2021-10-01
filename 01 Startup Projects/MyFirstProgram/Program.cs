using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();
           
            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage( ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }
                     
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    { 
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT");

                Console.WriteLine("Play Again? [Y or N]");

                string playAgain = PlayAgain();
                if (playAgain == "Y")
                {
                    continue;
                }
                else
                    return;
            }

            static string PlayAgain()
            {
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    return answer;
                }

                else if (answer != "Y" && answer != "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Enter Y or N");
                    return PlayAgain();

                }

                else if (answer == "N")
                {
                    return answer;
                }
 
                else
                {
                    return "N";
                }
            }

            static void GetAppInfo()
            {
                string appName = "Number Guesser";
                string appVersion = "1.0.0";
                string appAuthor = "Brad Traversy";

                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                Console.ResetColor();
            }

            static void GreetUser()
            {
                Console.WriteLine("What is your name?");

                string inputName = Console.ReadLine();

                Console.WriteLine("Hello {0}, let's play a game...", inputName);
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
