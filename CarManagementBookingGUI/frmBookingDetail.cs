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
    public partial class frmBookingDetail : Form
    {
        BindingSource source;
        IBookingDetailRepository bookingDetailRepository = new BookingDetailRepository();
        public frmBookingDetail()
        {
            InitializeComponent();
        }
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinOrderDetail { get; set; }

        public int checkEmptyinOrderDetail { get; set; }
        public int GetCountinOrderDetail { get; set; }

        public TblUser GetInfoUserinOrderDetail { get; set; }
        public int GetBookingId { get; set; }

        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            IEnumerable<TblBookingDetail> bookingDeatil = bookingDetailRepository.GetListBookingDeatilById(GetBookingId);
            var listBookingDetail = bookingDeatil.Select(x => new
            {
                x.Car.CarName,
                x.BookingPrice,
                Expired = x.BookingExpired.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture),
                Date = x.BookingDate.Value.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture)
            });

            source = new BindingSource();
            source.DataSource = listBookingDetail.ToList();

            txtCarName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtDate.DataBindings.Clear();
            txtExpired.DataBindings.Clear();

            txtCarName.DataBindings.Add("Text", source, "CarName");
            txtPrice.DataBindings.Add("Text", source, "BookingPrice");
            txtDate.DataBindings.Add("Text", source, "Expired");
            txtExpired.DataBindings.Add("Text", source, "Date");

            dgvOrderList.DataSource = source;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmBooking frmBooking = new frmBooking()
            {
                GetCountinOrder = GetCountinOrderDetail,
                GetInfoUserinOrder = GetInfoUserinOrderDetail,
                GetListOrderinOrder = GetListOrderinOrderDetail,
                checkEmptyinOrder = checkEmptyinOrderDetail,
            };
            frmBooking.ShowDialog();
            Close();
        }
    }
}
