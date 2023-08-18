using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        public IEnumerable<TblBookingDetail> GetListOrderDetail(int carID)
        {
            return BookingDetailDAO.Instance.GetListCarinBookingDetail(carID);
        }

        public void InsertNewBookingDetail(int carid, int bookingid, double subprice, DateTime bookingDate, DateTime bookingExpired)
        {
            BookingDetailDAO.Instance.InsertNewBookingDetail(carid, bookingid, subprice, bookingDate, bookingExpired);
        }
    }
}
