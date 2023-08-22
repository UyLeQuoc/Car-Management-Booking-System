using BusinessObjects;
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

namespace CarManagementBookingGUI
{
    public partial class frmViewCar : Form
    {
        ICarRepository carRepo = new CarRepository();
        BindingSource source;
        IEnumerable<TblCar> listCar;
        List<TblCar> order;
        public frmViewCar()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinCreate { get; set; }

        public int checkEmptyinView { get; set; }
        public int GetCountinView { get; set; }

        public TblUser GetInfoUser { get; set; }
        public string GetCarPlate { get; set; }


        private void txtCarName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmViewCar_Load(object sender, EventArgs e)
        {
            if (GetInfoUser != null)
            {
                try
                {
                    btnLogin.Visible = false;
                    btnSignUp.Visible = false;
                    Login.Text = "Welcome " + GetInfoUser.FullName;
                    listCar = carRepo.ViewListCar();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source = new BindingSource();
                    source.DataSource = cars;
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");

                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Login.Visible = false;
                    btnViewOrder.Visible = false;
                    btnLogOut.Visible = false;
                    listCar = carRepo.ViewListCar();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source = new BindingSource();
                    source.DataSource = cars;
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");

                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void lbCategory_Click(object sender, EventArgs e)
        {

        }

        private void lbTo_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin frmLogin = new frmLogin() 
            {
                GetListOrderinLogin = GetListOrderinCreate,
                GetCountinLogin = GetCountinView,
                checkEmptyinLogin = checkEmptyinView,
            };
            frmLogin.ShowDialog();
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            frmSignUp frmSignUpp = new frmSignUp() 
            {
                GetListOrderinSignUp = GetListOrderinCreate,
                GetCountinSignUp = GetCountinView,
                checkEmptyinSignUp = checkEmptyinView
            };
            frmSignUpp.ShowDialog();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string value = txtSearchValue.Text;
            IEnumerable<TblCar> searchCar = carRepo.SearchCarByNameMember(value.Trim());
            if (value.Trim().Length == 0)
            {
                MessageBox.Show("Do not allow Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (searchCar.Any())
                {
                    listCar = searchCar;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Car is not found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LoadData()
        {
            if (GetInfoUser != null)
            {
                try
                {
                    btnLogin.Visible = false;
                    btnSignUp.Visible = false;
                    Login.Text = "Welcome " + GetInfoUser.FullName;
                    source = new BindingSource();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source.DataSource = cars.ToList();
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");

                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Login.Visible = false;
                    source = new BindingSource();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source.DataSource = cars.ToList();
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");
                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (GetInfoUser != null)
            {
                try
                {
                    btnLogin.Visible = false;
                    btnSignUp.Visible = false;
                    Login.Text = "Welcome " + GetInfoUser.FullName;
                    listCar = carRepo.ViewListCar();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source = new BindingSource();
                    source.DataSource = cars;
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");
                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    txtSearchValue.Clear();
                    Login.Visible = false;
                    listCar = carRepo.ViewListCar();
                    var cars = from car in listCar
                               select new { car.CarName, car.CarPlate, car.PricePerHour, car.Brand.BrandName, car.Model.ModelName };
                    source = new BindingSource();
                    source.DataSource = cars;
                    txtCarName.DataBindings.Clear();
                    txtCarPlate.DataBindings.Clear();
                    txtCarPrice.DataBindings.Clear();
                    txtCarBrand.DataBindings.Clear();
                    txtCarModel.DataBindings.Clear();

                    txtCarName.DataBindings.Add("Text", source, "CarName");
                    txtCarPlate.DataBindings.Add("Text", source, "CarPlate");
                    txtCarPrice.DataBindings.Add("Text", source, "PricePerHour");
                    txtCarBrand.DataBindings.Add("Text", source, "BrandName");
                    txtCarModel.DataBindings.Add("Text", source, "ModelName");

                    dgvViewCar.Columns.Clear();
                    dgvViewCar.DataSource = source;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Cars", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            decimal from = txtFrom.Value;
            decimal to = txtTo.Value;
            IEnumerable<TblCar> filterCar = carRepo.FilterCarsMember(from, to);
            if (filterCar.Any())
            {
                listCar = filterCar;
                LoadData();
            }
            else
            {
                MessageBox.Show("Car is not found!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnChooseTime_Click(object sender, EventArgs e)
        {
            if (GetCountinView != 0)
            {
                if (!GetListOrderinCreate.Any())
                {
                    GetCarPlate = txtCarPlate.Text;
                    Hide();
                    frmChooseTime frmChooseTime = new frmChooseTime()
                    {
                        GetCarPlateinDetail = GetCarPlate,
                        GetCountinBookingTime = GetCountinView,
                        checkEmptyinBookingTime = checkEmptyinView,
                        GetInfoUserinDetail = GetInfoUser,
                        GetListOrderinBookingTime = GetListOrderinCreate,
                    };
                    frmChooseTime.ShowDialog();
                    Close();
                }
                else
                {
                    foreach (var tmp in GetListOrderinCreate)
                    {
                        int i = GetListOrderinCreate.Count;
                        if (txtCarPlate.Text.Equals(tmp.Value.CarPlate))
                        {
                            MessageBox.Show("This Car is already in Cart", "Notifi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        if (i == GetListOrderinCreate.Count)
                        {
                            GetCarPlate = txtCarPlate.Text;
                            Hide();
                            frmChooseTime frmChooseTime = new frmChooseTime()
                            {
                                GetCarPlateinDetail = GetCarPlate,
                                GetCountinBookingTime = GetCountinView,
                                checkEmptyinBookingTime = checkEmptyinView,
                                GetInfoUserinDetail = GetInfoUser,
                                GetListOrderinBookingTime = GetListOrderinCreate,
                            };
                            frmChooseTime.ShowDialog();
                            Close();
                        }
                    }
                }
            }
            else
            {
                GetCarPlate = txtCarPlate.Text;
                Hide();
                frmChooseTime frmChooseTime = new frmChooseTime()
                {
                    GetCarPlateinDetail = GetCarPlate,
                    GetCountinBookingTime = GetCountinView,
                    checkEmptyinBookingTime = checkEmptyinView,
                    GetInfoUserinDetail = GetInfoUser,
                    GetListOrderinBookingTime = GetListOrderinCreate,
                };
                frmChooseTime.ShowDialog();
                Close();
            }

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            if (checkEmptyinView == 0)// Khi View người dùng nhấp vào View Cart
            {
                if (GetCountinView != 0)//
                {
                    Hide();
                    checkEmptyinView++;
                    frmCart frmCart = new frmCart()
                    {
                        GetListOrderinCart = GetListOrderinCreate,
                        GetCountinCart = GetCountinView,
                        GetInfoUserinCart = GetInfoUser,
                        checkEmptyinCart = checkEmptyinView,
                    };
                    frmCart.ShowDialog();
                    Close();

                }
                else
                {
                    GetListOrderinCreate = new();
                    MessageBox.Show("Empty Cart!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (GetListOrderinCreate.Count == 0)
                {
                    MessageBox.Show("Empty Cart!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Hide();
                    frmCart frmCart = new frmCart()
                    {
                        GetListOrderinCart = GetListOrderinCreate,
                        GetCountinCart = GetCountinView,
                        GetInfoUserinCart = GetInfoUser,
                        checkEmptyinCart = checkEmptyinView,
                    };
                    frmCart.ShowDialog();
                    Close();
                }
            }

        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            Hide();
            frmBooking frmOrder = new frmBooking()
            {
                GetInfoUserinOrder = GetInfoUser,
                GetCountinOrder = GetCountinView,
                GetListOrderinOrder = GetListOrderinCreate,
                checkEmptyinOrder = checkEmptyinView,
            };
            frmOrder.ShowDialog();
            Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar() { };
            frmViewCar.ShowDialog();
            Close();
        }
    }
}
