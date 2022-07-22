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
    public partial class CoordinatorsForm : Form
    {
        public CoordinatorsForm()
        {
            InitializeComponent();
        }
       CountriesBusiness countriesBusiness = new CountriesBusiness();
       CityBusiness cityBusiness = new CityBusiness();
       CountyBusiness countyBusiness = new CountyBusiness();
       DistrictBusiness districtBusiness = new DistrictBusiness();
       CoordinatorBusiness coordinatorBusiness = new CoordinatorBusiness();
        private void CoordinatorsForm_Load(object sender, EventArgs e)
        {
            dgvCoordinators.DataSource = coordinatorBusiness.GetCoordinators();
            BindCountries();
        }
       
        private void BindCountries()
        {
            var countries = countriesBusiness.GetAll();

            countries.Insert(0, new DataLayer.Country { CountryID = 0, CountryName = "Select a Country..." });
            cmbCountry.DataSource = countries;
            cmbCountry.DisplayMember = "CountryName";
            cmbCountry.ValueMember = "CountryID";
        }
        private void BindCities(int countryID)
        {
            var cities = cityBusiness.GetCitiesByCountry(countryID);

            cities.Insert(0, new DataLayer.City { CityID = 0, CityName = "Select a City..." });
            cmbCity.DataSource = cities;
            cmbCity.DisplayMember = "CityName";
            cmbCity.ValueMember = "CityID";
        }
        private void BindCounties(int cityID)
        {
            var counties = countyBusiness.GetCountiesByCity(cityID);

            counties.Insert(0, new DataLayer.County { CountyID = 0, CountyName = "Select a County..." });
            cmbCounty.DataSource = counties;
            cmbCounty.DisplayMember = "CountyName";
            cmbCounty.ValueMember = "CountyID";
        }
        private void BindDistricts(int countyID)
        {
            var districts = districtBusiness.GetDistrictsByCounty(countyID);

            districts.Insert(0, new DataLayer.District { DistrictID = 0, DistrictName = "Select a District..." });
            cmbDistrict.DataSource = districts;
            cmbDistrict.DisplayMember = "DistrictName";
            cmbDistrict.ValueMember = "DistrictID";
        }
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCountry.SelectedIndex > 0)
            {
                var id = Convert.ToInt32(cmbCountry.SelectedValue);
                BindCities(id);
            }   
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedIndex>0)
            {
                var id = Convert.ToInt32(cmbCity.SelectedValue);
                BindCounties(id);
            }
        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCounty.SelectedIndex > 0)
            {
                var id = Convert.ToInt32(cmbCounty.SelectedValue);
                BindDistricts(id);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            coordinatorBusiness.Insert(new Coordinator
            {
                CoordinatorName = txtCoordinatorName.Text,
                CoordinatorDescription = txtCoordinatorDescription.Text,
                CountryID=Convert.ToInt32(cmbCountry.SelectedValue),
                CityID= Convert.ToInt32(cmbCity.SelectedValue),
                CountyID= Convert.ToInt32(cmbCounty.SelectedValue),
                DistrictID= Convert.ToInt32(cmbDistrict.SelectedValue),
                Latitude = txtLatitude.Text,
                Longtitude = txtLongtitude.Text
            });
            dgvCoordinators.DataSource = coordinatorBusiness.GetCoordinators();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            coordinatorBusiness.Update(new Coordinator
            {
                CoordinatorID = Convert.ToInt32(txtCoordinatorID.Text),
                CoordinatorName = txtCoordinatorName.Text,
                CoordinatorDescription = txtCoordinatorDescription.Text,
                CountryID = Convert.ToInt32(cmbCountry.SelectedValue),
                CityID = Convert.ToInt32(cmbCity.SelectedValue),
                CountyID = Convert.ToInt32(cmbCounty.SelectedValue),
                DistrictID = Convert.ToInt32(cmbDistrict.SelectedValue),
                Latitude = txtLatitude.Text,
                Longtitude = txtLongtitude.Text
            }) ;
            dgvCoordinators.DataSource = coordinatorBusiness.GetCoordinators();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            coordinatorBusiness.Delete(Convert.ToInt32(txtCoordinatorID.Text));
            dgvCoordinators.DataSource = coordinatorBusiness.GetCoordinators();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {

            txtCoordinatorID.Clear();
            txtCoordinatorName.Clear();
            txtCoordinatorDescription.Clear();
            txtLatitude.Clear();
            txtLongtitude.Clear();
            cmbCountry.SelectedIndex = 0;
            cmbCity.SelectedIndex = 0;
            cmbCounty.SelectedIndex = 0;
            cmbDistrict.SelectedIndex = 0;
        }

        private void dgvCoordinators_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCoordinatorID.Text = dgvCoordinators.Rows[e.RowIndex].Cells["CoordinatorID"].Value.ToString();
            txtCoordinatorName.Text = dgvCoordinators.Rows[e.RowIndex].Cells["CoordinatorName"].Value.ToString();
            txtCoordinatorDescription.Text = dgvCoordinators.Rows[e.RowIndex].Cells["CoordinatorDescription"].Value.ToString();
            txtLatitude.Text = dgvCoordinators.Rows[e.RowIndex].Cells["Latitude"].Value.ToString();
            txtLongtitude.Text = dgvCoordinators.Rows[e.RowIndex].Cells["Longtitude"].Value.ToString();
            cmbCountry.SelectedValue = Convert.ToInt32(dgvCoordinators.Rows[e.RowIndex].Cells["CountryID"].Value);
            cmbCity.SelectedValue = Convert.ToInt32(dgvCoordinators.Rows[e.RowIndex].Cells["CityID"].Value);
            cmbCounty.SelectedValue = Convert.ToInt32(dgvCoordinators.Rows[e.RowIndex].Cells["CountyID"].Value);
            cmbDistrict.SelectedValue = Convert.ToInt32(dgvCoordinators.Rows[e.RowIndex].Cells["DistrictID"].Value);
        }
    }
}
