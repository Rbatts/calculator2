﻿using ConsoleApp2;
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
            Console.ForegroundColor = ConsoleColor.Green;
            var opperator = Prompts.UserOpperator("\nCALCULATOR MODE:\n\nPlease enter the operator: ");
            Console.ResetColor();
            while (opperator != "+" && opperator != "-" && opperator != "*" && opperator != "/")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nYou've entered an incorrect operator.\nAn operator should be * / - +");

                opperator = Console.ReadLine();
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            var response = Prompts.UserNumbers($"\nPlease enter the numbers to {opperator}");
            Console.ResetColor();
            var answer = CalculateAnswer(opperator, response);

            logger.LogCalculation(string.Join(opperator, response), answer.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThe answer is: {0}", answer);
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        private long CalculateAnswer(string opperator, List<long> response)
        {
            switch (opperator)
            {
                case "*":
                return response.Skip(1).Aggregate(response[0], (acc, number) => acc * number);

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