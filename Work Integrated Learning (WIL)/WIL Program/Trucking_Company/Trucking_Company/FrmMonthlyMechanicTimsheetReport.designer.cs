namespace Trucking_Company
{
    partial class FrmMonthlyMechanicTimsheetReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonthlyMechanicTimsheetReport));
            this.MechanicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTimesheet = new Trucking_Company.dsTimesheet();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.rpvMonthlyMechanic = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CmbMechanicID = new System.Windows.Forms.ComboBox();
            this.LblMechanicIDNumber = new System.Windows.Forms.Label();
            this.CmbMonth = new System.Windows.Forms.ComboBox();
            this.LblMonth = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.lblMonthlyMechanic = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.MechanicTableAdapter = new Trucking_Company.dsTimesheetTableAdapters.MechanicTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTimesheet)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MechanicBindingSource
            // 
            this.MechanicBindingSource.DataMember = "Mechanic";
            this.MechanicBindingSource.DataSource = this.dsTimesheet;
            // 
            // dsTimesheet
            // 
            this.dsTimesheet.DataSetName = "dsTimesheet";
            this.dsTimesheet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnGenerate);
            this.PnlForBorder.Controls.Add(this.rpvMonthlyMechanic);
            this.PnlForBorder.Controls.Add(this.CmbMechanicID);
            this.PnlForBorder.Controls.Add(this.LblMechanicIDNumber);
            this.PnlForBorder.Controls.Add(this.CmbMonth);
            this.PnlForBorder.Controls.Add(this.LblMonth);
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
            this.BtnGenerate.Location = new System.Drawing.Point(603, 149);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(84, 29);
            this.BtnGenerate.TabIndex = 43;
            this.BtnGenerate.Text = "&Generate";
            this.BtnGenerate.UseVisualStyleBackColor = false;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // rpvMonthlyMechanic
            // 
            reportDataSource6.Name = "dsMonthlyMechanicTimesheet";
            reportDataSource6.Value = this.MechanicBindingSource;
            this.rpvMonthlyMechanic.LocalReport.DataSources.Add(reportDataSource6);
            this.rpvMonthlyMechanic.LocalReport.ReportEmbeddedResource = "Trucking_Company.rptMonthlyMechanicTimesheet.rdlc";
            this.rpvMonthlyMechanic.Location = new System.Drawing.Point(0, 217);
            this.rpvMonthlyMechanic.Name = "rpvMonthlyMechanic";
            this.rpvMonthlyMechanic.Size = new System.Drawing.Size(716, 278);
            this.rpvMonthlyMechanic.TabIndex = 36;
            // 
            // CmbMechanicID
            // 
            this.CmbMechanicID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbMechanicID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMechanicID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMechanicID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbMechanicID.FormattingEnabled = true;
            this.CmbMechanicID.Location = new System.Drawing.Point(260, 128);
            this.CmbMechanicID.Name = "CmbMechanicID";
            this.CmbMechanicID.Size = new System.Drawing.Size(324, 31);
            this.CmbMechanicID.TabIndex = 35;
            // 
            // LblMechanicIDNumber
            // 
            this.LblMechanicIDNumber.AutoSize = true;
            this.LblMechanicIDNumber.BackColor = System.Drawing.Color.White;
            this.LblMechanicIDNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMechanicIDNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblMechanicIDNumber.Location = new System.Drawing.Point(44, 130);
            this.LblMechanicIDNumber.Name = "LblMechanicIDNumber";
            this.LblMechanicIDNumber.Size = new System.Drawing.Size(210, 25);
            this.LblMechanicIDNumber.TabIndex = 34;
            this.LblMechanicIDNumber.Text = "MECHANIC ID NUMBER: ";
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
            this.CmbMonth.Location = new System.Drawing.Point(260, 165);
            this.CmbMonth.Name = "CmbMonth";
            this.CmbMonth.Size = new System.Drawing.Size(324, 31);
            this.CmbMonth.TabIndex = 28;
            // 
            // LblMonth
            // 
            this.LblMonth.AutoSize = true;
            this.LblMonth.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblMonth.Location = new System.Drawing.Point(94, 167);
            this.LblMonth.Name = "LblMonth";
            this.LblMonth.Size = new System.Drawing.Size(151, 25);
            this.LblMonth.TabIndex = 27;
            this.LblMonth.Text = "SELECT MONTH:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.lblMonthlyMechanic);
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
            // lblMonthlyMechanic
            // 
            this.lblMonthlyMechanic.AutoSize = true;
            this.lblMonthlyMechanic.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyMechanic.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyMechanic.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblMonthlyMechanic.Location = new System.Drawing.Point(59, 34);
            this.lblMonthlyMechanic.Name = "lblMonthlyMechanic";
            this.lblMonthlyMechanic.Size = new System.Drawing.Size(591, 43);
            this.lblMonthlyMechanic.TabIndex = 44;
            this.lblMonthlyMechanic.Text = "MONTHLY TIMESHEET REPORT";
            // 
            // MechanicTableAdapter
            // 
            this.MechanicTableAdapter.ClearBeforeFill = true;
            // 
            // FrmMonthlyMechanicTimsheetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmMonthlyMechanicTimsheetReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.MechanicBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTimesheet)).EndInit();
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
        private System.Windows.Forms.Label lblMonthlyMechanic;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.ComboBox CmbMonth;
        private System.Windows.Forms.Label LblMonth;
        private Microsoft.Reporting.WinForms.ReportViewer rpvMonthlyMechanic;
        private System.Windows.Forms.ComboBox CmbMechanicID;
        private System.Windows.Forms.Label LblMechanicIDNumber;
        private System.Windows.Forms.BindingSource MechanicBindingSource;
        private dsTimesheet dsTimesheet;
        private dsTimesheetTableAdapters.MechanicTableAdapter MechanicTableAdapter;
        private System.Windows.Forms.Button BtnGenerate;
    }
}