using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Prompt
    {
        static void main(string[] args)
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
            Console.WriteLine(
                "Please enter\n\n(1) to use the dates mode\n    or   \n(2) to use the Calculator mode.\n");
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

            return true;
        }
    }
}
