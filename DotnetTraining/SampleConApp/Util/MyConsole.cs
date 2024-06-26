using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp.Util
{
    internal class MyConsole
    {
        public static void PrintSuccessMessage(string message)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }

        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));
        }
        public static void PrintErrorMessage(string message)
        {
            ConsoleColor old = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }
    }
}
