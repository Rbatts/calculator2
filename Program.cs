﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the calculator\n");

            Console.Write("Enter your opperator\n");
            string opperator = Console.ReadLine();

            Console.Write("How many numbers do you want to" + " " + opperator + " " + "?");
            int count = int.Parse(Console.ReadLine());

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

            Console.WriteLine("Answer");
            Console.WriteLine(answer);
            Console.ReadLine();
        
        }


    }
}
