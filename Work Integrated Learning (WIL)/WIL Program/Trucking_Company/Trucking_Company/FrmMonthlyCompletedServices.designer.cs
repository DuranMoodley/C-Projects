namespace Trucking_Company
{
    partial class FrmMonthlyCompletedServices
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyCompletedServices));
            this.VehicleServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMonthlyCompletedVehicleService = new Trucking_Company.dsMonthlyCompletedVehicleService();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvMonthlyReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.LblServiceMonth = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblMonthlyServiceCom = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleServiceTableAdapter = new Trucking_Company.dsMonthlyCompletedVehicleServiceTableAdapters.VehicleServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyCompletedVehicleService)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleServiceBindingSource
            // 
            this.VehicleServiceBindingSource.DataMember = "VehicleService";
            this.VehicleServiceBindingSource.DataSource = this.dsMonthlyCompletedVehicleService;
            // 
            // dsMonthlyCompletedVehicleService
            // 
            this.dsMonthlyCompletedVehicleService.DataSetName = "dsMonthlyCompletedVehicleService";
            this.dsMonthlyCompletedVehicleService.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvMonthlyReport);
            this.PnlForBorder.Controls.Add(this.CmbMonth);
            this.PnlForBorder.Controls.Add(this.LblServiceMonth);
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
            this.BtnGenerate.Location = new System.Drawing.Point(604, 153);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 31);
            this.BtnGenerate.TabIndex = 33;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvMonthlyReport
            // 
            reportDataSource6.Name = "dsVehicleServiceCompletedMonthly";
            reportDataSource6.Value = this.VehicleServiceBindingSource;
            this.rpvMonthlyReport.LocalReport.DataSources.Add(reportDataSource6);
            this.rpvMonthlyReport.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptMonthlyCompletedService.rdlc";
            this.rpvMonthlyReport.Location = new System.Drawing.Point(0, 216);
            this.rpvMonthlyReport.Name = "rpvMonthlyReport";
            this.rpvMonthlyReport.Size = new System.Drawing.Size(716, 279);
            this.rpvMonthlyReport.TabIndex = 28;
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
            this.CmbMonth.Location = new System.Drawing.Point(192, 153);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(376, 31);
            this.CmbMonth.TabIndex = 25;
            // 
            // LblServiceMonth
            // 
            this.LblServiceMonth.AutoSize = true;
            this.LblServiceMonth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceMonth.Location = new System.Drawing.Point(20, 155);
            this.LblServiceMonth.Name = "LblServiceMonth";
            this.LblServiceMonth.Size = new System.Drawing.Size(157, 25);
            this.LblServiceMonth.TabIndex = 24;
            this.LblServiceMonth.Text = "SERVICE MONTH:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblMonthlyServiceCom);
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
            // LblMonthlyServiceCom
            // 
            this.LblMonthlyServiceCom.AutoSize = true;
            this.LblMonthlyServiceCom.BackColor = System.Drawing.Color.Transparent;
            this.LblMonthlyServiceCom.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonthlyServiceCom.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblMonthlyServiceCom.Location = new System.Drawing.Point(37, 38);
            this.LblMonthlyServiceCom.Name = "LblMonthlyServiceCom";
            this.LblMonthlyServiceCom.Size = new System.Drawing.Size(633, 43);
            this.LblMonthlyServiceCom.TabIndex = 44;
            this.LblMonthlyServiceCom.Text = "MONTHLY COMPLETED SERVICES";
            // 
            // VehicleServiceTableAdapter
            // 
            this.VehicleServiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMonthlyCompletedServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMonthlyCompletedServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyCompletedVehicleService)).EndInit();
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
        private System.Windows.Forms.Label LblMonthlyServiceCom;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.Label LblServiceMonth;
        private System.Windows.Forms.ComboBox CmbMonth;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthlyReport;
        private System.Windows.Forms.BindingSource VehicleServiceBindingSource;
        private dsMonthlyCompletedVehicleService dsMonthlyCompletedVehicleService;
        private dsMonthlyCompletedVehicleServiceTableAdapters.VehicleServiceTableAdapter VehicleServiceTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}