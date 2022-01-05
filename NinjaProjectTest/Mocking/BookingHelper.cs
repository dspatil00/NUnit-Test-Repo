using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaProjectTest.Mocking
{
    public class BookingHelper
    {
        // Modifing some code to check 
        // git branch commit 
        // git repository trial


        public static string OverlappingBookingsExist(Booking booking)
        {
            if (booking.Status == "Cancelled")
                return string.Empty;

            var unitOfWork = new UnitOfWork();
            var bookings =
                unitOfWork.Query<Booking>()
                    .Where(
                        b => b.Id != booking.Id && b.Status != "Cancelled");

            var overlappingBooking =
                bookings.FirstOrDefault(
                    b =>
                        booking.ArrivalDate >= b.ArrivalDate
                        && booking.ArrivalDate < b.DepartureDate
                        || booking.DepartureDate > b.ArrivalDate
                        && booking.DepartureDate <= b.DepartureDate);

            return overlappingBooking == null ? string.Empty : overlappingBooking.Reference;
        }

        public class UnitOfWork
        {
            public IQueryable<T> Query<T>()
            {
                return new List<T>().AsQueryable();
            }
        }

        public class Booking
        {
            public string Status { get; set; }
            public int Id { get; set; }
            public DateTime ArrivalDate { get; set; }
            public DateTime DepartureDate { get; set; }
            public string Reference { get; set; }
        }
    }


}
