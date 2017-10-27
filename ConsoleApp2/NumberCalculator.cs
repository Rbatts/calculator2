using ConsoleApp2;
using System;

namespace Consoleapp2
{
    class NumberCalculator
    {
        private Logger logger;

        public NumberCalculator(Logger logger)
        {
            this.logger = logger;
        }
        public void CalculatorFunction()
        {
            try
            {
                Console.Write("\nWelcome to the Calculator mode.\n\nPlease enter your operator\n");
                var opperator = Console.ReadLine();
                while (opperator != "+" && opperator != "-" && opperator != "*" && opperator != "/")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nYou've entered an incorrect operator.\nAn operator should be * / - +");
                    opperator = Console.ReadLine();
                    Console.ResetColor();
                }

                Console.Write("How many numbers do you want to" + " " + opperator + " " + "?");
                var count = int.Parse(Console.ReadLine());

                int[] response = new int[count];

                for (int index = 0; index < count; index++)
                {
                    Console.Write("Please enter number " + (index + 1) + ": ");
                    response[index] = int.Parse(Console.ReadLine());
                }

                int answer = response[0];

                for (int index = 1; index < count; index++)

                        if (opperator == "+")
                        {
                            answer = (answer + response[index]);
                        }
                        else if (opperator == "/")
                        {
                            answer = (answer / response[index]);
                        }
                        else if (opperator == "*")
                        {
                            answer = (answer * response[index]);
                        }
                        else if (opperator == "-")
                        {
                            answer = (answer - response[index]);
                        }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Answer");
                    Console.WriteLine(answer);
                    Console.ResetColor();
                    logger.LogCalculation(string.Join(opperator, response), answer.ToString());
                    Console.ReadLine();

            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I'm sorry you've entered either your numbers or operator incorrectly.\n Remember an operator is either + - / * ");
                Console.ReadLine();
                Console.ResetColor();
            }

            Console.Clear();

        }

    }

}