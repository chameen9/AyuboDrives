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
    public partial class FrmMainDash : Form
    {
        public FrmMainDash()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult resExit = MessageBox.Show("Do you want to Exit ?", "Confirm to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {
            PnlTopic.BackColor = Color.FromArgb(100,107,5,146);
            PnlLogo.BackColor = Color.FromArgb(100, 107, 5, 146);
            PicLogo.BackColor = Color.FromArgb(100, 107, 5, 146);

            LblLoadName.Text = FrmLogin.unm;


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
                MessageBox.Show("Error while load Data" + err.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
            LblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult resExit = MessageBox.Show("Do you want to Logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                new FrmLogin().Show();
                this.Hide();
            }
        }

        private void BtnCusReg_Click(object sender, EventArgs e)
        {
            PnlLoad.Controls.Clear();

            FrmCusReg cusreg = new FrmCusReg();

            cusreg.TopLevel = false;
            PnlLoad.Controls.Add(cusreg);
            cusreg.Dock = DockStyle.Fill;
            cusreg.Show();

            BtnBack.Visible = true;
        }

        private void BtnDayt_Click(object sender, EventArgs e)
        {
            PnlLoad.Controls.Clear();

            FrmDayTour daytour = new FrmDayTour();

            daytour.TopLevel = false;
            PnlLoad.Controls.Add(daytour);
            daytour.Dock = DockStyle.Fill;
            daytour.Show();

            BtnBack.Visible = true;
        }

        private void BtnLongt_Click(object sender, EventArgs e)
        {
            PnlLoad.Controls.Clear();

            FrmLongTour longtour = new FrmLongTour();

            longtour.TopLevel = false;
            PnlLoad.Controls.Add(longtour);
            longtour.Dock = DockStyle.Fill;
            longtour.Show();

            BtnBack.Visible = true;
        }

        private void BtnRentcal_Click(object sender, EventArgs e)
        {
            PnlLoad.Controls.Clear();

            FrmRentCal rentcal = new FrmRentCal();

            rentcal.TopLevel = false;
            PnlLoad.Controls.Add(rentcal);
            rentcal.Dock = DockStyle.Fill;
            rentcal.Show();

            BtnBack.Visible = true;
        }

        private void BtnAdminCn_Click(object sender, EventArgs e)
        {
            PnlSideMenu.Visible = true;

            PnlLoad.Controls.Clear();

            FrmAdminLoadWait admwait = new FrmAdminLoadWait();

            admwait.TopLevel = false;
            PnlLoad.Controls.Add(admwait);
            admwait.Dock = DockStyle.Fill;
            admwait.Show();
        }

        private void LblVehReg_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(107,5,146);
            PnlVehDtls.BackColor = Color.FromArgb(143,51,242);
            PnlDrivReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlPackColl.BackColor = Color.FromArgb(143, 51, 242);
            PnlReports.BackColor = Color.FromArgb(143, 51, 242);
            PnlUserCon.BackColor = Color.FromArgb(143, 51, 242);

            PnlLoad.Controls.Clear();

            FrmVehReg vehreg = new FrmVehReg();

            vehreg.TopLevel = false;
            PnlLoad.Controls.Add(vehreg);
            vehreg.Dock = DockStyle.None;
            vehreg.Show();
        }

        private void LblVehDtls_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlVehDtls.BackColor = Color.FromArgb(107, 5, 146);
            PnlDrivReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlPackColl.BackColor = Color.FromArgb(143, 51, 242);
            PnlReports.BackColor = Color.FromArgb(143, 51, 242);
            PnlUserCon.BackColor = Color.FromArgb(143, 51, 242);

            PnlLoad.Controls.Clear();

            FrmVehDetails vedtls = new FrmVehDetails();

            vedtls.TopLevel = false;
            PnlLoad.Controls.Add(vedtls);
            vedtls.Dock = DockStyle.None;
            vedtls.Show();
        }

        private void LblDrivReg_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlVehDtls.BackColor = Color.FromArgb(143, 51, 242);
            PnlDrivReg.BackColor = Color.FromArgb(107, 5, 146);
            PnlPackColl.BackColor = Color.FromArgb(143, 51, 242);
            PnlReports.BackColor = Color.FromArgb(143, 51, 242);
            PnlUserCon.BackColor = Color.FromArgb(143, 51, 242);

            PnlLoad.Controls.Clear();

            FrmDrivReg drivreg = new FrmDrivReg();

            drivreg.TopLevel = false;
            PnlLoad.Controls.Add(drivreg);
            drivreg.Dock = DockStyle.None;
            drivreg.Show();
        }

        private void LblPckColl_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlVehDtls.BackColor = Color.FromArgb(143, 51, 242);
            PnlDrivReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlPackColl.BackColor = Color.FromArgb(107, 5, 146);
            PnlReports.BackColor = Color.FromArgb(143, 51, 242);
            PnlUserCon.BackColor = Color.FromArgb(143, 51, 242);

            PnlLoad.Controls.Clear();

            FrmPackReg pckg = new FrmPackReg();

            pckg.TopLevel = false;
            PnlLoad.Controls.Add(pckg);
            pckg.Dock = DockStyle.None;
            pckg.Show();
        }

        private void LblReports_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlVehDtls.BackColor = Color.FromArgb(143, 51, 242);
            PnlDrivReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlPackColl.BackColor = Color.FromArgb(143, 51, 242);
            PnlReports.BackColor = Color.FromArgb(107, 5, 146);
            PnlUserCon.BackColor = Color.FromArgb(143, 51, 242);

            PnlLoad.Controls.Clear();

            FrmReports reprts = new FrmReports();

            reprts.TopLevel = false;
            PnlLoad.Controls.Add(reprts);
            reprts.Dock = DockStyle.None;
            reprts.Show();
        }

        private void LblUserCon_Click(object sender, EventArgs e)
        {
            PnlVehReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlVehDtls.BackColor = Color.FromArgb(143, 51, 242);
            PnlDrivReg.BackColor = Color.FromArgb(143, 51, 242);
            PnlPackColl.BackColor = Color.FromArgb(143, 51, 242);
            PnlReports.BackColor = Color.FromArgb(143, 51, 242);
            PnlUserCon.BackColor = Color.FromArgb(107, 5, 146);

            PnlLoad.Controls.Clear();

            FrmUserControl usrcon = new FrmUserControl();

            usrcon.TopLevel = false;
            PnlLoad.Controls.Add(usrcon);
            usrcon.Dock = DockStyle.None;
            usrcon.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMainDash mndsh = new FrmMainDash();
            mndsh.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            FrmMainDash mndsh = new FrmMainDash();
            mndsh.Show();
            this.Hide();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.BackColor = Color.FromArgb(107, 5, 146);
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMax.Visible = false;
            BtnNormal.Visible = true;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMax.Visible = true;
            BtnNormal.Visible = false;
        }
    }
}
