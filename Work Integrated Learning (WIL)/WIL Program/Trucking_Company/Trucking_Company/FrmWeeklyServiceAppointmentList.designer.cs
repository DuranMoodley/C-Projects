namespace Trucking_Company
{
    partial class FrmWeeklyServiceAppointmentList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeeklyServiceAppointmentList));
            this.ServiceAppointmentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsWeeklyServiceAppointmentList = new Trucking_Company.dsWeeklyServiceAppointmentList();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvWeeklyReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblServiceList = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.ServiceAppointmentListTableAdapter = new Trucking_Company.dsWeeklyServiceAppointmentListTableAdapters.ServiceAppointmentListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceAppointmentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWeeklyServiceAppointmentList)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceAppointmentListBindingSource
            // 
            this.ServiceAppointmentListBindingSource.DataMember = "ServiceAppointmentList";
            this.ServiceAppointmentListBindingSource.DataSource = this.dsWeeklyServiceAppointmentList;
            // 
            // dsWeeklyServiceAppointmentList
            // 
            this.dsWeeklyServiceAppointmentList.DataSetName = "dsWeeklyServiceAppointmentList";
            this.dsWeeklyServiceAppointmentList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvWeeklyReport);
            this.PnlForBorder.Controls.Add(this.DtpEndDate);
            this.PnlForBorder.Controls.Add(this.DtpStartDate);
            this.PnlForBorder.Controls.Add(this.lblEndDate);
            this.PnlForBorder.Controls.Add(this.LblStartDate);
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
            this.BtnGenerate.Location = new System.Drawing.Point(529, 150);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGenerate.TabIndex = 46;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvWeeklyReport
            // 
            reportDataSource4.Name = "dsServiceAppointmentListWeekly";
            reportDataSource4.Value = this.ServiceAppointmentListBindingSource;
            this.rpvWeeklyReport.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvWeeklyReport.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptWeeklyServiceAppointmentList.rdlc";
            this.rpvWeeklyReport.Location = new System.Drawing.Point(0, 217);
            this.rpvWeeklyReport.Name = "rpvWeeklyReport";
            this.rpvWeeklyReport.Size = new System.Drawing.Size(716, 278);
            this.rpvWeeklyReport.TabIndex = 31;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.Location = new System.Drawing.Point(176, 167);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(324, 29);
            this.DtpEndDate.TabIndex = 30;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.Location = new System.Drawing.Point(176, 131);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(324, 29);
            this.DtpStartDate.TabIndex = 29;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndDate.Location = new System.Drawing.Point(68, 167);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(102, 25);
            this.lblEndDate.TabIndex = 25;
            this.lblEndDate.Text = "END DATE:";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblStartDate.Location = new System.Drawing.Point(47, 135);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(123, 25);
            this.LblStartDate.TabIndex = 24;
            this.LblStartDate.Text = "START DATE:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblServiceList);
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
            // LblServiceList
            // 
            this.LblServiceList.AutoSize = true;
            this.LblServiceList.BackColor = System.Drawing.Color.Transparent;
            this.LblServiceList.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceList.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblServiceList.Location = new System.Drawing.Point(140, 34);
            this.LblServiceList.Name = "LblServiceList";
            this.LblServiceList.Size = new System.Drawing.Size(427, 43);
            this.LblServiceList.TabIndex = 44;
            this.LblServiceList.Text = "WEEKLY SERVICE LIST";
            // 
            // ServiceAppointmentListTableAdapter
            // 
            this.ServiceAppointmentListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWeeklyServiceAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(725, 505);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmWeeklyServiceAppointmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ServiceAppointmentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWeeklyServiceAppointmentList)).EndInit();
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
        private System.Windows.Forms.Label LblServiceList;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWeeklyReport;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.BindingSource ServiceAppointmentListBindingSource;
        private dsWeeklyServiceAppointmentList dsWeeklyServiceAppointmentList;
        private dsWeeklyServiceAppointmentListTableAdapters.ServiceAppointmentListTableAdapter ServiceAppointmentListTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}