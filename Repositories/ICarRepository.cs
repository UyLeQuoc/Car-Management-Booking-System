using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarRepository
    {
        public IEnumerable<TblCar> GetAllCars();

        public void DeleteCar(int carId);

        public IEnumerable<TblCar> SearchCarByID(int carID);
        IEnumerable<TblCar> SearchCarByName(string carName);
        IEnumerable<TblCar> FilterCars(decimal from, decimal to);
    }
}
