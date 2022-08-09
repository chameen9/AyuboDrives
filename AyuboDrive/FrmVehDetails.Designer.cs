namespace AyuboDrive
{
    partial class FrmVehDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehDetails));
            this.LblVehDetails = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnReg = new System.Windows.Forms.Button();
            this.GrpRentCharge = new System.Windows.Forms.GroupBox();
            this.GrpHire = new System.Windows.Forms.GroupBox();
            this.LblNormalCharg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblDailyRate = new System.Windows.Forms.Label();
            this.TxtDailyRate = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblWeeklyRate = new System.Windows.Forms.Label();
            this.TxtWeeklyRate = new System.Windows.Forms.TextBox();
            this.LblMonthlyRate = new System.Windows.Forms.Label();
            this.TxtMonthlyRate = new System.Windows.Forms.TextBox();
            this.TxtNormalCharge = new System.Windows.Forms.TextBox();
            this.TxtExtraCharge = new System.Windows.Forms.TextBox();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.PnlVehdtls = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrpHire.SuspendLayout();
            this.PnlVehdtls.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblVehDetails
            // 
            this.LblVehDetails.AutoSize = true;
            this.LblVehDetails.BackColor = System.Drawing.Color.Transparent;
            this.LblVehDetails.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehDetails.ForeColor = System.Drawing.Color.White;
            this.LblVehDetails.Location = new System.Drawing.Point(12, 18);
            this.LblVehDetails.Name = "LblVehDetails";
            this.LblVehDetails.Size = new System.Drawing.Size(169, 23);
            this.LblVehDetails.TabIndex = 39;
            this.LblVehDetails.Text = "Vehicle Details";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(199, 48);
            this.TxtName.MaxLength = 20;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(143, 25);
            this.TxtName.TabIndex = 0;
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
            this.BtnClose.Location = new System.Drawing.Point(397, 48);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Visible = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.BtnSearch.Location = new System.Drawing.Point(397, 48);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(25, 25);
            this.BtnSearch.TabIndex = 10;
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
            this.BtnReg.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReg.Location = new System.Drawing.Point(495, 318);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(200, 60);
            this.BtnReg.TabIndex = 9;
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // GrpRentCharge
            // 
            this.GrpRentCharge.BackColor = System.Drawing.Color.Transparent;
            this.GrpRentCharge.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRentCharge.ForeColor = System.Drawing.Color.White;
            this.GrpRentCharge.Location = new System.Drawing.Point(495, 48);
            this.GrpRentCharge.Name = "GrpRentCharge";
            this.GrpRentCharge.Size = new System.Drawing.Size(326, 238);
            this.GrpRentCharge.TabIndex = 6;
            this.GrpRentCharge.TabStop = false;
            this.GrpRentCharge.Text = "Rent Charges";
            // 
            // GrpHire
            // 
            this.GrpHire.BackColor = System.Drawing.Color.Transparent;
            this.GrpHire.Controls.Add(this.LblNormalCharg);
            this.GrpHire.Controls.Add(this.label4);
            this.GrpHire.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpHire.ForeColor = System.Drawing.Color.White;
            this.GrpHire.Location = new System.Drawing.Point(73, 142);
            this.GrpHire.Name = "GrpHire";
            this.GrpHire.Size = new System.Drawing.Size(355, 144);
            this.GrpHire.TabIndex = 3;
            this.GrpHire.TabStop = false;
            this.GrpHire.Text = "Hire Charges";
            // 
            // LblNormalCharg
            // 
            this.LblNormalCharg.BackColor = System.Drawing.Color.Transparent;
            this.LblNormalCharg.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNormalCharg.ForeColor = System.Drawing.Color.White;
            this.LblNormalCharg.Location = new System.Drawing.Point(58, 50);
            this.LblNormalCharg.Name = "LblNormalCharg";
            this.LblNormalCharg.Size = new System.Drawing.Size(140, 23);
            this.LblNormalCharg.TabIndex = 19;
            this.LblNormalCharg.Text = "Normal Charge";
            this.LblNormalCharg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Extra Charge";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblName
            // 
            this.LblName.BackColor = System.Drawing.Color.Transparent;
            this.LblName.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.Color.White;
            this.LblName.Location = new System.Drawing.Point(69, 48);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(124, 23);
            this.LblName.TabIndex = 17;
            this.LblName.Text = "Type Name";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDailyRate
            // 
            this.LblDailyRate.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyRate.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyRate.ForeColor = System.Drawing.Color.White;
            this.LblDailyRate.Location = new System.Drawing.Point(524, 104);
            this.LblDailyRate.Name = "LblDailyRate";
            this.LblDailyRate.Size = new System.Drawing.Size(140, 23);
            this.LblDailyRate.TabIndex = 21;
            this.LblDailyRate.Text = "Daily Rate";
            this.LblDailyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtDailyRate
            // 
            this.TxtDailyRate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDailyRate.Location = new System.Drawing.Point(670, 104);
            this.TxtDailyRate.MaxLength = 14;
            this.TxtDailyRate.Name = "TxtDailyRate";
            this.TxtDailyRate.Size = new System.Drawing.Size(125, 28);
            this.TxtDailyRate.TabIndex = 5;
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
            this.BtnDelete.Location = new System.Drawing.Point(495, 318);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(200, 60);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.BtnClear.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(228, 318);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(200, 60);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
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
            this.BtnUpdate.Location = new System.Drawing.Point(228, 318);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(200, 60);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Visible = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblId
            // 
            this.LblId.BackColor = System.Drawing.Color.Transparent;
            this.LblId.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblId.ForeColor = System.Drawing.Color.White;
            this.LblId.Location = new System.Drawing.Point(69, 90);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(85, 23);
            this.LblId.TabIndex = 18;
            this.LblId.Text = "Type ID";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtId
            // 
            this.TxtId.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtId.Location = new System.Drawing.Point(199, 90);
            this.TxtId.MaxLength = 6;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(103, 28);
            this.TxtId.TabIndex = 2;
            // 
            // LblWeeklyRate
            // 
            this.LblWeeklyRate.BackColor = System.Drawing.Color.Transparent;
            this.LblWeeklyRate.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeklyRate.ForeColor = System.Drawing.Color.White;
            this.LblWeeklyRate.Location = new System.Drawing.Point(524, 162);
            this.LblWeeklyRate.Name = "LblWeeklyRate";
            this.LblWeeklyRate.Size = new System.Drawing.Size(140, 23);
            this.LblWeeklyRate.TabIndex = 22;
            this.LblWeeklyRate.Text = "Weekly Rate";
            this.LblWeeklyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtWeeklyRate
            // 
            this.TxtWeeklyRate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWeeklyRate.Location = new System.Drawing.Point(670, 162);
            this.TxtWeeklyRate.MaxLength = 14;
            this.TxtWeeklyRate.Name = "TxtWeeklyRate";
            this.TxtWeeklyRate.Size = new System.Drawing.Size(125, 28);
            this.TxtWeeklyRate.TabIndex = 6;
            // 
            // LblMonthlyRate
            // 
            this.LblMonthlyRate.BackColor = System.Drawing.Color.Transparent;
            this.LblMonthlyRate.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthlyRate.ForeColor = System.Drawing.Color.White;
            this.LblMonthlyRate.Location = new System.Drawing.Point(524, 224);
            this.LblMonthlyRate.Name = "LblMonthlyRate";
            this.LblMonthlyRate.Size = new System.Drawing.Size(140, 23);
            this.LblMonthlyRate.TabIndex = 23;
            this.LblMonthlyRate.Text = "Monthly Rate";
            this.LblMonthlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtMonthlyRate
            // 
            this.TxtMonthlyRate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMonthlyRate.Location = new System.Drawing.Point(670, 224);
            this.TxtMonthlyRate.MaxLength = 14;
            this.TxtMonthlyRate.Name = "TxtMonthlyRate";
            this.TxtMonthlyRate.Size = new System.Drawing.Size(125, 28);
            this.TxtMonthlyRate.TabIndex = 7;
            // 
            // TxtNormalCharge
            // 
            this.TxtNormalCharge.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNormalCharge.Location = new System.Drawing.Point(288, 192);
            this.TxtNormalCharge.MaxLength = 8;
            this.TxtNormalCharge.Name = "TxtNormalCharge";
            this.TxtNormalCharge.Size = new System.Drawing.Size(84, 28);
            this.TxtNormalCharge.TabIndex = 3;
            // 
            // TxtExtraCharge
            // 
            this.TxtExtraCharge.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExtraCharge.Location = new System.Drawing.Point(288, 238);
            this.TxtExtraCharge.MaxLength = 8;
            this.TxtExtraCharge.Name = "TxtExtraCharge";
            this.TxtExtraCharge.Size = new System.Drawing.Size(84, 28);
            this.TxtExtraCharge.TabIndex = 4;
            // 
            // CmbName
            // 
            this.CmbName.DropDownHeight = 90;
            this.CmbName.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbName.FormattingEnabled = true;
            this.CmbName.IntegralHeight = false;
            this.CmbName.Location = new System.Drawing.Point(199, 47);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(174, 28);
            this.CmbName.TabIndex = 1;
            this.CmbName.Visible = false;
            this.CmbName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // PnlVehdtls
            // 
            this.PnlVehdtls.BackColor = System.Drawing.Color.Transparent;
            this.PnlVehdtls.Controls.Add(this.panel4);
            this.PnlVehdtls.Controls.Add(this.panel3);
            this.PnlVehdtls.Controls.Add(this.panel2);
            this.PnlVehdtls.Controls.Add(this.panel1);
            this.PnlVehdtls.Controls.Add(this.CmbName);
            this.PnlVehdtls.Controls.Add(this.TxtExtraCharge);
            this.PnlVehdtls.Controls.Add(this.TxtNormalCharge);
            this.PnlVehdtls.Controls.Add(this.TxtMonthlyRate);
            this.PnlVehdtls.Controls.Add(this.LblMonthlyRate);
            this.PnlVehdtls.Controls.Add(this.TxtWeeklyRate);
            this.PnlVehdtls.Controls.Add(this.LblWeeklyRate);
            this.PnlVehdtls.Controls.Add(this.TxtId);
            this.PnlVehdtls.Controls.Add(this.LblId);
            this.PnlVehdtls.Controls.Add(this.BtnClear);
            this.PnlVehdtls.Controls.Add(this.TxtDailyRate);
            this.PnlVehdtls.Controls.Add(this.LblDailyRate);
            this.PnlVehdtls.Controls.Add(this.LblName);
            this.PnlVehdtls.Controls.Add(this.GrpHire);
            this.PnlVehdtls.Controls.Add(this.GrpRentCharge);
            this.PnlVehdtls.Controls.Add(this.BtnReg);
            this.PnlVehdtls.Controls.Add(this.BtnSearch);
            this.PnlVehdtls.Controls.Add(this.BtnClose);
            this.PnlVehdtls.Controls.Add(this.TxtName);
            this.PnlVehdtls.Controls.Add(this.BtnUpdate);
            this.PnlVehdtls.Controls.Add(this.BtnDelete);
            this.PnlVehdtls.Location = new System.Drawing.Point(57, 141);
            this.PnlVehdtls.Name = "PnlVehdtls";
            this.PnlVehdtls.Size = new System.Drawing.Size(890, 400);
            this.PnlVehdtls.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 1);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(1, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 1);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(889, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 400);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 400);
            this.panel1.TabIndex = 24;
            // 
            // FrmVehDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AyuboDrive.Properties.Resources.BackLoadFrom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 686);
            this.ControlBox = false;
            this.Controls.Add(this.PnlVehdtls);
            this.Controls.Add(this.LblVehDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVehDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Details";
            this.Load += new System.EventHandler(this.FrmVehDetails_Load);
            this.GrpHire.ResumeLayout(false);
            this.PnlVehdtls.ResumeLayout(false);
            this.PnlVehdtls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVehDetails;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReg;
        private System.Windows.Forms.GroupBox GrpRentCharge;
        private System.Windows.Forms.GroupBox GrpHire;
        private System.Windows.Forms.Label LblNormalCharg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblDailyRate;
        private System.Windows.Forms.TextBox TxtDailyRate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblWeeklyRate;
        private System.Windows.Forms.TextBox TxtWeeklyRate;
        private System.Windows.Forms.Label LblMonthlyRate;
        private System.Windows.Forms.TextBox TxtMonthlyRate;
        private System.Windows.Forms.TextBox TxtNormalCharge;
        private System.Windows.Forms.TextBox TxtExtraCharge;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.Panel PnlVehdtls;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}