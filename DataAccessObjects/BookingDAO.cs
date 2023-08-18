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
        private static BookingDAO instance;
        private static object instanceLook = new object();
        public static BookingDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new BookingDAO();
                    }
                    return instance;
                }
            }
        }

        public void InsertNewBooking(double total, int userid)
        {
            DateTime createdDate = DateTime.Now;
            string formattedcreatedDate = createdDate.ToString("MM-dd-yyyy");
            var context = new CarBookingManagementContext();
            string query = $"insert into tblBookings\r\n  values ('{formattedcreatedDate}', {total}, {userid})";
            context.Database.ExecuteSqlRaw(query);
        }

        public int GetIdNewBooking()
        {
            var context = new CarBookingManagementContext();
            var newId = (from tmp in context.TblBookings
                        orderby tmp.BookingId descending
                        select tmp.BookingId).FirstOrDefault();
            return newId;                        
        }
    }
}
