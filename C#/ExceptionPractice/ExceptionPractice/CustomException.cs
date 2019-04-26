using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionPractice
{
    class CustomException : Exception
    {
        public CustomException(string message) :base(message)
        {

            Console.WriteLine(message);
        
        }

    }
}
