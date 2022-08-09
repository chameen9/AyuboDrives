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
using System.Runtime.InteropServices;

namespace AyuboDrive
{
    public partial class FrmLogin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]


        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int NwidthElipse,
            int nHeightElipse
            );

        public FrmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        DtaBse dtb = new DtaBse();

        private void loginprocess()
        {
            unm = TxtUsername.Text;

            String que = "SELECT * FROM UserControl WHERE UserName='" + TxtUsername.Text + "' AND UserPw='" + TxtPassword.Text + "'";
            int rows = dtb.rcount(que);



            if (rows >= 1)
            {
                dtb.con.Open();
                dtb.cmd = new SqlCommand(que, dtb.con);
                SqlDataReader read = dtb.cmd.ExecuteReader();



                while (read.Read())
                {
                    userlevel = read.GetValue(2).ToString();
                }
                dtb.con.Close();



                FrmMainDash mndash = new FrmMainDash();
                mndash.Show();
                this.Hide();

            }
            else if (TxtUsername.Text == "Username" || TxtPassword.Text == "Password")
            {
                MessageBox.Show("Username or Password cannot be empty !", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Username or Password should be wrong. Please check again !", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string userlevel = "";
        public static string unm = "";

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder

            BtnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            loginprocess();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult resExit = MessageBox.Show("Do you want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (resExit == DialogResult.No)
            {
                
            }
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "Username")
            {
                TxtUsername.Text = "";
                TxtUsername.ForeColor = Color.FromArgb(26,23,58);
                PnlUn.BackColor = Color.FromArgb(76, 66, 166);
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (TxtUsername.Text == "")
            {
                TxtUsername.Text = "Username";
                TxtUsername.ForeColor = Color.FromArgb(50, 35, 146);
                PnlUn.BackColor = Color.FromArgb(160, 90, 245);
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "Password")
            {
                TxtPassword.Text = "";
                TxtPassword.ForeColor = Color.FromArgb(26,23,58);
                TxtPassword.UseSystemPasswordChar = true;
                PnlShHdPw.Visible = true;
                PnlPw.BackColor = Color.FromArgb(76, 66, 166);
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                TxtPassword.Text = "Password";
                TxtPassword.ForeColor = Color.FromArgb(50, 35, 146);
                TxtPassword.UseSystemPasswordChar = false;
                PnlShHdPw.Visible = false;
                PnlPw.BackColor = Color.FromArgb(160, 90, 245);
            }
        }

        private void PicShowPw_Click(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = false;
            PicHidePw.Visible = true;
            PicShowPw.Visible = false;
        }

        private void PicHidePw_Click(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
            PicHidePw.Visible = false;
            PicShowPw.Visible = true;
        }
    }
}
