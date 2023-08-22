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
    public partial class frmBookingManagement : Form
    {
        public TblUser curUser { get; set; }
        BindingSource source;
        IBookingRepository bookingRepository = new BookingRepository();
        bool isSearch = false, isFilter = false, isSearchById = false, isSearchByName = false;

        public frmBookingManagement()
        {
            InitializeComponent();
        }

        private void frmBookingManagement_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadBookingsToUI(IEnumerable<TblBooking> bookings)
        {
            source = new BindingSource();
            var listBookings = from b in bookings
                               select new { b.BookingId, b.User.FullName, b.CreatedDate, b.TotalPrice };
            source.DataSource = listBookings.ToList();

            txtBookingID.DataBindings.Clear();
            txtBookingUser.DataBindings.Clear();
            txtCreateDate.DataBindings.Clear();
            txtTotalPrice.DataBindings.Clear();

            txtBookingID.DataBindings.Add("Text", source, "BookingId");
            txtBookingUser.DataBindings.Add("Text", source, "FullName");
            txtCreateDate.DataBindings.Add("Text", source, "CreatedDate");
            txtTotalPrice.DataBindings.Add("Text", source, "TotalPrice");

            dgvBookingsList.Columns.Clear();
            dgvBookingsList.DataSource = source;
        }

        private void dgvBookingsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmStaffBookingDetail frm = new frmStaffBookingDetail()
                {
                    bookingID = int.Parse(txtBookingID.Text)
                };
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "View booking detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBookingsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStaff frmStaff = new frmStaff()
            {
                curUser = curUser
            };
            frmStaff.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                isSearch = true;

                if (txtSearchValue.Text.Trim().Length == 0)
                {
                    throw new Exception("Please fill out the field, enter only blank character is not allowed!");
                }
                if (isSearch)
                {
                    IEnumerable<TblBooking> listResult = null;
                    if (radioByID.Checked)
                    {
                        if (txtSearchValue.Text.Length == 0)
                        {
                            throw new Exception("Please fill out the field!");
                        }
                        isSearchById = true;
                        isSearchByName = false;
                        int bookingID = int.Parse(txtSearchValue.Text);
                        listResult = bookingRepository.FindBookingsByBookingID(bookingID);

                    }
                    if (radioByName.Checked)
                    {
                        isSearchById = false;
                        isSearchByName = true;
                        string userName = txtSearchValue.Text;
                        listResult = bookingRepository.FindBookingsByUserName(userName);
                    }

                    if (listResult.Any())
                    {
                        LoadBookingsToUI(listResult);
                    }
                    else
                    {
                        throw new Exception("No search found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFrom.Text.Trim().Length == 0 && txtTo.Text.Trim().Length == 0)
                {
                    throw new Exception("Please fill out at least one field!");
                }
                else
                {
                    isFilter = true;
                    IEnumerable<TblBooking> bookingsList = null;
                    if (txtFrom.Text.Length != 0 && txtTo.Text.Length != 0)
                    {
                        decimal from = decimal.Parse(txtFrom.Text);
                        decimal to = decimal.Parse(txtTo.Text);
                        if (from < 0 || to < 0 || from > to)
                        {
                            throw new Exception("Invalid filter values!");
                        }
                        bookingsList = bookingRepository.FilterBookings(from, to);
                    }
                    else if (txtFrom.Text.Length != 0 && txtTo.Text.Length == 0)
                    {
                        decimal from = decimal.Parse(txtFrom.Text);
                        if (from < 0)
                        {
                            throw new Exception("Invalid filter values!");
                        }
                        bookingsList = bookingRepository.FilterBookings(from, -100);
                    }
                    else if (txtFrom.Text.Length == 0 && txtTo.Text.Length != 0)
                    {
                        decimal to = decimal.Parse(txtTo.Text);
                        if (to < 0)
                        {
                            throw new Exception("Invalid filter values!");
                        }
                        bookingsList = bookingRepository.FilterBookings(-100, to);
                    }

                    if (bookingsList.Any())
                    {
                        LoadBookingsToUI(bookingsList);
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            grSearch.Enabled = true;
            grFilter.Enabled = true;
            isSearch = false;
            isFilter = false;
            txtFrom.Text = string.Empty;
            txtTo.Text = string.Empty;
            txtSearchValue.Text = string.Empty;
            var bookings = bookingRepository.GetAllBookings();
            LoadBookingsToUI(bookings);
        }
    }
}
