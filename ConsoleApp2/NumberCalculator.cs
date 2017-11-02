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
            var opperator = Prompts.UserOpperator("\nPlease enter the operator: ");
            while (opperator != "+" && opperator != "-" && opperator != "*" && opperator != "/")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou've entered an incorrect operator.\nAn operator should be * / - +");
                opperator = Console.ReadLine();
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            var response = Prompts.UserNumbers(string.Format("\nPlease enter the numbers to {0}", opperator));
            var answer = CalculateAnswer(opperator, response);

            logger.LogCalculation(string.Join(opperator, response), answer.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe answer is: {0}", answer);
            Console.WriteLine();
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        private int CalculateAnswer(string opperator, List<int> response)
        {
            switch (opperator)
            {
                case "*":
                return response.Aggregate(1, (acc, number) => acc * number);

                case "/":
                return response.Skip(1).Aggregate(response[0], (acc, number) => acc / number);

                case "+":
                return response.Sum();

                case "-":
                return response.Skip(1).Aggregate(response[0], (acc, number) => acc - number);
               
                    default:
                        throw new InvalidOperatorException(opperator);

            }

        }

    }

}