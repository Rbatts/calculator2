using System;
using System.IO;

namespace ConsoleApp2
{
    public class Logger
    {
        private const string LogFile = @"C:\Work\Logs\Calculator2.txt";

        public Logger()
        {
            if (File.Exists(LogFile))
            {
                File.Delete(LogFile);
            }
        }

        public void LogCalculation(string question, string answer)
        {
            File.AppendAllText(LogFile, string.Format("{0} = {1}{2}", question, answer, Environment.NewLine));
        }

    }

}