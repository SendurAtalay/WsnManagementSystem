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
    public partial class Countries : Form
    {
        public Countries()
        {
            InitializeComponent();
        }

        CountriesBusiness countriesBusiness = new CountriesBusiness(); 
        private void Countries_Load(object sender, EventArgs e)
        {
            dgvCountries.DataSource = countriesBusiness.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
              countriesBusiness.Insert(new DataLayer.Country
            {
                CountryName = txtCountryName.Text,
            });
            dgvCountries.DataSource = countriesBusiness.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            countriesBusiness.Update(new DataLayer.Country
            {
                CountryID = Convert.ToInt32(txtCountryID.Text),
                CountryName = txtCountryName.Text,
                
            });
            dgvCountries.DataSource = countriesBusiness.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            countriesBusiness.Delete(Convert.ToInt32(txtCountryID.Text));
            dgvCountries.DataSource = countriesBusiness.GetAll();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtCountryID.Clear();
            txtCountryName.Clear();
           
        }

        private void dgvCountries_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCountryName.Text = dgvCountries.Rows[e.RowIndex].Cells["CountryName"].Value.ToString();
            txtCountryID.Text = dgvCountries.Rows[e.RowIndex].Cells["CountryID"].Value.ToString();
        }
    }
}
