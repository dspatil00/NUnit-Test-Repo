using System;

using NinjaProjectTest.Fundamentals;
using NUnit.Framework;

namespace NinjaProjectTest.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTest
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShuldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Specific Assert
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase);

            //Too General Assert
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
