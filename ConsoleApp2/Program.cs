using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private const int NumberCalculator = 1;
        private const int DateCalculator = 2;


        static void Main(string[] args)
        {
            {
                bool MainMenu = true;
                while (MainMenu == true)
                {
                    MainMenu = Menu();
                }
            }

        }

        public static bool Menu()
        {
            Console.WriteLine("\nWelcome To The Calculator!");
            Console.WriteLine("\nPlease enter\n\n(1) to use the dates mode\n    or   \n(2) to use the Calculator mode.\n");
                string mode = Console.ReadLine();
                while (mode != "1" && mode != "2")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You must enter the mode Dates or Calculator");
                    mode = Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                    return true;
                }
            if (mode == "1")
            {
                new DateCalculator().DateFunction();
            }
            else if (mode == "2")
            {
                new NumberCalculator().CalculatorFunction();
            }

                return true;
        }

        
    }

}