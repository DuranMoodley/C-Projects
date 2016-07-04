namespace Trucking_Company
{
    partial class FrmWeeklyCompletedTripReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeeklyCompletedTripReport));
            this.TripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTrip = new Trucking_Company.dsTrip();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvWeeklyComTrip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.PnlDeleteTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblWeeklyCompletedTrip = new System.Windows.Forms.Label();
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
            this.PnlForBorder.Controls.Add(this.rpvWeeklyComTrip);
            this.PnlForBorder.Controls.Add(this.DtpEndDate);
            this.PnlForBorder.Controls.Add(this.DtpStartDate);
            this.PnlForBorder.Controls.Add(this.lblEndDate);
            this.PnlForBorder.Controls.Add(this.LblStartDate);
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
            this.BtnGenerate.Location = new System.Drawing.Point(580, 144);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGenerate.TabIndex = 44;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvWeeklyComTrip
            // 
            reportDataSource1.Name = "dsWeeklyCompletedTrip";
            reportDataSource1.Value = this.TripBindingSource;
            this.rpvWeeklyComTrip.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvWeeklyComTrip.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptWeeklyCompletedTrip.rdlc";
            this.rpvWeeklyComTrip.Location = new System.Drawing.Point(0, 217);
            this.rpvWeeklyComTrip.Name = "rpvWeeklyComTrip";
            this.rpvWeeklyComTrip.Size = new System.Drawing.Size(716, 278);
            this.rpvWeeklyComTrip.TabIndex = 43;
            // 
            // DtpEndDate
            // 
            this.DtpEndDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpEndDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDate.Location = new System.Drawing.Point(212, 164);
            this.DtpEndDate.Name = "DtpEndDate";
            this.DtpEndDate.Size = new System.Drawing.Size(324, 29);
            this.DtpEndDate.TabIndex = 41;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpStartDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.Location = new System.Drawing.Point(212, 128);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.Size = new System.Drawing.Size(324, 29);
            this.DtpStartDate.TabIndex = 40;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEndDate.Location = new System.Drawing.Point(104, 168);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(102, 25);
            this.lblEndDate.TabIndex = 39;
            this.lblEndDate.Text = "END DATE:";
            // 
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblStartDate.Location = new System.Drawing.Point(83, 132);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(123, 25);
            this.LblStartDate.TabIndex = 38;
            this.LblStartDate.Text = "START DATE:";
            // 
            // PnlDeleteTripBackgroundImage
            // 
            this.PnlDeleteTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.LblWeeklyCompletedTrip);
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
            // LblWeeklyCompletedTrip
            // 
            this.LblWeeklyCompletedTrip.AutoSize = true;
            this.LblWeeklyCompletedTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblWeeklyCompletedTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeklyCompletedTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblWeeklyCompletedTrip.Location = new System.Drawing.Point(101, 37);
            this.LblWeeklyCompletedTrip.Name = "LblWeeklyCompletedTrip";
            this.LblWeeklyCompletedTrip.Size = new System.Drawing.Size(510, 43);
            this.LblWeeklyCompletedTrip.TabIndex = 11;
            this.LblWeeklyCompletedTrip.Text = "WEEKLY COMPLETED TRIP";
            // 
            // TripTableAdapter
            // 
            this.TripTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWeeklyCompletedTripReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmWeeklyCompletedTripReport";
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
        private System.Windows.Forms.Label LblWeeklyCompletedTrip;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteTrip;
        private Microsoft.Reporting.WinForms.ReportViewer rpvWeeklyComTrip;
        private System.Windows.Forms.DateTimePicker DtpEndDate;
        private System.Windows.Forms.DateTimePicker DtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.BindingSource TripBindingSource;
        private dsTrip dsTrip;
        private dsTripTableAdapters.TripTableAdapter TripTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}