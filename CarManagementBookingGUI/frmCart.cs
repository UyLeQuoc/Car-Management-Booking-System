using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementBookingGUI
{
    public partial class frmCart : Form
    {
        BindingSource source;
        double total = 0;
        IBookingDetailRepository bookingDetail = new BookingDetailRepository();
        IBookingRepository booking = new BookingRepository();
        public frmCart()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinCart { get; set; }
        public int checkEmptyinCart { get; set; }
        public int GetCountinCart { get; set; }

        public TblUser GetInfoUserinCart { get; set; }
        public DateTime GetBookingDateinCart { get; set; }
        public DateTime GetBookingExpiredinCart { get; set; }

        private void frmCart_Load(object sender, EventArgs e)
        {
            source = new BindingSource();
            var listOrder = (from tmp in GetListOrderinCart
                             select new
                             {
                                 tmp.Value.CarName,
                                 tmp.Value.Model.ModelName,
                                 tmp.Value.CarPlate,
                                 tmp.Value.PricePerHour,
                                 tmp.Value.Brand.BrandName,
                                 tmp.Key.BookingDate,
                                 tmp.Key.BookingExpired,
                                 Subtotal = Math.Round((tmp.Key.BookingExpired.Value - tmp.Key.BookingDate.Value).TotalHours * (double)tmp.Value.PricePerHour.Value)
                             }).ToList();
            foreach (var tmp in listOrder)
            {
                total = total + tmp.Subtotal;
            }
            txtTotal.Text = total.ToString();
            source.DataSource = listOrder.ToList();

            txtDate.DataBindings.Clear();
            txtExpried.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            txtPlate.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtBrand.DataBindings.Clear();
            txtSub.DataBindings.Clear();

            txtDate.DataBindings.Add("Text", source, "BookingDate");
            txtExpried.DataBindings.Add("Text", source, "BookingExpired");
            txtName.DataBindings.Add("Text", source, "CarName");
            txtModel.DataBindings.Add("Text", source, "ModelName");
            txtPlate.DataBindings.Add("Text", source, "CarPlate");
            txtPrice.DataBindings.Add("Text", source, "PricePerHour");
            txtBrand.DataBindings.Add("Text", source, "BrandName");
            txtSub.DataBindings.Add("Text", source, "Subtotal");

            dgvOrderList.DataSource = source;
        }

        public void LoadData()
        {
            source = new BindingSource();
            var listOrder = (from tmp in GetListOrderinCart
                             select new
                             {
                                 tmp.Value.CarName,
                                 tmp.Value.Model.ModelName,
                                 tmp.Value.CarPlate,
                                 tmp.Value.PricePerHour,
                                 tmp.Value.Brand.BrandName,
                                 tmp.Key.BookingDate,
                                 tmp.Key.BookingExpired,
                                 Subtotal = Math.Round((tmp.Key.BookingExpired.Value - tmp.Key.BookingDate.Value).TotalHours * (double)tmp.Value.PricePerHour.Value)
                             }).ToList();
            foreach (var tmp in listOrder)
            {
                total = total + tmp.Subtotal;
            }
            txtTotal.Text = total.ToString();
            source.DataSource = listOrder.ToList();

            txtDate.DataBindings.Clear();
            txtExpried.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtModel.DataBindings.Clear();
            txtPlate.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtBrand.DataBindings.Clear();
            txtSub.DataBindings.Clear();

            txtDate.DataBindings.Add("Text", source, "BookingDate");
            txtExpried.DataBindings.Add("Text", source, "BookingExpired");
            txtName.DataBindings.Add("Text", source, "CarName");
            txtModel.DataBindings.Add("Text", source, "ModelName");
            txtPlate.DataBindings.Add("Text", source, "CarPlate");
            txtPrice.DataBindings.Add("Text", source, "PricePerHour");
            txtBrand.DataBindings.Add("Text", source, "BrandName");
            txtSub.DataBindings.Add("Text", source, "Subtotal");

            dgvOrderList.DataSource = source;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar()
            {
                GetListOrderinCreate = GetListOrderinCart,
                checkEmptyinView = checkEmptyinCart,
                GetCountinView = GetCountinCart,
                GetInfoUser = GetInfoUserinCart,
            };
            frmViewCar.ShowDialog();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show($"Do you want to Remove {txtName.Text}?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
            {
                foreach (var tmp in GetListOrderinCart)
                {
                    if (tmp.Value.CarPlate.Equals(txtPlate.Text))
                    {
                        GetListOrderinCart.Remove(tmp.Key);
                        LoadData();
                        break;

                    }

                }
            }
            if (!GetListOrderinCart.Any())
            {
                Hide();
                frmViewCar frmViewCar = new frmViewCar()
                {
                    GetListOrderinCreate = GetListOrderinCart,
                    checkEmptyinView = checkEmptyinCart,
                    GetCountinView = GetCountinCart,
                    GetInfoUser = GetInfoUserinCart,
                };
                frmViewCar.ShowDialog();
                Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpdateCart frmUpdateCart = new frmUpdateCart()
            {
                GetListOrderinUpdateCart = GetListOrderinCart,
                GetCountinUpdateCart = GetCountinCart,
                GetInfoUserinUpdateCart = GetInfoUserinCart,
                checkEmptyinUpdateCart = checkEmptyinCart,
                GetBookingDateinUpdate = txtDate.Value,
                GetBookingExpiredinUpdate = txtExpried.Value,
                GetCarPlateinUpdate = txtPlate.Text,
            };
            frmUpdateCart.ShowDialog();
            Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(GetInfoUserinCart == null)
            {
                Hide();
                frmLogin frmLogin = new frmLogin()
                {
                    GetCountinLogin = GetCountinCart,
                    GetListOrderinLogin = GetListOrderinCart,
                    checkEmptyinLogin = checkEmptyinCart,
                };
                frmLogin.ShowDialog();
                Close();
            }
            else
            {
                if ((MessageBox.Show($"Do you want to CheckOut?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)) == DialogResult.OK)
                {
                    var listOrder = (from tmp in GetListOrderinCart
                                     select new
                                     {
                                         tmp.Value.CarId,
                                         tmp.Value.CarName,
                                         tmp.Value.Model.ModelName,
                                         tmp.Value.CarPlate,
                                         tmp.Value.PricePerHour,
                                         tmp.Value.Brand.BrandName,
                                         tmp.Key.BookingDate,
                                         tmp.Key.BookingExpired,
                                         Subtotal = Math.Round((tmp.Key.BookingExpired.Value - tmp.Key.BookingDate.Value).TotalHours * (double)tmp.Value.PricePerHour.Value)
                                     }).ToList();
                    booking.InsertNewBooking(total, GetInfoUserinCart.UserId);
                    int newBookingId = booking.GetIdNewBooking();
                    foreach (var tmp in listOrder)
                    {
                        bookingDetail.InsertNewBookingDetail(tmp.CarId, newBookingId, tmp.Subtotal, tmp.BookingDate.Value, tmp.BookingExpired.Value);
                    }
                    Hide();
                    frmViewCar frmViewCar = new frmViewCar()
                    {
                        GetInfoUser = GetInfoUserinCart,
                    };
                    frmViewCar.ShowDialog();
                    Close();
                }
            }
        }
    }
}
