using System;

namespace PalindromeLibrary
{
    public class Palindrome
    {
        bool result = false;
        public bool PalindromeTest(string strInput)
        {
            if (strInput.Length < 2)
            {
                return false;
            }

            strInput = strInput.Replace(" ", "");
            strInput = strInput.Replace(",", "");
            strInput = strInput.Replace(".", "");
            strInput = strInput.ToLower();
            char[] input = strInput.ToCharArray();

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

        }
    }
}
