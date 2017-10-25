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
        static void Main(string[] args)
        {
            bool MainMenu = true;
            while (MainMenu == true)
            {
                MainMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.WriteLine("Please enter\n\n(1) to use the dates mode\n    or   \n(2) to use the Calculator mode.\n");
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
            if (mode == "2")
            {
                try
                {
                    Console.Write("\nWelcome to the Calculator mode.\n\nPlease enter your operator\n");
                    string opperator = Console.ReadLine();
                    while (opperator != "+" && opperator != "-" && opperator != "*" && opperator != "/")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nYou've entered an incorrect operator.\nAn operator should be * / - +");
                        opperator = Console.ReadLine();
                        Console.ResetColor();
                    }

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
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("I'm sorry you've entered either your numbers or operator incorrectly.\n Remember an operator is either + - / * ");
                    Console.ReadLine();
                    Console.ResetColor();
                }
                
                Console.Clear();
            }
            else if (mode == "1")
            {
                try
                {
                    Console.WriteLine("\nPlease enter your date in the format dd/mm/yyyy.\n");
                    string responsedatetime = Console.ReadLine();
                    DateTime dt = Convert.ToDateTime(responsedatetime);

                    Console.Write("\nHow many days do you want to add to" + " " + responsedatetime + "?\n");
                    string dateadded = Console.ReadLine();
                    DateTime dt2 = dt.AddDays(Convert.ToInt32(dateadded));

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nNew Date");
                    Console.WriteLine(dt2);
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nI'm sorry there has been an error.\n\nMake sure you enter the date in this format dd/mm/yyyy.\n\nAnd please select a digit for your date to add.");
                    Console.ReadLine();
                    Console.ResetColor();
                    Console.Clear();
                }
            }
            return true;

        }

    }

}