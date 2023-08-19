using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CarRepository: ICarRepository
    {
        public IEnumerable<TblCar> FilterCars(decimal from, decimal to)
        {
            return CarDAO.Instance.FilterCars(from, to);
        }

        public TblCar GetCarByCarPlate(string plate)
        {
            return CarDAO.Instance.GetCarbyCarPlate(plate);
        }

        public IEnumerable<TblCar> SearchCarByName(string carName)
        {
            return CarDAO.Instance.SearchCarByName(carName);
        }

        public IEnumerable<TblCar> ViewListCar()
        {
            return CarDAO.Instance.ViewListCar();
        }
    }
}
