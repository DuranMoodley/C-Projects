namespace Trucking_Company
{
    partial class FrmUpdateVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateVehicle));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.DtpNextOdometerReading = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblNextOdometerReading = new System.Windows.Forms.Label();
            this.TxtCurrentOdometerReading = new System.Windows.Forms.TextBox();
            this.LblCurrentOdometerReading = new System.Windows.Forms.Label();
            this.TxtEngineSize = new System.Windows.Forms.TextBox();
            this.LblEngineSize = new System.Windows.Forms.Label();
            this.TxtVehicleManufacture = new System.Windows.Forms.TextBox();
            this.TxtVehicleType = new System.Windows.Forms.TextBox();
            this.TxtVehicleRegistration = new System.Windows.Forms.TextBox();
            this.TxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.LblVehicleManufacture = new System.Windows.Forms.Label();
            this.LblVehicleType = new System.Windows.Forms.Label();
            this.LblVehicleRegistration = new System.Windows.Forms.Label();
            this.LblVehicleNumber = new System.Windows.Forms.Label();
            this.PnlUpdateVehicleBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblUpdateVehicle = new System.Windows.Forms.Label();
            this.TipUpdateVehicleForm = new System.Windows.Forms.ToolTip(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.PnlForBorder.SuspendLayout();
            this.PnlUpdateVehicleBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnSearch);
            this.PnlForBorder.Controls.Add(this.DtpNextOdometerReading);
            this.PnlForBorder.Controls.Add(this.BtnUpdate);
            this.PnlForBorder.Controls.Add(this.LblNextOdometerReading);
            this.PnlForBorder.Controls.Add(this.TxtCurrentOdometerReading);
            this.PnlForBorder.Controls.Add(this.LblCurrentOdometerReading);
            this.PnlForBorder.Controls.Add(this.TxtEngineSize);
            this.PnlForBorder.Controls.Add(this.LblEngineSize);
            this.PnlForBorder.Controls.Add(this.TxtVehicleManufacture);
            this.PnlForBorder.Controls.Add(this.TxtVehicleType);
            this.PnlForBorder.Controls.Add(this.TxtVehicleRegistration);
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblVehicleManufacture);
            this.PnlForBorder.Controls.Add(this.LblVehicleType);
            this.PnlForBorder.Controls.Add(this.LblVehicleRegistration);
            this.PnlForBorder.Controls.Add(this.LblVehicleNumber);
            this.PnlForBorder.Controls.Add(this.PnlUpdateVehicleBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // DtpNextOdometerReading
            // 
            this.DtpNextOdometerReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpNextOdometerReading.Enabled = false;
            this.DtpNextOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNextOdometerReading.Location = new System.Drawing.Point(278, 405);
            this.DtpNextOdometerReading.Name = "DtpNextOdometerReading";
            this.DtpNextOdometerReading.Size = new System.Drawing.Size(388, 29);
            this.DtpNextOdometerReading.TabIndex = 41;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Enabled = false;
            this.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnUpdate.Location = new System.Drawing.Point(492, 440);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 37);
            this.BtnUpdate.TabIndex = 39;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // LblNextOdometerReading
            // 
            this.LblNextOdometerReading.AutoSize = true;
            this.LblNextOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNextOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblNextOdometerReading.Location = new System.Drawing.Point(66, 409);
            this.LblNextOdometerReading.Name = "LblNextOdometerReading";
            this.LblNextOdometerReading.Size = new System.Drawing.Size(206, 25);
            this.LblNextOdometerReading.TabIndex = 38;
            this.LblNextOdometerReading.Text = "Next Odometer Reading:";
            // 
            // TxtCurrentOdometerReading
            // 
            this.TxtCurrentOdometerReading.Enabled = false;
            this.TxtCurrentOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrentOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtCurrentOdometerReading.Location = new System.Drawing.Point(278, 370);
            this.TxtCurrentOdometerReading.Name = "TxtCurrentOdometerReading";
            this.TxtCurrentOdometerReading.Size = new System.Drawing.Size(388, 29);
            this.TxtCurrentOdometerReading.TabIndex = 37;
            this.TxtCurrentOdometerReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentOdometerReading
            // 
            this.LblCurrentOdometerReading.AutoSize = true;
            this.LblCurrentOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblCurrentOdometerReading.Location = new System.Drawing.Point(42, 372);
            this.LblCurrentOdometerReading.Name = "LblCurrentOdometerReading";
            this.LblCurrentOdometerReading.Size = new System.Drawing.Size(230, 25);
            this.LblCurrentOdometerReading.TabIndex = 36;
            this.LblCurrentOdometerReading.Text = "Current Odometer Reading:";
            // 
            // TxtEngineSize
            // 
            this.TxtEngineSize.Enabled = false;
            this.TxtEngineSize.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEngineSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEngineSize.Location = new System.Drawing.Point(278, 335);
            this.TxtEngineSize.Name = "TxtEngineSize";
            this.TxtEngineSize.Size = new System.Drawing.Size(388, 29);
            this.TxtEngineSize.TabIndex = 35;
            this.TxtEngineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEngineSize
            // 
            this.LblEngineSize.AutoSize = true;
            this.LblEngineSize.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEngineSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEngineSize.Location = new System.Drawing.Point(161, 337);
            this.LblEngineSize.Name = "LblEngineSize";
            this.LblEngineSize.Size = new System.Drawing.Size(111, 25);
            this.LblEngineSize.TabIndex = 34;
            this.LblEngineSize.Text = "Engine Size:";
            // 
            // TxtVehicleManufacture
            // 
            this.TxtVehicleManufacture.Enabled = false;
            this.TxtVehicleManufacture.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleManufacture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleManufacture.Location = new System.Drawing.Point(278, 300);
            this.TxtVehicleManufacture.Name = "TxtVehicleManufacture";
            this.TxtVehicleManufacture.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleManufacture.TabIndex = 33;
            this.TxtVehicleManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleType
            // 
            this.TxtVehicleType.Enabled = false;
            this.TxtVehicleType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleType.Location = new System.Drawing.Point(278, 265);
            this.TxtVehicleType.Name = "TxtVehicleType";
            this.TxtVehicleType.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleType.TabIndex = 32;
            this.TxtVehicleType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleRegistration
            // 
            this.TxtVehicleRegistration.Enabled = false;
            this.TxtVehicleRegistration.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleRegistration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleRegistration.Location = new System.Drawing.Point(278, 230);
            this.TxtVehicleRegistration.Name = "TxtVehicleRegistration";
            this.TxtVehicleRegistration.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleRegistration.TabIndex = 31;
            this.TxtVehicleRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(278, 195);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleNumber.TabIndex = 30;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleManufacture
            // 
            this.LblVehicleManufacture.AutoSize = true;
            this.LblVehicleManufacture.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleManufacture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleManufacture.Location = new System.Drawing.Point(92, 302);
            this.LblVehicleManufacture.Name = "LblVehicleManufacture";
            this.LblVehicleManufacture.Size = new System.Drawing.Size(180, 25);
            this.LblVehicleManufacture.TabIndex = 29;
            this.LblVehicleManufacture.Text = "Vehicle Manufacture:";
            // 
            // LblVehicleType
            // 
            this.LblVehicleType.AutoSize = true;
            this.LblVehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleType.Location = new System.Drawing.Point(152, 267);
            this.LblVehicleType.Name = "LblVehicleType";
            this.LblVehicleType.Size = new System.Drawing.Size(120, 25);
            this.LblVehicleType.TabIndex = 28;
            this.LblVehicleType.Text = "Vehicle Type:";
            // 
            // LblVehicleRegistration
            // 
            this.LblVehicleRegistration.AutoSize = true;
            this.LblVehicleRegistration.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleRegistration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleRegistration.Location = new System.Drawing.Point(97, 232);
            this.LblVehicleRegistration.Name = "LblVehicleRegistration";
            this.LblVehicleRegistration.Size = new System.Drawing.Size(175, 25);
            this.LblVehicleRegistration.TabIndex = 27;
            this.LblVehicleRegistration.Text = "Vehicle Registration:";
            // 
            // LblVehicleNumber
            // 
            this.LblVehicleNumber.AutoSize = true;
            this.LblVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumber.Location = new System.Drawing.Point(130, 197);
            this.LblVehicleNumber.Name = "LblVehicleNumber";
            this.LblVehicleNumber.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNumber.TabIndex = 26;
            this.LblVehicleNumber.Text = "Vehicle Number:";
            // 
            // PnlUpdateVehicleBackgroundImage
            // 
            this.PnlUpdateVehicleBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlUpdateVehicleBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlUpdateVehicleBackgroundImage.Controls.Add(this.LblUpdateVehicle);
            this.PnlUpdateVehicleBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlUpdateVehicleBackgroundImage.Name = "PnlUpdateVehicleBackgroundImage";
            this.PnlUpdateVehicleBackgroundImage.Size = new System.Drawing.Size(716, 163);
            this.PnlUpdateVehicleBackgroundImage.TabIndex = 0;
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
            this.TipUpdateVehicleForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblUpdateVehicle
            // 
            this.LblUpdateVehicle.AutoSize = true;
            this.LblUpdateVehicle.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateVehicle.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateVehicle.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUpdateVehicle.Location = new System.Drawing.Point(185, 58);
            this.LblUpdateVehicle.Name = "LblUpdateVehicle";
            this.LblUpdateVehicle.Size = new System.Drawing.Size(342, 43);
            this.LblUpdateVehicle.TabIndex = 42;
            this.LblUpdateVehicle.Text = "UPDATE VEHICLE";
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
            this.BtnSearch.Location = new System.Drawing.Point(582, 440);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 43;
            this.BtnSearch.Text = "&Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmUpdateVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUpdateVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlUpdateVehicleBackgroundImage.ResumeLayout(false);
            this.PnlUpdateVehicleBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlUpdateVehicleBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblUpdateVehicle;
        private System.Windows.Forms.ToolTip TipUpdateVehicleForm;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblNextOdometerReading;
        private System.Windows.Forms.TextBox TxtCurrentOdometerReading;
        private System.Windows.Forms.Label LblCurrentOdometerReading;
        private System.Windows.Forms.TextBox TxtEngineSize;
        private System.Windows.Forms.Label LblEngineSize;
        private System.Windows.Forms.TextBox TxtVehicleManufacture;
        private System.Windows.Forms.TextBox TxtVehicleType;
        private System.Windows.Forms.TextBox TxtVehicleRegistration;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.Label LblVehicleManufacture;
        private System.Windows.Forms.Label LblVehicleType;
        private System.Windows.Forms.Label LblVehicleRegistration;
        private System.Windows.Forms.Label LblVehicleNumber;
        private System.Windows.Forms.DateTimePicker DtpNextOdometerReading;
        private System.Windows.Forms.Button BtnSearch;
    }
}