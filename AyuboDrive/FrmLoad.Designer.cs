namespace AyuboDrive
{
    partial class FrmLoad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoad));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PnlProgress = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LblProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PnlProgress
            // 
            this.PnlProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(87)))), ((int)(((byte)(239)))));
            this.PnlProgress.Location = new System.Drawing.Point(479, 231);
            this.PnlProgress.Name = "PnlProgress";
            this.PnlProgress.Size = new System.Drawing.Size(20, 12);
            this.PnlProgress.TabIndex = 3;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.ForeColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(472, 426);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(54, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // LblProgress
            // 
            this.LblProgress.BackColor = System.Drawing.Color.Transparent;
            this.LblProgress.Font = new System.Drawing.Font("Felix Titling", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(146)))));
            this.LblProgress.Location = new System.Drawing.Point(682, 203);
            this.LblProgress.Name = "LblProgress";
            this.LblProgress.Size = new System.Drawing.Size(79, 20);
            this.LblProgress.TabIndex = 5;
            this.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDrive.Properties.Resources.LoadBackNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 473);
            this.ControlBox = false;
            this.Controls.Add(this.LblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.PnlProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoad";
            this.Load += new System.EventHandler(this.FrmLoad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel PnlProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label LblProgress;
    }
}