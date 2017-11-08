using ConsoleApp2;
using System;

namespace Consoleapp2
{
    class DateCalculator
    {
        private Logger logger;
        public DateCalculator(Logger logger)
        {
            this.logger = logger;
        }
        public void DateFunction()
        {
             try
             {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDATES MODE:\n\nNow enter your date in the format dd/mm/yyyy.\n");
                Console.ResetColor();
                string responsedatetime = Console.ReadLine();
                DateTime dt = Convert.ToDateTime(responsedatetime);


                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nHow many days do you want to add to" + " " + responsedatetime + "?\n\n");
                Console.ResetColor();
                string dateadded = Console.ReadLine();
                DateTime dt2 = dt.AddDays(Convert.ToInt32(dateadded));


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNew Date");
                Console.WriteLine(dt2);
                logger.LogCalculation($"{responsedatetime:dd/MM/yyyy} + {dateadded}", dt2.ToString("dd/MM/yyyy"));
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
             }
             catch
             {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nMake sure you enter the date in this format { dd/mm/yyyy }.\n\nAnd please select a digit for your date to add.");
                Console.ResetColor();
                Console.ReadLine();
                Console.Clear();
             }
        }
    }  
}