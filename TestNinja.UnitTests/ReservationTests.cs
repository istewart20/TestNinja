using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminUser_ReturnsTrue()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_UserWhoMadeReservation_ReturnsTrue()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            var result = reservation.CanBeCancelledBy(user);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnyOtherUser_ReturnsFalse()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}