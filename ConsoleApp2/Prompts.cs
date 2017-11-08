using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Prompts
    {
        public static long AskForNumber(string message)
        {
            while (true)
            {
                long? maybeNumber = AskForOptionalNumber(message, out bool terminate);

                if (maybeNumber.HasValue)
                {
                    return maybeNumber.Value;
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nPlease Enter 1 or 2 to use the Calculator\n");
                    Console.ResetColor();
                }
            }
        }

        public static long? AskForOptionalNumber(string message, out Boolean terminate)
        {
            terminate = false;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    terminate = true;
                    return null;
                }
                if (!long.TryParse(input, out long number))
                {
                    return null;
                }
                return number;
            }
        }

        public static List<long> UserNumbers(string message)
        {
            Console.WriteLine(message);
            List<long> numbers = new List<long>();

            while (true)
            {
                Console.ResetColor();
                long? number = AskForOptionalNumber("\nPlease enter the next number: ", out bool terminate);
                if (terminate)
                {
                    break;
                }
                if (number.HasValue)
                {
                    numbers.Add(number.Value);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou have entered an invalid number.\n\nOr a number that is too large.");
                    Console.ReadLine();
                    numbers = null;
                    Console.Clear();
                }
            }
            return numbers;
        }
        public static string UserOpperator(string message)
        {
            Console.Write(message);
            string opperator = Console.ReadLine();
            return opperator;   
        }
    }
}