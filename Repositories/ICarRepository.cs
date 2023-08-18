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
        public IEnumerable<TblCar> ViewCar();
        public IEnumerable<TblCar> SearchCar(string value);
        public IEnumerable<TblCar> FilterCar(decimal from, decimal to);
        public TblCar GetCarByCarPlate(string plate);
    }
}
