using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BookingDAO
    {
        private BookingDAO() { }
        private static BookingDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BookingDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BookingDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblBooking> GetAllBookings() {
            var context = new CarBookingManagementContext();
            var bookings = context.TblBookings.Include(x => x.User);
            return bookings;
        }
        public void InsertNewBooking(double total, int userid)
        {
            try
            {
            DateTime createdDate = DateTime.Now;
            string formattedcreatedDate = createdDate.ToString("MM-dd-yyyy");
            var context = new CarBookingManagementContext();
               
            string query = $"insert into tblBookings\r\n  values ('{formattedcreatedDate}', {total}, {userid})";
            context.Database.ExecuteSqlRaw(query);
        }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblBooking> FindBookingsByUserName(string userName)
        {
            try
            {
                var context = new CarBookingManagementContext();
                var bookings = context.TblBookings.Include(x => x.User).Where(u => u.User.FullName.ToLower().Contains(userName.Trim().ToLower()));
                return bookings;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblBooking> FindBookingsByBookingID(int bookingID)
        {
            try
        {
            var context = new CarBookingManagementContext();
                var bookings = context.TblBookings.Include(x => x.User).Where(u => u.BookingId == bookingID);
                return bookings;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblBooking> FilterBookings(decimal from, decimal to)
        {
            try
        {
            var context = new CarBookingManagementContext();
                IEnumerable<TblBooking> bookingsList = null;
                if (to == -100)
                {
                    bookingsList = context.TblBookings.Include(x => x.User).Where(x => x.TotalPrice >= from);
                }
                else if (from == -100)
                {
                    bookingsList = context.TblBookings.Include(x => x.User).Where(x => x.TotalPrice <= to);
                }
                else
                {
                    bookingsList = context.TblBookings.Include(x => x.User).Where(x => x.TotalPrice >= from && x.TotalPrice <= to);
                }
                return bookingsList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int GetIdNewBooking()
        {
            var context = new CarBookingManagementContext();
            var newId = (from tmp in context.TblBookings
                         orderby tmp.BookingId descending
                         select tmp.BookingId).FirstOrDefault();
            return newId;
        }

        public IEnumerable<TblBooking> GetListBooking(int userid)
        {
            var context = new CarBookingManagementContext();
            var listBooking = context.TblBookings;
            return listBooking;
        }
    }
}
