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
        public IEnumerable<TblBookingDetail> GetAllBookingDetailExcept(int bookingID, int carID, DateTime expiredDate) => BookingDetailDAO.GetAllBookingDetailExcept(bookingID, carID, expiredDate);

        public IEnumerable<TblBookingDetail> GetBookingDetailsByBookingID(int bookingID) => BookingDetailDAO.GetBookingDetailsByBookingID(bookingID);

        public void UpdateBookingDetail(int bookingID, int carID, DateTime bookingExpired, int returnStatus) => BookingDetailDAO.UpdateBookingDetail(bookingID, carID, bookingExpired, returnStatus);
    }
}
