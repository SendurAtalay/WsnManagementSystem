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
    public partial class WsnDomains : Form
    {
        public WsnDomains()
        {
            InitializeComponent();
        }
        WsnDomainsBusiness wsnDomainBusiness = new WsnDomainsBusiness();
        private void WsnDomains_Load(object sender, EventArgs e)
        {
            dgvDomains.DataSource = wsnDomainBusiness.GetAll();
        }

        private void dgvDomains_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDomainName.Text = dgvDomains.Rows[e.RowIndex].Cells["WsnDomainName"].Value.ToString();
            txtDomainID.Text = dgvDomains.Rows[e.RowIndex].Cells["WsnDomainID"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            wsnDomainBusiness.Insert(new DataLayer.WsnDomain
            {
                WsnDomainName = txtDomainName.Text,
                
            });
            dgvDomains.DataSource = wsnDomainBusiness.GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            wsnDomainBusiness.Update(new DataLayer.WsnDomain
            {
                WsnDomainID = Convert.ToInt32(txtDomainID.Text),
                WsnDomainName = txtDomainName.Text,
                
            });
            dgvDomains.DataSource = wsnDomainBusiness.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            wsnDomainBusiness.Delete(Convert.ToInt32(txtDomainID.Text));
            dgvDomains.DataSource = wsnDomainBusiness.GetAll();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            txtDomainID.Clear();
            txtDomainName.Clear();
        }
    }
}
