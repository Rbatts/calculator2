using Consoleapp2;
using System;

namespace ConsoleApp2
{
    class Program
    {
        enum CalculatorType
        {
            Number = 1,
            Date = 2
        }

        static void Main()
        {
            var logger = new Logger();

            while (true)
            { 
                try
                {
                    PrintWelcomeMessage();
                    CalculatorType calculationMode = AskForCalculationMode();

                    if (calculationMode == CalculatorType.Number)
                    {
                        new NumberCalculator(logger).CalculatorFunction();
                    }
                    else if (calculationMode == CalculatorType.Date)
                    {
                        new DateCalculator(logger).DateFunction();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nPlease Enter 1 or 2 to use the Calculator\n");
                        Console.ResetColor();
                        Console.ReadLine();
                        Console.Clear();

                    }
                }
                catch
                {
                    
                }
            }
        }

        private static void PrintWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWELCOME TO THE CALCULATOR!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
        }

        private static CalculatorType AskForCalculationMode()
        {
            Console.WriteLine("\nPLEASE ENTER\n\n{0} > to use the Calculator mode:", (long)CalculatorType.Number);
            Console.WriteLine("\n{0} > to use the Dates mode:\n", (long)CalculatorType.Date);
            return (CalculatorType)Prompts.AskForNumber("");
        }
    }
}