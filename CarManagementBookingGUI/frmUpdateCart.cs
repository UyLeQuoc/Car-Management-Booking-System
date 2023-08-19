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

namespace CarManagementBookingGUI
{
    public partial class frmUpdateCart : Form
    {
        ICarRepository carRepo = new CarRepository();
        IBookingDetailRepository ordetail = new BookingDetailRepository();
        public frmUpdateCart()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinUpdateCart { get; set; }
        public int checkEmptyinUpdateCart { get; set; }
        public int GetCountinUpdateCart { get; set; }

        public TblUser GetInfoUserinUpdateCart { get; set; }
        public DateTime GetBookingDateinUpdate { get; set; }
        public DateTime GetBookingExpiredinUpdate { get; set; }
        public string GetCarPlateinUpdate { get; set; }

        private void frmUpdateCart_Load(object sender, EventArgs e)
        {
            txtDate.Value = GetBookingDateinUpdate;
            txtExpried.Value = GetBookingExpiredinUpdate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            frmCart frmCart = new frmCart()
            {
                GetListOrderinCart = GetListOrderinUpdateCart,
                checkEmptyinCart = checkEmptyinUpdateCart,
                GetCountinCart = GetCountinUpdateCart,
                GetInfoUserinCart = GetInfoUserinUpdateCart,
            };
            frmCart.ShowDialog();
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = true;

            TblCar car = carRepo.GetCarByCarPlate(GetCarPlateinUpdate);
            IEnumerable<TblBookingDetail> listcarorder = ordetail.GetListOrderDetail(car.CarId);

            foreach (var item in listcarorder)
            {
                DateTime a = (DateTime)item.BookingDate;
                DateTime ex = (DateTime)item.BookingExpired;
                string bookingDateinData = a.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                string bookingDate = txtDate.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                string bookingExpiredinData = ex.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);
                string bookingExpired = txtExpried.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture);

                if ((bookingDate.ToString().CompareTo(bookingDateinData) >= 0 && bookingDate.CompareTo(bookingExpiredinData) <= 0)
                    || (bookingExpired.CompareTo(bookingDateinData) >= 0 && bookingExpired.CompareTo(bookingExpiredinData) <= 0))
                {
                    if (MessageBox.Show($"This Car is already Booking from {bookingDateinData} to {bookingExpiredinData}" +
                        $"Please Book car after {bookingExpiredinData}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        check = false;
                        break;
                    };

                }
                else
                {
                    if (bookingDate.CompareTo(bookingExpired) >= 0)
                    {
                        if (MessageBox.Show("The BookingDate required greater than BookingExpired", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            check = false;
                            break;
                        };
                    }
                }
            }

            if (check)
            {
                if (MessageBox.Show("Are you sure to Update?", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (var tmp in GetListOrderinUpdateCart)
                    {
                        if (tmp.Value.CarPlate.Equals(GetCarPlateinUpdate))
                        {
                            tmp.Key.BookingDate = txtDate.Value;
                            tmp.Key.BookingExpired = txtExpried.Value;
                            break;
                        }
                    }
                    Hide();
                    frmCart frmCart = new frmCart()
                    {
                        GetCountinCart = GetCountinUpdateCart,
                        checkEmptyinCart = checkEmptyinUpdateCart,
                        GetListOrderinCart = GetListOrderinUpdateCart,
                        GetInfoUserinCart = GetInfoUserinUpdateCart,
                    };
                    frmCart.ShowDialog();
                    Close();
                };               
            }
        }
    }
}
