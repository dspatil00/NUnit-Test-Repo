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
    public class ReservationTest
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);

            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            var reservation = new Reservation() { MadeBy= new User()};

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);

        }
    }
}
