using System;
using NinjaProjectTest.Fundamentals;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NinjaProjectTest.UnitTest
{
    [TestFixture]
    public class DemeritPointsTests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var cal = new DemeritPointsCalculator();
            Assert.That(() => cal.CalculateDemeritPoints(speed), 
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }   

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed,int expectedResult)
        {
            var cal = new DemeritPointsCalculator();

            var result = cal.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));

        }

        
    }
}
