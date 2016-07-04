namespace Trucking_Company
{
    partial class FrmDailyDriverTimsheetReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyDriverTimsheetReport));
            this.DriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTimesheet = new Trucking_Company.dsTimesheet();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvDailyDriver = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbDriverID = new System.Windows.Forms.ComboBox();
            this.DtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblEmployeeIdNumber = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDailyDriver = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.DriverTableAdapter = new Trucking_Company.dsTimesheetTableAdapters.DriverTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DriverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTimesheet)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DriverBindingSource
            // 
            this.DriverBindingSource.DataMember = "Driver";
            this.DriverBindingSource.DataSource = this.dsTimesheet;
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
            this.PnlForBorder.Controls.Add(this.rpvDailyDriver);
            this.PnlForBorder.Controls.Add(this.CmbDriverID);
            this.PnlForBorder.Controls.Add(this.DtpTripDate);
            this.PnlForBorder.Controls.Add(this.LblDate);
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
            this.BtnGenerate.Location = new System.Drawing.Point(594, 147);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 40;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvDailyDriver
            // 
            reportDataSource3.Name = "dsDailyDriverTimesheet";
            reportDataSource3.Value = this.DriverBindingSource;
            this.rpvDailyDriver.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvDailyDriver.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptDailyDriverTimesheet.rdlc";
            this.rpvDailyDriver.Location = new System.Drawing.Point(0, 217);
            this.rpvDailyDriver.Name = "rpvDailyDriver";
            this.rpvDailyDriver.Size = new System.Drawing.Size(716, 278);
            this.rpvDailyDriver.TabIndex = 39;
            // 
            // CmbDriverID
            // 
            this.CmbDriverID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbDriverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDriverID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDriverID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbDriverID.FormattingEnabled = true;
            this.CmbDriverID.Location = new System.Drawing.Point(228, 128);
            this.CmbDriverID.Name = "CmbDriverID";
            this.CmbDriverID.Size = new System.Drawing.Size(324, 33);
            this.CmbDriverID.TabIndex = 38;
            // 
            // DtpTripDate
            // 
            this.DtpTripDate.CalendarFont = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTripDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpTripDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTripDate.Location = new System.Drawing.Point(228, 166);
            this.DtpTripDate.Name = "DtpTripDate";
            this.DtpTripDate.Size = new System.Drawing.Size(324, 32);
            this.DtpTripDate.TabIndex = 37;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDate.Location = new System.Drawing.Point(160, 170);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(62, 25);
            this.LblDate.TabIndex = 35;
            this.LblDate.Text = "DATE:";
            // 
            // LblEmployeeIdNumber
            // 
            this.LblEmployeeIdNumber.AutoSize = true;
            this.LblEmployeeIdNumber.BackColor = System.Drawing.Color.White;
            this.LblEmployeeIdNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeIdNumber.Location = new System.Drawing.Point(44, 131);
            this.LblEmployeeIdNumber.Name = "LblEmployeeIdNumber";
            this.LblEmployeeIdNumber.Size = new System.Drawing.Size(178, 25);
            this.LblEmployeeIdNumber.TabIndex = 34;
            this.LblEmployeeIdNumber.Text = "DRIVER ID NUMBER:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblDailyDriver);
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
            // LblDailyDriver
            // 
            this.LblDailyDriver.AutoSize = true;
            this.LblDailyDriver.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyDriver.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyDriver.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDailyDriver.Location = new System.Drawing.Point(98, 37);
            this.LblDailyDriver.Name = "LblDailyDriver";
            this.LblDailyDriver.Size = new System.Drawing.Size(513, 43);
            this.LblDailyDriver.TabIndex = 44;
            this.LblDailyDriver.Text = "DAILY TIMESHEET REPORT";
            // 
            // DriverTableAdapter
            // 
            this.DriverTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailyDriverTimsheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDailyDriverTimsheetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DriverBindingSource)).EndInit();
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
        private System.Windows.Forms.Label LblDailyDriver;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDailyDriver;
        private System.Windows.Forms.ComboBox CmbDriverID;
        private System.Windows.Forms.DateTimePicker DtpTripDate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblEmployeeIdNumber;
        private System.Windows.Forms.BindingSource DriverBindingSource;
        private dsTimesheet dsTimesheet;
        private dsTimesheetTableAdapters.DriverTableAdapter DriverTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}