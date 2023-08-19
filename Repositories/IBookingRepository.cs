using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBookingRepository
    {
        public void InsertNewBooking(double total, int userid);
        public int GetIdNewBooking();
        public IEnumerable<TblBooking> GetListBooking(int userid);
    }
}
