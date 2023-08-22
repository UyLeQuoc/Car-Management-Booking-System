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
        void DeleteCar(int carId);
        void AddNewCar(TblCar car);
        void UpdateCar(TblCar car);
        TblCar GetCarByCarPlateExcept(string carPlate, int carID);
        TblCar GetCarByCarPlate(string carPlate);
        TblCar GetCarByID(int carId);
        IEnumerable<TblCar> SearchCarByIDMember(int carID);
        IEnumerable<TblCar> SearchCarByNameMember(string carName);
        IEnumerable<TblCar> FilterCarsMember(decimal from, decimal to);
        IEnumerable<TblCar> ViewListCar();
        IEnumerable<TblCar> GetAllCars();
        IEnumerable<TblCar> SearchCarByID(int carID);
        IEnumerable<TblCar> SearchCarByName(string carName);
        IEnumerable<TblCar> FilterCars(decimal from, decimal to);


    }
}
