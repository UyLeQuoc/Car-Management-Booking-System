using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BookingDetailDAO
    {
        private BookingDetailDAO() { }
        private static BookingDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BookingDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public static IEnumerable<TblBookingDetail> GetBookingDetailsByBookingID(int bookingID)
        {
            try
            {
            var context = new CarBookingManagementContext();
                var bookingDetailsList = context.TblBookingDetails.Include(x => x.Car).Where(d => d.BookingId == bookingID);
                return bookingDetailsList;
        }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertNewBookingDetail(int carid, int bookingid, double subprice, DateTime bookingDate, DateTime bookingExpired)
        {
            DateTime BookingDate = bookingDate;
            string formattedBookingDate = BookingDate.ToString("MM-dd-yyyy");
            DateTime BookingExpired = bookingExpired;
            string formattedBookingExpired = BookingExpired.ToString("MM-dd-yyyy");
            var context = new CarBookingManagementContext();
            string query = $"insert into tblBookingDetails\r\n  values ({carid}, {bookingid}, {subprice}, '{formattedBookingDate}', '{formattedBookingExpired}', 0)";
            context.Database.ExecuteSqlRaw(query);
        }

        public IEnumerable<TblBookingDetail> GetListBookingDeatilById(int bookingId)
        {
            var context = new CarBookingManagementContext();
            var listDeatil = context.TblBookingDetails.Include(y => y.Car).Where(x => x.BookingId == bookingId);
            return (listDeatil.ToList());
        }

        public IEnumerable<TblBookingDetail> GetListCarinBookingDetail(int carId)
        {
            var context = new CarBookingManagementContext();
            var listDetail = context.TblBookingDetails.Where(x => x.CarId == carId);
            return listDetail.ToList();
        }

        public static void UpdateBookingDetail(int bookingID, int carID, DateTime bookingExpired, int returnStatus)
        {
            try
            {
                var context = new CarBookingManagementContext();
                TblBookingDetail bookingDetail = context.TblBookingDetails.FirstOrDefault(d => d.BookingId == bookingID && d.CarId == carID);
                bookingDetail.BookingExpired = bookingExpired;
                bookingDetail.ReturnStatus = (short?)returnStatus;
                context.TblBookingDetails.Update(bookingDetail);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static IEnumerable<TblBookingDetail> GetAllBookingDetailExcept(int bookingID, int carID, DateTime expiredDate)
        {
            try
            {
                var context = new CarBookingManagementContext();
                var listResult = context.TblBookingDetails.Where(x => x.CarId == carID && x.BookingId != bookingID && (((DateTime)x.BookingDate).CompareTo(expiredDate)) > 0);
                return listResult;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
