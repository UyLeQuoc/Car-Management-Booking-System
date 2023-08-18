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
        public IEnumerable<TblCar> FilterCar(decimal from, decimal to)
        {
            return CarDAO.Instance.FilterCar(from, to);
        }

        public TblCar GetCarByCarPlate(string plate)
        {
            return CarDAO.Instance.GetCarbyCarPlate(plate);
        }

        public IEnumerable<TblCar> SearchCar(string value)
        {
            return CarDAO.Instance.SearchCar(value);
        }

        public IEnumerable<TblCar> ViewCar()
        {
            return CarDAO.Instance.ViewCar();
        }
    }
}
