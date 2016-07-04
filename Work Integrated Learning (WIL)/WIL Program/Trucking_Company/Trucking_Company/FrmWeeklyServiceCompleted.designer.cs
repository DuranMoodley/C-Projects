namespace Trucking_Company
{
    partial class FrmWeeklyServiceCompleted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeeklyServiceCompleted));
            this.VehicleServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVehicleServiceCompletedWeekly = new Trucking_Company.dsVehicleServiceCompletedWeekly();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvWeeklyComServices = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblWeeklyComServices = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleServiceTableAdapter = new Trucking_Company.dsVehicleServiceCompletedWeeklyTableAdapters.VehicleServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVehicleServiceCompletedWeekly)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleServiceBindingSource
            // 
            this.VehicleServiceBindingSource.DataMember = "VehicleService";
            this.VehicleServiceBindingSource.DataSource = this.dsVehicleServiceCompletedWeekly;
            // 
            // dsVehicleServiceCompletedWeekly
            // 
            this.dsVehicleServiceCompletedWeekly.DataSetName = "dsVehicleServiceCompletedWeekly";
            this.dsVehicleServiceCompletedWeekly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvWeeklyComServices);
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
            this.BtnGenerate.Location = new System.Drawing.Point(601, 149);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGenerate.TabIndex = 47;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvWeeklyComServices
            // 
            reportDataSource2.Name = "dsWeeklyCompletedServices";
            reportDataSource2.Value = this.VehicleServiceBindingSource;
            this.rpvWeeklyComServices.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvWeeklyComServices.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptWeeklyCompletedServices.rdlc";
            this.rpvWeeklyComServices.Location = new System.Drawing.Point(0, 217);
            this.rpvWeeklyComServices.Name = "rpvWeeklyComServices";
            this.rpvWeeklyComServices.Size = new System.Drawing.Size(716, 278);
            this.rpvWeeklyComServices.TabIndex = 38;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.Location = new System.Drawing.Point(238, 170);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(324, 29);
            this.DtpEndDate.TabIndex = 36;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.Location = new System.Drawing.Point(238, 134);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(324, 29);
            this.DtpStartDate.TabIndex = 35;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndDate.Location = new System.Drawing.Point(130, 174);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(102, 25);
            this.lblEndDate.TabIndex = 34;
            this.lblEndDate.Text = "END DATE:";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblStartDate.Location = new System.Drawing.Point(109, 138);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(123, 25);
            this.LblStartDate.TabIndex = 33;
            this.LblStartDate.Text = "START DATE:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblWeeklyComServices);
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
            // LblWeeklyComServices
            // 
            this.LblWeeklyComServices.AutoSize = true;
            this.LblWeeklyComServices.BackColor = System.Drawing.Color.Transparent;
            this.LblWeeklyComServices.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeklyComServices.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblWeeklyComServices.Location = new System.Drawing.Point(55, 37);
            this.LblWeeklyComServices.Name = "LblWeeklyComServices";
            this.LblWeeklyComServices.Size = new System.Drawing.Size(598, 43);
            this.LblWeeklyComServices.TabIndex = 44;
            this.LblWeeklyComServices.Text = "WEEKLY COMPLETED SERVICES";
            // 
            // VehicleServiceTableAdapter
            // 
            this.VehicleServiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWeeklyServiceCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(725, 505);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmWeeklyServiceCompleted";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVehicleServiceCompletedWeekly)).EndInit();
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
        private System.Windows.Forms.Label LblWeeklyComServices;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWeeklyComServices;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.BindingSource VehicleServiceBindingSource;
        private dsVehicleServiceCompletedWeekly dsVehicleServiceCompletedWeekly;
        private dsVehicleServiceCompletedWeeklyTableAdapters.VehicleServiceTableAdapter VehicleServiceTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}