namespace Trucking_Company
{
    partial class FrmAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddService));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.TxtServiceCost = new System.Windows.Forms.TextBox();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.CmbServiceCode = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.LblVehicleNumber = new System.Windows.Forms.Label();
            this.TxtWorkNeeded = new System.Windows.Forms.TextBox();
            this.LblWorkNeeded = new System.Windows.Forms.Label();
            this.LblServiceAppointmentTime = new System.Windows.Forms.Label();
            this.DtpServiceAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.LblServiceCode = new System.Windows.Forms.Label();
            this.LblServiceType = new System.Windows.Forms.Label();
            this.TxtServiceType = new System.Windows.Forms.TextBox();
            this.PnlAddServiceBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblAddService = new System.Windows.Forms.Label();
            this.TipAddServiceForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlAddServiceBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.TxtServiceCost);
            this.PnlForBorder.Controls.Add(this.lblServiceCost);
            this.PnlForBorder.Controls.Add(this.CmbServiceCode);
            this.PnlForBorder.Controls.Add(this.BtnSubmit);
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumber);
            this.PnlForBorder.Controls.Add(this.LblVehicleNumber);
            this.PnlForBorder.Controls.Add(this.TxtWorkNeeded);
            this.PnlForBorder.Controls.Add(this.LblWorkNeeded);
            this.PnlForBorder.Controls.Add(this.LblServiceAppointmentTime);
            this.PnlForBorder.Controls.Add(this.DtpServiceAppointmentTime);
            this.PnlForBorder.Controls.Add(this.LblServiceCode);
            this.PnlForBorder.Controls.Add(this.LblServiceType);
            this.PnlForBorder.Controls.Add(this.TxtServiceType);
            this.PnlForBorder.Controls.Add(this.PnlAddServiceBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // TxtServiceCost
            // 
            this.TxtServiceCost.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServiceCost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtServiceCost.Location = new System.Drawing.Point(288, 321);
            this.TxtServiceCost.Name = "TxtServiceCost";
            this.TxtServiceCost.Size = new System.Drawing.Size(324, 29);
            this.TxtServiceCost.TabIndex = 29;
            this.TxtServiceCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.BackColor = System.Drawing.Color.White;
            this.lblServiceCost.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCost.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblServiceCost.Location = new System.Drawing.Point(165, 323);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(117, 25);
            this.lblServiceCost.TabIndex = 28;
            this.lblServiceCost.Text = "Service Cost:";
            // 
            // CmbServiceCode
            // 
            this.CmbServiceCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbServiceCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbServiceCode.FormattingEnabled = true;
            this.CmbServiceCode.Location = new System.Drawing.Point(288, 214);
            this.CmbServiceCode.Name = "CmbServiceCode";
            this.CmbServiceCode.Size = new System.Drawing.Size(324, 31);
            this.CmbServiceCode.TabIndex = 27;
            this.CmbServiceCode.Text = "Please select a service code. . .";
            this.CmbServiceCode.SelectedIndexChanged += new System.EventHandler(this.CmbxServiceCode_SelectedIndexChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(528, 426);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 26;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(288, 356);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(324, 29);
            this.TxtVehicleNumber.TabIndex = 25;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleNumber
            // 
            this.LblVehicleNumber.AutoSize = true;
            this.LblVehicleNumber.BackColor = System.Drawing.Color.White;
            this.LblVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumber.Location = new System.Drawing.Point(140, 358);
            this.LblVehicleNumber.Name = "LblVehicleNumber";
            this.LblVehicleNumber.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNumber.TabIndex = 24;
            this.LblVehicleNumber.Text = "Vehicle Number:";
            // 
            // TxtWorkNeeded
            // 
            this.TxtWorkNeeded.Enabled = false;
            this.TxtWorkNeeded.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWorkNeeded.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtWorkNeeded.Location = new System.Drawing.Point(288, 286);
            this.TxtWorkNeeded.Name = "TxtWorkNeeded";
            this.TxtWorkNeeded.Size = new System.Drawing.Size(324, 29);
            this.TxtWorkNeeded.TabIndex = 23;
            this.TxtWorkNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblWorkNeeded
            // 
            this.LblWorkNeeded.AutoSize = true;
            this.LblWorkNeeded.BackColor = System.Drawing.Color.White;
            this.LblWorkNeeded.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWorkNeeded.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblWorkNeeded.Location = new System.Drawing.Point(157, 288);
            this.LblWorkNeeded.Name = "LblWorkNeeded";
            this.LblWorkNeeded.Size = new System.Drawing.Size(125, 25);
            this.LblWorkNeeded.TabIndex = 22;
            this.LblWorkNeeded.Text = "Work Needed:";
            // 
            // LblServiceAppointmentTime
            // 
            this.LblServiceAppointmentTime.AutoSize = true;
            this.LblServiceAppointmentTime.BackColor = System.Drawing.Color.White;
            this.LblServiceAppointmentTime.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceAppointmentTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceAppointmentTime.Location = new System.Drawing.Point(58, 395);
            this.LblServiceAppointmentTime.Name = "LblServiceAppointmentTime";
            this.LblServiceAppointmentTime.Size = new System.Drawing.Size(224, 25);
            this.LblServiceAppointmentTime.TabIndex = 21;
            this.LblServiceAppointmentTime.Text = "Service Appointment Time:";
            // 
            // DtpServiceAppointmentTime
            // 
            this.DtpServiceAppointmentTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpServiceAppointmentTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpServiceAppointmentTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpServiceAppointmentTime.Location = new System.Drawing.Point(288, 391);
            this.DtpServiceAppointmentTime.Name = "DtpServiceAppointmentTime";
            this.DtpServiceAppointmentTime.Size = new System.Drawing.Size(324, 29);
            this.DtpServiceAppointmentTime.TabIndex = 20;
            // 
            // LblServiceCode
            // 
            this.LblServiceCode.AutoSize = true;
            this.LblServiceCode.BackColor = System.Drawing.Color.White;
            this.LblServiceCode.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceCode.Location = new System.Drawing.Point(159, 216);
            this.LblServiceCode.Name = "LblServiceCode";
            this.LblServiceCode.Size = new System.Drawing.Size(123, 25);
            this.LblServiceCode.TabIndex = 16;
            this.LblServiceCode.Text = "Service Code:";
            // 
            // LblServiceType
            // 
            this.LblServiceType.AutoSize = true;
            this.LblServiceType.BackColor = System.Drawing.Color.White;
            this.LblServiceType.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServiceType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblServiceType.Location = new System.Drawing.Point(161, 253);
            this.LblServiceType.Name = "LblServiceType";
            this.LblServiceType.Size = new System.Drawing.Size(121, 25);
            this.LblServiceType.TabIndex = 18;
            this.LblServiceType.Text = "Service Type:";
            // 
            // TxtServiceType
            // 
            this.TxtServiceType.Enabled = false;
            this.TxtServiceType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServiceType.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtServiceType.Location = new System.Drawing.Point(288, 251);
            this.TxtServiceType.Name = "TxtServiceType";
            this.TxtServiceType.Size = new System.Drawing.Size(324, 29);
            this.TxtServiceType.TabIndex = 19;
            this.TxtServiceType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PnlAddServiceBackgroundImage
            // 
            this.PnlAddServiceBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlAddServiceBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlAddServiceBackgroundImage.Controls.Add(this.LblAddService);
            this.PnlAddServiceBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlAddServiceBackgroundImage.Name = "PnlAddServiceBackgroundImage";
            this.PnlAddServiceBackgroundImage.Size = new System.Drawing.Size(716, 156);
            this.PnlAddServiceBackgroundImage.TabIndex = 0;
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
            this.TipAddServiceForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblAddService
            // 
            this.LblAddService.AutoSize = true;
            this.LblAddService.BackColor = System.Drawing.Color.Transparent;
            this.LblAddService.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddService.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblAddService.Location = new System.Drawing.Point(231, 57);
            this.LblAddService.Name = "LblAddService";
            this.LblAddService.Size = new System.Drawing.Size(273, 43);
            this.LblAddService.TabIndex = 42;
            this.LblAddService.Text = "ADD SERVICE ";
            // 
            // FrmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlAddServiceBackgroundImage.ResumeLayout(false);
            this.PnlAddServiceBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlAddServiceBackgroundImage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Label LblAddService;
        private System.Windows.Forms.ToolTip TipAddServiceForm;
        private System.Windows.Forms.Label LblServiceAppointmentTime;
        private System.Windows.Forms.DateTimePicker DtpServiceAppointmentTime;
        private System.Windows.Forms.Label LblServiceCode;
        private System.Windows.Forms.Label LblServiceType;
        private System.Windows.Forms.TextBox TxtServiceType;
        private System.Windows.Forms.TextBox TxtWorkNeeded;
        private System.Windows.Forms.Label LblWorkNeeded;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.Label LblVehicleNumber;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ComboBox CmbServiceCode;
        private System.Windows.Forms.TextBox TxtServiceCost;
        private System.Windows.Forms.Label lblServiceCost;
    }
}