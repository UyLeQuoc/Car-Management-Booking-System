using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class BrandDAO
    {
        private BrandDAO() { }
        private static BrandDAO instance = null;
        private static readonly object instanceLock = new object();
        public static BrandDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new BrandDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblBrand> GetAllBrands()
        {
            try
            {
                var context = new CarBookingManagementContext();
                IEnumerable<TblBrand> brands = context.TblBrands;
                return brands;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
