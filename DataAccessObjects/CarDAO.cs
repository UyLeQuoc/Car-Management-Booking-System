using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CarDAO
    {
        private static CarDAO instance;
        private static object instanceLook = new object();
        public static CarDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CarDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblCar> ViewCar()
        {
            try
            {
                IEnumerable<TblCar> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblCars.Include(x => x.Brand).Include(y => y.Model).Where(z => z.IsDeleted == 0);
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblCar> SearchCar(string value)
        {
            try
            {
                IEnumerable<TblCar> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblCars.Include(y => y.Model).Include(z => z.Brand).Where(x => x.CarName.ToLower().Contains(value.Trim().ToLower()));
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblCar> FilterCar(decimal from, decimal to)
        {
            try
            {
                IEnumerable<TblCar> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblCars.Include(y => y.Model).Include(z => z.Brand).Where(x => x.PricePerHour >= from && x.PricePerHour <= to);
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TblCar GetCarbyCarPlate(string plate)
        {
            try
            {
                var context = new CarBookingManagementContext();
                var car = context.TblCars.Include(y => y.Model).Include(z => z.Brand).Include(t => t.TblBookingDetails).SingleOrDefault(x => x.CarPlate.Equals(plate));
                return car;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
