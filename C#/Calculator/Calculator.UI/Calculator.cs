using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.UI
{
    public class Calculator
    {
        public void Calculate(int n)         //define calculate method and note that it gets an integer passed to it
        {

            for (int X = n; X >= 1; X--)   //run through n to 1
            {

                if (X % 3 == 0)            // test to see if a number is a multiple of 3. if a numer is a multiple                                         
                {                           // of 3 it advances to the write statement, otherwise it'll get skipped.
                    Console.WriteLine(X);  // output is the multiple of 3
                }
            }

        }

    }
}
