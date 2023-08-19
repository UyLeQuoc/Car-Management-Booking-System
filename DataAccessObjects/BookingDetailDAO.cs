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
        private static BookingDetailDAO instance;
        private static object instanceLook = new object();
        public static BookingDetailDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new BookingDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblBookingDetail> GetListCarinBookingDetail(int carId)
        {
            var context = new CarBookingManagementContext();
            var listDetail = context.TblBookingDetails.Where(x => x.CarId == carId);
            return listDetail.ToList();
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
    }
}
