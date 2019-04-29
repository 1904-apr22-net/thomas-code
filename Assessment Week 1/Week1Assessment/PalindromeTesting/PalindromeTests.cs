using PalindromeLibrary;
using System;
using Xunit;

namespace PalindromeTesting
{
    public class PalindromeTests

    {
        [Fact]
        public void charCount()
        {
            var c = new Palindrome();           

            var result = c.PalindromeTest(" ");

            Assert.False(result);

        }

        [Theory]
        [InlineData("nurses run")]
        [InlineData("racecaR")]
        [InlineData("1221")]
        [InlineData("never odd, or even.")]
        public void isPalindrome(string testInput)
        {
            var c = new Palindrome();

            bool palinResult = c.PalindromeTest(testInput);

            Assert.True(palinResult);


        }

        [Theory]
        [InlineData("nurses walk")]
        [InlineData("racecaRs")]
        [InlineData("122134")]
        [InlineData("never odds, or evens.")]
        public void isntPalindrome(string testInput)
        {
            var c = new Palindrome();

            bool palinResult = c.PalindromeTest(testInput);

            Assert.False(palinResult);


        }
    }
}
