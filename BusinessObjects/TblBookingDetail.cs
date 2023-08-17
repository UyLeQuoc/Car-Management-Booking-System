using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblBookingDetail
    {
        public int CarId { get; set; }
        public int BookingId { get; set; }
        public decimal? BookingPrice { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? BookingExpired { get; set; }
        public short? ReturnStatus { get; set; }

        public virtual TblBooking Booking { get; set; }
        public virtual TblCar Car { get; set; }
    }
}
