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
    public partial class frmBookingDetailUpdate : Form
    {
        public int curBookingID { get; set; }
        public int carID { get; set; }

        public DateTime bookingDate { get; set; }
        public DateTime bookingExpired { get; set; }
        public int returnStatus { get; set; }

        public IBookingDetailRepository bookingDetailRepository = new BookingDetailRepository();

        public frmBookingDetailUpdate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaffBookingDetail frm = new frmStaffBookingDetail()
            {
                bookingID = curBookingID,
            };
            frm.ShowDialog();
            this.Close();
        }

        private void frmBookingDetailUpdate_Load(object sender, EventArgs e)
        {
            txtBookingDate.Value = bookingDate;
            txtBookingExpired.Value = bookingExpired;
            txtReturnStatus.Value = returnStatus;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime bookDate = bookingDate;
                DateTime expiredDate = txtBookingExpired.Value;
                int returnStatusChanged = int.Parse(txtReturnStatus.Text);
                if (expiredDate.CompareTo(bookDate) <= 0)
                {
                    throw new Exception("Expired date must be after booking date!");
                }
                var checkList = bookingDetailRepository.GetAllBookingDetailExcept(curBookingID, carID, bookingExpired);
                foreach (var item in checkList)
                {
                    if (expiredDate.CompareTo(item.BookingDate) >= 0)
                    {
                        throw new Exception("This car was booked in your booking days!");
                    }
                }
                bookingDetailRepository.UpdateBookingDetail(curBookingID, carID, expiredDate, returnStatusChanged);
                MessageBox.Show("Update successfully!", "Update booking detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update booking detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReturnStatus_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
