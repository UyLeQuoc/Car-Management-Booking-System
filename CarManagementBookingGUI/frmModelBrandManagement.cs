using BusinessObjects;

using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarManagementBookingGUI
{
    public partial class frmModelBrandManagement : Form
    {

        IBrandRepository brandRepository = new BrandRepository();
        BindingSource sourceBrand;

        IModelRepository modelRepository = new ModelRepository();
        BindingSource sourceModel;

        public frmModelBrandManagement()
        {
            InitializeComponent();
        }

        private void frmModelBrandManagement_Load(object sender, EventArgs e)
        {
            btnLoadBrand.Enabled = true;
            btnNewBrand.Enabled = true;
            btnUpdateBrand.Enabled = true;
            btnDeleteBrand.Enabled = true;
            LoadBrand();

            btnLoadModel.Enabled = true;
            btnNewModel.Enabled = true;
            btnUpdateModel.Enabled = true;
            btnDeleteModel.Enabled = true;
            LoadModel();
        }

        private void LoadBrand()
        {
            var list = brandRepository.GetAllList();

            try
            {
                sourceBrand = new BindingSource();
                sourceBrand.DataSource = list;

                txtBrandId.DataBindings.Clear();
                txtBrand.DataBindings.Clear();

                txtBrand.DataBindings.Add("Text", sourceBrand, "BrandName");
                txtBrandId.DataBindings.Add("Text", sourceBrand, "BrandId");

                dgvBrand.DataSource = null;
                dgvBrand.DataSource = sourceBrand;
                dgvBrand.Columns["TblCars"].Visible = false;

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void btnLoadBrand_Click(object sender, EventArgs e) => LoadBrand();

        private void btnNewBrand_Click(object sender, EventArgs e)
        {
            try
            {
                TblBrand brand = new TblBrand()
                {
                    BrandId = int.Parse(txtBrandId.Text),
                    BrandName = txtBrand.Text,
                };
                if (MessageBox.Show("Confirm to create a Brand?", "Create Brand", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    brandRepository.Create(brand);

                    MessageBox.Show("Create brand success!", "Create Brand", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadBrand();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Create Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateBrand_Click(object sender, EventArgs e)
        {
            try
            {
                TblBrand brand = new TblBrand()
                {
                    BrandId = int.Parse(txtBrandId.Text),
                    BrandName = txtBrand.Text,
                };
                if (MessageBox.Show("Confirm to update a Brand?", "Update Brand", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    brandRepository.Update(brand);

                    MessageBox.Show("Update Brand success!", "Update Brand", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadBrand();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Update Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBrandId.Text.Length != 0)
                {
                    if (MessageBox.Show($"Do you really want to delete the user: \n" +
                $"Brand: {txtBrand.Text}\n", "Delete brand", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        brandRepository.Delete(int.Parse(txtBrandId.Text));

                    LoadBrand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Brand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadModel()
        {
            var list = modelRepository.GetAllList();

            try
            {
                sourceModel = new BindingSource();
                sourceModel.DataSource = list;

                txtModelId.DataBindings.Clear();
                txtModelName.DataBindings.Clear();

                txtModelName.DataBindings.Add("Text", sourceModel, "ModelName");
                txtModelId.DataBindings.Add("Text", sourceModel, "ModelId");

                dgvModel.DataSource = null;
                dgvModel.DataSource = sourceModel;
                dgvModel.Columns["TblCars"].Visible = false;

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void btnLoadModel_Click(object sender, EventArgs e) => LoadModel();

        private void btnNewModel_Click(object sender, EventArgs e)
        {
            try
            {
                TblModel model = new TblModel()
                {
                    ModelId = int.Parse(txtModelId.Text),
                    ModelName = txtModelName.Text,
                };
                if (MessageBox.Show("Confirm to create a Model?", "Create Model", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    modelRepository.Create(model);

                    MessageBox.Show("Create Model success!", "Create Model", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadModel();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Create Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            try
            {
                TblModel Model = new TblModel()
                {
                    ModelId = int.Parse(txtModelId.Text),
                    ModelName = txtModelName.Text,
                };
                if (MessageBox.Show("Confirm to update a Model?", "Update Model", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    modelRepository.Update(Model);

                    MessageBox.Show("Update Model success!", "Update Model", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                LoadModel();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Update Model", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModelId.Text.Length != 0)
                {
                    if (MessageBox.Show($"Do you really want to delete the user: \n" +
                $"Model: {txtModelName.Text}\n", "Delete Model", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        modelRepository.Delete(int.Parse(txtModelId.Text));

                    LoadModel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Model");
            }
        }
    }
}
