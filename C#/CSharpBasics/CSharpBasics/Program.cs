using System;

// namespace is just address to a collection of classes
// usual convention is, to have your namespace match your folder structure
namespace CSharpBasics
{
    // a class "Program"
    // in vs ctrl + k, ctrl + c for comments. ctrl + k, ctrl + u for uncomments
    // in vs code ctrl + / for both
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //variables and types
            //(type) (new name) = (value)
            string s = "abc";
            s = "cba";

            // declaration of the variable
            String s2;
            // the initializationi of the variable
            // (giving it its initial value)
            s2 = "a";

            //numeric types
            // integer types (default to use)
            // int (4 byte0
            // byte (1), short (2), long (8)

            // decimal types
            // double (8 bytes) (default to use)
            // float (4)
            // the benefit of the higher memory of double
            // .. we can store more precision, about 15 decimal places

            // boolean
            bool b = true;
            b = false;

            //boolean operators
            b = true || true; // OR
            b = false && true; //AND

            // comparison operators
            b = (3 == 3); //equals
            b = (3 != 3); //not equals
            b = (3 < 3); //less than or greater than
            b = (3 <= 3); //less than or equal to

            // conditional
            if 3 <= 4 








            // loops
            // a for loop, using a loop variable "num", that runs 10 times.
            for (int num = 0; num < 10; num++)
                {
                    // this code runs 10 times
                    Console.WriteLine(num); // print out 0 - 9


                }

            while (b)
            {
                // this code runs many times son long as the condition is true
            }

            switch (s)
            {
                case "1":
                    // do something
                    break;
                case "abc":
                    break;
                default:
                    break;
            }

            //in C# we can put plenty of thiings in switch statement
            // it will compare with ==

            AnotherMethod();
        }

        // (modifiers) (return type) (method nme) in parents, the parameters)
        static void AnotherMethod()
        {
            // extract some code out to another reusable function.
        }
    }
}
