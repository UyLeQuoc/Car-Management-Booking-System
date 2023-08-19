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
        public int GetIdNewBooking()
        {
            return BookingDAO.Instance.GetIdNewBooking();
        }

        public IEnumerable<TblBooking> GetListBooking(int userid)
        {
           return BookingDAO.Instance.GetListBooking(userid);
        }

        public void InsertNewBooking(double total, int userid)
        {
            BookingDAO.Instance.InsertNewBooking(total, userid);
        }

    }
}
