using PalindromeLibrary;
using System;

namespace PalindromeTesterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input to be determined if it is a palidrome or not. ");
            string userInput = Console.ReadLine();

            Palindrome test = new Palindrome();
            bool answer = test.PalindromeTest(userInput);

            if (answer == true)
            {
                Console.WriteLine("The previous user input is a palindrome.");
            }
            else
            {
                Console.WriteLine("The previous user input isn't a palindrome.");
            }
        }
    }
}
