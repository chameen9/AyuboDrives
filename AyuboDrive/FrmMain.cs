using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AyuboDrive
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder

            BtnCusReg.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent border
            BtnRentcal.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            BtnDayt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            BtnAdminCn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            BtnLongt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            BtnCusReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent; //transparent over colour
            BtnRentcal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BtnDayt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BtnLongt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BtnAdminCn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;

            String uname = FrmLogin.unm;
            String Utype = "";

            try
            {
                dtb.con.Open();
                String select_query = "SELECT UserType FROM UserControl WHERE UserName='" + uname + "'";
                dtb.cmd = new SqlCommand(select_query, dtb.con);
                SqlDataReader R = dtb.cmd.ExecuteReader();
                while (R.Read())
                {
                    Utype = R.GetValue(0).ToString();

                }
                dtb.con.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show("Error while load Data" + err.Message,"System Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Utype == "Admin")
            {
                BtnAdminCn.Visible = true;
            }
            else
            {
                BtnAdminCn.Visible = false;
            }

        }

        private void BtnCusReg_Click_1(object sender, EventArgs e)
        {
            //new FrmCusReg().Show(); // load customer registration
            //this.Visible = false;

            //FrmMainDash.PnlLoad.Controls.Clear();

            //FrmMain main = new FrmMain();

            //main.TopLevel = false;
            //PnlLoad.Controls.Add(main);
            //main.Dock = DockStyle.None;
            //main.Show();
        }

        private void BtnDayt_Click_1(object sender, EventArgs e)
        {
            new FrmDayTour().Show(); // load day tour
            this.Visible = false;
        }

        private void BtnLongt_Click_1(object sender, EventArgs e)
        {
            new FrmLongTour().Show(); // load long tour
            this.Visible = false;
        }

        private void BtnRentcal_Click_1(object sender, EventArgs e)
        {
            new FrmRentCal().Show(); // load rent calculation
            this.Visible = false;
        }

        private void BtnAdminCn_Click_1(object sender, EventArgs e)
        {
            //new FrmAdminDash().Show(); // load admin dash
            //this.Visible = false;
        }
    }
}
