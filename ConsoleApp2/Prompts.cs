using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Prompts
    {
        public static int AskForNumber(string message)
        {
            while (true)
            {
                int? maybeNumber = AskForOptionalNumber(message, out bool terminate);

                if (maybeNumber.HasValue)
                {
                    return maybeNumber.Value;
                }
            }
        }

        public static int? AskForOptionalNumber(string message, out Boolean terminate)
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

                if (!int.TryParse(input, out int number))
                {
                    return null;
                }

                return number;
            }
        }

        public static List<int> UserNumbers(string message)
        {
            Console.WriteLine(message);
            List<int> numbers = new List<int>();
            
            while (true)
            {
                Console.ResetColor();
                int? number = AskForOptionalNumber("\nPlease enter the next number: ", out bool terminate);
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
                    Console.WriteLine("You haven't entered a number\n");
                    Console.ResetColor();
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