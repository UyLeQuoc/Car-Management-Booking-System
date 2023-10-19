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
        public IEnumerable<TblBookingDetail> GetListBookingDeatilById(int bookingId)
        {
            return BookingDetailDAO.Instance.GetListBookingDeatilById(bookingId);
        }
        public IEnumerable<TblBookingDetail> GetAllBookingDetailExcept(int bookingID, int carID, DateTime expiredDate) => BookingDetailDAO.GetAllBookingDetailExcept(bookingID, carID, expiredDate);

        public IEnumerable<TblBookingDetail> GetBookingDetailsByBookingID(int bookingID) => BookingDetailDAO.GetBookingDetailsByBookingID(bookingID);
        public IEnumerable<TblBookingDetail> GetListOrderDetail(int carID)
        {
            return BookingDetailDAO.Instance.GetListCarinBookingDetail(carID);
        }

        public void UpdateBookingDetail(int bookingID, int carID, DateTime bookingExpired, int returnStatus) => BookingDetailDAO.UpdateBookingDetail(bookingID, carID, bookingExpired, returnStatus);
        public void InsertNewBookingDetail(int carid, int bookingid, double subprice, DateTime bookingDate, DateTime bookingExpired)
        {
            BookingDetailDAO.Instane.InsertNewBookingDetail(carid, bookingid, subprice, bookingDate, bookingExpired);
        }

        public TblBookingDetail checkCarIsBooked(int carId) => BookingDetailDAO.checkCarIsBooked(carId);
    }
}
