using System;

namespace ConsoleApp2
{
    public class InvalidOperatorException : Exception
    {
        public InvalidOperatorException(string opperator) : base(string.Format("The operation {0} is not supported.", opperator))
        {
         
        }
    }
}