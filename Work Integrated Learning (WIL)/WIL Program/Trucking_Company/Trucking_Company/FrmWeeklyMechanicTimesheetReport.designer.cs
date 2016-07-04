namespace Trucking_Company
{
    partial class FrmWeeklyMechanicTimesheetReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeeklyMechanicTimesheetReport));
            this.MechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTimesheet = new Trucking_Company.dsTimesheet();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvWeeklyMehanic = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.CmbMechanicID = new System.Windows.Forms.ComboBox();
            this.LblEmployeeIdNumber = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblWeeklyMechanic = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.MechanicTableAdapter = new Trucking_Company.dsTimesheetTableAdapters.MechanicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTimesheet)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MechanicBindingSource
            // 
            this.MechanicBindingSource.DataMember = "Mechanic";
            this.MechanicBindingSource.DataSource = this.dsTimesheet;
            // 
            // dsTimesheet
            // 
            this.dsTimesheet.DataSetName = "dsTimesheet";
            this.dsTimesheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvWeeklyMehanic);
            this.PnlForBorder.Controls.Add(this.DtpEndDate);
            this.PnlForBorder.Controls.Add(this.DtpStartDate);
            this.PnlForBorder.Controls.Add(this.lblEndDate);
            this.PnlForBorder.Controls.Add(this.LblStartDate);
            this.PnlForBorder.Controls.Add(this.CmbMechanicID);
            this.PnlForBorder.Controls.Add(this.LblEmployeeIdNumber);
            this.PnlForBorder.Controls.Add(this.PnlDeleteServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGenerate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerate.ForeColor = System.Drawing.Color.White;
            this.BtnGenerate.Location = new System.Drawing.Point(604, 144);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGenerate.TabIndex = 45;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvWeeklyMehanic
            // 
            reportDataSource3.Name = "dsWeeklyMechanicTimesheet";
            reportDataSource3.Value = this.MechanicBindingSource;
            this.rpvWeeklyMehanic.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvWeeklyMehanic.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptWeeklyMechanicTimesheet.rdlc";
            this.rpvWeeklyMehanic.Location = new System.Drawing.Point(0, 217);
            this.rpvWeeklyMehanic.Name = "rpvWeeklyMehanic";
            this.rpvWeeklyMehanic.Size = new System.Drawing.Size(716, 278);
            this.rpvWeeklyMehanic.TabIndex = 41;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.Location = new System.Drawing.Point(228, 217);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(324, 29);
            this.DtpEndDate.TabIndex = 39;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.Location = new System.Drawing.Point(252, 168);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(324, 29);
            this.DtpStartDate.TabIndex = 38;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndDate.Location = new System.Drawing.Point(106, 218);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(116, 29);
            this.lblEndDate.TabIndex = 37;
            this.lblEndDate.Text = "END DATE:";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblStartDate.Location = new System.Drawing.Point(107, 168);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(123, 25);
            this.LblStartDate.TabIndex = 36;
            this.LblStartDate.Text = "START DATE:";
            // 
            // CmbMechanicID
            // 
            this.CmbMechanicID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbMechanicID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMechanicID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMechanicID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbMechanicID.FormattingEnabled = true;
            this.CmbMechanicID.Location = new System.Drawing.Point(252, 128);
            this.CmbMechanicID.Name = "CmbMechanicID";
            this.CmbMechanicID.Size = new System.Drawing.Size(324, 31);
            this.CmbMechanicID.TabIndex = 35;
            // 
            // LblEmployeeIdNumber
            // 
            this.LblEmployeeIdNumber.AutoSize = true;
            this.LblEmployeeIdNumber.BackColor = System.Drawing.Color.White;
            this.LblEmployeeIdNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeIdNumber.Location = new System.Drawing.Point(41, 131);
            this.LblEmployeeIdNumber.Name = "LblEmployeeIdNumber";
            this.LblEmployeeIdNumber.Size = new System.Drawing.Size(205, 25);
            this.LblEmployeeIdNumber.TabIndex = 34;
            this.LblEmployeeIdNumber.Text = "MECHANIC ID NUMBER:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblWeeklyMechanic);
            this.PnlDeleteServiceBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteServiceBackgroundImage.Name = "PnlDeleteServiceBackgroundImage";
            this.PnlDeleteServiceBackgroundImage.Size = new System.Drawing.Size(716, 122);
            this.PnlDeleteServiceBackgroundImage.TabIndex = 0;
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReturn.BackgroundImage")));
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnReturn.Location = new System.Drawing.Point(672, 8);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(36, 28);
            this.BtnReturn.TabIndex = 45;
            this.TipDeleteService.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblWeeklyMechanic
            // 
            this.LblWeeklyMechanic.AutoSize = true;
            this.LblWeeklyMechanic.BackColor = System.Drawing.Color.Transparent;
            this.LblWeeklyMechanic.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeklyMechanic.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblWeeklyMechanic.Location = new System.Drawing.Point(80, 35);
            this.LblWeeklyMechanic.Name = "LblWeeklyMechanic";
            this.LblWeeklyMechanic.Size = new System.Drawing.Size(556, 43);
            this.LblWeeklyMechanic.TabIndex = 44;
            this.LblWeeklyMechanic.Text = "WEEKLY TIMESHEET REPORT";
            // 
            // MechanicTableAdapter
            // 
            this.MechanicTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWeeklyMechanicTimesheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmWeeklyMechanicTimesheetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTimesheet)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteServiceBackgroundImage.ResumeLayout(false);
            this.PnlDeleteServiceBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteServiceBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblWeeklyMechanic;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.ComboBox CmbMechanicID;
        private System.Windows.Forms.Label LblEmployeeIdNumber;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWeeklyMehanic;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.BindingSource MechanicBindingSource;
        private dsTimesheet dsTimesheet;
        private dsTimesheetTableAdapters.MechanicTableAdapter MechanicTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}