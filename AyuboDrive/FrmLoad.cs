using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AyuboDrive
{
    public partial class FrmLoad : Form
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
        public FrmLoad()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int y = 7;

            PnlProgress.Width += y;

            if (PnlProgress.Width >= 200)
            {
                FrmLogin log = new FrmLogin();
                log.Show();
                timer.Enabled = false;
                this.Hide();
            }


            if (progressBar.Value < 100)
            {
                progressBar.Value += 4;

                LblProgress.Text = progressBar.Value.ToString() + "%";
            }
        }

        private void FrmLoad_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
