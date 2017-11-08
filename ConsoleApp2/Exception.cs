using System;

namespace ConsoleApp2
{
    public class InvalidOperatorException : Exception
    {
        public InvalidOperatorException(string opperator) : base($"The operation {opperator} is not supported.")
        {
         
        }
    }
}