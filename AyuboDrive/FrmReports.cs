using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult resExit = MessageBox.Show("Do you want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //new FrmAdminDash().Show(); // load admin form
            this.Visible = false;
        }
    }
}
