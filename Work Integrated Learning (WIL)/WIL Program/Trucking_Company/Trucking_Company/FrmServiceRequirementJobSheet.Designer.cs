namespace Trucking_Company
{
    partial class FrmServiceRequirementJobSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiceRequirementJobSheet));
            this.ServiceJobsheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsServiceJobSheet = new Trucking_Company.dsServiceJobSheet();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblServiceJobSheet = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.ServiceJobsheetTableAdapter = new Trucking_Company.dsServiceJobSheetTableAdapters.ServiceJobsheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceJobsheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceJobSheet)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceJobsheetBindingSource
            // 
            this.ServiceJobsheetBindingSource.DataMember = "ServiceJobsheet";
            this.ServiceJobsheetBindingSource.DataSource = this.dsServiceJobSheet;
            // 
            // dsServiceJobSheet
            // 
            this.dsServiceJobSheet.DataSetName = "dsServiceJobSheet";
            this.dsServiceJobSheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.reportViewer1);
            this.PnlForBorder.Controls.Add(this.PnlDeleteServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsServiceRequirementJobsheet";
            reportDataSource1.Value = this.ServiceJobsheetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptServiceJobSheet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 374);
            this.reportViewer1.TabIndex = 1;
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblServiceJobSheet);
            this.PnlDeleteServiceBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteServiceBackgroundImage.Name = "PnlDeleteServiceBackgroundImage";
            this.PnlDeleteServiceBackgroundImage.Size = new System.Drawing.Size(716, 125);
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
            // LblServiceJobSheet
            // 
            this.LblServiceJobSheet.AutoSize = true;
            this.LblServiceJobSheet.BackColor = System.Drawing.Color.Transparent;
            this.LblServiceJobSheet.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceJobSheet.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblServiceJobSheet.Location = new System.Drawing.Point(166, 36);
            this.LblServiceJobSheet.Name = "LblServiceJobSheet";
            this.LblServiceJobSheet.Size = new System.Drawing.Size(376, 43);
            this.LblServiceJobSheet.TabIndex = 44;
            this.LblServiceJobSheet.Text = "SERVICE  JOBSHEET";
            // 
            // ServiceJobsheetTableAdapter
            // 
            this.ServiceJobsheetTableAdapter.ClearBeforeFill = true;
            // 
            // FrmServiceRequirementJobSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmServiceRequirementJobSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmServiceRequirementJobSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceJobsheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsServiceJobSheet)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlDeleteServiceBackgroundImage.ResumeLayout(false);
            this.PnlDeleteServiceBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteServiceBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblServiceJobSheet;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ServiceJobsheetBindingSource;
        private dsServiceJobSheet dsServiceJobSheet;
        private dsServiceJobSheetTableAdapters.ServiceJobsheetTableAdapter ServiceJobsheetTableAdapter;
    }
}