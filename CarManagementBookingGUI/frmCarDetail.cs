﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManagementBookingGUI
{
    public partial class frmCarDetail : Form
    {
        public bool isUpdate = false;
        public TblCar curCar { get; set; }
        public IBrandRepository brandRepository = new BrandRepository();
        public IModelRepository modelRepository = new ModelRepository();
        public ICarRepository carRepository = new CarRepository();

        public frmCarDetail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<TblBrand> brands = brandRepository.GetAllBrands();
            var listBrands = from b in brands
                             select b.BrandName;
            listBrands = listBrands.Distinct();
            txtBrand.Items.Clear();
            txtBrand.Items.AddRange(listBrands.ToArray());

            IEnumerable<TblModel> models = modelRepository.GetAllModels();
            var listModels = from model in models
                             select model.ModelName;
            listModels = listModels.Distinct();
            txtModel.Items.Clear();
            txtModel.Items.AddRange(listModels.ToArray());

            if (!isUpdate)
            {
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                txtIsDeleted.Text = "0";

            }
            else
            {
                btnCreate.Visible = false;
                btnUpdate.Visible = true;
                txtIsDeleted.Text = curCar.IsDeleted.ToString();

                txtCarName.Text = curCar.CarName;
                txtCarPlate.Text = curCar.CarPlate;
                txtPricePerHour.Text = curCar.PricePerHour.ToString();

                int indexBrand = listBrands.Select((value, idx) => new { value, idx })
                          .Where(pair => pair.value == curCar.Brand.BrandName)
                          .Select(pair => pair.idx)
                          .FirstOrDefault();
                txtBrand.SelectedIndex = indexBrand;

                int indexModel = listModels.Select((value, idx) => new { value, idx })
                          .Where(pair => pair.value == curCar.Model.ModelName)
                          .Select(pair => pair.idx)
                          .FirstOrDefault();
                txtModel.SelectedIndex = indexModel;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string carName = (txtCarName.Text).Trim();
                string carPlate = (txtCarPlate.Text).Trim();
                decimal carPrice = decimal.Parse(txtPricePerHour.Text);
                TblBrand brand = brandRepository.GetAllBrands().FirstOrDefault(b => b.BrandName == txtBrand.Text);
                TblModel model = modelRepository.GetAllModels().FirstOrDefault(m => m.ModelName == txtModel.Text);

                TblCar checkPlate = carRepository.GetCarByCarPlate(carPlate);
                if (checkPlate != null)
                {
                    throw new Exception("Car plate is already exist!");
                }

                TblCar newCar = new TblCar()
                {
                    CarName = carName,
                    CarPlate = carPlate,
                    PricePerHour = carPrice,
                    BrandId = brand.BrandId,
                    ModelId = model.ModelId,
                    IsDeleted = 0
                };

                carRepository.AddNewCar(newCar);
                MessageBox.Show("Add car successfully!", "Add new car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCarManagement frmCarManagement = new frmCarManagement();
                frmCarManagement.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add new car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarManagement frmCarManagement = new frmCarManagement();
            frmCarManagement.ShowDialog();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = curCar.CarId;
                string carName = (txtCarName.Text).Trim();
                string carPlate = (txtCarPlate.Text).Trim();
                decimal carPrice = decimal.Parse(txtPricePerHour.Text);
                TblBrand brand = brandRepository.GetAllBrands().FirstOrDefault(b => b.BrandName == txtBrand.Text);
                TblModel model = modelRepository.GetAllModels().FirstOrDefault(m => m.ModelName == txtModel.Text);

                TblCar checkPlate = carRepository.GetCarByCarPlateExcept(carPlate, curCar.CarId);
                if (checkPlate != null)
                {
                    throw new Exception("Car plate is already exist!");
                }

                TblCar newCar = new TblCar()
                {
                    CarId = carID,
                    CarName = carName,
                    CarPlate = carPlate,
                    PricePerHour = carPrice,
                    BrandId = brand.BrandId,
                    ModelId = model.ModelId,
                    IsDeleted = 0
                };

                carRepository.UpdateCar(newCar);
                MessageBox.Show("Update car successfully!", "Update car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmCarManagement frmCarManagement = new frmCarManagement();
                frmCarManagement.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
