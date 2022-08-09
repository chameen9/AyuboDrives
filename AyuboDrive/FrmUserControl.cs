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
    public partial class FrmUserControl : Form
    {
        public FrmUserControl()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        public void erase()
        {
            TxtName.Text = "";
            TxtPw.Text = "";
            CmbType.SelectedIndex = 0;
            TxtName.Focus();
        }

        public void erase2()
        {
            CmbName.SelectedIndex = 0;
            TxtPw.Text = "";
            CmbType.SelectedIndex = 0;
            CmbName.Focus();
        }

        private void FrmUserControl_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string uname = TxtName.Text;
            string pw = TxtPw.Text;
            string type = CmbType.Text;

            if (uname == "" || pw == "" || type == "-Select-" || type == "")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO UserControl VALUES('" + TxtName.Text + "','" + TxtPw.Text + "','" + CmbType.Text + "')", "User registeration was Successful ! ");
                erase();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string nm = CmbName.Text;

            if (nm == "" || nm == "-Select-")
            {
                MessageBox.Show("Please select a User!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbName.Focus();
            }
            else
            {
            dtb.updateq("UPDATE UserControl SET UserPw = '" + TxtPw.Text + "', UserType = '" + CmbType.Text + "' WHERE UserName='" + CmbName.Text + "'", "User, " + CmbName.Text + "'s details update was Successfull !");
            erase2();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string nm = CmbName.Text;

            if (nm == "" || nm == "-Select-")
            {
                MessageBox.Show("Please select a User!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbName.Focus();
            }
            else
            {
            dtb.deleteq("DELETE FROM UserControl WHERE UserName='" + CmbName.Text + "'", "User, " + CmbName.Text + "'s details deleted Successfully !");
            erase2();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            erase();

            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            BtnClear.Visible = false;
            BtnReg.Visible = false;
            BtnClose.Visible = true;
            BtnSearch.Visible = false;
            CmbName.Visible = true;
            TxtName.Visible = false;
            CmbName.Focus();


            try
            {
                String quegetname = "SELECT UserName FROM UserControl ORDER BY UserName";      // calling customer id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);
                dtb.con.Close();



                CmbName.Items.Clear();
                CmbName.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbName.Items.Add(row["UserName"]);      // add cus ids to the cmbid
                }

                CmbName.SelectedIndex = 0;

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            BtnClear.Visible = true;
            BtnReg.Visible = true;
            BtnClose.Visible = false;
            BtnSearch.Visible = true;
            CmbName.Visible = false;
            TxtName.Visible = true;
            TxtName.Focus();
            erase2();
        }

        private void CmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // load all table data to the form by using cmbname
                if (CmbName.SelectedIndex > 0)
                {
                    String username = CmbName.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM UserControl WHERE UserName = '" + username + "' ORDER BY UserName";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtPw.Text = R.GetValue(1).ToString();
                        CmbType.Text = R.GetValue(2).ToString();
                        
                    }
                    dtb.con.Close();
                }
                else
                {
                    TxtPw.Text = "";
                    CmbType.SelectedIndex = 0;
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
