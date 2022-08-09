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
    public partial class FrmVehDetails : Form
    {
        public FrmVehDetails()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        private void erase()
        {
            TxtName.Text = "";
            TxtId.Text = "";
            TxtNormalCharge.Text = "";
            TxtExtraCharge.Text = "";
            TxtDailyRate.Text = "";
            TxtWeeklyRate.Text = "";
            TxtMonthlyRate.Text = "";
            TxtName.Focus();
        }

        private void erase2()
        {
            CmbName.SelectedIndex = 0;
            TxtId.Text = "";
            TxtNormalCharge.Text = "";
            TxtExtraCharge.Text = "";
            TxtDailyRate.Text = "";
            TxtWeeklyRate.Text = "";
            TxtMonthlyRate.Text = "";
            CmbName.Focus();
        }

        private void FrmVehDetails_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
            TxtName.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string id = TxtId.Text;
            string dayr = TxtDailyRate.Text;
            string weer = TxtWeeklyRate.Text;
            string monr = TxtMonthlyRate.Text;
            string nrmlc = TxtNormalCharge.Text;
            string exc = TxtExtraCharge.Text;

            if (name == "" || id == "" || dayr == "" || weer == "-Select-" || monr == "" || nrmlc == "" || exc == "")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtName.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO VehicleType VALUES('" + TxtName.Text + "','" + TxtId.Text + "','" + TxtDailyRate.Text + "','" + TxtWeeklyRate.Text + "','" + TxtMonthlyRate.Text + "','" + TxtNormalCharge.Text + "','" + TxtExtraCharge.Text + "')", "Vehicle Type registeration was Successful ! ");
                erase();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string nm = CmbName.Text;

            if (nm == "" || nm == "-Select-")
            {
                MessageBox.Show("Please select a Vehicle Type!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbName.Focus();
            }

            else
            {
            dtb.updateq("UPDATE VehicleType SET TypeID = '" + TxtId.Text + "', DayRate = '" + TxtDailyRate.Text + "', WeeklyRate = '" + TxtWeeklyRate.Text + "' , MonthlyRate = '" + TxtMonthlyRate.Text + "' , NormalCharge = '" + TxtNormalCharge.Text + "', ExtraCharge = '" + TxtExtraCharge.Text + "' WHERE TypeName='" + CmbName.Text + "'", "Vehicle Type ', " + CmbName.Text + "' update was Successfull !");
            erase2();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string nm = CmbName.Text;

            if (nm == "" || nm == "-Select-")
            {
                MessageBox.Show("Please select a Vehicle Type!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbName.Focus();
            }

            else
            {
            dtb.deleteq("DELETE FROM VehicleType WHERE TypeName='" + CmbName.Text + "'", "Vehicle Type, '" + CmbName.Text + "' deleted Successfully !");
            erase2();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            erase();

            CmbName.Visible = true;
            TxtName.Visible = false;
            BtnClose.Visible = true;
            BtnSearch.Visible = false;
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;
            BtnClear.Visible = false;
            BtnReg.Visible = false;
            CmbName.Focus();

            try
            {
                String queGetID = "SELECT TypeName FROM VehicleType ORDER BY TypeName";      // calling customer id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(queGetID, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);
                



                CmbName.Items.Clear();
                CmbName.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbName.Items.Add(row["TypeName"]);      // add cus ids to the cmbid
                }

                CmbName.SelectedIndex = 0;
                dtb.con.Close();

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            CmbName.Visible = false;
            TxtName.Visible = true;
            BtnClose.Visible = false;
            BtnSearch.Visible = true;
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            BtnClear.Visible = true;
            BtnReg.Visible = true;
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

                    String vtype = CmbName.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM VehicleType WHERE TypeName = '" + vtype + "' ORDER BY TypeName";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    if (R.Read())
                    {
                        TxtId.Text = R.GetValue(1).ToString();
                        TxtDailyRate.Text = R.GetValue(2).ToString();
                        TxtWeeklyRate.Text = R.GetValue(3).ToString();
                        TxtMonthlyRate.Text = R.GetValue(4).ToString();
                        TxtNormalCharge.Text = R.GetValue(5).ToString();
                        TxtExtraCharge.Text = R.GetValue(6).ToString();



                    }

                    dtb.con.Close();

                }

                else
                {
                    TxtId.Text = "";
                    TxtDailyRate.Text = "";
                    TxtWeeklyRate.Text = "";
                    TxtMonthlyRate.Text = "";
                    TxtNormalCharge.Text = "";
                    TxtExtraCharge.Text = "";
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
