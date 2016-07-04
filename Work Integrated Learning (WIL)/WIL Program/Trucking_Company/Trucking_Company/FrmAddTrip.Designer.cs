namespace Trucking_Company
{
    partial class FrmAddTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddTrip));
            this.LblAddTrip = new System.Windows.Forms.Label();
            this.LblTripID = new System.Windows.Forms.Label();
            this.LblTripDestination = new System.Windows.Forms.Label();
            this.TxtTripID = new System.Windows.Forms.TextBox();
            this.TxtTripDestination = new System.Windows.Forms.TextBox();
            this.TxtEstimatedTravelled = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.PnlAddTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.CmbTripStatus = new System.Windows.Forms.ComboBox();
            this.TxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.LblVehicleNumber = new System.Windows.Forms.Label();
            this.LblTripStatus = new System.Windows.Forms.Label();
            this.DtpTripDate = new System.Windows.Forms.DateTimePicker();
            this.LblTripDate = new System.Windows.Forms.Label();
            this.LblEstimatedTravelled = new System.Windows.Forms.Label();
            this.TipAddTripForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlAddTripBackgroundImage.SuspendLayout();
            this.PnlForBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblAddTrip
            // 
            this.LblAddTrip.AutoSize = true;
            this.LblAddTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblAddTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAddTrip.Location = new System.Drawing.Point(267, 68);
            this.LblAddTrip.Name = "LblAddTrip";
            this.LblAddTrip.Size = new System.Drawing.Size(195, 43);
            this.LblAddTrip.TabIndex = 9;
            this.LblAddTrip.Text = "ADD TRIP";
            // 
            // LblTripID
            // 
            this.LblTripID.AutoSize = true;
            this.LblTripID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripID.Location = new System.Drawing.Point(190, 236);
            this.LblTripID.Name = "LblTripID";
            this.LblTripID.Size = new System.Drawing.Size(69, 25);
            this.LblTripID.TabIndex = 10;
            this.LblTripID.Text = "Trip ID:";
            // 
            // LblTripDestination
            // 
            this.LblTripDestination.AutoSize = true;
            this.LblTripDestination.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripDestination.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripDestination.Location = new System.Drawing.Point(117, 271);
            this.LblTripDestination.Name = "LblTripDestination";
            this.LblTripDestination.Size = new System.Drawing.Size(142, 25);
            this.LblTripDestination.TabIndex = 11;
            this.LblTripDestination.Text = "Trip Destination:";
            // 
            // TxtTripID
            // 
            this.TxtTripID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTripID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtTripID.Location = new System.Drawing.Point(265, 234);
            this.TxtTripID.Name = "TxtTripID";
            this.TxtTripID.Size = new System.Drawing.Size(376, 29);
            this.TxtTripID.TabIndex = 13;
            this.TxtTripID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTripID.MouseHover += new System.EventHandler(this.TxtTripID_MouseHover);
            // 
            // TxtTripDestination
            // 
            this.TxtTripDestination.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTripDestination.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtTripDestination.Location = new System.Drawing.Point(265, 269);
            this.TxtTripDestination.Name = "TxtTripDestination";
            this.TxtTripDestination.Size = new System.Drawing.Size(376, 29);
            this.TxtTripDestination.TabIndex = 14;
            this.TxtTripDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEstimatedTravelled
            // 
            this.TxtEstimatedTravelled.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstimatedTravelled.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEstimatedTravelled.Location = new System.Drawing.Point(265, 304);
            this.TxtEstimatedTravelled.Name = "TxtEstimatedTravelled";
            this.TxtEstimatedTravelled.Size = new System.Drawing.Size(376, 29);
            this.TxtEstimatedTravelled.TabIndex = 15;
            this.TxtEstimatedTravelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(557, 446);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 16;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // PnlAddTripBackgroundImage
            // 
            this.PnlAddTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlAddTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlAddTripBackgroundImage.Controls.Add(this.LblAddTrip);
            this.PnlAddTripBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlAddTripBackgroundImage.Name = "PnlAddTripBackgroundImage";
            this.PnlAddTripBackgroundImage.Size = new System.Drawing.Size(716, 181);
            this.PnlAddTripBackgroundImage.TabIndex = 18;
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
            this.TipAddTripForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.CmbTripStatus);
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblTripStatus);
            this.PnlForBorder.Controls.Add(this.DtpTripDate);
            this.PnlForBorder.Controls.Add(this.LblTripDate);
            this.PnlForBorder.Controls.Add(this.LblEstimatedTravelled);
            this.PnlForBorder.Controls.Add(this.PnlAddTripBackgroundImage);
            this.PnlForBorder.Controls.Add(this.TxtTripID);
            this.PnlForBorder.Controls.Add(this.BtnSubmit);
            this.PnlForBorder.Controls.Add(this.LblTripDestination);
            this.PnlForBorder.Controls.Add(this.TxtEstimatedTravelled);
            this.PnlForBorder.Controls.Add(this.TxtTripDestination);
            this.PnlForBorder.Controls.Add(this.LblTripID);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 516);
            this.PnlForBorder.TabIndex = 10;
            // 
            // CmbTripStatus
            // 
            this.CmbTripStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTripStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTripStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbTripStatus.FormattingEnabled = true;
            this.CmbTripStatus.Items.AddRange(new object[] {
            "Pending",
            "Dispatched"});
            this.CmbTripStatus.Location = new System.Drawing.Point(265, 374);
            this.CmbTripStatus.Name = "CmbTripStatus";
            this.CmbTripStatus.Size = new System.Drawing.Size(376, 31);
            this.CmbTripStatus.TabIndex = 29;
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(265, 411);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(376, 29);
            this.TxtVehicleNumber.TabIndex = 28;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleNumber
            // 
            this.LblVehicleNumber.AutoSize = true;
            this.LblVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumber.Location = new System.Drawing.Point(117, 413);
            this.LblVehicleNumber.Name = "LblVehicleNumber";
            this.LblVehicleNumber.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNumber.TabIndex = 27;
            this.LblVehicleNumber.Text = "Vehicle Number:";
            // 
            // LblTripStatus
            // 
            this.LblTripStatus.AutoSize = true;
            this.LblTripStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripStatus.Location = new System.Drawing.Point(156, 376);
            this.LblTripStatus.Name = "LblTripStatus";
            this.LblTripStatus.Size = new System.Drawing.Size(103, 25);
            this.LblTripStatus.TabIndex = 24;
            this.LblTripStatus.Text = "Trip Status:";
            // 
            // DtpTripDate
            // 
            this.DtpTripDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpTripDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpTripDate.Location = new System.Drawing.Point(265, 339);
            this.DtpTripDate.Name = "DtpTripDate";
            this.DtpTripDate.Size = new System.Drawing.Size(376, 29);
            this.DtpTripDate.TabIndex = 22;
            // 
            // LblTripDate
            // 
            this.LblTripDate.AutoSize = true;
            this.LblTripDate.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripDate.Location = new System.Drawing.Point(169, 343);
            this.LblTripDate.Name = "LblTripDate";
            this.LblTripDate.Size = new System.Drawing.Size(90, 25);
            this.LblTripDate.TabIndex = 21;
            this.LblTripDate.Text = "Trip Date:";
            // 
            // LblEstimatedTravelled
            // 
            this.LblEstimatedTravelled.AutoSize = true;
            this.LblEstimatedTravelled.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstimatedTravelled.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEstimatedTravelled.Location = new System.Drawing.Point(42, 306);
            this.LblEstimatedTravelled.Name = "LblEstimatedTravelled";
            this.LblEstimatedTravelled.Size = new System.Drawing.Size(217, 25);
            this.LblEstimatedTravelled.TabIndex = 19;
            this.LblEstimatedTravelled.Text = "Estimated Travelled (KM):";
            // 
            // FrmAddTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 523);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmAddTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlAddTripBackgroundImage.ResumeLayout(false);
            this.PnlAddTripBackgroundImage.PerformLayout();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblAddTrip;
        private System.Windows.Forms.Label LblTripID;
        private System.Windows.Forms.Label LblTripDestination;
        private System.Windows.Forms.TextBox TxtTripID;
        private System.Windows.Forms.TextBox TxtTripDestination;
        private System.Windows.Forms.TextBox TxtEstimatedTravelled;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Panel PnlAddTripBackgroundImage;
        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblTripStatus;
        private System.Windows.Forms.DateTimePicker DtpTripDate;
        private System.Windows.Forms.Label LblTripDate;
        private System.Windows.Forms.Label LblEstimatedTravelled;
        private System.Windows.Forms.ToolTip TipAddTripForm;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.Label LblVehicleNumber;
        private System.Windows.Forms.ComboBox CmbTripStatus;
    }
}