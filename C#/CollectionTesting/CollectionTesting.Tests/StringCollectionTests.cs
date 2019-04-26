using CollectionTesting.Library;
using System;
using Xunit;

namespace CollectionTesting.Tests
{
    // in xUnit, each test is one method, marked with an attribute, either [Fact] or [Theory]
    public class StringCollectioniTests
    {
        [Fact]
        public void CtorZeroThrowsNoExceptions()
        {
            // three steps to a good unit test
            //1. arrange

            //2. act (the behavior you are testing
            var C = new StringCollection();

            //3. assert (verify the behavior was correct
        }

        [Fact]
        public void AddShoulAdd()
        {
            //arrange
            var c = new StringCollection();

            //act
            c.Add("abc");

            //assert
            var value = c[0];
            Assert.Equal("abc", value);
        }


        [Fact]
        public void isStringAlphabatizedShouldReturnFalse()
        {
            // arrange
            StringCollection c = new StringCollection();
            c.Add("cba");

            // act
            var result = c.isAlphabaticOrder();

            // assert
            Assert.False(result);
        }

        [Fact]
        public void isStringAlphabatizedShouldReturnTrue()
        {
            // arrange
            StringCollection c = new StringCollection();
            c.Add("abc");

            // act
            var result = c.isAlphabaticOrder();

            // assert
            Assert.True(result);
        }

        [Fact]

        public void isStringUpperShouldTrue()
        {
            // arrange
            StringCollection c = new StringCollection();
            c.Add("ABC");

            // act
            var result = c.isStringUpper();

            // assert
            Assert.True(result);
        }

        [Fact]
        public void isStringUpperShouldFalse()
        {
            // arrange
            StringCollection c = new StringCollection();
            c.Add("AbC");

            // act
            var result = c.isStringUpper();

            // assert
            Assert.False(result);
        }

        [Fact]
          public void GetLongestStringShouldBeCorrect()
        {
              var c = new StringCollection();
              c.Add("ab");
              c.Add("abc");

              var result = c.GetLongestString();

              Assert.Equal("abc", result);
           }

        [Fact]
        public void GetLongestStringWithEmptyShouldReturnNull()
        {
            // arrange
            var c = new StringCollection();

            // act
            var result = c.GetLongestString();

            // assert
            Assert.Null(result);
        }

        [Theory]
        [InlineData("abc", "abc", "ab")]
        [InlineData(null)] // duplicating the above test
        [InlineData("a", "a", "b")]
        [InlineData("abc", "a", null, "abc")]
        public void GetLongestStringShouldBeCorrectTheory(string longest, params string[] values)
        {
            // arrange
            var c = new StringCollection(values);

            // act
            var result = c.GetLongestString();

            // assert
            Assert.Equal(longest, result);
        }

        [Fact]
        public void RemoveShortestRemovesShortest()
        {
            var c = new StringCollection();
            c.RemoveShortest();
        }


    }

}
