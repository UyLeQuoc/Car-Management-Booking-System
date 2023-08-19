using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public IEnumerable<TblBooking> FilterBookings(decimal from, decimal to) => BookingDAO.Instance.FilterBookings(from, to);

        public IEnumerable<TblBooking> FindBookingsByBookingID(int bookingID) => BookingDAO.Instance.FindBookingsByBookingID(bookingID);

        public IEnumerable<TblBooking> FindBookingsByUserName(string userName) => BookingDAO.Instance.FindBookingsByUserName(userName);

        public IEnumerable<TblBooking> GetAllBookings() => BookingDAO.Instance.GetAllBookings();
    }
}
