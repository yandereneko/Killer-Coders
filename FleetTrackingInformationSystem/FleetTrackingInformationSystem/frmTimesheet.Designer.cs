﻿namespace FleetTrackingInformationSystem
{
    partial class frmTimesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimesheet));
            this.pnlTimesheet = new System.Windows.Forms.Panel();
            this.lblTimesheet = new System.Windows.Forms.Label();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblNumHoursWorked = new System.Windows.Forms.Label();
            this.updHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.lblT_ID = new System.Windows.Forms.Label();
            this.txtT_ID = new System.Windows.Forms.TextBox();
            this.cboE_ID = new System.Windows.Forms.ComboBox();
            this.pnlTimesheet.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHoursWorked)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimesheet
            // 
            this.pnlTimesheet.BackColor = System.Drawing.Color.Transparent;
            this.pnlTimesheet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimesheet.Controls.Add(this.lblTimesheet);
            this.pnlTimesheet.Location = new System.Drawing.Point(29, 54);
            this.pnlTimesheet.Name = "pnlTimesheet";
            this.pnlTimesheet.Size = new System.Drawing.Size(526, 66);
            this.pnlTimesheet.TabIndex = 9;
            // 
            // lblTimesheet
            // 
            this.lblTimesheet.AutoSize = true;
            this.lblTimesheet.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesheet.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTimesheet.Location = new System.Drawing.Point(193, 14);
            this.lblTimesheet.Name = "lblTimesheet";
            this.lblTimesheet.Size = new System.Drawing.Size(133, 33);
            this.lblTimesheet.TabIndex = 7;
            this.lblTimesheet.Text = "Timesheet";
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(584, 24);
            this.mnuFleet.TabIndex = 14;
            this.mnuFleet.Text = "menuStrip1";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(99, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(99, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeeID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEmployeeID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeID.Location = new System.Drawing.Point(58, 259);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(100, 21);
            this.lblEmployeeID.TabIndex = 17;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lblNumHoursWorked
            // 
            this.lblNumHoursWorked.AutoSize = true;
            this.lblNumHoursWorked.BackColor = System.Drawing.Color.Transparent;
            this.lblNumHoursWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumHoursWorked.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNumHoursWorked.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumHoursWorked.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNumHoursWorked.Location = new System.Drawing.Point(58, 312);
            this.lblNumHoursWorked.Name = "lblNumHoursWorked";
            this.lblNumHoursWorked.Size = new System.Drawing.Size(193, 21);
            this.lblNumHoursWorked.TabIndex = 18;
            this.lblNumHoursWorked.Text = "Number Of Hours Worked:";
            // 
            // updHoursWorked
            // 
            this.updHoursWorked.DecimalPlaces = 1;
            this.updHoursWorked.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updHoursWorked.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.updHoursWorked.Location = new System.Drawing.Point(273, 307);
            this.updHoursWorked.Name = "updHoursWorked";
            this.updHoursWorked.Size = new System.Drawing.Size(234, 26);
            this.updHoursWorked.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(55, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(272, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(380, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Location = new System.Drawing.Point(29, 430);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(526, 66);
            this.pnlButtons.TabIndex = 37;
            // 
            // lblT_ID
            // 
            this.lblT_ID.AutoSize = true;
            this.lblT_ID.BackColor = System.Drawing.Color.Transparent;
            this.lblT_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblT_ID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT_ID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblT_ID.Location = new System.Drawing.Point(58, 206);
            this.lblT_ID.Name = "lblT_ID";
            this.lblT_ID.Size = new System.Drawing.Size(103, 21);
            this.lblT_ID.TabIndex = 38;
            this.lblT_ID.Text = "Timesheet ID:";
            // 
            // txtT_ID
            // 
            this.txtT_ID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_ID.Location = new System.Drawing.Point(273, 201);
            this.txtT_ID.Name = "txtT_ID";
            this.txtT_ID.Size = new System.Drawing.Size(234, 26);
            this.txtT_ID.TabIndex = 39;
            // 
            // cboE_ID
            // 
            this.cboE_ID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboE_ID.FormattingEnabled = true;
            this.cboE_ID.Location = new System.Drawing.Point(273, 252);
            this.cboE_ID.Name = "cboE_ID";
            this.cboE_ID.Size = new System.Drawing.Size(234, 26);
            this.cboE_ID.TabIndex = 40;
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 534);
            this.Controls.Add(this.cboE_ID);
            this.Controls.Add(this.txtT_ID);
            this.Controls.Add(this.lblT_ID);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.updHoursWorked);
            this.Controls.Add(this.lblNumHoursWorked);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.pnlTimesheet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            this.pnlTimesheet.ResumeLayout(false);
            this.pnlTimesheet.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updHoursWorked)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTimesheet;
        private System.Windows.Forms.Label lblTimesheet;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblNumHoursWorked;
        private System.Windows.Forms.NumericUpDown updHoursWorked;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Label lblT_ID;
        private System.Windows.Forms.TextBox txtT_ID;
        private System.Windows.Forms.ComboBox cboE_ID;
    }
}