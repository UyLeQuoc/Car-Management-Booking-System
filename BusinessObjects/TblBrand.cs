using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblBrand
    {
        public TblBrand()
        {
            TblCars = new HashSet<TblCar>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<TblCar> TblCars { get; set; }
    }
}
