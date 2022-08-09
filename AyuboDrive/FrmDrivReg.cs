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
    public partial class FrmDrivReg : Form
    {
        public FrmDrivReg()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();


        private void erase()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtNIC.Text = "";
            CmbGender.SelectedIndex = 0;
            TxtContact.Text = "";
            TxtEmail.Text = "";
            TxtAddress.Text = "";
            DtpAssign.Value = DateTime.Now;
            DtpRelese.Value = DateTime.Now;
            TxtID.Focus();
        }

        private void erase2()
        {
            CmbID.Text = "";
            TxtName.Text = "";
            TxtNIC.Text = "";
            CmbGender.SelectedIndex = 0;
            TxtContact.Text = "";
            TxtEmail.Text = "";
            TxtAddress.Text = "";
            DtpAssign.Text="";
            DtpRelese.Text="";
            CmbID.Focus();
        }

        private void FrmDrivReg_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
            TxtID.Focus();
            CmbGender.SelectedIndex = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)     // exit button
        {
            DialogResult resExit = MessageBox.Show("Do you want to Exit?", "Confirm to Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)  //minimize button
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text;
            string uname = TxtName.Text;
            string nic = TxtNIC.Text;
            string gender = CmbGender.Text;
            string contact = TxtContact.Text;
            string email = TxtEmail.Text;
            string add = TxtAddress.Text;
            string adte = DtpAssign.Text;
            string rdte = DtpRelese.Text;
            string time = DateTime.Now.ToString();

            if (id == "" || uname == "" || nic == "" || gender == "-Select-" || gender == "" || contact == "" || email == "" || add == "" || rdte == time)
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtID.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO Driver VALUES('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtNIC.Text + "','" + CmbGender.Text + "','" + TxtContact.Text + "','" + TxtEmail.Text + "','" + TxtAddress.Text + "','" + DtpAssign.Text + "','" + DtpRelese.Text + "')", "Driver registeration was Successful ! ");
                erase();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id = CmbID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Driver!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbID.Focus();
            }

            else
            {
            dtb.updateq("UPDATE Driver SET DrivName = '" + TxtName.Text + "', NIC = '" + TxtNIC.Text + "', Gender = '" + CmbGender.Text + "' , ContNumber = '" + TxtContact.Text + "' , Email = '" + TxtEmail.Text + "', Address = '" + TxtAddress.Text + "', AssignDate = '" + DtpAssign.Text + "', ReleaseDate = '" + DtpRelese.Text + "' WHERE DrivID='" + CmbID.Text + "'", "Driver, " + TxtName.Text + "'s details update was Successfull !");
            erase2();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = CmbID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Driver!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbID.Focus();
            }
            else
            {
                dtb.deleteq("DELETE FROM Driver WHERE DrivID='" + CmbID.Text + "'", "Driver, " + TxtName.Text + "'s details deleted Successfully !");
                erase2();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            erase();

            CmbID.Visible = true;
            TxtID.Visible = false;
            BtnClose.Visible = true;
            BtnSearch.Visible = false;
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            BtnClear.Visible = false;
            BtnReg.Visible = false;
            CmbID.Focus();


            try
            {
                String queGetID = "SELECT DrivID FROM Driver ORDER BY DrivID";      // calling customer id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(queGetID, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);
                dtb.con.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["DrivID"]);      // add cus ids to the cmbid
                }

                CmbID.SelectedIndex = 0;

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            BtnClose.Visible = false;
            BtnSearch.Visible = true;
            CmbID.Visible = false;
            TxtID.Visible = true;
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            BtnClear.Visible = true;
            BtnReg.Visible = true;
            TxtID.Focus();
            erase();
        }

        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // load all table data to the form by using cmb id
                if (CmbID.SelectedIndex > 0)
                {
                    String DrivID = CmbID.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM Driver WHERE DrivID = '" + DrivID + "'";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtName.Text = R.GetValue(1).ToString();
                        TxtNIC.Text = R.GetValue(2).ToString();
                        CmbGender.Text = R.GetValue(3).ToString();
                        TxtContact.Text = "0"+R.GetValue(4).ToString();
                        TxtEmail.Text = R.GetValue(5).ToString();
                        TxtAddress.Text = R.GetValue(6).ToString();
                        DtpAssign.Text = R.GetValue(7).ToString();
                        DtpRelese.Text = R.GetValue(8).ToString();


                    }
                    dtb.con.Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtNIC.Text = "";
                    CmbGender.SelectedIndex = 0;
                    TxtContact.Text = "";
                    TxtEmail.Text = "";
                    TxtAddress.Text = "";
                    DtpAssign.Text = "";
                    DtpRelese.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            int cnt = TxtContact.Text.Length;

            if (cnt==10)
            {
                TxtContact.ForeColor = Color.Green;
            }
            else
            {
                TxtContact.ForeColor = Color.Red;
            }
        }

        private void TxtNIC_TextChanged(object sender, EventArgs e)
        {
            int nicl = TxtNIC.Text.Length;

            if (nicl < 10)
            {
                TxtNIC.ForeColor = Color.Red;
            }
            else if (nicl == 11)
            {
                TxtNIC.ForeColor = Color.Red;
            }
            else
            {
                TxtNIC.ForeColor = Color.Green;
            }
        }
    }
}
