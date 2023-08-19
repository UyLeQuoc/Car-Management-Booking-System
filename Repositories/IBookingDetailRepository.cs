using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBookingDetailRepository
    {
        public IEnumerable<TblBookingDetail> GetBookingDetailsByBookingID(int bookingID);

        public IEnumerable<TblBookingDetail> GetAllBookingDetailExcept(int bookingID, int carID, DateTime expiredDate);

        public void UpdateBookingDetail(int bookingID, int carID, DateTime bookingExpired, int returnStatus);

    }
}
