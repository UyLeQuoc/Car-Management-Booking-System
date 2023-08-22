﻿using BusinessObjects;
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
        public TblCar GetCarByCarPlate(string plate)
        {
            return CarDAO.Instance.GetCarbyCarPlate(plate);
        }
        public IEnumerable<TblCar> ViewListCar()
        {
            return CarDAO.Instance.ViewListCar();
        }


        public IEnumerable<TblCar> FilterCars(decimal from, decimal to) => CarDAO.Instance.FilterCars(from, to);

        public IEnumerable<TblCar> GetAllCars() => CarDAO.Instance.GetAllCars();

        public IEnumerable<TblCar> SearchCarByID(int carID) => CarDAO.Instance.SearchCarByID(carID);

        public IEnumerable<TblCar> SearchCarByName(string carName) => CarDAO.Instance.SearchCarByName(carName);

        public void AddNewCar(TblCar car) => CarDAO.Instance.AddnewCar(car);

        public void DeleteCar(int carId) => CarDAO.Instance.DeleteCar(carId);


        public TblCar GetCarByCarPlateExcept(string carPlate, int carID) => CarDAO.Instance.GetCarByCarPlateExcept(carPlate, carID);

        public TblCar GetCarByID(int carId) => CarDAO.Instance.GetCarByID(carId);


        public void UpdateCar(TblCar car) => CarDAO.Instance.UpdateCar(car);

        public IEnumerable<TblCar> FilterCarsMember(decimal from, decimal to) => CarDAO.Instance.FilterCarsMember(from, to);

        public IEnumerable<TblCar> SearchCarByIDMember(int carID) => CarDAO.Instance.SearchCarByIDMember(carID);

        public IEnumerable<TblCar> SearchCarByNameMember(string carName) => CarDAO.Instance.SearchCarByNameMember(carName);
    }
}
