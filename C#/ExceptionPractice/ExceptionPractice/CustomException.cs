using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionPractice
{
    class CustomException : Exception
    {
        public CustomException(string message)
        {
            Console.WriteLine(message);

            TestCatch();
        }
        private static void TestThrow()
        {
            CustomException example = new CustomException("Custome exception in TestThrow()");

            throw example;
        }
        static void TestCatch()
        {
            try
            {
                TestThrow();

            }
            catch (CustomException example)
            {
                Console.WriteLine(example.ToString());
            }
        }
    }
}
