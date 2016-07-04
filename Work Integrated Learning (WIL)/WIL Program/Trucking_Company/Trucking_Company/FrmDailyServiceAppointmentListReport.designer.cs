namespace Trucking_Company
{
    partial class FrmDailyServiceAppointmentListReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyServiceAppointmentListReport));
            this.VehicleServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDailyServiceAppointmentList = new Trucking_Company.dsDailyServiceAppointmentList();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvDailyServiceAppointmentList = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.LblDateOfReport = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDailyService = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.ServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsService = new Trucking_Company.dsService();
            this.ServiceTableAdapter = new Trucking_Company.dsServiceTableAdapters.ServiceTableAdapter();
            this.VehicleServicesTableAdapter = new Trucking_Company.dsDailyServiceAppointmentListTableAdapters.VehicleServicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDailyServiceAppointmentList)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsService)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleServicesBindingSource
            // 
            this.VehicleServicesBindingSource.DataMember = "VehicleServices";
            this.VehicleServicesBindingSource.DataSource = this.dsDailyServiceAppointmentList;
            // 
            // dsDailyServiceAppointmentList
            // 
            this.dsDailyServiceAppointmentList.DataSetName = "dsDailyServiceAppointmentList";
            this.dsDailyServiceAppointmentList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvDailyServiceAppointmentList);
            this.PnlForBorder.Controls.Add(this.DtpServiceDate);
            this.PnlForBorder.Controls.Add(this.LblDateOfReport);
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
            this.BtnGenerate.Location = new System.Drawing.Point(573, 149);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 33;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvDailyServiceAppointmentList
            // 
            reportDataSource2.Name = "dsServiceAppListDaily";
            reportDataSource2.Value = this.VehicleServicesBindingSource;
            this.rpvDailyServiceAppointmentList.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvDailyServiceAppointmentList.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptDailyServiceAppList.rdlc";
            this.rpvDailyServiceAppointmentList.Location = new System.Drawing.Point(0, 216);
            this.rpvDailyServiceAppointmentList.Name = "rpvDailyServiceAppointmentList";
            this.rpvDailyServiceAppointmentList.Size = new System.Drawing.Size(716, 279);
            this.rpvDailyServiceAppointmentList.TabIndex = 27;
            // 
            // DtpServiceDate
            // 
            this.DtpServiceDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.DtpServiceDate.Location = new System.Drawing.Point(226, 149);
            this.DtpServiceDate.Name = "DtpServiceDate";
            this.DtpServiceDate.Size = new System.Drawing.Size(288, 29);
            this.DtpServiceDate.TabIndex = 23;
            // 
            // LblDateOfReport
            // 
            this.LblDateOfReport.AutoSize = true;
            this.LblDateOfReport.BackColor = System.Drawing.Color.White;
            this.LblDateOfReport.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfReport.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDateOfReport.Location = new System.Drawing.Point(37, 153);
            this.LblDateOfReport.Name = "LblDateOfReport";
            this.LblDateOfReport.Size = new System.Drawing.Size(139, 25);
            this.LblDateOfReport.TabIndex = 22;
            this.LblDateOfReport.Text = "SERVICE DATE:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblDailyService);
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
            this.BtnReturn.Location = new System.Drawing.Point(677, 8);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(36, 28);
            this.BtnReturn.TabIndex = 45;
            this.TipDeleteService.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblDailyService
            // 
            this.LblDailyService.AutoSize = true;
            this.LblDailyService.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyService.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyService.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDailyService.Location = new System.Drawing.Point(23, 39);
            this.LblDailyService.Name = "LblDailyService";
            this.LblDailyService.Size = new System.Drawing.Size(666, 43);
            this.LblDailyService.TabIndex = 44;
            this.LblDailyService.Text = "DAILY SERVICE APPOINTMENT LIST";
            // 
            // ServiceBindingSource
            // 
            this.ServiceBindingSource.DataMember = "Service";
            this.ServiceBindingSource.DataSource = this.dsService;
            // 
            // dsService
            // 
            this.dsService.DataSetName = "dsService";
            this.dsService.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ServiceTableAdapter
            // 
            this.ServiceTableAdapter.ClearBeforeFill = true;
            // 
            // VehicleServicesTableAdapter
            // 
            this.VehicleServicesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailyServiceAppointmentListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDailyServiceAppointmentListReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDailyServiceAppointmentList)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteServiceBackgroundImage.ResumeLayout(false);
            this.PnlDeleteServiceBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteServiceBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblDailyService;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.Label LblDateOfReport;
        private System.Windows.Forms.DateTimePicker DtpServiceDate;
        private System.Windows.Forms.BindingSource ServiceBindingSource;
        private dsService dsService;
        private dsServiceTableAdapters.ServiceTableAdapter ServiceTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDailyServiceAppointmentList;
        private System.Windows.Forms.BindingSource VehicleServicesBindingSource;
        private dsDailyServiceAppointmentList dsDailyServiceAppointmentList;
        private dsDailyServiceAppointmentListTableAdapters.VehicleServicesTableAdapter VehicleServicesTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}