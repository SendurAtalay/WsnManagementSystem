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
    public partial class SensorMeasurementTypes : Form
    {
        public SensorMeasurementTypes()
        {
            InitializeComponent();
        }
        SensorMeasurementTypeBusiness sensorMeasurementTypes = new SensorMeasurementTypeBusiness();
        private void SensorMeasurementTypes_Load(object sender, EventArgs e)
        {
            dgvMeasurementTypes.DataSource = sensorMeasurementTypes.GetAll();
        }

        private void dgvMeasurementTypes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMeasurementID.Text = dgvMeasurementTypes.Rows[e.RowIndex].Cells["SensorMeasurementTypeID"].Value.ToString();
            txtMeasurementName.Text = dgvMeasurementTypes.Rows[e.RowIndex].Cells["SensorMeasurementTypeName"].Value.ToString();
            txtMeasurementAbbreviation.Text = dgvMeasurementTypes.Rows[e.RowIndex].Cells["SensorMeasurementTypeAbbreviation"].Value.ToString();

        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtMeasurementID.Clear();
           txtMeasurementName.Clear();
            txtMeasurementAbbreviation.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sensorMeasurementTypes.Insert(new DataLayer.SensorMeasurementType
            {
                SensorMeasurementTypeName=txtMeasurementName.Text,
                SensorMeasurementTypeAbbreviation=txtMeasurementAbbreviation.Text
            });
            dgvMeasurementTypes.DataSource = sensorMeasurementTypes.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sensorMeasurementTypes.Update(new DataLayer.SensorMeasurementType
            {
                SensorMeasurementTypeID = Convert.ToInt32(txtMeasurementID.Text),
                SensorMeasurementTypeName = txtMeasurementName.Text,
                SensorMeasurementTypeAbbreviation = txtMeasurementAbbreviation.Text
            });
            dgvMeasurementTypes.DataSource = sensorMeasurementTypes.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sensorMeasurementTypes.Delete(Convert.ToInt32(txtMeasurementID.Text));
            dgvMeasurementTypes.DataSource = sensorMeasurementTypes.GetAll();
        }

    }
}
