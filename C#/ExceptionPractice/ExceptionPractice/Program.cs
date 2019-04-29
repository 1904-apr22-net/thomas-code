using System;

namespace ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TestCatch();            
        }

        private static void TestThrow()
        {
            CustomException example = new CustomException("Custome exception in TestThrow()");

            throw example;
        }
        public static void TestCatch()
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

        public static void TestFinally()
        {
            
        }

    }
}
