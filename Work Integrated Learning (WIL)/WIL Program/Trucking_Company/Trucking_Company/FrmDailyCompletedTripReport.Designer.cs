namespace Trucking_Company
{
    partial class FrmDailyCompletedTripReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDailyCompletedTripReport));
            this.CompletedDailyTripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCompletedDailyTrip = new Trucking_Company.dsCompletedDailyTrip();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.DtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.rpvDailyCompletedTrip = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LblTripDate = new System.Windows.Forms.Label();
            this.PnlDeleteTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDailyCompletedTrip = new System.Windows.Forms.Label();
            this.TipDeleteTrip = new System.Windows.Forms.ToolTip(this.components);
            this.dsTrip = new Trucking_Company.dsTrip();
            this.TripBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TripTableAdapter = new Trucking_Company.dsTripTableAdapters.TripTableAdapter();
            this.CompletedDailyTripTableAdapter = new Trucking_Company.dsCompletedDailyTripTableAdapters.CompletedDailyTripTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDailyTripBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompletedDailyTrip)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteTripBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CompletedDailyTripBindingSource
            // 
            this.CompletedDailyTripBindingSource.DataMember = "CompletedDailyTrip";
            this.CompletedDailyTripBindingSource.DataSource = this.dsCompletedDailyTrip;
            // 
            // dsCompletedDailyTrip
            // 
            this.dsCompletedDailyTrip.DataSetName = "dsCompletedDailyTrip";
            this.dsCompletedDailyTrip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.DtpTripDate);
            this.PnlForBorder.Controls.Add(this.rpvDailyCompletedTrip);
            this.PnlForBorder.Controls.Add(this.LblTripDate);
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
            this.BtnGenerate.Location = new System.Drawing.Point(600, 151);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 33;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // DtpTripDate
            // 
            this.DtpTripDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpTripDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTripDate.Location = new System.Drawing.Point(204, 150);
            this.DtpTripDate.Name = "DtpTripDate";
            this.DtpTripDate.Size = new System.Drawing.Size(324, 29);
            this.DtpTripDate.TabIndex = 28;
            // 
            // rpvDailyCompletedTrip
            // 
            reportDataSource1.Name = "dsCompletedTripDaily";
            reportDataSource1.Value = this.CompletedDailyTripBindingSource;
            this.rpvDailyCompletedTrip.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDailyCompletedTrip.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptDailyCompletedTrip.rdlc";
            this.rpvDailyCompletedTrip.Location = new System.Drawing.Point(0, 216);
            this.rpvDailyCompletedTrip.Name = "rpvDailyCompletedTrip";
            this.rpvDailyCompletedTrip.Size = new System.Drawing.Size(716, 279);
            this.rpvDailyCompletedTrip.TabIndex = 27;
            // 
            // LblTripDate
            // 
            this.LblTripDate.AutoSize = true;
            this.LblTripDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripDate.Location = new System.Drawing.Point(46, 151);
            this.LblTripDate.Name = "LblTripDate";
            this.LblTripDate.Size = new System.Drawing.Size(105, 25);
            this.LblTripDate.TabIndex = 23;
            this.LblTripDate.Text = "TRIP DATE:";
            // 
            // PnlDeleteTripBackgroundImage
            // 
            this.PnlDeleteTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.LblDailyCompletedTrip);
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
            // LblDailyCompletedTrip
            // 
            this.LblDailyCompletedTrip.AutoSize = true;
            this.LblDailyCompletedTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblDailyCompletedTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDailyCompletedTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDailyCompletedTrip.Location = new System.Drawing.Point(43, 36);
            this.LblDailyCompletedTrip.Name = "LblDailyCompletedTrip";
            this.LblDailyCompletedTrip.Size = new System.Drawing.Size(623, 43);
            this.LblDailyCompletedTrip.TabIndex = 11;
            this.LblDailyCompletedTrip.Text = "DAILY COMPLETED TRIP REPORT";
            // 
            // dsTrip
            // 
            this.dsTrip.DataSetName = "dsTrip";
            this.dsTrip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TripBindingSource
            // 
            this.TripBindingSource.DataMember = "Trip";
            this.TripBindingSource.DataSource = this.dsTrip;
            // 
            // TripTableAdapter
            // 
            this.TripTableAdapter.ClearBeforeFill = true;
            // 
            // CompletedDailyTripTableAdapter
            // 
            this.CompletedDailyTripTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDailyCompletedTripReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDailyCompletedTripReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.CompletedDailyTripBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCompletedDailyTrip)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteTripBackgroundImage.ResumeLayout(false);
            this.PnlDeleteTripBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteTripBackgroundImage;
        private System.Windows.Forms.Label LblDailyCompletedTrip;
        private System.Windows.Forms.Label LblTripDate;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteTrip;
        private Microsoft.Reporting.WinForms.ReportViewer rpvDailyCompletedTrip;
        private System.Windows.Forms.DateTimePicker DtpTripDate;
        private System.Windows.Forms.BindingSource TripBindingSource;
        private dsTrip dsTrip;
        private dsTripTableAdapters.TripTableAdapter TripTableAdapter;
        private System.Windows.Forms.BindingSource CompletedDailyTripBindingSource;
        private dsCompletedDailyTrip dsCompletedDailyTrip;
        private dsCompletedDailyTripTableAdapters.CompletedDailyTripTableAdapter CompletedDailyTripTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}