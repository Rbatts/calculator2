using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class DateCalculator
    {
        public void DateFunction()
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
    }  
}
