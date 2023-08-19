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

        public List<TblBrand> GetAllList()
        {
            try
            {
                List<TblBrand> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblBrands.ToList();
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public TblBrand GetBrand(int id)
        {
            TblBrand brand = null;

            try
            {
                var context = GetAllList();
                brand = context.SingleOrDefault(item => item.BrandId == id);

            }
            catch (Exception ex)
            {
                throw new Exception("Brand does not exist!!");
            }

            return brand;
        }
        public void Create(TblBrand brandCurrent)
        {
            if (brandCurrent == null)
            {
                throw new Exception("Brand is undefined!!");
            }
            try
            {
                var context = new CarBookingManagementContext();
                // check duplicate of email
                var checkDuplicate = context.TblBrands.SingleOrDefault(us => us.BrandName.Equals(brandCurrent.BrandName));
                if (checkDuplicate != null)
                {
                    throw new Exception("Brand Name has already existed!");
                }
                context.TblBrands.Add(brandCurrent);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(TblBrand brandCurrent)
        {
            if (brandCurrent == null)
            {
                throw new Exception("Brand is undefined!!");
            }
            try
            {
                TblBrand _Brand = GetBrand(brandCurrent.BrandId);
                if (_Brand != null)
                {
                    var context = new CarBookingManagementContext();
                    context.TblBrands.Update(brandCurrent);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Brand does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var context = new CarBookingManagementContext();
                TblBrand brand = context.TblBrands.FirstOrDefault(x => x.BrandId == id);
                context.TblBrands.Remove(brand);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
