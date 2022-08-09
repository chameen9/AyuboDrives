namespace AyuboDrive
{
    partial class FrmUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserControl));
            this.LblUserControl = new System.Windows.Forms.Label();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.PnlUcon = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.LblType = new System.Windows.Forms.Label();
            this.LblPw = new System.Windows.Forms.Label();
            this.LblUname = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlUcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUserControl
            // 
            this.LblUserControl.AutoSize = true;
            this.LblUserControl.BackColor = System.Drawing.Color.Transparent;
            this.LblUserControl.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserControl.ForeColor = System.Drawing.Color.White;
            this.LblUserControl.Location = new System.Drawing.Point(12, 18);
            this.LblUserControl.Name = "LblUserControl";
            this.LblUserControl.Size = new System.Drawing.Size(146, 23);
            this.LblUserControl.TabIndex = 43;
            this.LblUserControl.Text = "User Control";
            // 
            // TxtPw
            // 
            this.TxtPw.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPw.Location = new System.Drawing.Point(186, 109);
            this.TxtPw.MaxLength = 12;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.Size = new System.Drawing.Size(148, 28);
            this.TxtPw.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(186, 33);
            this.TxtName.MaxLength = 128;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(201, 25);
            this.TxtName.TabIndex = 0;
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "-Select-",
            "Admin",
            "Employee"});
            this.CmbType.Location = new System.Drawing.Point(186, 180);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(110, 28);
            this.CmbType.TabIndex = 2;
            // 
            // PnlUcon
            // 
            this.PnlUcon.BackColor = System.Drawing.Color.Transparent;
            this.PnlUcon.Controls.Add(this.panel4);
            this.PnlUcon.Controls.Add(this.panel3);
            this.PnlUcon.Controls.Add(this.panel2);
            this.PnlUcon.Controls.Add(this.panel1);
            this.PnlUcon.Controls.Add(this.CmbType);
            this.PnlUcon.Controls.Add(this.CmbName);
            this.PnlUcon.Controls.Add(this.TxtPw);
            this.PnlUcon.Controls.Add(this.TxtName);
            this.PnlUcon.Controls.Add(this.BtnSearch);
            this.PnlUcon.Controls.Add(this.BtnReg);
            this.PnlUcon.Controls.Add(this.BtnClear);
            this.PnlUcon.Controls.Add(this.LblType);
            this.PnlUcon.Controls.Add(this.LblPw);
            this.PnlUcon.Controls.Add(this.LblUname);
            this.PnlUcon.Controls.Add(this.BtnClose);
            this.PnlUcon.Controls.Add(this.BtnUpdate);
            this.PnlUcon.Controls.Add(this.BtnDelete);
            this.PnlUcon.Location = new System.Drawing.Point(230, 163);
            this.PnlUcon.Name = "PnlUcon";
            this.PnlUcon.Size = new System.Drawing.Size(550, 340);
            this.PnlUcon.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(1, 339);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(548, 1);
            this.panel4.TabIndex = 58;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 1);
            this.panel3.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(549, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 340);
            this.panel2.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 340);
            this.panel1.TabIndex = 55;
            // 
            // CmbName
            // 
            this.CmbName.DropDownHeight = 90;
            this.CmbName.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbName.FormattingEnabled = true;
            this.CmbName.IntegralHeight = false;
            this.CmbName.Location = new System.Drawing.Point(186, 32);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(228, 28);
            this.CmbName.TabIndex = 54;
            this.CmbName.Visible = false;
            this.CmbName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.BackgroundImage = global::AyuboDrive.Properties.Resources.SearchIcon1;
            this.BtnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Location = new System.Drawing.Point(426, 32);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(25, 25);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.Transparent;
            this.BtnReg.BackgroundImage = global::AyuboDrive.Properties.Resources.BtnReg;
            this.BtnReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReg.FlatAppearance.BorderSize = 0;
            this.BtnReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReg.Location = new System.Drawing.Point(312, 251);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(200, 60);
            this.BtnReg.TabIndex = 4;
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Transparent;
            this.BtnClear.BackgroundImage = global::AyuboDrive.Properties.Resources.BtnClear;
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Location = new System.Drawing.Point(68, 251);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 60);
            this.BtnClear.TabIndex = 3;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // LblType
            // 
            this.LblType.AutoSize = true;
            this.LblType.BackColor = System.Drawing.Color.Transparent;
            this.LblType.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.ForeColor = System.Drawing.Color.White;
            this.LblType.Location = new System.Drawing.Point(90, 179);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(50, 23);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.BackColor = System.Drawing.Color.Transparent;
            this.LblPw.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPw.ForeColor = System.Drawing.Color.White;
            this.LblPw.Location = new System.Drawing.Point(90, 108);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(88, 23);
            this.LblPw.TabIndex = 1;
            this.LblPw.Text = "Password";
            // 
            // LblUname
            // 
            this.LblUname.AutoSize = true;
            this.LblUname.BackColor = System.Drawing.Color.Transparent;
            this.LblUname.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUname.ForeColor = System.Drawing.Color.White;
            this.LblUname.Location = new System.Drawing.Point(90, 32);
            this.LblUname.Name = "LblUname";
            this.LblUname.Size = new System.Drawing.Size(96, 23);
            this.LblUname.TabIndex = 0;
            this.LblUname.Text = "UserName";
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImage = global::AyuboDrive.Properties.Resources.CloseIconSrch;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(426, 32);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.BackgroundImage = global::AyuboDrive.Properties.Resources.BtnUpdate;
            this.BtnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(68, 251);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(200, 60);
            this.BtnUpdate.TabIndex = 13;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.BackgroundImage = global::AyuboDrive.Properties.Resources.BtnDelete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(312, 251);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 60);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // FrmUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDrive.Properties.Resources.BackLoadFrom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 686);
            this.ControlBox = false;
            this.Controls.Add(this.LblUserControl);
            this.Controls.Add(this.PnlUcon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.FrmUserControl_Load);
            this.PnlUcon.ResumeLayout(false);
            this.PnlUcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserControl;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.Panel PnlUcon;
        private System.Windows.Forms.Label LblUname;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblPw;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}