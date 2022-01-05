using System;
using NinjaProjectTest.Fundamentals;
using NUnit.Framework;

namespace NinjaProjectTest.UnitTest
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ShouldReturnNotFound()
        {
            var customer = new CustomerController();

            var result =customer.GetCustomer(0);

            //NotFound Objecct
            Assert.That(result, Is.TypeOf<NotFound>());

            //NotFound Object or One of its derivatives
           // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ShouldReturnOk()
        {
            var customer = new CustomerController();

            var result = customer.GetCustomer(1);

            Assert.That(result, Is.TypeOf<ok>());
        }
    }
}
