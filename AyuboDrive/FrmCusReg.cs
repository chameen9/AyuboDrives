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
    public partial class FrmCusReg : Form
    {
        public FrmCusReg()
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
            TxtAddress.Text = "";
            TxtID.Focus();
        }

        private void erase2()
        {
            CmbID.SelectedIndex =0;
            TxtName.Text = "";
            TxtNIC.Text = "";
            CmbGender.SelectedIndex = 0;
            TxtContact.Text = "";
            TxtAddress.Text = "";
            CmbID.Focus();
        }

        private void FrmCusReg_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
            TxtID.Focus();
            CmbGender.SelectedIndex = 0;
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

            TxtContact.ForeColor = Color.Black;

            try
            {
                String queGetCusID = "SELECT CusID FROM Customer ORDER BY CusID";      // calling customer id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(queGetCusID, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);
                dtb.con.Close();



                CmbID.Items.Clear();
                CmbID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbID.Items.Add(row["CusID"]);      // add cus ids to the cmbid
                }

                CmbID.SelectedIndex = 0;

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LblAccessD.Text = "";
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

            catch (Exception ex)
            {
                MessageBox.Show("Error while load Data" + ex.Message);
            }

            if (Utype == "Admin")
            {
                BtnDelete.Enabled = true;
                LblAccessD.Text = "";
            }
            else
            {
                BtnDelete.Enabled = false;
                LblAccessD.Text = "Access Denied";
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

            catch (Exception ex)
            {
                MessageBox.Show("Error while load Data" + ex.Message);
            }

            if (Utype == "Admin")
            {
                LblAccessD.Text = "";
            }
            else
            {
                LblAccessD.Text = "";
            }
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string id = TxtID.Text;
            string uname = TxtName.Text;
            string nic = TxtNIC.Text;
            string gender = CmbGender.Text;
            string contact = TxtContact.Text;
            string address = TxtAddress.Text;

            if (id=="" || uname=="" || nic=="" || gender== "-Select-" || gender=="" ||contact=="" || address=="")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.","Feilds Empty !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TxtID.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO Customer VALUES('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtNIC.Text + "','" + CmbGender.Text + "','" + TxtContact.Text + "','" + TxtAddress.Text + "')", "Customer registeration was Successful ! ");
                erase();
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string id = CmbID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Customer!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbID.Focus();
            }

            else
            {
                dtb.updateq("UPDATE Customer SET CusName = '" + TxtName.Text + "', NIC = '" + TxtNIC.Text + "', Gender = '" + CmbGender.Text + "' , Contact = '" + TxtContact.Text + "' , Address = '" + TxtAddress.Text + "' WHERE CusID='" + CmbID.Text + "'", "Customer, " + TxtName.Text + "'s details update was Successfull !");
                erase2();
            }
            
        }

        private void CmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtContact.ForeColor = Color.Black;

            try
            {
                // load all table data to the form by using cmmb id
                if (CmbID.SelectedIndex > 0)
                {
                    String CusID = CmbID.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM Customer WHERE CusID = '" + CusID + "' ORDER BY CusID";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtName.Text = R.GetValue(1).ToString();
                        TxtNIC.Text = R.GetValue(2).ToString();
                        CmbGender.Text = R.GetValue(3).ToString();
                        TxtContact.Text = "0"+R.GetValue(4).ToString();
                        TxtAddress.Text = R.GetValue(5).ToString();


                    }
                    dtb.con.Close();
                }
                else
                {
                    TxtName.Text = "";
                    TxtNIC.Text = "";
                    CmbGender.SelectedIndex = 0;
                    TxtContact.Text = "";
                    TxtAddress.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = CmbID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Customer!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbID.Focus();
            }

            else
            {
                dtb.deleteq("DELETE FROM Customer WHERE CusID='" + CmbID.Text + "'", "Customer, " + TxtName.Text + "'s details deleted Successfully !");
                erase2();
            }
        }

        private void TxtContact_TextChanged(object sender, EventArgs e)
        {
            int tt = TxtContact.Text.Length;

            if (tt==10)
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

            if (nicl<10)
            {
                TxtNIC.ForeColor = Color.Red;
            }
            else if (nicl==11)
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
