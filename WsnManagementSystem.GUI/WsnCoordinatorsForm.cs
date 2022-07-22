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
    public partial class WsnCoordinatorsForm : Form
    {
        public WsnCoordinatorsForm()
        {
            InitializeComponent();
        }
        CoordinatorBusiness coordinatorsBusiness = new CoordinatorBusiness();
        SensorNetworkBusiness sensorNetworkBusiness = new SensorNetworkBusiness();
        WsnCoordinatorBusiness wsncoordinatorBusiness = new WsnCoordinatorBusiness();

        private void WsnCoordinatorsForm_Load(object sender, EventArgs e)
        {
            dgvWsnCoordinator.DataSource = wsncoordinatorBusiness.GetWsnCoordinators();
            BindSensorNetwork(); 
            BindCoordinator();
        }
        private void BindCoordinator()
        {
            var coordinators = coordinatorsBusiness.GetAll();

            coordinators.Insert(0, new DataLayer.Coordinator { CoordinatorID = 0, CoordinatorName = "Select a Coordinator..." });
            cmbCoordinator.DataSource = coordinators;
            cmbCoordinator.DisplayMember = "CoordinatorName";
            cmbCoordinator.ValueMember = "CoordinatorID";
        }
        private void BindSensorNetwork()
        {
            var sensorNetworks = sensorNetworkBusiness.GetAll();

            sensorNetworks.Insert(0, new DataLayer.SensorNetwork { SensorNetworkID = 0, SensorNetworkName = "Select a SensorNetwork..." });
            cmbSensorNetwork.DataSource = sensorNetworks;
            cmbSensorNetwork.DisplayMember = "SensorNetworkName";
            cmbSensorNetwork.ValueMember = "SensorNetworkID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            wsncoordinatorBusiness.Insert(new DataLayer.WsnCoordinator
            {

                WsnSensorNetworkID = Convert.ToInt32(cmbSensorNetwork.SelectedValue),
                CoordinatorID = Convert.ToInt32(cmbCoordinator.SelectedValue),

            });
            dgvWsnCoordinator.DataSource = wsncoordinatorBusiness.GetWsnCoordinators();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            wsncoordinatorBusiness.Update(new DataLayer.WsnCoordinator
            {
                Id = Convert.ToInt32(txtId.Text),
                WsnSensorNetworkID = Convert.ToInt32(cmbSensorNetwork.SelectedValue),
                CoordinatorID = Convert.ToInt32(cmbCoordinator.SelectedValue),

            });
            dgvWsnCoordinator.DataSource = wsncoordinatorBusiness.GetWsnCoordinators();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            wsncoordinatorBusiness.Delete(Convert.ToInt32(txtId.Text));
            dgvWsnCoordinator.DataSource = wsncoordinatorBusiness.GetWsnCoordinators();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            cmbSensorNetwork.SelectedIndex = 0;
            cmbCoordinator.SelectedIndex = 0;
        }

        private void dgvWsnCoordinator_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvWsnCoordinator.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            cmbSensorNetwork.SelectedValue = Convert.ToInt32(dgvWsnCoordinator.Rows[e.RowIndex].Cells["WsnSensorNetworkID"].Value);
            cmbCoordinator.SelectedValue = Convert.ToInt32(dgvWsnCoordinator.Rows[e.RowIndex].Cells["CoordinatorID"].Value);
        }
    }
}
