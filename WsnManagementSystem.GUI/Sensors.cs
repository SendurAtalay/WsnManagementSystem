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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSet_Click(object sender, EventArgs e)
        {

        }
    }
}
