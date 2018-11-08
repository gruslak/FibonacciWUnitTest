using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void First2NumbersAreCorrect()
        {
            Fibonacci sut = new Fibonacci(); //sut = subject under test

            var numbers = sut.GetFirstNNumbers(2);

            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(1, numbers[1]);
        }
        [TestMethod]
        public void First4NumbersAreCorrect()
        {
            Fibonacci sut = new Fibonacci();

            var numbers = sut.GetFirstNNumbers(4);

            Assert.AreEqual(1, numbers[0]);
            Assert.AreEqual(1, numbers[1]);
            Assert.AreEqual(2, numbers[2]);
            Assert.AreEqual(3, numbers[3]);

        }
    }
}
