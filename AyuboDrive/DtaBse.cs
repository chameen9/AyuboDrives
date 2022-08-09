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
    class DtaBse
    {
            public DataSet Dset = new DataSet();
            public SqlDataAdapter SqlDa = new SqlDataAdapter();
            public SqlCommand cmd = new SqlCommand();
            public SqlConnection con = new SqlConnection(@"Data Source=CHVM2EN;Initial Catalog=AyuboDrive;Integrated Security=True");


        public void insertq(String que, String msg)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while adding..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            
        }


        public void updateq(String que, String msg)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        public void updateqwithoutmsg(String que)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();


            }

            catch (Exception Error)
            {
                MessageBox.Show("Error while Updating..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }

        }

        public void deleteq(String que, String msg)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(msg, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error while Delete..." + Environment.NewLine + Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        public int rcount(String que)
        {
            con.Open();

            SqlDa = new SqlDataAdapter(que, con);
            DataTable Dt = new DataTable();
            SqlDa.Fill(Dt);
            con.Close();

            return Dt.Rows.Count;
        }
    }
}
