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
    public partial class Sensors : Form
    {
        public Sensors()
        {
            InitializeComponent();
        }
        SensorBusiness sensorBusiness = new SensorBusiness();
        private void Sensorscs_Load(object sender, EventArgs e)
        {
            dgvSensors.DataSource = sensorBusiness.GetAll();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sensorBusiness.Insert(new DataLayer.Sensor
            {
                SensorName = txtSensorName.Text,
                SensorDefination = txtSensorDefinition.Text,
            });
            dgvSensors.DataSource = sensorBusiness.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sensorBusiness.Update(new DataLayer.Sensor
            {
                SensorID = Convert.ToInt32(txtSensorID.Text),
                SensorName = txtSensorName.Text,
                SensorDefination = txtSensorDefinition.Text
            });
            dgvSensors.DataSource = sensorBusiness.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sensorBusiness.Delete(Convert.ToInt32(txtSensorID.Text));
            dgvSensors.DataSource = sensorBusiness.GetAll();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtSensorID.Clear();
            txtSensorName.Clear();
            txtSensorDefinition.Clear();
        }

        private void dgvSensors_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtSensorName.Text = dgvSensors.Rows[e.RowIndex].Cells["SensorName"].Value.ToString();
            txtSensorID.Text = dgvSensors.Rows[e.RowIndex].Cells["SensorID"].Value.ToString();
            txtSensorDefinition.Text = dgvSensors.Rows[e.RowIndex].Cells["SensorDefination"].Value.ToString();
        }
    }
}
