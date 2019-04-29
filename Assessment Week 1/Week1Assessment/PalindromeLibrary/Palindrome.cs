using System;

namespace PalindromeLibrary
{
    public class Palindrome
    {
        bool result = false;
        public bool PalindromeTest(string strInput)
        {
            strInput.Replace(" ", "");
            strInput.Replace(",", "");
            strInput.Replace(".", "");
            strInput.Replace("'", "");
            strInput.Replace("?", "");
            strInput.Replace("!", "");
            strInput.ToLower();
            char[] input = strInput.ToCharArray();

         //   if (input.length % 2 = 0)
         //   {
         //       for (int i = 0; i < (input.length / 2); i++)
         //       {
         //           if (input[i] == input[(input.length/2) + i])                   //i commented this part out because i think the other test will handle evens and odd inputs
         //           {
          //              result = true;
         //           }
         //           else
         //           {
          //              return false;
         //           }
         //       }
         //   }

         //   else
         //   {
                for (int i = 0; i < ((input.Length / 2) - input.Length % 2); i++)
                {
                    if (input[i] == input[((input.Length) - (i + 1))])
                    {
                        result = true;
                    }
                    else
                    {
                        return false;
                    }
                }
            return result;
         //}

        }
    }
}
