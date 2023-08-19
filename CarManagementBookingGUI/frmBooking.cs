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
    public partial class frmBooking : Form
    {
        BindingSource source;
        IBookingRepository bookingRepository = new BookingRepository();
        public Dictionary<TblBookingDetail, TblCar> GetListOrderinOrder { get; set; }

        public int checkEmptyinOrder { get; set; }
        public int GetCountinOrder { get; set; }

        public TblUser GetInfoUserinOrder { get; set; }
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            IEnumerable<TblBooking> Booking = bookingRepository.GetListBooking(GetInfoUserinOrder.UserId);
            var listBooking = Booking.Select(x => new { x.BookingId, x.TotalPrice, Time = x.CreatedDate.Value.ToString("MM-dd-yyyy", CultureInfo.InvariantCulture) });
            source = new BindingSource();
            source.DataSource = listBooking.ToList();

            txtBookingID.DataBindings.Clear();
            txtOrderTotal.DataBindings.Clear();
            txtTime.DataBindings.Clear();

            txtBookingID.DataBindings.Add("Text", source, "BookingId");
            txtOrderTotal.DataBindings.Add("Text", source, "TotalPrice");
            txtTime.DataBindings.Add("Text", source, "Time");

            dgvOrderList.DataSource = source;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            frmViewCar frmViewCar = new frmViewCar()
            {
                GetListOrderinCreate = GetListOrderinOrder,
                GetCountinView = GetCountinOrder,
                checkEmptyinView = checkEmptyinOrder,
                GetInfoUser = GetInfoUserinOrder,
            };
            frmViewCar.ShowDialog();
            Close();
        }

        private void btnOrderDetail_Click(object sender, EventArgs e)
        {
            Hide();
            frmBookingDetail frmViewCar = new frmBookingDetail()
            {
                GetListOrderinOrderDetail = GetListOrderinOrder,
                GetCountinOrderDetail = GetCountinOrder,
                checkEmptyinOrderDetail = checkEmptyinOrder,
                GetInfoUserinOrderDetail = GetInfoUserinOrder,
                GetBookingId = int.Parse(txtBookingID.Text),
            };
            frmViewCar.ShowDialog();
            Close();
        }
    }
}
