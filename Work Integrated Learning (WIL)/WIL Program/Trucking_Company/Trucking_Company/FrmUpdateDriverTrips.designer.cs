namespace Trucking_Company
{
    partial class FrmUpdateDriverTrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateDriverTrips));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.CmbTrip = new System.Windows.Forms.ComboBox();
            this.LblTripID = new System.Windows.Forms.Label();
            this.CmbDriverID = new System.Windows.Forms.ComboBox();
            this.LblEmployeeIdNumber = new System.Windows.Forms.Label();
            this.PnlDeleteServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblUpdateDrivers = new System.Windows.Forms.Label();
            this.TipDeleteService = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnSubmit);
            this.PnlForBorder.Controls.Add(this.CmbTrip);
            this.PnlForBorder.Controls.Add(this.LblTripID);
            this.PnlForBorder.Controls.Add(this.CmbDriverID);
            this.PnlForBorder.Controls.Add(this.LblEmployeeIdNumber);
            this.PnlForBorder.Controls.Add(this.PnlDeleteServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // CmbTrip
            // 
            this.CmbTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTrip.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTrip.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbTrip.FormattingEnabled = true;
            this.CmbTrip.Location = new System.Drawing.Point(281, 314);
            this.CmbTrip.Name = "CmbTrip";
            this.CmbTrip.Size = new System.Drawing.Size(324, 33);
            this.CmbTrip.TabIndex = 42;
            // 
            // LblTripID
            // 
            this.LblTripID.AutoSize = true;
            this.LblTripID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripID.Location = new System.Drawing.Point(187, 318);
            this.LblTripID.Name = "LblTripID";
            this.LblTripID.Size = new System.Drawing.Size(75, 29);
            this.LblTripID.TabIndex = 41;
            this.LblTripID.Text = "Trip ID:";
            // 
            // CmbDriverID
            // 
            this.CmbDriverID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbDriverID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDriverID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDriverID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbDriverID.FormattingEnabled = true;
            this.CmbDriverID.Location = new System.Drawing.Point(281, 247);
            this.CmbDriverID.Name = "CmbDriverID";
            this.CmbDriverID.Size = new System.Drawing.Size(324, 33);
            this.CmbDriverID.TabIndex = 40;
            // 
            // LblEmployeeIdNumber
            // 
            this.LblEmployeeIdNumber.AutoSize = true;
            this.LblEmployeeIdNumber.BackColor = System.Drawing.Color.White;
            this.LblEmployeeIdNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeIdNumber.Location = new System.Drawing.Point(110, 255);
            this.LblEmployeeIdNumber.Name = "LblEmployeeIdNumber";
            this.LblEmployeeIdNumber.Size = new System.Drawing.Size(152, 25);
            this.LblEmployeeIdNumber.TabIndex = 39;
            this.LblEmployeeIdNumber.Text = "Driver ID Number:";
            // 
            // PnlDeleteServiceBackgroundImage
            // 
            this.PnlDeleteServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteServiceBackgroundImage.Controls.Add(this.LblUpdateDrivers);
            this.PnlDeleteServiceBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteServiceBackgroundImage.Name = "PnlDeleteServiceBackgroundImage";
            this.PnlDeleteServiceBackgroundImage.Size = new System.Drawing.Size(716, 147);
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
            // LblUpdateDrivers
            // 
            this.LblUpdateDrivers.AutoSize = true;
            this.LblUpdateDrivers.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateDrivers.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateDrivers.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUpdateDrivers.Location = new System.Drawing.Point(147, 55);
            this.LblUpdateDrivers.Name = "LblUpdateDrivers";
            this.LblUpdateDrivers.Size = new System.Drawing.Size(429, 43);
            this.LblUpdateDrivers.TabIndex = 44;
            this.LblUpdateDrivers.Text = "UPDATE DRIVERS TRIP";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(323, 415);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 43;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // FrmUpdateDriverTrips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUpdateDriverTrips";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label LblUpdateDrivers;
        private System.Windows.Forms.ToolTip TipDeleteService;
        private System.Windows.Forms.ComboBox CmbDriverID;
        private System.Windows.Forms.Label LblEmployeeIdNumber;
        private System.Windows.Forms.Label LblTripID;
        private System.Windows.Forms.ComboBox CmbTrip;
        private System.Windows.Forms.Button BtnSubmit;
    }
}