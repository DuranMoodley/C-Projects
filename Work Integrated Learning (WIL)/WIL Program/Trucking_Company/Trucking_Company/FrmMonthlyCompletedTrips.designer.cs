namespace Trucking_Company
{
    partial class FrmMonthlyCompletedTrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyCompletedTrips));
            this.TripMonthlyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMonthlyTrip = new Trucking_Company.dsMonthlyTrip();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvMonthReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.LblTripMonth = new System.Windows.Forms.Label();
            this.PnlDeleteTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblMonthlyTrip = new System.Windows.Forms.Label();
            this.TipDeleteTrip = new System.Windows.Forms.ToolTip(this.components);
            this.TripMonthlyTableAdapter = new Trucking_Company.dsMonthlyTripTableAdapters.TripMonthlyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TripMonthlyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyTrip)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteTripBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TripMonthlyBindingSource
            // 
            this.TripMonthlyBindingSource.DataMember = "TripMonthly";
            this.TripMonthlyBindingSource.DataSource = this.dsMonthlyTrip;
            // 
            // dsMonthlyTrip
            // 
            this.dsMonthlyTrip.DataSetName = "dsMonthlyTrip";
            this.dsMonthlyTrip.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvMonthReport);
            this.PnlForBorder.Controls.Add(this.CmbMonth);
            this.PnlForBorder.Controls.Add(this.LblTripMonth);
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
            this.BtnGenerate.Location = new System.Drawing.Point(605, 154);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 31);
            this.BtnGenerate.TabIndex = 34;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvMonthReport
            // 
            reportDataSource7.Name = "dsTripMonthly";
            reportDataSource7.Value = this.TripMonthlyBindingSource;
            this.rpvMonthReport.LocalReport.DataSources.Add(reportDataSource7);
            this.rpvMonthReport.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptMonthlyTripReport.rdlc";
            this.rpvMonthReport.Location = new System.Drawing.Point(0, 216);
            this.rpvMonthReport.Name = "rpvMonthReport";
            this.rpvMonthReport.Size = new System.Drawing.Size(716, 279);
            this.rpvMonthReport.TabIndex = 27;
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
            this.CmbMonth.Location = new System.Drawing.Point(188, 154);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(376, 31);
            this.CmbMonth.TabIndex = 24;
            // 
            // LblTripMonth
            // 
            this.LblTripMonth.AutoSize = true;
            this.LblTripMonth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripMonth.Location = new System.Drawing.Point(35, 155);
            this.LblTripMonth.Name = "LblTripMonth";
            this.LblTripMonth.Size = new System.Drawing.Size(123, 25);
            this.LblTripMonth.TabIndex = 23;
            this.LblTripMonth.Text = "TRIP MONTH:";
            // 
            // PnlDeleteTripBackgroundImage
            // 
            this.PnlDeleteTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.LblMonthlyTrip);
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
            // LblMonthlyTrip
            // 
            this.LblMonthlyTrip.AutoSize = true;
            this.LblMonthlyTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblMonthlyTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthlyTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMonthlyTrip.Location = new System.Drawing.Point(78, 33);
            this.LblMonthlyTrip.Name = "LblMonthlyTrip";
            this.LblMonthlyTrip.Size = new System.Drawing.Size(545, 43);
            this.LblMonthlyTrip.TabIndex = 11;
            this.LblMonthlyTrip.Text = "MONTHLY COMPLETED TRIP";
            // 
            // TripMonthlyTableAdapter
            // 
            this.TripMonthlyTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMonthlyCompletedTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMonthlyCompletedTrips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TripMonthlyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyTrip)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteTripBackgroundImage.ResumeLayout(false);
            this.PnlDeleteTripBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteTripBackgroundImage;
        private System.Windows.Forms.Label LblMonthlyTrip;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.Label LblTripMonth;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteTrip;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthReport;
        private System.Windows.Forms.BindingSource TripMonthlyBindingSource;
        private dsMonthlyTrip dsMonthlyTrip;
        private dsMonthlyTripTableAdapters.TripMonthlyTableAdapter TripMonthlyTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}