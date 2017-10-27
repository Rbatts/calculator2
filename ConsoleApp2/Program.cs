using ConsoleApp2;
using System;

namespace Consoleapp2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var logger = new Logger();
                bool MainMenu = true;
                while (MainMenu == true)
                {
                    MainMenu = Menu(logger);
                }
            }
        }
        public static bool Menu(Logger logger)
        {
            Console.WriteLine("\nWelcome To The Calculator!");
            Console.WriteLine("\nPlease enter\n\n(1) to use the dates mode\n    or   \n(2) to use the Calculator mode.\n");
                string mode = Console.ReadLine();
                while (mode != "1" && mode != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You must enter the mode Dates or Calculator");
                    mode = Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                    return true;
                }
            if (mode == "1")
            {
                new DateCalculator(logger).DateFunction();
            }
            else if (mode == "2")
            {
                new NumberCalculator(logger).CalculatorFunction();
            }
                return true;
        }  

    }

}