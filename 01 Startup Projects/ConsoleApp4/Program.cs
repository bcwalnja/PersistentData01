using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Calculator");
            Console.WriteLine();
            Console.WriteLine("Enter a Number");

            while (true)
            {
                 string number = Console.ReadLine();

                 float correctNumber = 0;

                 while (!float.TryParse(number, out correctNumber))
                 {
                     Warning();
                     number = Console.ReadLine();
                 }

                 correctNumber = float.Parse(number);
               
                Console.WriteLine("Enter a Second Number");

                string entry = Console.ReadLine();

                float correctEntry = 0;

                while (!float.TryParse(entry, out correctEntry))
                {
                    Warning();
                    entry = Console.ReadLine();
                }

                correctEntry = float.Parse(entry);

                Console.WriteLine("     Choose one of these options");
                Console.WriteLine("                     a. Add");
                Console.WriteLine("                     b. Subtract");
                Console.WriteLine("                     c. Multiply");
                Console.WriteLine("                     d. Divide");

                string oper = Console.ReadLine().ToUpper();
                
                while (oper != "A" && oper != "B" && oper != "C" && oper != "D")
                {
                    WarningTwo();
                    oper = Console.ReadLine().ToUpper();
                }

                if (oper == "A")
                {
                    float aAnswer = correctNumber + correctEntry;
                    Console.WriteLine("The answer is {0}", aAnswer);
                }

                if (oper == "B")
                {
                    float bAnswer = correctNumber - correctEntry;
                    Console.WriteLine("The answer is {0}", bAnswer);

                }

                if (oper == "C")
                {
                    float cAnswer = correctNumber * correctEntry;
                    Console.WriteLine("The answer is {0}", cAnswer);
                }

                if (oper == "D")
                {
                    float dAnswer = correctNumber / correctEntry;
                    Console.WriteLine("The answer is {0}", dAnswer);
                }

                Console.WriteLine();
                Console.WriteLine("Do You Want To Calculate More Numbers?");
                Console.WriteLine("Enter    Y or N");
                string answer = Console.ReadLine().ToUpper();

                while(answer != "Y" && answer !="N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Choose An Option");
                    Console.ResetColor();

                    answer = Console.ReadLine().ToUpper();
                }

                if (answer == "N")
                {
                    break;
                }

                if (answer == "Y")
                {
                    Console.WriteLine("Enter A Number");
                    continue;
                }

            }

            static void Warning()
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Please Use Number");

                Console.ResetColor();

            }

            static void WarningTwo()
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Please Choose An Option");

                Console.ResetColor();

            }
        }
    }
}
