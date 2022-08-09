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
    public partial class FrmRentCal : Form
    {
        public FrmRentCal()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        
        private void cmbvtyload()
        {
            // load vehicle types
            try
            {
                string tynme = CmbvehTypeName.Text;

                String quegetname = "SELECT TypeName FROM VehicleType";      // calling  names to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);

                CmbvehTypeName.Items.Clear();
                CmbvehTypeName.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbvehTypeName.Items.Add(row["TypeName"]);      // add ids to the cmbid
                }

                CmbvehTypeName.SelectedIndex = 0;

                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dtb.con.Close();
            }
        }


        private void cmbvehnumbload()
        {
            // load vehicle number
            try
            {
                string nmb = CmbVehNumb.Text;

                String quegetnumb = "SELECT VehNumber FROM VehicleReg ORDER BY VehNumber";      // calling  names to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetnumb, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);

                CmbVehNumb.Items.Clear();
                CmbVehNumb.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbVehNumb.Items.Add(row["VehNumber"]);      // add ids to the cmbid
                }

                CmbVehNumb.SelectedIndex = 0;

                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dtb.con.Close();
            }

        }

        private void cmbcusidload()
        {
            // load cus id
            try
            {
                string cusid = CmbCusID.SelectedIndex.ToString();

                String quegetid = "SELECT CusID FROM Customer ORDER BY CusID";      // calling  cusids to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetid, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);

                CmbCusID.Items.Clear();
                CmbCusID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbCusID.Items.Add(row["CusID"]);      // add cusids to the cmbid
                }

                CmbCusID.SelectedIndex = 0;

                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dtb.con.Close();
            }

        }

        private void erase()
        {
            txtTransID.Text = "";
            CmbvehTypeName.Text = "";
            CmbVehNumb.Text = "";
            CmbDriverID.Text = "";
            CmbCusID.Text = "";
            TxtTotPrice.Text = "";
            DtpIssued.Value = DateTime.Now;
            DtpReturned.Value = DateTime.Now;
            ChkDriv.Checked = false;
            ChkVehNumb.Checked = false;
            txtTransID.Focus();
        }

        public void daycount()                         // count days
        {
            DateTime isdte = DtpIssued.Value.Date;
            DateTime retdte = DtpReturned.Value.Date;

            TimeSpan totd = retdte - isdte;

            int days = totd.Days;
            
        }

        public void daycountevent()                         // count days
        {
            DateTime isdte = DtpIssued.Value.Date;
            DateTime retdte = DtpReturned.Value.Date;

            TimeSpan totd = retdte - isdte;

            int days = totd.Days;

            if (retdte < isdte)
            {
                //MessageBox.Show("Check the dates again!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                DtpReturned.Value = DateTime.Now;
            }
            
            LblTotDayCount.Text = days.ToString();
            
        }


        private void FrmRentCal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder

            txtTransID.Focus();

            cmbvtyload();

            cmbvehnumbload();

            cmbcusidload();
        }

        private void CmbvehTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (CmbvehTypeName.SelectedIndex > 0)
                {
                    String Vtype = CmbvehTypeName.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM VehicleType WHERE TypeName = '" + Vtype + "' ORDER BY TypeName";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    if (R.Read())
                    {
                        LblMonthlyRate.Text = "(" + R.GetValue(4) + ")";
                        LblWeeklyRate.Text = "(" + R.GetValue(3) + ")";
                        LblDailyRate.Text = "(" + R.GetValue(2) + ")";
                        
                    }
                    dtb.con.Close();
                }
                else
                {
                    LblMonthlyRate.Text = "";
                    LblWeeklyRate.Text = "";
                    LblDailyRate.Text = "";
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        
        private void CmbVehNumb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChkDriv_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDriv.Checked)
            {
                LblDriverID.Text = "Driver ID";
                CmbDriverID.Visible = true;

                try
                {
                    String queGetCusID = "SELECT DrivID FROM Driver ORDER BY DrivID";      // calling driver id to the cmb
                    dtb.con.Open();
                    dtb.SqlDa = new SqlDataAdapter(queGetCusID, dtb.con);
                    DataTable Dt = new DataTable();
                    dtb.SqlDa.Fill(Dt);
                    dtb.con.Close();



                    CmbDriverID.Items.Clear();
                    CmbDriverID.Items.Add("-Select-");
                    foreach (DataRow row in Dt.Rows)
                    {
                        CmbDriverID.Items.Add(row["DrivID"]);      // add cus ids to the cmbid
                    }

                    CmbDriverID.SelectedIndex = 0;

                }
                catch (Exception Err)
                {
                    MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (!ChkDriv.Checked)
            {
                LblDriverID.Text = "Driver";
                CmbDriverID.Visible = false;

                CmbDriverID.Items.Clear();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();

            cmbvtyload();

            cmbvehnumbload();

            cmbcusidload();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (TxtTotPrice.TextLength > 1)
            {
                dtb.insertq("INSERT INTO RentDetails VALUES('" + txtTransID.Text + "','" + CmbCusID.SelectedIndex.ToString() + "','" + CmbDriverID.SelectedIndex.ToString() + "','" + CmbVehNumb.SelectedIndex.ToString() + "','" + CmbvehTypeName.SelectedIndex.ToString() + "','" + DtpIssued.Value.ToString() + "','" + DtpReturned.Value.ToString() + "',20,200.00)", "Rent details successfully saved ! ");

                dtb.updateqwithoutmsg("UPDATE Driver SET AssignDate = '" + DtpIssued.Text + "', ReleaseDate = '" + DtpReturned.Text + "' WHERE DrivID='" + CmbDriverID.Text + "'");
                //erase();
            }
        }

        private void ChkVehNumb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVehNumb.Checked)
            {
                CmbVehNumb.Visible = true;
                LblVehNumb.Text = "Vehicle Number";

                try
                {
                    string tynme = CmbvehTypeName.SelectedIndex.ToString();
                    String queGetVnumb = "SELECT VehNumber FROM VehicleReg ORDER BY VehNumber";      // calling veh numb to the cmb
                    dtb.con.Open();
                    dtb.SqlDa = new SqlDataAdapter(queGetVnumb, dtb.con);
                    DataTable Dt = new DataTable();
                    dtb.SqlDa.Fill(Dt);
                    dtb.con.Close();



                    CmbVehNumb.Items.Clear();
                    CmbVehNumb.Items.Add("-Select-");
                    foreach (DataRow row in Dt.Rows)
                    {
                        CmbVehNumb.Items.Add(row["VehNumber"]);      // add veh nmbrs to the cmb
                    }

                    CmbVehNumb.SelectedIndex = 0;

                }
                catch (Exception Err)
                {
                    MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!ChkVehNumb.Checked)
            {
                CmbVehNumb.Visible = false;
                LblVehNumb.Text = "Vehicle";

                CmbVehNumb.Items.Clear();
            }
        }

        private void DtpIssued_ValueChanged(object sender, EventArgs e)
        {
            daycountevent();
        }

        private void DtpReturned_ValueChanged(object sender, EventArgs e)
        {
            daycountevent();
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            daycountevent();
        }
    }
}
