using System;
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
            //string myString = "42";
            //int myInteger = int.Parse(myString);
            Console.Write("Welcome to the calculator\n");

            Console.Write("Please enter a number\n");
            string uResponse2 = Console.ReadLine();
            int firstNumber = int.Parse(uResponse2);

            Console.Write("Enter your opperator\n");
            string opperator = Console.ReadLine();

            Console.Write("Please enter another number\n");
            string uResponse3 = Console.ReadLine();
            int secondNumber = int.Parse(uResponse3);

            int answer = 0;

            if (opperator == "+")
            {
                answer = (firstNumber + secondNumber);
            }
            else if (opperator == "/")
            {
                answer = (firstNumber / secondNumber);
            }
            else if (opperator == "*")
            {
                answer = (firstNumber * secondNumber);
            }
            else if (opperator == "-")
            {
                answer = (firstNumber - secondNumber);
            }

            Console.WriteLine("Answer");
            Console.WriteLine(answer);
            Console.ReadLine();
        
        }


    }
}
