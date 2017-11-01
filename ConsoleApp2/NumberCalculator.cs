using Calculator;
using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var opperator = Prompts.UserOpperator("Please enter the operator: ");
            while (opperator != "+" && opperator != "-" && opperator != "*" && opperator != "/")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou've entered an incorrect operator.\nAn operator should be * / - +");
                opperator = Console.ReadLine();
                Console.ResetColor();
            }
            var response = Prompts.UserNumbers(string.Format("Please enter the numbers to {0}. ", opperator));
            var answer = CalculateAnswer(opperator, response);

            logger.LogCalculation(string.Join(opperator, response), answer.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The answer is: {0}", answer);
            Console.WriteLine();
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        private int CalculateAnswer(string opperator, List<int> response)
        {
            if (opperator == "*")
            {
                return response.Aggregate(1, (acc, number) => acc * number);
            }
            else if (opperator == "/")
            {
                return response.Skip(1).Aggregate(response[0], (acc, number) => acc / number);
            }
            else if (opperator == "+")
            {
                return response.Sum();
            }
            else if (opperator == "-")
            {
                return response.Skip(1).Aggregate(response[0], (acc, number) => acc - number);
            }

            return -1;

        }

    }

}