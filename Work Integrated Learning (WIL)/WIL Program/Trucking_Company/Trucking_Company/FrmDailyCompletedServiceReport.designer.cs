namespace Trucking_Company
{
    partial class FrmDailyCompletedServiceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyCompletedServiceReport));
            this.VehicleServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDailyVehicleServiceCompleted = new Trucking_Company.dsDailyVehicleServiceCompleted();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LblServiceDate = new System.Windows.Forms.Label();
            this.DtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.rpvDailyCompletedService = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDailyCompleteVehicleService = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleServiceTableAdapter = new Trucking_Company.dsDailyVehicleServiceCompletedTableAdapters.VehicleServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDailyVehicleServiceCompleted)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleServiceBindingSource
            // 
            this.VehicleServiceBindingSource.DataMember = "VehicleService";
            this.VehicleServiceBindingSource.DataSource = this.dsDailyVehicleServiceCompleted;
            // 
            // dsDailyVehicleServiceCompleted
            // 
            this.dsDailyVehicleServiceCompleted.DataSetName = "dsDailyVehicleServiceCompleted";
            this.dsDailyVehicleServiceCompleted.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.LblServiceDate);
            this.PnlForBorder.Controls.Add(this.DtpServiceDate);
            this.PnlForBorder.Controls.Add(this.rpvDailyCompletedService);
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
            this.BtnGenerate.Location = new System.Drawing.Point(600, 151);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 32;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LblServiceDate
            // 
            this.LblServiceDate.AutoSize = true;
            this.LblServiceDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceDate.Location = new System.Drawing.Point(40, 155);
            this.LblServiceDate.Name = "LblServiceDate";
            this.LblServiceDate.Size = new System.Drawing.Size(139, 25);
            this.LblServiceDate.TabIndex = 30;
            this.LblServiceDate.Text = "SERVICE DATE:";
            // 
            // DtpServiceDate
            // 
            this.DtpServiceDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpServiceDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpServiceDate.Location = new System.Drawing.Point(224, 151);
            this.DtpServiceDate.Name = "DtpServiceDate";
            this.DtpServiceDate.Size = new System.Drawing.Size(324, 29);
            this.DtpServiceDate.TabIndex = 29;
            // 
            // rpvDailyCompletedService
            // 
            reportDataSource1.Name = "dsVsCompletedService";
            reportDataSource1.Value = this.VehicleServiceBindingSource;
            this.rpvDailyCompletedService.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDailyCompletedService.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptDailyCompletedService.rdlc";
            this.rpvDailyCompletedService.Location = new System.Drawing.Point(0, 216);
            this.rpvDailyCompletedService.Name = "rpvDailyCompletedService";
            this.rpvDailyCompletedService.Size = new System.Drawing.Size(716, 279);
            this.rpvDailyCompletedService.TabIndex = 1;
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblDailyCompleteVehicleService);
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
            // LblDailyCompleteVehicleService
            // 
            this.LblDailyCompleteVehicleService.AutoSize = true;
            this.LblDailyCompleteVehicleService.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyCompleteVehicleService.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyCompleteVehicleService.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDailyCompleteVehicleService.Location = new System.Drawing.Point(84, 39);
            this.LblDailyCompleteVehicleService.Name = "LblDailyCompleteVehicleService";
            this.LblDailyCompleteVehicleService.Size = new System.Drawing.Size(536, 43);
            this.LblDailyCompleteVehicleService.TabIndex = 44;
            this.LblDailyCompleteVehicleService.Text = "DAILY COMPLETED SERVICE";
            // 
            // VehicleServiceTableAdapter
            // 
            this.VehicleServiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailyCompletedServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDailyCompletedServiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDailyVehicleServiceCompleted)).EndInit();
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
        private System.Windows.Forms.Label LblDailyCompleteVehicleService;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDailyCompletedService;
        private System.Windows.Forms.DateTimePicker DtpServiceDate;
        private System.Windows.Forms.Label LblServiceDate;
        private System.Windows.Forms.BindingSource VehicleServiceBindingSource;
        private dsDailyVehicleServiceCompleted dsDailyVehicleServiceCompleted;
        private dsDailyVehicleServiceCompletedTableAdapters.VehicleServiceTableAdapter VehicleServiceTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}