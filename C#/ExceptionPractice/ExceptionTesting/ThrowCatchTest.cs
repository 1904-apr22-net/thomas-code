using Xunit;
using System;
using ExceptionTesting;
using ExceptionPractice;

namespace ExceptionTesting
{
    public class ThrowCatchTest

    {
        [Fact]
        public void ExceptTest1()
        {

            var c = new CustomException("test");

            Assert.Throws();


        }
    }
}
