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
    public partial class DefinationOfSensorMeasurementForm : Form
    {
        public DefinationOfSensorMeasurementForm()
        {
            InitializeComponent();
        }
        DefinationOfSensorMeasurementBusiness definatiofsensormeasurementBusiness = new DefinationOfSensorMeasurementBusiness();
        SensorBusiness sensorBusiness = new SensorBusiness();
        SensorMeasurementTypeBusiness sensormeasurementtypebusiness = new SensorMeasurementTypeBusiness();

        private void DefinationOfSensorMeasurementForm_Load(object sender, EventArgs e)
        {
            dgvDefinationOfSensorMeasurement.DataSource = definatiofsensormeasurementBusiness.DefinationOfSensorMeasurement();
            BindSensors();
            BindSensorMeasurementType();
        }
        private void BindSensors()
        {
            var sensors = sensorBusiness.GetAll();

            sensors.Insert(0, new DataLayer.Sensor { SensorID = 0, SensorName = "Select a Sensor..." });
            cmbSensor.DataSource = sensors;
            cmbSensor.DisplayMember = "SensorName";
            cmbSensor.ValueMember = "SensorID";
        }

        private void BindSensorMeasurementType()
        {
            var sensorMeasurementType = sensormeasurementtypebusiness.GetAll();

            sensorMeasurementType.Insert(0, new DataLayer.SensorMeasurementType { SensorMeasurementTypeID = 0, SensorMeasurementTypeName = "Select a Sensor Type..." });
            cmbSensorMeasurementTypes.DataSource = sensorMeasurementType;
            cmbSensorMeasurementTypes.DisplayMember = "SensorMeasurementTypeName";
            cmbSensorMeasurementTypes.ValueMember = "SensorMeasurementTypeID";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            definatiofsensormeasurementBusiness.Insert(new DataLayer.DefinationOfSensorMeasurement
            {
                DataTypeOfMeasurement = txtDataTypeOfMeasurement.Text,
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
                SensorMeasurementTypeID = Convert.ToInt32(cmbSensorMeasurementTypes.SelectedValue),
               
            });
            dgvDefinationOfSensorMeasurement.DataSource = definatiofsensormeasurementBusiness.DefinationOfSensorMeasurement();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            definatiofsensormeasurementBusiness.Update(new DataLayer.DefinationOfSensorMeasurement
            {
                DefinationOfSensorMeasurementID = Convert.ToInt32(txtDefinationOfSensorMeasurementID.Text),
                DataTypeOfMeasurement = txtDataTypeOfMeasurement.Text,
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
                SensorMeasurementTypeID = Convert.ToInt32(cmbSensorMeasurementTypes.SelectedValue),

            });
            dgvDefinationOfSensorMeasurement.DataSource = definatiofsensormeasurementBusiness.DefinationOfSensorMeasurement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            definatiofsensormeasurementBusiness.Delete(Convert.ToInt32(txtDefinationOfSensorMeasurementID.Text));
            dgvDefinationOfSensorMeasurement.DataSource = definatiofsensormeasurementBusiness.DefinationOfSensorMeasurement();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtDefinationOfSensorMeasurementID.Clear();
            txtDataTypeOfMeasurement.Clear();
            cmbSensor.SelectedIndex = 0;
            cmbSensorMeasurementTypes.SelectedIndex = 0;
        }

        private void dgvDefinationOfSensorMeasurement_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDefinationOfSensorMeasurementID.Text = dgvDefinationOfSensorMeasurement.Rows[e.RowIndex].Cells["DefinationOfSensorMeasurementID"].Value.ToString();
            txtDataTypeOfMeasurement.Text = dgvDefinationOfSensorMeasurement.Rows[e.RowIndex].Cells["DataTypeOfMeasurement"].Value.ToString();
            cmbSensor.SelectedValue = Convert.ToInt32(dgvDefinationOfSensorMeasurement.Rows[e.RowIndex].Cells["SensorID"].Value);
            cmbSensorMeasurementTypes.SelectedValue = Convert.ToInt32(dgvDefinationOfSensorMeasurement.Rows[e.RowIndex].Cells["SensorMeasurementTypeID"].Value);
        }
    }
}
