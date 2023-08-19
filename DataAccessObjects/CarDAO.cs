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
        private CarDAO() { }
        public static CarDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CarDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<TblCar> ViewListCar()
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
        public IEnumerable<TblCar> GetAllCars()
        {
            try
            {
                IEnumerable<TblCar> cars = null;
                var context = new CarBookingManagementContext();
                cars = context.TblCars.Include(x => x.Brand).Include(y => y.Model);
                return cars;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        public void DeleteCar(int carId)
        {
            try
            {
                TblCar car = context.TblCars.FirstOrDefault(x => x.CarId == carId);
                car.IsDeleted = 1;
                context.TblCars.Update(car);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<TblCar> FilterCars(decimal from, decimal to)
         {
            try
            {
                var context = new CarBookingManagementContext();
                IEnumerable<TblCar> carList = context.TblCars.Include(x => x.Brand).Include(x => x.Model).Where(x => x.PricePerHour >= from && x.PricePerHour <= to);
                return carList;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
      public IEnumerable<TblCar> SearchCarByName(string carName)
        {
            try
            {
                var context = new CarBookingManagementContext();
                IEnumerable<TblCar> carList = context.TblCars.Include(x => x.Brand).Include(x => x.Model).Where(x => x.CarName.ToLower().Contains(carName.Trim().ToLower()));
                return carList;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<TblCar> SearchCarByID(int carID)
        {
            try
            {
                var context = new CarBookingManagementContext();
                IEnumerable<TblCar> carList = context.TblCars.Include(x => x.Brand).Include(x=>x.Model).Where(x => x.CarId == carID);
                return carList;
            }catch (Exception ex)
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
