namespace Trucking_Company
{
    partial class FrmUpdateTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateTrip));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.TxtTripID = new System.Windows.Forms.TextBox();
            this.LblHours = new System.Windows.Forms.Label();
            this.TxtHours = new System.Windows.Forms.TextBox();
            this.TxtKmActuallyTravelled = new System.Windows.Forms.TextBox();
            this.LblActualTravelled = new System.Windows.Forms.Label();
            this.CmbTripStatus = new System.Windows.Forms.ComboBox();
            this.LblTripStatus = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PnlUpdateTripBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblUpdateTrip = new System.Windows.Forms.Label();
            this.LblTripID = new System.Windows.Forms.Label();
            this.TipUpdateTripForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlUpdateTripBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.TxtTripID);
            this.PnlForBorder.Controls.Add(this.LblHours);
            this.PnlForBorder.Controls.Add(this.TxtHours);
            this.PnlForBorder.Controls.Add(this.TxtKmActuallyTravelled);
            this.PnlForBorder.Controls.Add(this.LblActualTravelled);
            this.PnlForBorder.Controls.Add(this.CmbTripStatus);
            this.PnlForBorder.Controls.Add(this.LblTripStatus);
            this.PnlForBorder.Controls.Add(this.BtnUpdate);
            this.PnlForBorder.Controls.Add(this.BtnSearch);
            this.PnlForBorder.Controls.Add(this.PnlUpdateTripBackgroundImage);
            this.PnlForBorder.Controls.Add(this.LblTripID);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // TxtTripID
            // 
            this.TxtTripID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTripID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtTripID.Location = new System.Drawing.Point(254, 265);
            this.TxtTripID.Name = "TxtTripID";
            this.TxtTripID.Size = new System.Drawing.Size(376, 29);
            this.TxtTripID.TabIndex = 40;
            this.TxtTripID.Text = "Please enter trip ID number and click search...";
            this.TxtTripID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHours
            // 
            this.LblHours.AutoSize = true;
            this.LblHours.BackColor = System.Drawing.Color.White;
            this.LblHours.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHours.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblHours.Location = new System.Drawing.Point(144, 374);
            this.LblHours.Name = "LblHours";
            this.LblHours.Size = new System.Drawing.Size(104, 25);
            this.LblHours.TabIndex = 39;
            this.LblHours.Text = "Total Hours";
            // 
            // TxtHours
            // 
            this.TxtHours.Enabled = false;
            this.TxtHours.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHours.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtHours.Location = new System.Drawing.Point(254, 372);
            this.TxtHours.Name = "TxtHours";
            this.TxtHours.Size = new System.Drawing.Size(376, 29);
            this.TxtHours.TabIndex = 38;
            this.TxtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtKmActuallyTravelled
            // 
            this.TxtKmActuallyTravelled.Enabled = false;
            this.TxtKmActuallyTravelled.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKmActuallyTravelled.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtKmActuallyTravelled.Location = new System.Drawing.Point(254, 337);
            this.TxtKmActuallyTravelled.Name = "TxtKmActuallyTravelled";
            this.TxtKmActuallyTravelled.Size = new System.Drawing.Size(376, 29);
            this.TxtKmActuallyTravelled.TabIndex = 37;
            this.TxtKmActuallyTravelled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblActualTravelled
            // 
            this.LblActualTravelled.AutoSize = true;
            this.LblActualTravelled.BackColor = System.Drawing.Color.White;
            this.LblActualTravelled.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActualTravelled.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblActualTravelled.Location = new System.Drawing.Point(47, 339);
            this.LblActualTravelled.Name = "LblActualTravelled";
            this.LblActualTravelled.Size = new System.Drawing.Size(201, 25);
            this.LblActualTravelled.TabIndex = 36;
            this.LblActualTravelled.Text = "(KM) Actually Travelled:";
            // 
            // CmbTripStatus
            // 
            this.CmbTripStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTripStatus.Enabled = false;
            this.CmbTripStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTripStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbTripStatus.FormattingEnabled = true;
            this.CmbTripStatus.Items.AddRange(new object[] {
            "Completed",
            "Incomplete",
            "Dispatched",
            "Waiting"});
            this.CmbTripStatus.Location = new System.Drawing.Point(254, 300);
            this.CmbTripStatus.Name = "CmbTripStatus";
            this.CmbTripStatus.Size = new System.Drawing.Size(376, 31);
            this.CmbTripStatus.TabIndex = 35;
            // 
            // LblTripStatus
            // 
            this.LblTripStatus.AutoSize = true;
            this.LblTripStatus.BackColor = System.Drawing.Color.White;
            this.LblTripStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripStatus.Location = new System.Drawing.Point(145, 302);
            this.LblTripStatus.Name = "LblTripStatus";
            this.LblTripStatus.Size = new System.Drawing.Size(103, 25);
            this.LblTripStatus.TabIndex = 29;
            this.LblTripStatus.Text = "Trip Status:";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(456, 407);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 37);
            this.BtnUpdate.TabIndex = 21;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            this.BtnSearch.Location = new System.Drawing.Point(546, 407);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 20;
            this.BtnSearch.Text = "&Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // PnlUpdateTripBackgroundImage
            // 
            this.PnlUpdateTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlUpdateTripBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlUpdateTripBackgroundImage.Controls.Add(this.LblUpdateTrip);
            this.PnlUpdateTripBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlUpdateTripBackgroundImage.Name = "PnlUpdateTripBackgroundImage";
            this.PnlUpdateTripBackgroundImage.Size = new System.Drawing.Size(716, 206);
            this.PnlUpdateTripBackgroundImage.TabIndex = 16;
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
            this.TipUpdateTripForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblUpdateTrip
            // 
            this.LblUpdateTrip.AutoSize = true;
            this.LblUpdateTrip.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateTrip.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateTrip.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUpdateTrip.Location = new System.Drawing.Point(234, 77);
            this.LblUpdateTrip.Name = "LblUpdateTrip";
            this.LblUpdateTrip.Size = new System.Drawing.Size(263, 43);
            this.LblUpdateTrip.TabIndex = 10;
            this.LblUpdateTrip.Text = "UPDATE TRIP";
            // 
            // LblTripID
            // 
            this.LblTripID.AutoSize = true;
            this.LblTripID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTripID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTripID.Location = new System.Drawing.Point(179, 267);
            this.LblTripID.Name = "LblTripID";
            this.LblTripID.Size = new System.Drawing.Size(69, 25);
            this.LblTripID.TabIndex = 14;
            this.LblTripID.Text = "Trip ID:";
            // 
            // FrmUpdateTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUpdateTrip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlUpdateTripBackgroundImage.ResumeLayout(false);
            this.PnlUpdateTripBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Label LblTripID;
        private System.Windows.Forms.Panel PnlUpdateTripBackgroundImage;
        private System.Windows.Forms.Label LblUpdateTrip;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblTripStatus;
        private System.Windows.Forms.ComboBox CmbTripStatus;
        private System.Windows.Forms.Label LblActualTravelled;
        private System.Windows.Forms.TextBox TxtKmActuallyTravelled;
        private System.Windows.Forms.Label LblHours;
        private System.Windows.Forms.TextBox TxtHours;
        private System.Windows.Forms.TextBox TxtTripID;
        private System.Windows.Forms.ToolTip TipUpdateTripForm;
    }
}