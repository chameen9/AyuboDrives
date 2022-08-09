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
    public partial class FrmLongTour : Form
    {
        public FrmLongTour()
        {
            InitializeComponent();
        }

        DtaBse dtb = new DtaBse();
        

        int totdays = 0;

        private void totdayscal()
        {
            DateTime startDte = DtpStartDate.Value.AddDays(-1);
            DateTime endDte = DtpEndDate.Value;

            TimeSpan tot = endDte - startDte;

            double totdayslbl = double.Parse(tot.TotalDays.ToString());
            totdays = (int)Math.Floor(totdayslbl);

            if (totdayslbl > 0)
            {
                LblTotalDays.Text = totdays.ToString();
                LblTotalDays.ForeColor = Color.FromArgb(255, 255, 255);
            }
            if (totdays == 0)
            {
                LblTotalDays.Text = totdays.ToString();
                LblTotalDays.ForeColor = Color.FromArgb(255, 255, 255);
            }

            if (totdays < 0)
            {
                LblTotalDays.Text = totdays.ToString();
                LblTotalDays.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }


        private void cusidload()
        {
            try
            {
                String quegetname = "SELECT CusID FROM Customer ORDER BY CusID";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbCusID.Items.Clear();
                CmbCusID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbCusID.Items.Add(row["CusID"]);      // add ids to the cmbid
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

        private void drividload()
        {
            try
            {
                String quegetname = "SELECT DrivID FROM Driver ORDER BY DrivID";      // calling  id to the cmb
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);




                CmbDriverID.Items.Clear();
                CmbDriverID.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbDriverID.Items.Add(row["DrivID"]);      // add ids to the cmbid
                }

                CmbDriverID.SelectedIndex = 0;
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

        private void vehtypeload()
        {
            try
            {
                String quegetname = "SELECT TypeName FROM VehicleType ORDER BY TypeName";      // calling  id to the cmb
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

        private void pcknamesload()
        {
            try
            {
                String quegetname = "SELECT DISTINCT PckName FROM LongTourPack ORDER BY PckName";
                dtb.con.Open();
                dtb.SqlDa = new SqlDataAdapter(quegetname, dtb.con);
                DataTable Dt = new DataTable();
                dtb.SqlDa.Fill(Dt);


                CmbTourType.Items.Clear();
                CmbTourType.Items.Add("-Select-");
                foreach (DataRow row in Dt.Rows)
                {
                    CmbTourType.Items.Add(row["PckName"]);
                }

                CmbTourType.SelectedIndex = 0;
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
            CmbCusID.Text = "-Select-";
            CmbDriverID.Text = "-Select-";
            CmbTourType.Text = "-Select-";
            CmbvehTypeName.Text = "-Select-";
            CmbVehNumb.Text = "-Select-";
            TxtStartLoc.Text = "";
            TxtEndLoc.Text = "";
            TxtStartKM.Text = "0";
            TxtEndKM.Text = "0";
            DtpStartDate.Value = DateTime.Now;
            DtpEndDate.Value = DateTime.Now;
            LblFullDistance.Text = "0 KM";
            LblTotalDays.Text = "0";
            CmbPackg.Text = "-Select-";
            LblMaxDatesCount.Text = "0";
            LblMaxDistanceCount.Text = "0 KM";
            LblPriceCount.Text = "Rs.0.00";
            LblExtraKMCount.Text = "0 KM";
            LblExtraKMChargeCount.Text = "Rs.0.00";
            TxtParkingCharges.Text = "0.00";
            TxtOvrNightChrges.Text = "0.00";
            LblTotCharges.Text = "Rs.0.00";
            CmbPackg.Enabled = false;
            CmbCusID.Focus();
        }

        int extrakm = 0;

        private void extrakmcal()
        {
            extrakm = tot - maxkm;

            if (extrakm >= 0)
            {
                LblExtraKMCount.Text = extrakm.ToString() + " KM";
            }
            else
            {
                LblExtraKMCount.Text = "0 KM";
            }

        }

        double exkmcharge = 0;

        private void extrakmchrgload()
        {
            try
            {
                String vehtype = CmbvehTypeName.SelectedItem.ToString();
                String queGetexkm = "SELECT ExtraCharge FROM VehicleType WHERE TypeName = '" + vehtype + "'";
                dtb.con.Open();
                dtb.cmd = new SqlCommand(queGetexkm, dtb.con);
                SqlDataReader R = dtb.cmd.ExecuteReader();
                while (R.Read())
                {
                    LblExtraKMChargeCount.Text = "Rs." + R.GetValue(0).ToString();

                    exkmcharge = double.Parse(R.GetValue(0).ToString());
                }
                dtb.con.Close();
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

        private void startendtxtchange()
        {
            if ((TxtEndKM.Text == "0" || TxtEndKM.Text == "") && (TxtStartKM.Text=="0" || TxtStartKM.Text == ""))
            {
                BtnCal.Enabled = false;
            }

            if (TxtEndKM.TextLength >= 3 && TxtStartKM.TextLength >= 3)
            {
                BtnCal.Enabled = true;
            }

            if (TxtEndKM.TextLength <= 3 || TxtStartKM.TextLength <= 3)
            {
                BtnCal.Enabled = false;
            }
        }

        private void startdtpenddtpchange()
        {
            string startDte = DtpStartDate.Value.ToShortDateString();
            string endDte = DtpEndDate.Value.ToShortDateString();
            string dte = DateTime.Now.ToShortDateString();

            if (startDte == endDte)
            {
                BtnTotdaycal.Enabled = false;
            }
            if (startDte != endDte)
            {
                BtnTotdaycal.Enabled = true;
            }

        }

        private void FrmLongTour_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder

            cusidload();

            drividload();

            vehtypeload();

            pcknamesload();

            erase();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            erase();
        }

        private void TxtStartKM_MouseClick(object sender, MouseEventArgs e)
        {
            string strtkm = TxtStartKM.Text;

            if (strtkm == "0")
            {
                TxtStartKM.Clear();
            }

            else
            {
            }
        }

        private void TxtEndKM_MouseClick(object sender, MouseEventArgs e)
        {
            string endkm = TxtEndKM.Text;

            if (endkm == "0")
            {
                TxtEndKM.Clear();
            }

            else
            {
            }
        }

        private void TxtParkingCharges_MouseClick(object sender, MouseEventArgs e)
        {
            string pknchg = TxtParkingCharges.Text;

            if (pknchg == "0.00")
            {
                TxtParkingCharges.Clear();
            }

            else
            {
            }
        }

        private void TxtOvrNightChrges_MouseClick(object sender, MouseEventArgs e)
        {
            string ovrnght = TxtOvrNightChrges.Text;

            if (ovrnght == "0.00")
            {
                TxtOvrNightChrges.Clear();
            }

            else
            {
            }
        }

        private void TxtStartKM_TextChanged(object sender, EventArgs e)
        {
            startendtxtchange();
        }

        private void TxtEndKM_TextChanged(object sender, EventArgs e)
        {
            startendtxtchange();
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            startdtpenddtpchange();
        }

        private void DtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            startdtpenddtpchange();
        }

        double pkgprice = 0.00;
        int maxkm = 0;
        int maxdts = 0;

        private void CmbPackg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String pkgid = CmbPackg.SelectedItem.ToString();
                String queGetDt = "SELECT * FROM LongTourPack WHERE PckID = '" + pkgid + "' ORDER BY PckID";
                dtb.con.Open();
                dtb.cmd = new SqlCommand(queGetDt, dtb.con);
                SqlDataReader R = dtb.cmd.ExecuteReader();
                if (R.Read())
                {
                    LblMaxDistanceCount.Text = R.GetValue(2).ToString()+" KM";
                    LblMaxDatesCount.Text = R.GetValue(3).ToString();
                    LblPriceCount.Text = "Rs."+R.GetValue(4).ToString();

                    maxkm = int.Parse(R.GetValue(2).ToString());
                    maxdts = int.Parse(R.GetValue(3).ToString());
                    pkgprice = double.Parse(R.GetValue(4).ToString());
                    
                }

                else
                {
                    LblMaxDistanceCount.Text = "0 KM";
                    LblMaxDatesCount.Text = "0";
                    LblPriceCount.Text = "Rs.O.00";
                }
                dtb.con.Close();
            }

            catch (Exception Err)
            {
                MessageBox.Show("Error while Select..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                dtb.con.Close();
            }

            extrakmcal();
        }

        int endkm, startkm, tot;

        
        private void CmbvehTypeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CmbvehTypeName.SelectedItem.ToString() != "-Select-")
            {
                CmbVehNumb.Enabled = true;

                try
                {
                    string type = CmbvehTypeName.SelectedItem.ToString();
                    String queGeVehNumb = "SELECT VehNumber FROM VehicleReg WHERE TypeName = '" + type + "' ORDER BY VehNumber";
                    dtb.con.Open();
                    dtb.SqlDa = new SqlDataAdapter(queGeVehNumb, dtb.con);
                    DataTable Dt = new DataTable();
                    dtb.SqlDa.Fill(Dt);
                    dtb.con.Close();


                    CmbVehNumb.Items.Clear();
                    CmbVehNumb.Items.Add("-Select-");
                    foreach (DataRow row in Dt.Rows)
                    {
                        CmbVehNumb.Items.Add(row["VehNumber"]);
                    }

                    CmbVehNumb.SelectedIndex = 0;

                }
                catch (Exception Err)
                {
                    MessageBox.Show("Error while Search..." + Environment.NewLine + Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    dtb.con.Close();
                }

                extrakmchrgload();
            }

            else
            {
                CmbVehNumb.Enabled = false;
            }

            
        }
        
        private void CmbTourType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTourType.SelectedItem.ToString() != "-Select-")
            {
                CmbPackg.Enabled = true;

                try
                {
                    string tourtype = CmbTourType.SelectedItem.ToString();
                    String queGepcknm = "SELECT PckID FROM LongTourPack WHERE PckName = '" + tourtype + "' ORDER BY PckID";
                    dtb.con.Open();
                    dtb.SqlDa = new SqlDataAdapter(queGepcknm, dtb.con);
                    DataTable Dt = new DataTable();
                    dtb.SqlDa.Fill(Dt);
                    dtb.con.Close();


                    CmbPackg.Items.Clear();
                    CmbPackg.Items.Add("-Select-");
                    foreach (DataRow row in Dt.Rows)
                    {
                        CmbPackg.Items.Add(row["PckID"]);
                    }

                    CmbPackg.SelectedIndex = 0;

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

            else
            {
                CmbPackg.Enabled = false;
            }
        }

        double extrakmcharge = 0.00;

        double totalcharges = 0.00;

        double totprkingchgs = 0.00;

        double totovrnightchrg = 0.00;

        double totstaycharg = 0.00;

        int totnights = 0;

        int extradays = 0;

        private void BtnTotChgCal_Click(object sender, EventArgs e)
        {
            double prkingchg = double.Parse(TxtParkingCharges.Text.ToString());
            double ovrnghtchg = double.Parse(TxtOvrNightChrges.Text.ToString());

            extradays = totdays - maxdts;

            totnights = extradays - 1;

            totprkingchgs = prkingchg * totnights;

            totovrnightchrg = ovrnghtchg * totnights;

            totstaycharg = totprkingchgs + totovrnightchrg;

            extrakmcharge = extrakm * exkmcharge;

            totalcharges = extrakmcharge + totstaycharg + pkgprice;

            LblTotCharges.Text = "Rs. "+totalcharges.ToString()+".00";

        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            dtb.insertq("INSERT INTO LongTourDetails VALUES('" + TxtTourId.Text + "','" + CmbCusID.Text + "','" + CmbDriverID.Text + "','" + CmbvehTypeName.Text + "','" + CmbTourType.Text + "','" + CmbVehNumb.Text + "','" + TxtStartLoc.Text + "','" + TxtEndLoc.Text + "','" + LblFullDistance.Text + "','" + LblTotalDays.Text + "','" + LblExtraKMCount.Text + "','" + TxtParkingCharges.Text + "','" + TxtOvrNightChrges.Text + "','" + LblTotCharges.Text + "')", "Successfully saved the data ! ");
            erase();
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            endkm = int.Parse(TxtEndKM.Text);
            startkm = int.Parse(TxtStartKM.Text);

            tot = endkm - startkm;

            LblFullDistance.Text = tot.ToString()+" KM";
            
        }

        private void BtnTotdaycal_Click(object sender, EventArgs e)
        {
            totdayscal();
        }
    }
}
