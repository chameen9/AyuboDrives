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
    public partial class FrmPackReg : Form
    {
        public FrmPackReg()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        private void erasedt()
        {
            TxtDaytID.Text = "";
            TxtDaytName.Text = "";
            TxtDaytMaxD.Text = "";
            TxtDaytMaxHrs.Text = "";
            TxtDaytPrice.Text = "";
            TxtDaytID.Focus();
        }

        private void erasedt2()
        {
            CmbDaytID.Text = "";
            TxtDaytName.Text = "";
            TxtDaytMaxD.Text = "";
            TxtDaytMaxHrs.Text = "";
            TxtDaytPrice.Text = "";
            CmbDaytID.Focus();
        }

        private void eraselt()
        {
            TxtLongtId.Text = "";
            TxtLongtName.Text = "";
            TxtLongtMaxD.Text = "";
            TxtLongtMaxDte.Text = "";
            TxtLongtPrice.Text = "";
            TxtLongtId.Focus();
        }

        private void eraselt2()
        {
            CmbLongtId.Text = "";
            TxtLongtName.Text = "";
            TxtLongtMaxD.Text = "";
            TxtLongtMaxDte.Text = "";
            TxtLongtPrice.Text = "";
            CmbLongtId.Focus();
        }

        private void FrmHireCal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
            PnlDaytpack.Visible=false;
            PnlLongtpack.Visible = false;
        }

        private void LblDayt_Click(object sender, EventArgs e)
        {
            PnlLongtpack.Visible = false;
            PnlDaytpack.Visible = true;
            LblPackReg.Text = "Day-Tour Packages";
            PnlDaytbtn.BackColor = Color.FromArgb(107,5,146);
            PnlLongtbtn.BackColor = Color.FromArgb(143,51,242);
            LblSection.Visible = false;
            TxtDaytID.Focus();
        }

        private void LblLongt_Click(object sender, EventArgs e)
        {
            PnlDaytpack.Visible = false;
            PnlLongtpack.Visible = true;
            LblPackReg.Text = "Long-Tour Packages";
            PnlLongtbtn.BackColor = Color.FromArgb(107, 5, 146);
            PnlDaytbtn.BackColor = Color.FromArgb(143, 51, 242);
            LblSection.Visible = false;
            TxtLongtId.Focus();
            
        }

        private void BtnDaytClear_Click(object sender, EventArgs e)
        {
            erasedt();
        }

        private void BtnDaytReg_Click(object sender, EventArgs e)
        {
            string id = TxtDaytID.Text;
            string name = TxtDaytName.Text;
            string maxdis = TxtDaytMaxD.Text;
            string maxhrs = TxtDaytMaxHrs.Text;
            string price = TxtDaytPrice.Text;

            if (id == "" || name == "" || maxdis == "" || maxhrs == "" || price == "")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDaytID.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO DayTourPack VALUES('" + TxtDaytID.Text + "','" + TxtDaytName.Text + "','" + TxtDaytMaxD.Text + "','" + TxtDaytMaxHrs.Text + "','" + TxtDaytPrice.Text + "')", "Package registeration was Successful ! ");
                erasedt();
            }
        }

        private void BtnDaytUpdate_Click(object sender, EventArgs e)
        {
            string id = CmbDaytID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Package", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbDaytID.Focus();
            }

            else
            {
                dtb.updateq("UPDATE DayTourPack SET PckName = '" + TxtDaytName.Text + "', PckMaxDist = '" + TxtDaytMaxD.Text + "', PckMaxHours = '" + TxtDaytMaxHrs.Text + "', PckPrice = '" + TxtDaytPrice.Text + "' WHERE PckID='" + CmbDaytID.Text + "'", "Package, " + CmbDaytID.Text + "'s details update was Successfull !");
                erasedt2();
            }
        }

        private void BtnDaytDelete_Click(object sender, EventArgs e)
        {
            string id = CmbDaytID.Text;

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Package!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbDaytID.Focus();
            }

            else
            {
                dtb.deleteq("DELETE FROM DayTourPack WHERE PckID='" + CmbDaytID.Text + "'", "Package, " + CmbDaytID.Text + "'s details deleted Successfully !");
                erasedt2();
            }
        }

        private void BtnDaytSearch_Click(object sender, EventArgs e)
        {
            erasedt();
            CmbDaytID.Visible = true;
            TxtDaytID.Visible = false;
            BtnDaytUpdate.Visible = true;
            BtnDaytDelete.Visible = true;
            BtnDaytClear.Visible = false;
            BtnDaytReg.Visible = false;
            BtnDaytSearch.Visible = false;
            BtnDaytClose.Visible = true;
            CmbDaytID.Focus();


           
            try
            {
                String quegetid = "SELECT PckID FROM DayTourPack ORDER BY PckName";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetid, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbDaytID.Items.Clear();
                CmbDaytID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbDaytID.Items.Add(row["PckID"]);      // add  ids to the cmbid
                }

                CmbDaytID.SelectedIndex = 0;

                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDaytClose_Click(object sender, EventArgs e)
        {
            erasedt2();
            CmbDaytID.Visible = false;
            TxtDaytID.Visible = true;
            BtnDaytUpdate.Visible = false;
            BtnDaytDelete.Visible = false;
            BtnDaytClear.Visible = true;
            BtnDaytReg.Visible = true;
            BtnDaytSearch.Visible = true;
            BtnDaytClose.Visible = false;
            TxtDaytID.Focus();
        }

        private void CmbDaytID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // load all table data to the form by using cmbname
                if (CmbDaytID.SelectedIndex > 0)
                {

                    String PckID = CmbDaytID.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM DayTourPack WHERE PckID = '" + PckID + "'";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();

                    if (R.Read())
                    {
                        TxtDaytName.Text = R.GetValue(1).ToString();
                        TxtDaytMaxD.Text = R.GetValue(2).ToString();
                        TxtDaytMaxHrs.Text = R.GetValue(3).ToString();
                        TxtDaytPrice.Text = R.GetValue(4).ToString();

                    }
                    dtb.con.Close();


                }

                else
                {
                    TxtDaytName.Text = "";
                    TxtDaytMaxD.Text = "";
                    TxtDaytMaxHrs.Text = "";
                    TxtDaytPrice.Text = "";
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLongtClear_Click(object sender, EventArgs e)
        {
            eraselt();
        }

        private void BtnLongtReg_Click(object sender, EventArgs e)
        {
            string id = TxtLongtId.Text;
            string name = TxtLongtName.Text;
            string maxdis = TxtLongtMaxD.Text;
            string maxdts = TxtLongtMaxDte.Text;
            string price = TxtLongtPrice.Text;

            if (id == "" || name == "" || maxdis == "" || maxdts == "" || price == "")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtLongtId.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO LongTourPack VALUES('" + TxtLongtId.Text + "','" + TxtLongtName.Text + "','" + TxtLongtMaxD.Text + "','" + TxtLongtMaxDte.Text + "','" + TxtLongtPrice.Text + "')", "Package registeration was Successful ! ");
                eraselt();
            }
        }

        private void BtnLongtUpdate_Click(object sender, EventArgs e)
        {
            string id = CmbLongtId.SelectedIndex.ToString();

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Package", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbLongtId.Focus();
            }

            else
            {
                dtb.updateq("UPDATE LongTourPack SET PckName = '" + TxtLongtName.Text + "', PckMaxDist = '" + TxtLongtMaxD.Text + "', PckMaxDates = '" + TxtLongtMaxDte.Text + "', PckPrice = '" + TxtLongtPrice.Text + "' WHERE PckID='" + CmbLongtId.Text + "'", "Package, " + CmbLongtId.Text + "'s details update was Successfull !");
                eraselt2();
            }
        }

        private void BtnLongtDelete_Click(object sender, EventArgs e)
        {
            string id = CmbLongtId.SelectedIndex.ToString();

            if (id == "" || id == "-Select-")
            {
                MessageBox.Show("Please select a Package!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbLongtId.Focus();
            }

            else
            {
                dtb.deleteq("DELETE FROM LongTourPack WHERE PckID='" + CmbLongtId.Text + "'", "Package, " + CmbLongtId.Text + "'s details deleted Successfully !");
                eraselt2();
            }
        }

        private void BtnLongtSearch_Click(object sender, EventArgs e)
        {
            eraselt();
            CmbLongtId.Visible = true;
            TxtLongtId.Visible = false;
            BtnLongtUpdate.Visible = true;
            BtnLongtDelete.Visible = true;
            BtnLongtClear.Visible = false;
            BtnLongtReg.Visible = false;
            BtnLongtSearch.Visible = false;
            BtnLongtClose.Visible = true;
            CmbLongtId.Focus();


            try
            {
                String quegetid = "SELECT PckID FROM LongTourPack ORDER BY PckName";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetid, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbLongtId.Items.Clear();
                CmbLongtId.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbLongtId.Items.Add(row["PckID"]);      // add  ids to the cmbid
                }

                CmbLongtId.SelectedIndex = 0;

                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLongtClose_Click(object sender, EventArgs e)
        {
            eraselt2();
            CmbLongtId.Visible = false;
            TxtLongtId.Visible = true;
            BtnLongtUpdate.Visible = false;
            BtnLongtDelete.Visible = false;
            BtnLongtClear.Visible = true;
            BtnLongtReg.Visible = true;
            BtnLongtSearch.Visible = true;
            BtnLongtClose.Visible = false;
            TxtLongtId.Focus();
        }

        private void CmbLongtId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // load all table data to the form by using cmbname
                if (CmbLongtId.SelectedIndex > 0)
                {

                    String PckID = CmbLongtId.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM LongTourPack WHERE PckID = '" + PckID + "'";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();

                    if (R.Read())
                    {
                        TxtLongtName.Text = R.GetValue(1).ToString();
                        TxtLongtMaxD.Text = R.GetValue(2).ToString();
                        TxtLongtMaxDte.Text = R.GetValue(3).ToString();
                        TxtLongtPrice.Text = R.GetValue(4).ToString();

                    }
                    dtb.con.Close();
                }

                else
                {
                    TxtLongtName.Text = "";
                    TxtLongtMaxD.Text = "";
                    TxtLongtMaxDte.Text = "";
                    TxtLongtPrice.Text = "";
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
