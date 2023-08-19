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
    public partial class frmBookingDetail : Form
    {
        public int bookingID { get; set; }
        public BindingSource source;
        public IBookingDetailRepository bookingDetailRepository = new BookingDetailRepository();
        public frmBookingDetail()
        {
            InitializeComponent();
        }

        private void frmBookingDetail_Load(object sender, EventArgs e)
        {
            LoadBookingDetailsToUI();
        }

        private void LoadBookingDetailsToUI()
        {
            source = new BindingSource();
            var bookingDetailList = bookingDetailRepository.GetBookingDetailsByBookingID(bookingID);
            var list = from d in bookingDetailList
                       select new { d.BookingId, d.Car.CarName, d.BookingPrice, d.BookingDate, d.BookingExpired, d.ReturnStatus };
            source.DataSource = list;

            txtBookingID.DataBindings.Clear();
            txtCarName.DataBindings.Clear();
            txtBookingPrice.DataBindings.Clear();
            txtBookingDate.DataBindings.Clear();
            txtBookingExpired.DataBindings.Clear();
            txtReturnStatus.DataBindings.Clear();

            txtBookingID.DataBindings.Add("Text", source, "BookingId");
            txtCarName.DataBindings.Add("Text", source, "CarName");
            txtBookingPrice.DataBindings.Add("Text", source, "BookingPrice");
            txtBookingDate.DataBindings.Add("Text", source, "BookingDate");
            txtBookingExpired.DataBindings.Add("Text", source, "BookingExpired");
            txtReturnStatus.DataBindings.Add("Text", source, "ReturnStatus");

            dgvBookingDetailsList.Columns.Clear();
            dgvBookingDetailsList.DataSource = source;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBookingDetailsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvBookingDetailsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            TblBookingDetail tblBookingDetail = bookingDetailRepository.GetBookingDetailsByBookingID(int.Parse(txtBookingID.Text)).ToArray()[0];
            frmBookingDetailUpdate frm = new frmBookingDetailUpdate()
            {
                curBookingID = int.Parse(txtBookingID.Text),
                carID = tblBookingDetail.CarId,
                bookingDate = txtBookingDate.Value,
                bookingExpired = txtBookingExpired.Value,
                returnStatus = int.Parse(txtReturnStatus.Text),
            };
            frm.ShowDialog();   
            this.Close();
        }
    }
}
