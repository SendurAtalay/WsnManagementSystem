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
    }
}
