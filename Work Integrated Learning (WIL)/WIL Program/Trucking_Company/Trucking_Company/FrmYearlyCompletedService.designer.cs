namespace Trucking_Company
{
    partial class FrmYearlyCompletedService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYearlyCompletedService));
            this.VehicleServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServiceCompletedYearly = new Trucking_Company.dsServiceCompletedYearly();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGernerate = new System.Windows.Forms.Button();
            this.rpvYearReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.LblDateOfReport = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblYearlyCompleted = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleServiceTableAdapter = new Trucking_Company.dsServiceCompletedYearlyTableAdapters.VehicleServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceCompletedYearly)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleServiceBindingSource
            // 
            this.VehicleServiceBindingSource.DataMember = "VehicleService";
            this.VehicleServiceBindingSource.DataSource = this.dsServiceCompletedYearly;
            // 
            // dsServiceCompletedYearly
            // 
            this.dsServiceCompletedYearly.DataSetName = "dsServiceCompletedYearly";
            this.dsServiceCompletedYearly.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGernerate);
            this.PnlForBorder.Controls.Add(this.rpvYearReport);
            this.PnlForBorder.Controls.Add(this.TxtYear);
            this.PnlForBorder.Controls.Add(this.LblDateOfReport);
            this.PnlForBorder.Controls.Add(this.PnlDeleteServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // BtnGernerate
            // 
            this.BtnGernerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnGernerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGernerate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnGernerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGernerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGernerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGernerate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGernerate.ForeColor = System.Drawing.Color.White;
            this.BtnGernerate.Location = new System.Drawing.Point(596, 141);
            this.BtnGernerate.Name = "BtnGernerate";
            this.BtnGernerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGernerate.TabIndex = 48;
            this.BtnGernerate.Text = "&Generate";
            this.BtnGernerate.UseVisualStyleBackColor = false;
            this.BtnGernerate.Click += new System.EventHandler(this.BtnGernerate_Click);
            // 
            // rpvYearReport
            // 
            reportDataSource2.Name = "dsYearlyCompletedService";
            reportDataSource2.Value = this.VehicleServiceBindingSource;
            this.rpvYearReport.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvYearReport.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptYearlyCompletedService.rdlc";
            this.rpvYearReport.Location = new System.Drawing.Point(0, 190);
            this.rpvYearReport.Name = "rpvYearReport";
            this.rpvYearReport.Size = new System.Drawing.Size(716, 305);
            this.rpvYearReport.TabIndex = 39;
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtYear.Location = new System.Drawing.Point(170, 142);
            this.TxtYear.MaxLength = 4;
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(376, 32);
            this.TxtYear.TabIndex = 38;
            this.TxtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDateOfReport
            // 
            this.LblDateOfReport.AutoSize = true;
            this.LblDateOfReport.BackColor = System.Drawing.Color.White;
            this.LblDateOfReport.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateOfReport.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblDateOfReport.Location = new System.Drawing.Point(101, 145);
            this.LblDateOfReport.Name = "LblDateOfReport";
            this.LblDateOfReport.Size = new System.Drawing.Size(63, 25);
            this.LblDateOfReport.TabIndex = 22;
            this.LblDateOfReport.Text = "YEAR:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblYearlyCompleted);
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
            // LblYearlyCompleted
            // 
            this.LblYearlyCompleted.AutoSize = true;
            this.LblYearlyCompleted.BackColor = System.Drawing.Color.Transparent;
            this.LblYearlyCompleted.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYearlyCompleted.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblYearlyCompleted.Location = new System.Drawing.Point(64, 33);
            this.LblYearlyCompleted.Name = "LblYearlyCompleted";
            this.LblYearlyCompleted.Size = new System.Drawing.Size(565, 43);
            this.LblYearlyCompleted.TabIndex = 44;
            this.LblYearlyCompleted.Text = "YEARLY COMPLETED SERVICE";
            // 
            // VehicleServiceTableAdapter
            // 
            this.VehicleServiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmYearlyCompletedService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(725, 504);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmYearlyCompletedService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceCompletedYearly)).EndInit();
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
        private System.Windows.Forms.Label LblYearlyCompleted;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.Label LblDateOfReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpvYearReport;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.BindingSource VehicleServiceBindingSource;
        private dsServiceCompletedYearly dsServiceCompletedYearly;
        private dsServiceCompletedYearlyTableAdapters.VehicleServiceTableAdapter VehicleServiceTableAdapter;
        private System.Windows.Forms.Button BtnGernerate;
    }
}