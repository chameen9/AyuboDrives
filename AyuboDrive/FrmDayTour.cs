using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class FrmDayTour : Form
    {
        public FrmDayTour()
        {
            InitializeComponent();
        }

        private void FrmDayTour_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;   // to remove form boarder
        }
    }
}
