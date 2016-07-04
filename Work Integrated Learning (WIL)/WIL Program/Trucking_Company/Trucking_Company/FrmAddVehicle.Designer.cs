namespace Trucking_Company
{
    partial class FrmAddVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddVehicle));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.DtpNextOdometerReading = new System.Windows.Forms.DateTimePicker();
            this.BtnSubmit = new System.Windows.Forms.Button();
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
            this.PnlInsertVehicleBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblAddVehicle = new System.Windows.Forms.Label();
            this.TipInsertVehicleForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlInsertVehicleBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.DtpNextOdometerReading);
            this.PnlForBorder.Controls.Add(this.BtnSubmit);
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
            this.PnlForBorder.Controls.Add(this.PnlInsertVehicleBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // DtpNextOdometerReading
            // 
            this.DtpNextOdometerReading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpNextOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpNextOdometerReading.Location = new System.Drawing.Point(270, 404);
            this.DtpNextOdometerReading.Name = "DtpNextOdometerReading";
            this.DtpNextOdometerReading.Size = new System.Drawing.Size(387, 29);
            this.DtpNextOdometerReading.TabIndex = 25;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(573, 439);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 24;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblNextOdometerReading
            // 
            this.LblNextOdometerReading.AutoSize = true;
            this.LblNextOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNextOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblNextOdometerReading.Location = new System.Drawing.Point(58, 408);
            this.LblNextOdometerReading.Name = "LblNextOdometerReading";
            this.LblNextOdometerReading.Size = new System.Drawing.Size(206, 25);
            this.LblNextOdometerReading.TabIndex = 21;
            this.LblNextOdometerReading.Text = "Next Odometer Reading:";
            // 
            // TxtCurrentOdometerReading
            // 
            this.TxtCurrentOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrentOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtCurrentOdometerReading.Location = new System.Drawing.Point(269, 369);
            this.TxtCurrentOdometerReading.Name = "TxtCurrentOdometerReading";
            this.TxtCurrentOdometerReading.Size = new System.Drawing.Size(388, 29);
            this.TxtCurrentOdometerReading.TabIndex = 20;
            this.TxtCurrentOdometerReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCurrentOdometerReading
            // 
            this.LblCurrentOdometerReading.AutoSize = true;
            this.LblCurrentOdometerReading.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCurrentOdometerReading.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblCurrentOdometerReading.Location = new System.Drawing.Point(33, 371);
            this.LblCurrentOdometerReading.Name = "LblCurrentOdometerReading";
            this.LblCurrentOdometerReading.Size = new System.Drawing.Size(230, 25);
            this.LblCurrentOdometerReading.TabIndex = 19;
            this.LblCurrentOdometerReading.Text = "Current Odometer Reading:";
            // 
            // TxtEngineSize
            // 
            this.TxtEngineSize.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEngineSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEngineSize.Location = new System.Drawing.Point(269, 334);
            this.TxtEngineSize.Name = "TxtEngineSize";
            this.TxtEngineSize.Size = new System.Drawing.Size(388, 29);
            this.TxtEngineSize.TabIndex = 18;
            this.TxtEngineSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEngineSize
            // 
            this.LblEngineSize.AutoSize = true;
            this.LblEngineSize.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEngineSize.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEngineSize.Location = new System.Drawing.Point(152, 336);
            this.LblEngineSize.Name = "LblEngineSize";
            this.LblEngineSize.Size = new System.Drawing.Size(111, 25);
            this.LblEngineSize.TabIndex = 17;
            this.LblEngineSize.Text = "Engine Size:";
            // 
            // TxtVehicleManufacture
            // 
            this.TxtVehicleManufacture.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleManufacture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleManufacture.Location = new System.Drawing.Point(269, 299);
            this.TxtVehicleManufacture.Name = "TxtVehicleManufacture";
            this.TxtVehicleManufacture.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleManufacture.TabIndex = 16;
            this.TxtVehicleManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleType
            // 
            this.TxtVehicleType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleType.Location = new System.Drawing.Point(269, 264);
            this.TxtVehicleType.Name = "TxtVehicleType";
            this.TxtVehicleType.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleType.TabIndex = 15;
            this.TxtVehicleType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleRegistration
            // 
            this.TxtVehicleRegistration.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleRegistration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleRegistration.Location = new System.Drawing.Point(269, 229);
            this.TxtVehicleRegistration.Name = "TxtVehicleRegistration";
            this.TxtVehicleRegistration.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleRegistration.TabIndex = 14;
            this.TxtVehicleRegistration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(269, 194);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(388, 29);
            this.TxtVehicleNumber.TabIndex = 13;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleManufacture
            // 
            this.LblVehicleManufacture.AutoSize = true;
            this.LblVehicleManufacture.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleManufacture.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleManufacture.Location = new System.Drawing.Point(83, 301);
            this.LblVehicleManufacture.Name = "LblVehicleManufacture";
            this.LblVehicleManufacture.Size = new System.Drawing.Size(180, 25);
            this.LblVehicleManufacture.TabIndex = 12;
            this.LblVehicleManufacture.Text = "Vehicle Manufacture:";
            // 
            // LblVehicleType
            // 
            this.LblVehicleType.AutoSize = true;
            this.LblVehicleType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleType.Location = new System.Drawing.Point(143, 266);
            this.LblVehicleType.Name = "LblVehicleType";
            this.LblVehicleType.Size = new System.Drawing.Size(120, 25);
            this.LblVehicleType.TabIndex = 11;
            this.LblVehicleType.Text = "Vehicle Type:";
            // 
            // LblVehicleRegistration
            // 
            this.LblVehicleRegistration.AutoSize = true;
            this.LblVehicleRegistration.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleRegistration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleRegistration.Location = new System.Drawing.Point(88, 231);
            this.LblVehicleRegistration.Name = "LblVehicleRegistration";
            this.LblVehicleRegistration.Size = new System.Drawing.Size(175, 25);
            this.LblVehicleRegistration.TabIndex = 10;
            this.LblVehicleRegistration.Text = "Vehicle Registration:";
            // 
            // LblVehicleNumber
            // 
            this.LblVehicleNumber.AutoSize = true;
            this.LblVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumber.Location = new System.Drawing.Point(121, 196);
            this.LblVehicleNumber.Name = "LblVehicleNumber";
            this.LblVehicleNumber.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNumber.TabIndex = 9;
            this.LblVehicleNumber.Text = "Vehicle Number:";
            // 
            // PnlInsertVehicleBackgroundImage
            // 
            this.PnlInsertVehicleBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlInsertVehicleBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlInsertVehicleBackgroundImage.Controls.Add(this.LblAddVehicle);
            this.PnlInsertVehicleBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlInsertVehicleBackgroundImage.Name = "PnlInsertVehicleBackgroundImage";
            this.PnlInsertVehicleBackgroundImage.Size = new System.Drawing.Size(716, 167);
            this.PnlInsertVehicleBackgroundImage.TabIndex = 0;
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
            this.TipInsertVehicleForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblAddVehicle
            // 
            this.LblAddVehicle.AutoSize = true;
            this.LblAddVehicle.BackColor = System.Drawing.Color.Transparent;
            this.LblAddVehicle.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddVehicle.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAddVehicle.Location = new System.Drawing.Point(236, 58);
            this.LblAddVehicle.Name = "LblAddVehicle";
            this.LblAddVehicle.Size = new System.Drawing.Size(274, 43);
            this.LblAddVehicle.TabIndex = 13;
            this.LblAddVehicle.Text = "ADD VEHICLE";
            // 
            // FrmAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmAddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlInsertVehicleBackgroundImage.ResumeLayout(false);
            this.PnlInsertVehicleBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlInsertVehicleBackgroundImage;
        private System.Windows.Forms.Label LblAddVehicle;
        private System.Windows.Forms.TextBox TxtVehicleManufacture;
        private System.Windows.Forms.TextBox TxtVehicleType;
        private System.Windows.Forms.TextBox TxtVehicleRegistration;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.Label LblVehicleManufacture;
        private System.Windows.Forms.Label LblVehicleType;
        private System.Windows.Forms.Label LblVehicleRegistration;
        private System.Windows.Forms.Label LblVehicleNumber;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.TextBox TxtCurrentOdometerReading;
        private System.Windows.Forms.Label LblCurrentOdometerReading;
        private System.Windows.Forms.TextBox TxtEngineSize;
        private System.Windows.Forms.Label LblEngineSize;
        private System.Windows.Forms.Label LblNextOdometerReading;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ToolTip TipInsertVehicleForm;
        private System.Windows.Forms.DateTimePicker DtpNextOdometerReading;
    }
}