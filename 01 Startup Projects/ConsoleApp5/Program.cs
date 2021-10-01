using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(                   "               DICE ROLLER                   ");
            Console.WriteLine();
            PrintColorMessage(ConsoleColor.Blue, "How Many Sides Do You Want Your Dice To Have?");
            Console.WriteLine();

            while (true)
            {
                PrintColorMessage(ConsoleColor.Blue, "Type A Number, Then Press: Enter.");

                string UnPNumber = WrongAnswer();
                int Number = 0;
                Random UnRandom = new Random();

                Number = Int32.Parse(UnPNumber);
              
                int random = UnRandom.Next(1, Number);
               

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your Number Is {0}!", random);
                Console.ResetColor();

                Console.WriteLine();
                PrintColorMessage(ConsoleColor.Yellow, "Do You Want To Roll Again?            Enter   Y or N");
                string RollAgain = Console.ReadLine().ToUpper();

                while (RollAgain != "Y" && RollAgain != "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Please Enter Y or N!");
                    RollAgain = Console.ReadLine().ToUpper();
                }

                if (RollAgain == "Y")
                {
                    continue;
                }

                else
                    break;
            }

                static string WrongAnswer()
                {
           
                    string UnPNumber = Console.ReadLine();
                    int Number = 0;
                  

                    if (UnPNumber == "0")
                    {
                        PrintColorMessage(ConsoleColor.Red, " Please Choose A Number Above 0 !");
                        return WrongAnswer();
                    }

                    if (!int.TryParse(UnPNumber, out Number))
                    {
                        PrintColorMessage(ConsoleColor.Red, " Please Type A Number!");
                        return WrongAnswer();
                    }

                    else
                        return UnPNumber;

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
