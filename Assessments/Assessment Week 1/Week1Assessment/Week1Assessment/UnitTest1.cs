using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeLibrary;

namespace Week1Assessment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
