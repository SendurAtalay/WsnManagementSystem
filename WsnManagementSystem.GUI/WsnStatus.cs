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
    public partial class WsnStatus : Form
    {
        public WsnStatus()
        {
            InitializeComponent();
        }
        WsnStatueBusiness wsnStatueBusiness = new WsnStatueBusiness();
        private void WsnStatus_Load(object sender, EventArgs e)
        {
            dgvWsnStatus.DataSource = wsnStatueBusiness.GetAll();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            wsnStatueBusiness.Insert(new DataLayer.WsnStatu
            {
                WsnStatueName = txtStatueName.Text,
            });
            dgvWsnStatus.DataSource = wsnStatueBusiness.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            wsnStatueBusiness.Update(new DataLayer.WsnStatu
            {
                WsnStatueID = Convert.ToInt32(txtStatueID.Text),
                WsnStatueName = txtStatueName.Text,
            });
            dgvWsnStatus.DataSource = wsnStatueBusiness.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            wsnStatueBusiness.Delete(Convert.ToInt32(txtStatueID.Text));
            dgvWsnStatus.DataSource = wsnStatueBusiness.GetAll();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtStatueID.Clear();
            txtStatueName.Clear();
        }

        private void dgvWsnStatus_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtStatueName.Text = dgvWsnStatus.Rows[e.RowIndex].Cells["WsnStatueName"].Value.ToString();
            txtStatueID.Text = dgvWsnStatus.Rows[e.RowIndex].Cells["WsnStatueID"].Value.ToString();
           
        }
    }
}
