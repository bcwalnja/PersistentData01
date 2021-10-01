using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;

namespace Average_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string unGuid = Guid.NewGuid().ToString();

           // Console.WriteLine(unGuid);

            string guidFolder2 = @"c:\GUID\guidFolder\test.txt";

            File.WriteAllText(guidFolder2, unGuid);

            StreamReader fGuid = new StreamReader(@"c:\GUID\guidFolder\test.txt");

             string line = fGuid.ReadLine();

            Console.WriteLine(line);

            Console.ReadLine();
        }
    }
}
