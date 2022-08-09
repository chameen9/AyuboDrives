namespace AyuboDrive
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PicShowPw = new System.Windows.Forms.PictureBox();
            this.PicHidePw = new System.Windows.Forms.PictureBox();
            this.PnlShHdPw = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlUn = new System.Windows.Forms.Panel();
            this.PnlPw = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHidePw)).BeginInit();
            this.PnlShHdPw.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.BackgroundImage = global::AyuboDrive.Properties.Resources.ButtonLogin;
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(5)))), ((int)(((byte)(146)))));
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(653, 375);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(146, 41);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(146)))));
            this.TxtPassword.Location = new System.Drawing.Point(602, 292);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(244, 21);
            this.TxtPassword.TabIndex = 0;
            this.TxtPassword.Tag = "";
            this.TxtPassword.Text = "Password";
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsername.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(146)))));
            this.TxtUsername.Location = new System.Drawing.Point(602, 206);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(244, 21);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.Text = "Username";
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BackgroundImage = global::AyuboDrive.Properties.Resources.CloseIconPurple;
            this.BtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(871, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(25, 25);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PicShowPw
            // 
            this.PicShowPw.Image = global::AyuboDrive.Properties.Resources.EyeOpened;
            this.PicShowPw.Location = new System.Drawing.Point(3, 3);
            this.PicShowPw.Name = "PicShowPw";
            this.PicShowPw.Size = new System.Drawing.Size(21, 18);
            this.PicShowPw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicShowPw.TabIndex = 5;
            this.PicShowPw.TabStop = false;
            this.PicShowPw.Click += new System.EventHandler(this.PicShowPw_Click);
            // 
            // PicHidePw
            // 
            this.PicHidePw.Image = global::AyuboDrive.Properties.Resources.EyeClosed;
            this.PicHidePw.Location = new System.Drawing.Point(3, 3);
            this.PicHidePw.Name = "PicHidePw";
            this.PicHidePw.Size = new System.Drawing.Size(21, 18);
            this.PicHidePw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHidePw.TabIndex = 6;
            this.PicHidePw.TabStop = false;
            this.PicHidePw.Click += new System.EventHandler(this.PicHidePw_Click);
            // 
            // PnlShHdPw
            // 
            this.PnlShHdPw.BackColor = System.Drawing.Color.Transparent;
            this.PnlShHdPw.Controls.Add(this.PicShowPw);
            this.PnlShHdPw.Controls.Add(this.PicHidePw);
            this.PnlShHdPw.Location = new System.Drawing.Point(852, 293);
            this.PnlShHdPw.Name = "PnlShHdPw";
            this.PnlShHdPw.Size = new System.Drawing.Size(28, 30);
            this.PnlShHdPw.TabIndex = 0;
            this.PnlShHdPw.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(602, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 52);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(35)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login to your account";
            // 
            // PnlUn
            // 
            this.PnlUn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(90)))), ((int)(((byte)(245)))));
            this.PnlUn.Location = new System.Drawing.Point(602, 230);
            this.PnlUn.Name = "PnlUn";
            this.PnlUn.Size = new System.Drawing.Size(244, 2);
            this.PnlUn.TabIndex = 6;
            // 
            // PnlPw
            // 
            this.PnlPw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(90)))), ((int)(((byte)(245)))));
            this.PnlPw.Location = new System.Drawing.Point(602, 319);
            this.PnlPw.Name = "PnlPw";
            this.PnlPw.Size = new System.Drawing.Size(244, 2);
            this.PnlPw.TabIndex = 7;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDrive.Properties.Resources.LoginBackNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 545);
            this.Controls.Add(this.PnlPw);
            this.Controls.Add(this.PnlUn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlShHdPw);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayubo Drive - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicShowPw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHidePw)).EndInit();
            this.PnlShHdPw.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.PictureBox PicShowPw;
        private System.Windows.Forms.PictureBox PicHidePw;
        private System.Windows.Forms.Panel PnlShHdPw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PnlUn;
        private System.Windows.Forms.Panel PnlPw;
    }
}

