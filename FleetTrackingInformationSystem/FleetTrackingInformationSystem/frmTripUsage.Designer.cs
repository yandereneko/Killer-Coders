﻿namespace FleetTrackingInformationSystem
{
    partial class frmTripUsage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTripUsage));
            this.lblVehicleRegNo = new System.Windows.Forms.Label();
            this.lblFuelUsage = new System.Windows.Forms.Label();
            this.lblVehicleIncidents = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtVehicleIncidents = new System.Windows.Forms.TextBox();
            this.txtFuelUsage = new System.Windows.Forms.TextBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTripUsage = new System.Windows.Forms.Label();
            this.pnlTripUsage = new System.Windows.Forms.Panel();
            this.mnuFleet = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblKm = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.lblTripID = new System.Windows.Forms.Label();
            this.txtTripID = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.cboV_RN = new System.Windows.Forms.ComboBox();
            this.pnlTripUsage.SuspendLayout();
            this.mnuFleet.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVehicleRegNo
            // 
            this.lblVehicleRegNo.AutoSize = true;
            this.lblVehicleRegNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleRegNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleRegNo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleRegNo.Location = new System.Drawing.Point(68, 203);
            this.lblVehicleRegNo.Name = "lblVehicleRegNo";
            this.lblVehicleRegNo.Size = new System.Drawing.Size(150, 19);
            this.lblVehicleRegNo.TabIndex = 0;
            this.lblVehicleRegNo.Text = "Vehicle Reg Number:";
            // 
            // lblFuelUsage
            // 
            this.lblFuelUsage.AutoSize = true;
            this.lblFuelUsage.BackColor = System.Drawing.Color.Transparent;
            this.lblFuelUsage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblFuelUsage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFuelUsage.Location = new System.Drawing.Point(68, 360);
            this.lblFuelUsage.Name = "lblFuelUsage";
            this.lblFuelUsage.Size = new System.Drawing.Size(85, 19);
            this.lblFuelUsage.TabIndex = 2;
            this.lblFuelUsage.Text = "Fuel Usage:";
            // 
            // lblVehicleIncidents
            // 
            this.lblVehicleIncidents.AutoSize = true;
            this.lblVehicleIncidents.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleIncidents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVehicleIncidents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleIncidents.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVehicleIncidents.Location = new System.Drawing.Point(68, 416);
            this.lblVehicleIncidents.Name = "lblVehicleIncidents";
            this.lblVehicleIncidents.Size = new System.Drawing.Size(127, 19);
            this.lblVehicleIncidents.TabIndex = 3;
            this.lblVehicleIncidents.Text = "Vehicle Incidents:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblDateFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDateFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateFrom.Location = new System.Drawing.Point(68, 249);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(114, 19);
            this.lblDateFrom.TabIndex = 4;
            this.lblDateFrom.Text = "Trip Date From:";
            // 
            // txtVehicleIncidents
            // 
            this.txtVehicleIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleIncidents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleIncidents.Location = new System.Drawing.Point(232, 409);
            this.txtVehicleIncidents.Name = "txtVehicleIncidents";
            this.txtVehicleIncidents.Size = new System.Drawing.Size(197, 26);
            this.txtVehicleIncidents.TabIndex = 6;
            // 
            // txtFuelUsage
            // 
            this.txtFuelUsage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuelUsage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelUsage.Location = new System.Drawing.Point(232, 353);
            this.txtFuelUsage.Name = "txtFuelUsage";
            this.txtFuelUsage.Size = new System.Drawing.Size(197, 26);
            this.txtFuelUsage.TabIndex = 7;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Location = new System.Drawing.Point(232, 244);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(197, 26);
            this.dtpDateFrom.TabIndex = 8;
            // 
            // lblTripUsage
            // 
            this.lblTripUsage.AutoSize = true;
            this.lblTripUsage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTripUsage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripUsage.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripUsage.Location = new System.Drawing.Point(184, 10);
            this.lblTripUsage.Name = "lblTripUsage";
            this.lblTripUsage.Size = new System.Drawing.Size(133, 33);
            this.lblTripUsage.TabIndex = 10;
            this.lblTripUsage.Text = "Trip Usage";
            // 
            // pnlTripUsage
            // 
            this.pnlTripUsage.BackColor = System.Drawing.Color.Transparent;
            this.pnlTripUsage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlTripUsage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTripUsage.Controls.Add(this.lblTripUsage);
            this.pnlTripUsage.Location = new System.Drawing.Point(40, 61);
            this.pnlTripUsage.Name = "pnlTripUsage";
            this.pnlTripUsage.Size = new System.Drawing.Size(530, 64);
            this.pnlTripUsage.TabIndex = 11;
            // 
            // mnuFleet
            // 
            this.mnuFleet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.mnuFleet.Location = new System.Drawing.Point(0, 0);
            this.mnuFleet.Name = "mnuFleet";
            this.mnuFleet.Size = new System.Drawing.Size(594, 24);
            this.mnuFleet.TabIndex = 13;
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
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(290, 13);
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
            this.btnDelete.Location = new System.Drawing.Point(39, 13);
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
            this.btnAdd.Location = new System.Drawing.Point(163, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 35);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(404, 13);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 35);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDateTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateTo.Location = new System.Drawing.Point(68, 301);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(95, 19);
            this.lblDateTo.TabIndex = 15;
            this.lblDateTo.Text = "Trip Date To:";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Location = new System.Drawing.Point(232, 294);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(197, 26);
            this.dtpDateTo.TabIndex = 16;
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblKm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKm.Location = new System.Drawing.Point(68, 477);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(102, 19);
            this.lblKm.TabIndex = 17;
            this.lblKm.Text = "KM Travelled:";
            // 
            // txtKM
            // 
            this.txtKM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKM.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKM.Location = new System.Drawing.Point(232, 470);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(197, 26);
            this.txtKM.TabIndex = 18;
            // 
            // lblTripID
            // 
            this.lblTripID.AutoSize = true;
            this.lblTripID.BackColor = System.Drawing.Color.Transparent;
            this.lblTripID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTripID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTripID.Location = new System.Drawing.Point(68, 157);
            this.lblTripID.Name = "lblTripID";
            this.lblTripID.Size = new System.Drawing.Size(57, 19);
            this.lblTripID.TabIndex = 19;
            this.lblTripID.Text = "Trip ID:";
            // 
            // txtTripID
            // 
            this.txtTripID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTripID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripID.Location = new System.Drawing.Point(232, 150);
            this.txtTripID.Name = "txtTripID";
            this.txtTripID.Size = new System.Drawing.Size(197, 26);
            this.txtTripID.TabIndex = 20;
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
            this.pnlButtons.Location = new System.Drawing.Point(40, 543);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(530, 64);
            this.pnlButtons.TabIndex = 21;
            // 
            // cboV_RN
            // 
            this.cboV_RN.FormattingEnabled = true;
            this.cboV_RN.Location = new System.Drawing.Point(232, 203);
            this.cboV_RN.Name = "cboV_RN";
            this.cboV_RN.Size = new System.Drawing.Size(121, 21);
            this.cboV_RN.TabIndex = 22;
            // 
            // frmTripUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 643);
            this.Controls.Add(this.cboV_RN);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtTripID);
            this.Controls.Add(this.lblTripID);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.dtpDateTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.txtVehicleIncidents);
            this.Controls.Add(this.lblVehicleIncidents);
            this.Controls.Add(this.txtFuelUsage);
            this.Controls.Add(this.lblFuelUsage);
            this.Controls.Add(this.mnuFleet);
            this.Controls.Add(this.dtpDateFrom);
            this.Controls.Add(this.pnlTripUsage);
            this.Controls.Add(this.lblVehicleRegNo);
            this.Controls.Add(this.lblDateFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTripUsage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fleet Tracking Information System";
            this.Load += new System.EventHandler(this.frmTripUsage_Load);
            this.pnlTripUsage.ResumeLayout(false);
            this.pnlTripUsage.PerformLayout();
            this.mnuFleet.ResumeLayout(false);
            this.mnuFleet.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleRegNo;
        private System.Windows.Forms.Label lblFuelUsage;
        private System.Windows.Forms.Label lblVehicleIncidents;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TextBox txtVehicleIncidents;
        private System.Windows.Forms.TextBox txtFuelUsage;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblTripUsage;
        private System.Windows.Forms.Panel pnlTripUsage;
        private System.Windows.Forms.MenuStrip mnuFleet;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label lblTripID;
        private System.Windows.Forms.TextBox txtTripID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ComboBox cboV_RN;
    }
}