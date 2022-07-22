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
    public partial class SensorMeasurementsForm : Form
    {
        public SensorMeasurementsForm()
        {
            InitializeComponent();
        }
  
        SensorMeasurementBusiness sensorMeasurementBusiness = new SensorMeasurementBusiness();
        SensorBusiness sensorBusiness = new SensorBusiness();
        RouterBusiness routerBusiness = new RouterBusiness();
        SensorMeasurementTypeBusiness sensorMeasurementTypeBusiness = new SensorMeasurementTypeBusiness();
        private void SensorMeasurementsForm_Load(object sender, EventArgs e)
        {
            BindSensors();
            BindSensorMeasurementType();
            BindRouters();
            dgvSensorMeasurement.DataSource = sensorMeasurementBusiness.GetSensorMeasurements();
        }
        private void BindSensors()
        {
            var sensors = sensorBusiness.GetAll();

            sensors.Insert(0, new DataLayer.Sensor { SensorID = 0, SensorName = "Select a Sensor..." });
            cmbSensor.DataSource = sensors;
            cmbSensor.DisplayMember = "SensorName";
            cmbSensor.ValueMember = "SensorID";
        }
        private void BindRouters()
        {
            var routers = routerBusiness.GetAll();

            routers.Insert(0, new DataLayer.Router { RouterID = 0, RouterName = "Select a Router..." });
            cmbRouter.DataSource = routers;
            cmbRouter.DisplayMember = "RouterName";
            cmbRouter.ValueMember = "RouterID";
        }
        private void BindSensorMeasurementType()
        {
            var sensorMeasurementType = sensorMeasurementTypeBusiness.GetAll();

            sensorMeasurementType.Insert(0, new DataLayer.SensorMeasurementType { SensorMeasurementTypeID = 0, SensorMeasurementTypeName = "Select a S.Measurement Type..." });
            cmbSensorMeasurementType.DataSource = sensorMeasurementType;
            cmbSensorMeasurementType.DisplayMember = "SensorMeasurementTypeName";
            cmbSensorMeasurementType.ValueMember = "SensorMeasurementTypeID";
        }


        private void dgvSensorMeasurement_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSensorMeasurementID.Text = dgvSensorMeasurement.Rows[e.RowIndex].Cells["SensorMeasurementID"].Value.ToString();
            dtpCreatedTime.Text = dgvSensorMeasurement.Rows[e.RowIndex].Cells["SensorMeasurementDateTime"].Value.ToString();
            txtSensorMeasurementValue.Text = dgvSensorMeasurement.Rows[e.RowIndex].Cells["SensorMeasurementValue"].Value.ToString();
            cmbSensorMeasurementType.SelectedValue = Convert.ToInt32(dgvSensorMeasurement.Rows[e.RowIndex].Cells["SensorMeasurementTypeID"].Value);
            cmbSensor.SelectedValue = Convert.ToInt32(dgvSensorMeasurement.Rows[e.RowIndex].Cells["SensorID"].Value);
            cmbRouter.SelectedValue = Convert.ToInt32(dgvSensorMeasurement.Rows[e.RowIndex].Cells["RouterID"].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sensorMeasurementBusiness.Insert(new DataLayer.SensorMeasurement
            {
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
                RouterID = Convert.ToInt32(cmbRouter.SelectedValue),
                SensorMeasurementTypeID = Convert.ToInt32(cmbSensorMeasurementType.SelectedValue),
                SensorMeasurementDateTime = Convert.ToDateTime(dtpCreatedTime.Value),
                SensorMeasurementValue = txtSensorMeasurementValue.Text,
                
            }) ;
            dgvSensorMeasurement.DataSource = sensorMeasurementBusiness.GetSensorMeasurements();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sensorMeasurementBusiness.Update(new DataLayer.SensorMeasurement
            {
                SensorMeasurementID=Convert.ToInt32(txtSensorMeasurementID.Text),
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
                RouterID = Convert.ToInt32(cmbRouter.SelectedValue),
                SensorMeasurementTypeID = Convert.ToInt32(cmbSensorMeasurementType.SelectedValue),
                SensorMeasurementDateTime = Convert.ToDateTime(dtpCreatedTime.Value),
                SensorMeasurementValue = txtSensorMeasurementValue.Text,

            });
            dgvSensorMeasurement.DataSource = sensorMeasurementBusiness.GetSensorMeasurements();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sensorMeasurementBusiness.Delete(Convert.ToInt32(txtSensorMeasurementID.Text));
            dgvSensorMeasurement.DataSource = sensorMeasurementBusiness.GetSensorMeasurements();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtSensorMeasurementID.Clear();
            txtSensorMeasurementValue.Clear();
            cmbSensor.SelectedIndex = 0;
            cmbRouter.SelectedIndex = 0;
            cmbSensorMeasurementType.SelectedIndex = 0;
        }
    }
}
