using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesSystem
{
    public partial class frmChicken : Form
    {
        public frmChicken()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("LOGOUT APPLICATION", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfile frmProfile = new frmProfile();
            frmProfile.Show();

            this.Hide();
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            frmChicken frmChicken = new frmChicken();
            frmChicken.Show();

            this.Hide();
        }
    }
}
