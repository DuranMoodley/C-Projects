namespace Trucking_Company
{
    partial class FrmDailyPlannedTripReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyPlannedTripReport));
            this.TripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTrip = new Trucking_Company.dsTrip();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.DtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.LblDateOfReport = new System.Windows.Forms.Label();
            this.rptTripInformation = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PnlDeleteTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDeleteTrip = new System.Windows.Forms.Label();
            this.TipDeleteTrip = new System.Windows.Forms.ToolTip(this.components);
            this.TripTableAdapter = new Trucking_Company.dsTripTableAdapters.TripTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrip)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteTripBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TripBindingSource
            // 
            this.TripBindingSource.DataMember = "Trip";
            this.TripBindingSource.DataSource = this.dsTrip;
            // 
            // dsTrip
            // 
            this.dsTrip.DataSetName = "dsTrip";
            this.dsTrip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.DtpTripDate);
            this.PnlForBorder.Controls.Add(this.LblDateOfReport);
            this.PnlForBorder.Controls.Add(this.rptTripInformation);
            this.PnlForBorder.Controls.Add(this.PnlDeleteTripBackgroundImage);
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
            this.BtnGenerate.Location = new System.Drawing.Point(590, 152);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 35;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // DtpTripDate
            // 
            this.DtpTripDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.DtpTripDate.Location = new System.Drawing.Point(210, 152);
            this.DtpTripDate.Name = "DtpTripDate";
            this.DtpTripDate.Size = new System.Drawing.Size(288, 29);
            this.DtpTripDate.TabIndex = 22;
            // 
            // LblDateOfReport
            // 
            this.LblDateOfReport.AutoSize = true;
            this.LblDateOfReport.BackColor = System.Drawing.Color.White;
            this.LblDateOfReport.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfReport.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDateOfReport.Location = new System.Drawing.Point(36, 156);
            this.LblDateOfReport.Name = "LblDateOfReport";
            this.LblDateOfReport.Size = new System.Drawing.Size(105, 25);
            this.LblDateOfReport.TabIndex = 21;
            this.LblDateOfReport.Text = "TRIP DATE:";
            // 
            // rptTripInformation
            // 
            reportDataSource7.Name = "dsPlannedTripDaily";
            reportDataSource7.Value = this.TripBindingSource;
            this.rptTripInformation.LocalReport.DataSources.Add(reportDataSource7);
            this.rptTripInformation.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptDailyPlannedTrip.rdlc";
            this.rptTripInformation.Location = new System.Drawing.Point(0, 217);
            this.rptTripInformation.Name = "rptTripInformation";
            this.rptTripInformation.Size = new System.Drawing.Size(716, 278);
            this.rptTripInformation.TabIndex = 1;
            // 
            // PnlDeleteTripBackgroundImage
            // 
            this.PnlDeleteTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.LblDeleteTrip);
            this.PnlDeleteTripBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteTripBackgroundImage.Name = "PnlDeleteTripBackgroundImage";
            this.PnlDeleteTripBackgroundImage.Size = new System.Drawing.Size(716, 122);
            this.PnlDeleteTripBackgroundImage.TabIndex = 0;
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
            this.BtnReturn.TabIndex = 41;
            this.TipDeleteTrip.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblDeleteTrip
            // 
            this.LblDeleteTrip.AutoSize = true;
            this.LblDeleteTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblDeleteTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeleteTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDeleteTrip.Location = new System.Drawing.Point(64, 36);
            this.LblDeleteTrip.Name = "LblDeleteTrip";
            this.LblDeleteTrip.Size = new System.Drawing.Size(569, 43);
            this.LblDeleteTrip.TabIndex = 11;
            this.LblDeleteTrip.Text = "DAILY PLANNED TRIP REPORT";
            // 
            // TripTableAdapter
            // 
            this.TripTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailyPlannedTripReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDailyPlannedTripReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrip)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteTripBackgroundImage.ResumeLayout(false);
            this.PnlDeleteTripBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteTripBackgroundImage;
        private System.Windows.Forms.Label LblDeleteTrip;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteTrip;
        private Microsoft.Reporting.WinForms.ReportViewer rptTripInformation;
        private System.Windows.Forms.Label LblDateOfReport;
        private System.Windows.Forms.DateTimePicker DtpTripDate;
        private System.Windows.Forms.BindingSource TripBindingSource;
        private dsTrip dsTrip;
        private dsTripTableAdapters.TripTableAdapter TripTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}