namespace AyuboDrive
{
    partial class FrmDayTour
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDayTour));
            this.LblDayTourCal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDayTourCal
            // 
            this.LblDayTourCal.AutoSize = true;
            this.LblDayTourCal.BackColor = System.Drawing.Color.Transparent;
            this.LblDayTourCal.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDayTourCal.ForeColor = System.Drawing.Color.White;
            this.LblDayTourCal.Location = new System.Drawing.Point(12, 18);
            this.LblDayTourCal.Name = "LblDayTourCal";
            this.LblDayTourCal.Size = new System.Drawing.Size(237, 23);
            this.LblDayTourCal.TabIndex = 31;
            this.LblDayTourCal.Text = "Day-Tour Calculation";
            // 
            // FrmDayTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDrive.Properties.Resources.BackLoadFrom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 686);
            this.ControlBox = false;
            this.Controls.Add(this.LblDayTourCal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDayTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dal-Tour Calculation";
            this.Load += new System.EventHandler(this.FrmDayTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDayTourCal;
    }
}