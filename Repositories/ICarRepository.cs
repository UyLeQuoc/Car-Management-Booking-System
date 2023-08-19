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
        public IEnumerable<TblCar> ViewListCar();
        public IEnumerable<TblCar> SearchCarByName(string carName);
        public IEnumerable<TblCar> FilterCars(decimal from, decimal to);
        public TblCar GetCarByCarPlate(string plate);
    }
}
