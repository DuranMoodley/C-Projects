namespace Trucking_Company
{
    partial class FrmUpdatesService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatesService));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbServiceStatus = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblServiceStatus = new System.Windows.Forms.Label();
            this.TxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.LblVehicleNumber = new System.Windows.Forms.Label();
            this.LblServiceCode = new System.Windows.Forms.Label();
            this.TxtServiceCode = new System.Windows.Forms.TextBox();
            this.PnlUpdateServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblUpdateService = new System.Windows.Forms.Label();
            this.TipUpdateServiceForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlUpdateServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnSearch);
            this.PnlForBorder.Controls.Add(this.CmbServiceStatus);
            this.PnlForBorder.Controls.Add(this.BtnUpdate);
            this.PnlForBorder.Controls.Add(this.LblServiceStatus);
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblServiceCode);
            this.PnlForBorder.Controls.Add(this.TxtServiceCode);
            this.PnlForBorder.Controls.Add(this.PnlUpdateServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(499, 360);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 35;
            this.BtnSearch.Text = "&Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbServiceStatus
            // 
            this.CmbServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbServiceStatus.Enabled = false;
            this.CmbServiceStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbServiceStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbServiceStatus.FormattingEnabled = true;
            this.CmbServiceStatus.Items.AddRange(new object[] {
            "Started",
            "Complete",
            "Incomplete"});
            this.CmbServiceStatus.Location = new System.Drawing.Point(259, 323);
            this.CmbServiceStatus.Name = "CmbServiceStatus";
            this.CmbServiceStatus.Size = new System.Drawing.Size(324, 31);
            this.CmbServiceStatus.TabIndex = 34;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(409, 360);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 37);
            this.BtnUpdate.TabIndex = 32;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblServiceStatus
            // 
            this.LblServiceStatus.AutoSize = true;
            this.LblServiceStatus.BackColor = System.Drawing.Color.White;
            this.LblServiceStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceStatus.Location = new System.Drawing.Point(122, 325);
            this.LblServiceStatus.Name = "LblServiceStatus";
            this.LblServiceStatus.Size = new System.Drawing.Size(131, 25);
            this.LblServiceStatus.TabIndex = 28;
            this.LblServiceStatus.Text = "Service Status:";
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(259, 288);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(324, 29);
            this.TxtVehicleNumber.TabIndex = 27;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleNumber
            // 
            this.LblVehicleNumber.AutoSize = true;
            this.LblVehicleNumber.BackColor = System.Drawing.Color.White;
            this.LblVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumber.Location = new System.Drawing.Point(111, 290);
            this.LblVehicleNumber.Name = "LblVehicleNumber";
            this.LblVehicleNumber.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNumber.TabIndex = 26;
            this.LblVehicleNumber.Text = "Vehicle Number:";
            // 
            // LblServiceCode
            // 
            this.LblServiceCode.AutoSize = true;
            this.LblServiceCode.BackColor = System.Drawing.Color.White;
            this.LblServiceCode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceCode.Location = new System.Drawing.Point(130, 255);
            this.LblServiceCode.Name = "LblServiceCode";
            this.LblServiceCode.Size = new System.Drawing.Size(123, 25);
            this.LblServiceCode.TabIndex = 20;
            this.LblServiceCode.Text = "Service Code:";
            // 
            // TxtServiceCode
            // 
            this.TxtServiceCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtServiceCode.Location = new System.Drawing.Point(259, 253);
            this.TxtServiceCode.Name = "TxtServiceCode";
            this.TxtServiceCode.Size = new System.Drawing.Size(324, 29);
            this.TxtServiceCode.TabIndex = 21;
            this.TxtServiceCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PnlUpdateServiceBackgroundImage
            // 
            this.PnlUpdateServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlUpdateServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlUpdateServiceBackgroundImage.Controls.Add(this.LblUpdateService);
            this.PnlUpdateServiceBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlUpdateServiceBackgroundImage.Name = "PnlUpdateServiceBackgroundImage";
            this.PnlUpdateServiceBackgroundImage.Size = new System.Drawing.Size(716, 206);
            this.PnlUpdateServiceBackgroundImage.TabIndex = 1;
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
            this.BtnReturn.TabIndex = 43;
            this.TipUpdateServiceForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblUpdateService
            // 
            this.LblUpdateService.AutoSize = true;
            this.LblUpdateService.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateService.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateService.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUpdateService.Location = new System.Drawing.Point(185, 77);
            this.LblUpdateService.Name = "LblUpdateService";
            this.LblUpdateService.Size = new System.Drawing.Size(332, 43);
            this.LblUpdateService.TabIndex = 42;
            this.LblUpdateService.Text = "UPDATE SERVICE";
            // 
            // FrmUpdatesService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUpdatesService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlUpdateServiceBackgroundImage.ResumeLayout(false);
            this.PnlUpdateServiceBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlUpdateServiceBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblUpdateService;
        private System.Windows.Forms.ToolTip TipUpdateServiceForm;
        private System.Windows.Forms.Label LblServiceCode;
        private System.Windows.Forms.TextBox TxtServiceCode;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.Label LblVehicleNumber;
        private System.Windows.Forms.Label LblServiceStatus;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox CmbServiceStatus;
        private System.Windows.Forms.Button BtnSearch;
    }
}