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
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
        }


        CityBusiness cityBusiness = new CityBusiness();
        CountriesBusiness countriesBusiness = new CountriesBusiness();

        private void CityForm_Load(object sender, EventArgs e)
        {
            dgvCities.DataSource = cityBusiness.GetCities();
            BindCountries();
            
        }

        private void BindCountries()
        {
            var countries = countriesBusiness.GetAll();

            countries.Insert(0, new DataLayer.Country { CountryID = 0, CountryName = "Select a Country..." });
            cmbCountries.DataSource = countries;
            cmbCountries.DisplayMember = "CountryName";
            cmbCountries.ValueMember = "CountryID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cityBusiness.Insert(new DataLayer.City {CityName=txtCityName.Text,CountryID=Convert.ToInt32(cmbCountries.SelectedValue) });
            dgvCities.DataSource = cityBusiness.GetCities();
        }

        private void dgvCities_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCityId.Text = dgvCities.Rows[e.RowIndex].Cells["CityID"].Value.ToString();
            txtCityName.Text = dgvCities.Rows[e.RowIndex].Cells["CityName"].Value.ToString();
            cmbCountries.SelectedValue = Convert.ToInt32(dgvCities.Rows[e.RowIndex].Cells["CountryID"].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cityBusiness.Delete(Convert.ToInt32(txtCityId.Text));
            dgvCities.DataSource = cityBusiness.GetCities();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cityBusiness.Update(new DataLayer.City {CityID=Convert.ToInt32(txtCityId.Text) ,CityName = txtCityName.Text, CountryID = Convert.ToInt32(cmbCountries.SelectedValue) });
            dgvCities.DataSource = cityBusiness.GetCities();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtCityId.Clear();
            txtCityName.Clear();
            cmbCountries.SelectedIndex = 0;
        }
    }
}
