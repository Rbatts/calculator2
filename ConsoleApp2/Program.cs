using Consoleapp2;
using ConsoleApp2;
using System;
namespace Calculator
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You must enter the mode Dates or Calculator");
                        Console.ReadLine();
                        Console.ResetColor();
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
            Console.WriteLine("\nWelcome To The Calculator!");
            Console.WriteLine("\n--------------------------");
            Console.ResetColor();
        }

        private static CalculatorType AskForCalculationMode()
        {
            Console.WriteLine("\nPlease Enter\n\n{0} > to use the Calculator mode:\n", (int)CalculatorType.Number);
            Console.WriteLine("\n{0} > to use the Dates mode:\n", (int)CalculatorType.Date);
            return (CalculatorType)Prompts.AskForNumber("");
        }
    }
}