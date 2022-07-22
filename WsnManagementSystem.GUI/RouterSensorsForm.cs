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
    public partial class RouterSensorsForm : Form
    {
        public RouterSensorsForm()
        {
            InitializeComponent();
        }
        RouterBusiness routerBusiness = new RouterBusiness();
        SensorBusiness sensorBusiness = new SensorBusiness();
        RouterSensorBusiness routerSensorBusiness= new RouterSensorBusiness();
        private void RouterSensorsForm_Load(object sender, EventArgs e)
        {
            BindRouter();
            BindSensor();
            dgvRouterSensor.DataSource = routerSensorBusiness.GetRouterSensors();
        }
        private void BindRouter()
        {
            var router = routerBusiness.GetAll();

            router.Insert(0, new DataLayer.Router { RouterID = 0, RouterName = "Select a Router..." });
            cmbRouter.DataSource = router;
            cmbRouter.DisplayMember = "RouterName";
            cmbRouter.ValueMember = "RouterID";
        }
        private void BindSensor()
        {
            var sensor = sensorBusiness.GetAll();

            sensor.Insert(0, new DataLayer.Sensor { SensorID = 0, SensorName = "Select a Sensor..." });
            cmbSensor.DataSource = sensor;
            cmbSensor.DisplayMember = "SensorName";
            cmbSensor.ValueMember = "SensorID";
        }

        private void dgvRouterSensor_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtRouterSensorID.Text = dgvRouterSensor.Rows[e.RowIndex].Cells["RouterSensorID"].Value.ToString();
            cmbRouter.SelectedValue = Convert.ToInt32(dgvRouterSensor.Rows[e.RowIndex].Cells["RouterID"].Value);
            cmbSensor.SelectedValue = Convert.ToInt32(dgvRouterSensor.Rows[e.RowIndex].Cells["SensorID"].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            routerSensorBusiness.Insert(new DataLayer.RouterSensor
            {
                
                RouterID = Convert.ToInt32(cmbRouter.SelectedValue),
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
            });
            dgvRouterSensor.DataSource = routerSensorBusiness.GetRouterSensors();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            routerSensorBusiness.Update(new DataLayer.RouterSensor
            {
                RouterSensorID = Convert.ToInt32(txtRouterSensorID.Text),
                RouterID = Convert.ToInt32(cmbRouter.SelectedValue),
                SensorID = Convert.ToInt32(cmbSensor.SelectedValue),
            });
            dgvRouterSensor.DataSource = routerSensorBusiness.GetRouterSensors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            routerSensorBusiness.Delete(Convert.ToInt32(txtRouterSensorID.Text));
            dgvRouterSensor.DataSource = routerSensorBusiness.GetRouterSensors();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtRouterSensorID.Clear();
            cmbRouter.SelectedIndex = 0;
            cmbSensor.SelectedIndex = 0;
        }
    }
}
