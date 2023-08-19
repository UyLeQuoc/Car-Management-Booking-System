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
    public partial class frmChooseTime : Form
    {
        ICarRepository carRepo = new CarRepository();
        IBookingDetailRepository ordetail = new BookingDetailRepository();
        public frmChooseTime()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinBookingTime { get; set; }

        public int checkEmptyinBookingTime { get; set; }
        public int GetCountinBookingTime { get; set; }
        public string GetCarPlateinDetail { get; set; }
        public TblUser GetInfoUserinDetail { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            bool check = true;

            TblCar car = carRepo.GetCarByCarPlate(GetCarPlateinDetail);
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
                if (GetCountinBookingTime == 0)
                {
                    GetListOrderinBookingTime = new Dictionary<TblBookingDetail, TblCar>();
                    TblBookingDetail detail = new TblBookingDetail()
                    {

                        BookingDate = txtDate.Value,
                        BookingExpired = txtExpried.Value,
                    };
                    GetListOrderinBookingTime.Add(detail, car);
                    GetCountinBookingTime += 1;
                    MessageBox.Show("Add success!", "Notifi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    frmViewCar frmViewCar = new frmViewCar()
                    {
                        GetCountinView = GetCountinBookingTime,
                        checkEmptyinView = checkEmptyinBookingTime,
                        GetListOrderinCreate = GetListOrderinBookingTime,
                        GetInfoUser = GetInfoUserinDetail,
                    };
                    frmViewCar.ShowDialog();
                    Close();
                }
                else if (GetCountinBookingTime != 0)
                {
                    TblBookingDetail detail = new TblBookingDetail()
                    {
                        BookingDate = txtDate.Value,
                        BookingExpired = txtExpried.Value,
                    };
                    GetListOrderinBookingTime.Add(detail, car);
                    MessageBox.Show("Add success!", "Notifi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    frmViewCar frmViewCar = new frmViewCar()
                    {
                        GetCountinView = GetCountinBookingTime,
                        checkEmptyinView = checkEmptyinBookingTime,
                        GetListOrderinCreate = GetListOrderinBookingTime,
                        GetInfoUser = GetInfoUserinDetail,
                    };
                    frmViewCar.ShowDialog();
                    Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar()
            {
                GetCountinView = GetCountinBookingTime,
                checkEmptyinView = checkEmptyinBookingTime,
                GetListOrderinCreate = GetListOrderinBookingTime,
                GetInfoUser = GetInfoUserinDetail,
            };
            frmViewCar.ShowDialog();
            Close();
        }
    }
}
