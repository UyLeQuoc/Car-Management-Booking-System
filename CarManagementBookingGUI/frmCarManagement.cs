﻿using BusinessObjects;
using Microsoft.Data.SqlClient;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarManagementBookingGUI
{
    public partial class frmCarManagement : Form
    {
        BindingSource source;
        public static bool isUpdate = false;

        bool isSearch = false, isFilter = false, isSearchById = false, isSearchByName = false, isRdPrice = false, isRdStock = false;
        SqlConnection conn = new SqlConnection(CarBookingManagementContext.GetConnectionString());
        ICarRepository carRepository = new CarRepository();
        public frmCarManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnDelete.Enabled = true;
            grSearch.Enabled = true;
            grFilter.Enabled = true;
            isSearch = false;
            isFilter = false;
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtSearchValue.Text = string.Empty;
            IEnumerable<TblCar> carList = carRepository.GetAllCars();
            LoadCarsToUI(carList);
        }

        private void LoadCarsToUI(IEnumerable<TblCar> carList)
        {
            try
            {
                source = new BindingSource();
                var cars = from car in carList
                           select new { car.CarId, car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName, car.IsDeleted };
                source.DataSource = cars;

                txtCarID.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtCarPlate.DataBindings.Clear();
                txtPricePerHour.DataBindings.Clear();
                txtBrand.DataBindings.Clear();
                txtModel.DataBindings.Clear();
                txtIsDeleted.DataBindings.Clear();

                txtCarID.DataBindings.Add("Text", source, "CarId");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                txtPricePerHour.DataBindings.Add("Text", source, "PricePerHour");
                txtBrand.DataBindings.Add("Text", source, "BrandName");
                txtModel.DataBindings.Add("Text", source, "ModelName");
                txtIsDeleted.DataBindings.Add("Text", source, "IsDeleted");

                dgvCarsList.Columns.Clear();
                dgvCarsList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = int.Parse(txtCarID.Text);

                if ((MessageBox.Show("Do you really want to delete this car?", "Delete car", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    carRepository.DeleteCar(carID);
                    IEnumerable<TblCar> carList = carRepository.GetAllCars();
                    LoadCarsToUI(carList);
                    MessageBox.Show("Delete car successfully!", "Delete car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                isSearch = true;

                if (isSearch)
                {
                    IEnumerable<TblCar> carList = null;
                    if (radioByID.Checked)
                    {
                        isSearchById = true;
                        isSearchByName = false;
                        int carID = int.Parse(txtSearchValue.Text);
                        carList = carRepository.SearchCarByID(carID);

                    }
                    if (radioByName.Checked)
                    {
                        isSearchById = false;
                        isSearchByName = true;
                        string carName = txtSearchValue.Text;
                        carList = carRepository.SearchCarByName(carName);
                    }

                    if (carList.Any())
                    {
                        LoadCarsToUI(carList);
                    }
                    else
                    {
                        throw new Exception("No search found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                isFilter = true;
                decimal from = decimal.Parse(txtFrom.Text);
                decimal to = decimal.Parse(txtTo.Text);
                IEnumerable<TblCar> carList = carRepository.FilterCars(from, to);

                if (carList.Any())
                {
                    LoadCarsToUI(carList);
                }
                else
                {
                    throw new Exception("No search found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
