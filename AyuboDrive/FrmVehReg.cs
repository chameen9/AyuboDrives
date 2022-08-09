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
    public partial class FrmVehReg : Form
    {
        public FrmVehReg()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();

        private void erase()
        {
            TxtVehNumb.Text = "";
            TxtVehID.Text = "";
            CmbVehType.Text = "-Select-";
            TxtVehNumb.Focus();
        }

        private void erase2()
        {
            CmbVehNumb.SelectedIndex = 0;
            TxtVehID.Text = "";
            CmbVehType.Text = "";
            CmbVehNumb.Focus();
        }

        private void FrmCarReg_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
            TxtVehNumb.Focus();
            
            try
            {
                String quegetname = "SELECT TypeName FROM VehicleType";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbVehType.Items.Clear();
                CmbVehType.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbVehType.Items.Add(row["TypeName"]);      // add ids to the cmbid
                }

                CmbVehType.SelectedIndex = 0;
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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void BtnReg_Click(object sender, EventArgs e)
        {
            string vnum = TxtVehID.Text;
            string vid = TxtVehID.Text;
            string vtype = CmbVehType.Text;

            if (vnum == "" || vid == "" || vnum == "" || vtype == "" || vtype == "-Select-")
            {
                MessageBox.Show("There are empty feilds, Please fill those feilds.", "Feilds Empty !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtVehNumb.Focus();
            }

            else
            {
                dtb.insertq("INSERT INTO VehicleReg VALUES('" + TxtVehNumb.Text + "','" + TxtVehID.Text + "','" + CmbVehType.Text + "')", "Vehicle registeration was Successful ! ");
                erase();
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string vname = CmbVehNumb.Text;

            if (vname == "" || vname == "-Select-")
            {
                MessageBox.Show("Please select a Vehicle!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbVehNumb.Focus();
            }

            else
            {
                dtb.updateq("UPDATE VehicleReg SET VehID = '" + TxtVehID.Text + "', TypeName = '" + CmbVehType.Text + "' WHERE VehNumber='" + CmbVehNumb.Text + "'", "Vehicle, (" + CmbVehNumb.Text + ") details update was Successfull !");
                erase2();
            }
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string vname = CmbVehNumb.Text;

            if(vname=="" || vname == "-Select-")
            {
                MessageBox.Show("Please select a Vehicle!","System Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                CmbVehNumb.Focus();
            }

            else
            {
                dtb.deleteq("DELETE FROM VehicleReg WHERE VehNumber='" + CmbVehNumb.Text + "'", "Vehicle, " + CmbVehNumb.Text + "'s details deleted Successfully !");
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
            CmbVehNumb.Visible = true;
            TxtVehNumb.Visible = false;
            CmbVehType.Enabled = true;
            CmbVehNumb.Focus();

            try
            {
                String quegetname = "SELECT VehNumber FROM VehicleReg ORDER BY TypeName";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbVehNumb.Items.Clear();
                CmbVehNumb.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbVehNumb.Items.Add(row["VehNumber"]);      // add  ids to the cmbid
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            BtnUpdate.Visible = false;
            BtnDelete.Visible = false;
            BtnClear.Visible = true;
            BtnReg.Visible = true;
            BtnClose.Visible = false;
            BtnSearch.Visible = true;
            CmbVehNumb.Visible = false;
            TxtVehNumb.Visible = true;
            CmbVehType.Enabled = true;
            TxtVehNumb.Focus();
            erase2();
        }

        private void CmbVehNumb_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                // load all table data to the form by using cmbname
                if (CmbVehNumb.SelectedIndex > 0)
                {

                    String vreg = CmbVehNumb.SelectedItem.ToString();
                    String queGetDt = "SELECT * FROM VehicleReg WHERE VehNumber = '" + vreg + "' ORDER BY TypeName";
                    dtb.con.Open();
                    dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                    SqlDataReader R = dtb.cmd.ExecuteReader();
                    
                    if (R.Read())
                    {
                        TxtVehID.Text = R.GetValue(1).ToString();
                        CmbVehType.Text = R.GetValue(2).ToString();
                        
                    }
                    dtb.con.Close();
                }

                else
                {
                    TxtVehID.Text = "";
                    CmbVehType.Text = "";
                }

            }
            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dtb.con.Close();
            }
        }
    }
}
