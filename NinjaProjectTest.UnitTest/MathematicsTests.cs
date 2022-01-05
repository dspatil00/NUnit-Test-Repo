using NinjaProjectTest.Fundamentals;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaProjectTest.UnitTest
{
    [TestFixture]
    public class MathematicsTests
    {
        private Mathematics _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Mathematics();
        }

        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            //var math = new Mathematics();
           var result = _math.Add(10, 5);

            //var expected = 15;
            //Assert.AreEqual(expected, result);           

            Assert.That(result, Is.EqualTo(15));
        }

        #region Parameterized Test
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        #endregion Parameterized Test

        #region MaxMethodTest
        [Test]
        [Ignore("Already tested using Parameterized Test and Test Case Attribute")]
        public void Max_FirstArgIsGreater_ReturnFirstArg()
        {
            //var math = new Mathematics();
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Already tested using Parameterized Test and Test Case Attribute")]
        public void Max_SecondArgIsGreater_ReturnSecondArg()
        {
            //var math = new Mathematics();
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        [Ignore("Already tested using Parameterized Test and Test Case Attribute")]
        public void Max_BothArgAreEqual_ReturnSameArg()
        {
            // var math = new Mathematics();
            var result = _math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        #endregion MaxMethodTest


        [Test]
        public void GetOddNumber_LimitIsGreaterThanZero_ReturnOddNumbersUptoLimit()
        {
           var result = _math.GetOddNumbers(5);

            // More General
            Assert.That(result, Is.Not.Empty);

            //Too Specific
            Assert.That(result.Count(), Is.EqualTo(3));

            //or
            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            //OR
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));
        }

    }
}
