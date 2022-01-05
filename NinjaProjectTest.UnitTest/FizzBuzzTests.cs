using System;
using NinjaProjectTest.Fundamentals;
using NUnit.Framework;

namespace NinjaProjectTest.UnitTest
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void GetOutput_DivisibleBy5and3_ShouldReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_DivisibleBy5_ShouldReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(20);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_DivisibleBy3_ShouldReturnFizz()
        {
            var result = FizzBuzz.GetOutput(18);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_NotDivisibleBy3or5_ReturnSameStringNumberInput()
        {
            var result = FizzBuzz.GetOutput(22);
            Assert.That(result, Is.EqualTo("22"));

        }

    }
}
