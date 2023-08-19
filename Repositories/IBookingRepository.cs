using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBookingRepository
    {
        public IEnumerable<TblBooking> FilterBookings(decimal from, decimal to);
        public IEnumerable<TblBooking> GetAllBookings();
        public IEnumerable<TblBooking> FindBookingsByUserName(string userName);
        public IEnumerable<TblBooking> FindBookingsByBookingID(int bookingID);

        public void InsertNewBooking(double total, int userid);
        public int GetIdNewBooking();
        public IEnumerable<TblBooking> GetListBooking(int userid);

    }
}
