namespace Trucking_Company
{
    partial class FrmMonthlyDriverTimesheetReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyDriverTimesheetReport));
            this.DriverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTimesheet = new Trucking_Company.dsTimesheet();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvMonthly = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbDriverD = new System.Windows.Forms.ComboBox();
            this.LblEmployeeIdNumber = new System.Windows.Forms.Label();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.LblMonth = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblMonthly = new System.Windows.Forms.Label();
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
            this.PnlForBorder.Controls.Add(this.rpvMonthly);
            this.PnlForBorder.Controls.Add(this.CmbDriverD);
            this.PnlForBorder.Controls.Add(this.LblEmployeeIdNumber);
            this.PnlForBorder.Controls.Add(this.CmbMonth);
            this.PnlForBorder.Controls.Add(this.LblMonth);
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
            this.BtnGenerate.Location = new System.Drawing.Point(594, 151);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 42;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvMonthly
            // 
            reportDataSource1.Name = "dsMonthlyDriverTimesheet";
            reportDataSource1.Value = this.DriverBindingSource;
            this.rpvMonthly.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMonthly.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptMonthlyDriverTimesheet.rdlc";
            this.rpvMonthly.Location = new System.Drawing.Point(0, 217);
            this.rpvMonthly.Name = "rpvMonthly";
            this.rpvMonthly.Size = new System.Drawing.Size(716, 278);
            this.rpvMonthly.TabIndex = 41;
            // 
            // CmbDriverD
            // 
            this.CmbDriverD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbDriverD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDriverD.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDriverD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbDriverD.FormattingEnabled = true;
            this.CmbDriverD.Location = new System.Drawing.Point(235, 128);
            this.CmbDriverD.Name = "CmbDriverD";
            this.CmbDriverD.Size = new System.Drawing.Size(324, 31);
            this.CmbDriverD.TabIndex = 40;
            // 
            // LblEmployeeIdNumber
            // 
            this.LblEmployeeIdNumber.AutoSize = true;
            this.LblEmployeeIdNumber.BackColor = System.Drawing.Color.White;
            this.LblEmployeeIdNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeIdNumber.Location = new System.Drawing.Point(49, 131);
            this.LblEmployeeIdNumber.Name = "LblEmployeeIdNumber";
            this.LblEmployeeIdNumber.Size = new System.Drawing.Size(178, 25);
            this.LblEmployeeIdNumber.TabIndex = 39;
            this.LblEmployeeIdNumber.Text = "DRIVER ID NUMBER:";
            // 
            // CmbMonth
            // 
            this.CmbMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMonth.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbMonth.FormattingEnabled = true;
            this.CmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CmbMonth.Location = new System.Drawing.Point(236, 167);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(324, 31);
            this.CmbMonth.TabIndex = 37;
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblMonth.Location = new System.Drawing.Point(76, 170);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(151, 25);
            this.LblMonth.TabIndex = 36;
            this.LblMonth.Text = "SELECT MONTH:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblMonthly);
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
            // LblMonthly
            // 
            this.LblMonthly.AutoSize = true;
            this.LblMonthly.BackColor = System.Drawing.Color.Transparent;
            this.LblMonthly.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthly.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMonthly.Location = new System.Drawing.Point(59, 39);
            this.LblMonthly.Name = "LblMonthly";
            this.LblMonthly.Size = new System.Drawing.Size(591, 43);
            this.LblMonthly.TabIndex = 44;
            this.LblMonthly.Text = "MONTHLY TIMESHEET REPORT";
            // 
            // DriverTableAdapter
            // 
            this.DriverTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMonthlyDriverTimesheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMonthlyDriverTimesheetReport";
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
        private System.Windows.Forms.Label LblMonthly;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.ComboBox CmbDriverD;
        private System.Windows.Forms.Label LblEmployeeIdNumber;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.Label LblMonth;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthly;
        private System.Windows.Forms.BindingSource DriverBindingSource;
        private dsTimesheet dsTimesheet;
        private dsTimesheetTableAdapters.DriverTableAdapter DriverTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}