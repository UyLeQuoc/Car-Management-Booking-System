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
        public IEnumerable<TblBookingDetail> GetListOrderDetail(int carID);
        public IEnumerable<TblBookingDetail> GetListBookingDeatilById(int bookingId);
        public void InsertNewBookingDetail(int carid, int bookingid, double subprice, DateTime bookingDate, DateTime bookingExpired);
    }
}
