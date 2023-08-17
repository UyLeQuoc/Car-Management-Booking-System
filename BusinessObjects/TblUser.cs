using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string RoleId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
