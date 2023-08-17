using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblCar
    {
        public TblCar()
        {
            TblBookingDetails = new HashSet<TblBookingDetail>();
        }

        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarPlate { get; set; }
        public decimal? PricePerHour { get; set; }
        public int? BrandId { get; set; }
        public int ModelId { get; set; }
        public short? IsDeleted { get; set; }

        public virtual TblBrand Brand { get; set; }
        public virtual TblModel Model { get; set; }
        public virtual ICollection<TblBookingDetail> TblBookingDetails { get; set; }
    }
}
