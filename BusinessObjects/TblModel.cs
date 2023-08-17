using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TblModel
    {
        public TblModel()
        {
            TblCars = new HashSet<TblCar>();
        }

        public int ModelId { get; set; }
        public string ModelName { get; set; }

        public virtual ICollection<TblCar> TblCars { get; set; }
    }
}
