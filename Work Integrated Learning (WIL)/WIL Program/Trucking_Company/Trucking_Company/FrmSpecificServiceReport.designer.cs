namespace Trucking_Company
{
    partial class FrmSpecificServiceReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpecificServiceReport));
            this.VehicleServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSpecificService = new Trucking_Company.dsSpecificService();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvSpecificService = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbServiceCode = new System.Windows.Forms.ComboBox();
            this.LblServiceCode = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblSpecificService = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleServiceTableAdapter = new Trucking_Company.dsSpecificServiceTableAdapters.VehicleServiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpecificService)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleServiceBindingSource
            // 
            this.VehicleServiceBindingSource.DataMember = "VehicleService";
            this.VehicleServiceBindingSource.DataSource = this.dsSpecificService;
            // 
            // dsSpecificService
            // 
            this.dsSpecificService.DataSetName = "dsSpecificService";
            this.dsSpecificService.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvSpecificService);
            this.PnlForBorder.Controls.Add(this.CmbServiceCode);
            this.PnlForBorder.Controls.Add(this.LblServiceCode);
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
            this.BtnGenerate.Location = new System.Drawing.Point(601, 141);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 33);
            this.BtnGenerate.TabIndex = 41;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvSpecificService
            // 
            reportDataSource3.Name = "dsSpecificCompletedService";
            reportDataSource3.Value = this.VehicleServiceBindingSource;
            this.rpvSpecificService.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvSpecificService.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptSpecificServiceReport.rdlc";
            this.rpvSpecificService.Location = new System.Drawing.Point(0, 199);
            this.rpvSpecificService.Name = "rpvSpecificService";
            this.rpvSpecificService.Size = new System.Drawing.Size(716, 296);
            this.rpvSpecificService.TabIndex = 34;
            // 
            // CmbServiceCode
            // 
            this.CmbServiceCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbServiceCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbServiceCode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbServiceCode.FormattingEnabled = true;
            this.CmbServiceCode.Location = new System.Drawing.Point(192, 141);
            this.CmbServiceCode.Name = "CmbServiceCode";
            this.CmbServiceCode.Size = new System.Drawing.Size(376, 33);
            this.CmbServiceCode.TabIndex = 32;
            // 
            // LblServiceCode
            // 
            this.LblServiceCode.AutoSize = true;
            this.LblServiceCode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceCode.Location = new System.Drawing.Point(44, 144);
            this.LblServiceCode.Name = "LblServiceCode";
            this.LblServiceCode.Size = new System.Drawing.Size(142, 25);
            this.LblServiceCode.TabIndex = 31;
            this.LblServiceCode.Text = "SERVICE CODE:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblSpecificService);
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
            // LblSpecificService
            // 
            this.LblSpecificService.AutoSize = true;
            this.LblSpecificService.BackColor = System.Drawing.Color.Transparent;
            this.LblSpecificService.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSpecificService.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblSpecificService.Location = new System.Drawing.Point(113, 36);
            this.LblSpecificService.Name = "LblSpecificService";
            this.LblSpecificService.Size = new System.Drawing.Size(495, 43);
            this.LblSpecificService.TabIndex = 44;
            this.LblSpecificService.Text = "SPECIFIC SERVICE REPORT";
            // 
            // VehicleServiceTableAdapter
            // 
            this.VehicleServiceTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSpecificServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmSpecificServiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.VehicleServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSpecificService)).EndInit();
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
        private System.Windows.Forms.Label LblSpecificService;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.Label LblServiceCode;
        private System.Windows.Forms.ComboBox CmbServiceCode;
        private Microsoft.Reporting.WinForms.ReportViewer rpvSpecificService;
        private System.Windows.Forms.BindingSource VehicleServiceBindingSource;
        private dsSpecificService dsSpecificService;
        private dsSpecificServiceTableAdapters.VehicleServiceTableAdapter VehicleServiceTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}