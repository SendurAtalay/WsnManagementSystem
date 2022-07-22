using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WsnManagementSystem.BusinessLayer.Repository.Concrete;

namespace WsnManagementSystem.GUI
{
    public partial class DistrictsForm : Form
    {
        public DistrictsForm()
        {
            InitializeComponent();
        }
        DistrictBusiness districtBusiness = new DistrictBusiness();
        CountyBusiness countyBusiness = new CountyBusiness();
        private void DistrictsForm_Load(object sender, EventArgs e)
        {
            dgvDistrict.DataSource = districtBusiness.GetDistricts();
            BindCounty();
        }
        private void BindCounty()
        {
            var county = countyBusiness.GetAll();

            county.Insert(0, new DataLayer.County { CountyID = 0, CountyName = "Select a County..." });
            cmbCounty.DataSource = county;
            cmbCounty.DisplayMember = "CountyName";
            cmbCounty.ValueMember = "CountyID";
        }

        private void dgvDistrict_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDistrictID.Text = dgvDistrict.Rows[e.RowIndex].Cells["DistrictID"].Value.ToString();
            txtDistrictName.Text = dgvDistrict.Rows[e.RowIndex].Cells["DistrictName"].Value.ToString();
            cmbCounty.SelectedValue = Convert.ToInt32(dgvDistrict.Rows[e.RowIndex].Cells["CountyID"].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            districtBusiness.Insert(new DataLayer.District { DistrictName = txtDistrictName.Text, CountyID = Convert.ToInt32(cmbCounty.SelectedValue) });
            dgvDistrict.DataSource = districtBusiness.GetDistricts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            districtBusiness.Update(new DataLayer.District { DistrictID = Convert.ToInt32(txtDistrictID.Text), DistrictName = txtDistrictName.Text, CountyID = Convert.ToInt32(cmbCounty.SelectedValue) });
            dgvDistrict.DataSource = districtBusiness.GetDistricts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            districtBusiness.Delete(Convert.ToInt32(txtDistrictID.Text));
            dgvDistrict.DataSource = districtBusiness.GetDistricts();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtDistrictID.Clear();
            txtDistrictName.Clear();
            cmbCounty.SelectedIndex = 0;
        }
    }
}
