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
using WsnManagementSystem.DataLayer;

namespace WsnManagementSystem.GUI
{
    public partial class CountiesForm : Form
    {
        public CountiesForm()
        {
            InitializeComponent();
        }
        CityBusiness cityBusiness=new CityBusiness();
        CountyBusiness countyBusiness=new CountyBusiness();

        private void CountiesForm_Load(object sender, EventArgs e)
        {
            dgvCounties.DataSource = countyBusiness.GetCounties();
            BindCities();
        }
        private void BindCities()
        {
            var citiess = cityBusiness.GetAll();

            citiess.Insert(0, new DataLayer.City { CityID = 0, CityName = "Select a City..." });
            cmbCity.DataSource = citiess;
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            countyBusiness.Insert(new DataLayer.County { CountyName = txtCountyName.Text, CityID = Convert.ToInt32(cmbCity.SelectedValue) });
            dgvCounties.DataSource = countyBusiness.GetCounties(); ;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            countyBusiness.Update(new DataLayer.County { CountyID = Convert.ToInt32(txtCountyID.Text), CountyName = txtCountyName.Text, CityID = Convert.ToInt32(cmbCity.SelectedValue) });
            dgvCounties.DataSource = countyBusiness.GetCounties();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            countyBusiness.Delete(Convert.ToInt32(txtCountyID.Text));
            dgvCounties.DataSource = countyBusiness.GetCounties();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtCountyID.Clear();
            txtCountyName.Clear();
            cmbCity.SelectedIndex = 0;
        }

        private void dgvCounties_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCountyID.Text = dgvCounties.Rows[e.RowIndex].Cells["CountyID"].Value.ToString();
            txtCountyName.Text = dgvCounties.Rows[e.RowIndex].Cells["CountyName"].Value.ToString();
            cmbCity.SelectedValue = Convert.ToInt32(dgvCounties.Rows[e.RowIndex].Cells["CityID"].Value);
        }
       
    }
}
