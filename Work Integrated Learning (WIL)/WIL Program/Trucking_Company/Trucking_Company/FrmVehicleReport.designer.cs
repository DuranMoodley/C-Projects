namespace Trucking_Company
{
    partial class FrmVehicleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleReport));
            this.VehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsVehicle = new Trucking_Company.dsVehicle();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PnlDeleteVehicleBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblVehicleReport = new System.Windows.Forms.Label();
            this.TipDeleteVehicleForm = new System.Windows.Forms.ToolTip(this.components);
            this.VehicleTableAdapter = new Trucking_Company.dsVehicleTableAdapters.VehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVehicle)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteVehicleBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // VehicleBindingSource
            // 
            this.VehicleBindingSource.DataMember = "Vehicle";
            this.VehicleBindingSource.DataSource = this.dsVehicle;
            // 
            // dsVehicle
            // 
            this.dsVehicle.DataSetName = "dsVehicle";
            this.dsVehicle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.reportViewer1);
            this.PnlForBorder.Controls.Add(this.PnlDeleteVehicleBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dstVehicle";
            reportDataSource1.Value = this.VehicleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptVehicle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 120);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(716, 375);
            this.reportViewer1.TabIndex = 1;
            // 
            // PnlDeleteVehicleBackgroundImage
            // 
            this.PnlDeleteVehicleBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteVehicleBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteVehicleBackgroundImage.Controls.Add(this.LblVehicleReport);
            this.PnlDeleteVehicleBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteVehicleBackgroundImage.Name = "PnlDeleteVehicleBackgroundImage";
            this.PnlDeleteVehicleBackgroundImage.Size = new System.Drawing.Size(716, 122);
            this.PnlDeleteVehicleBackgroundImage.TabIndex = 0;
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
            this.BtnReturn.TabIndex = 42;
            this.TipDeleteVehicleForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblVehicleReport
            // 
            this.LblVehicleReport.AutoSize = true;
            this.LblVehicleReport.BackColor = System.Drawing.Color.Transparent;
            this.LblVehicleReport.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblVehicleReport.Location = new System.Drawing.Point(176, 37);
            this.LblVehicleReport.Name = "LblVehicleReport";
            this.LblVehicleReport.Size = new System.Drawing.Size(337, 43);
            this.LblVehicleReport.TabIndex = 9;
            this.LblVehicleReport.Text = "VEHICLE REPORT";
            // 
            // VehicleTableAdapter
            // 
            this.VehicleTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVehicleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmVehicleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVehicleReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsVehicle)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlDeleteVehicleBackgroundImage.ResumeLayout(false);
            this.PnlDeleteVehicleBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteVehicleBackgroundImage;
        private System.Windows.Forms.Label LblVehicleReport;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteVehicleForm;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VehicleBindingSource;
        private dsVehicle dsVehicle;
        private dsVehicleTableAdapters.VehicleTableAdapter VehicleTableAdapter;
    }
}