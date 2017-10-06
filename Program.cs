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

            Console.Write("Please enter a number\n");
            string uResponse = Console.ReadLine();
            int firstNumber = int.Parse(uResponse);

            Console.Write("Please enter another number\n");
            string uResponse2 = Console.ReadLine();
            int secondNumber = int.Parse(uResponse2);

            Console.WriteLine("Answer");
            int answer = firstNumber* secondNumber;
            Console.WriteLine(answer);
            Console.ReadLine();
        }


    }
}
