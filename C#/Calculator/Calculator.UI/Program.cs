using System;

namespace Calculator.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;                                //intialize
            

            Console.WriteLine("Please enter a number");
            num = int.Parse(Console.ReadLine());   // get input

            Calculator Calc = new Calculator();   // create calculator

            Calc.Calculate(num);                // run calculator

        }

       
    }
}

