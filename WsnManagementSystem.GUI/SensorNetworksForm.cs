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
    public partial class SensorNetworksForm : Form
    {
        public SensorNetworksForm()
        {
            InitializeComponent();
        }
        SensorNetworkBusiness sensorNetworkBusiness = new SensorNetworkBusiness();
        WsnDomainsBusiness wsnDomainsBusiness = new WsnDomainsBusiness();

        private void SensorNetworksForm_Load(object sender, EventArgs e)
        {
            dgvSensorNetwork.DataSource = sensorNetworkBusiness.GetSensorNetworks();
            BindWsnDomains();
        }

        private void BindWsnDomains()
        {
            var wsndomains = wsnDomainsBusiness.GetAll();

            wsndomains.Insert(0, new DataLayer.WsnDomain { WsnDomainID = 0, WsnDomainName = "Select a Domain..." });
            cmbDomain.DataSource = wsndomains;
            cmbDomain.DisplayMember = "WsnDomainName";
            cmbDomain.ValueMember = "WsnDomainID";
        }

        private void dgvSensorNetwork_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSensorNetworkId.Text = dgvSensorNetwork.Rows[e.RowIndex].Cells["SensorNetworkID"].Value.ToString();
            txtSensorNetworkName.Text = dgvSensorNetwork.Rows[e.RowIndex].Cells["SensorNetworkName"].Value.ToString();
            txtSensorNetworkDesc.Text = dgvSensorNetwork.Rows[e.RowIndex].Cells["SensorNetworkDesc"].Value.ToString();
            dtpCreatedDate.Value = Convert.ToDateTime(dgvSensorNetwork.Rows[e.RowIndex].Cells["SensorNetworkCreatedDateTime"].Value);
            cmbDomain.SelectedValue = Convert.ToInt32(dgvSensorNetwork.Rows[e.RowIndex].Cells["DomainID"].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sensorNetworkBusiness.Insert(new DataLayer.SensorNetwork { SensorNetworkName = txtSensorNetworkName.Text, DomainID = Convert.ToInt32(cmbDomain.SelectedValue), SensorNetworkDescription = txtSensorNetworkDesc.Text, SensorNetworkCreatedDateTime = Convert.ToDateTime(dtpCreatedDate.Value) });
            dgvSensorNetwork.DataSource = sensorNetworkBusiness.GetSensorNetworks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sensorNetworkBusiness.Update(new DataLayer.SensorNetwork { SensorNetworkID = Convert.ToInt32(txtSensorNetworkId.Text), SensorNetworkName = txtSensorNetworkName.Text, DomainID = Convert.ToInt32(cmbDomain.SelectedValue), SensorNetworkDescription= txtSensorNetworkDesc.Text, SensorNetworkCreatedDateTime = Convert.ToDateTime(dtpCreatedDate.Value) });
            dgvSensorNetwork.DataSource = sensorNetworkBusiness.GetSensorNetworks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sensorNetworkBusiness.Delete(Convert.ToInt32(txtSensorNetworkId.Text));
            dgvSensorNetwork.DataSource = sensorNetworkBusiness.GetSensorNetworks();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtSensorNetworkId.Clear();
            txtSensorNetworkName.Clear();
            txtSensorNetworkDesc.Clear();
            
            cmbDomain.SelectedIndex = 0;
        }
    }
}
