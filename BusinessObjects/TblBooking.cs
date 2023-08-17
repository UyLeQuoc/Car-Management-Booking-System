using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblBooking
    {
        public TblBooking()
        {
            TblBookingDetails = new HashSet<TblBookingDetail>();
        }

        public int BookingId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? TotalPrice { get; set; }
        public int UserId { get; set; }

        public virtual TblUser User { get; set; }
        public virtual ICollection<TblBookingDetail> TblBookingDetails { get; set; }
    }
}
