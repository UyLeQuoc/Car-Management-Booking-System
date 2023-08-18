using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carId) => CarDAO.Instance.DeleteCar(carId);

        public IEnumerable<TblCar> FilterCars(decimal from, decimal to) => CarDAO.Instance.FilterCars(from, to);

        public IEnumerable<TblCar> GetAllCars() => CarDAO.Instance.GetAllCars();

        public IEnumerable<TblCar> SearchCarByID(int carID) => CarDAO.Instance.SearchCarByID(carID);

        public IEnumerable<TblCar> SearchCarByName(string carName) => CarDAO.Instance.SearchCarByName(carName);
    }
}
