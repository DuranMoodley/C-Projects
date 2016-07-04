namespace Trucking_Company
{
    partial class FrmPasswordRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordRecovery));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.PnlDeleteTripBackgroundImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPasswordRecovery = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.CmbTypeOfEmployee = new System.Windows.Forms.ComboBox();
            this.lblTypeOfEmp = new System.Windows.Forms.Label();
            this.TxtIdNumber = new System.Windows.Forms.TextBox();
            this.lblEnterEmail = new System.Windows.Forms.Label();
            this.LblIdNumber = new System.Windows.Forms.Label();
            this.TxtEmailAdd = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TipDeleteTrip = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteTripBackgroundImage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.PnlDeleteTripBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // PnlDeleteTripBackgroundImage
            // 
            this.PnlDeleteTripBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.panel1);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.BtnSubmit);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.CmbTypeOfEmployee);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.lblTypeOfEmp);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.TxtIdNumber);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.lblEnterEmail);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.LblIdNumber);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.TxtEmailAdd);
            this.PnlDeleteTripBackgroundImage.Controls.Add(this.pictureBox1);
            this.PnlDeleteTripBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteTripBackgroundImage.Name = "PnlDeleteTripBackgroundImage";
            this.PnlDeleteTripBackgroundImage.Size = new System.Drawing.Size(716, 495);
            this.PnlDeleteTripBackgroundImage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.lblPasswordRecovery);
            this.panel1.Controls.Add(this.BtnReturn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 179);
            this.panel1.TabIndex = 58;
            // 
            // lblPasswordRecovery
            // 
            this.lblPasswordRecovery.AutoSize = true;
            this.lblPasswordRecovery.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordRecovery.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRecovery.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblPasswordRecovery.Location = new System.Drawing.Point(135, 67);
            this.lblPasswordRecovery.Name = "lblPasswordRecovery";
            this.lblPasswordRecovery.Size = new System.Drawing.Size(433, 43);
            this.lblPasswordRecovery.TabIndex = 59;
            this.lblPasswordRecovery.Text = "PASSWORD RECOVERY";
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
            this.BtnReturn.Location = new System.Drawing.Point(677, 3);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(36, 28);
            this.BtnReturn.TabIndex = 58;
            this.TipDeleteTrip.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(509, 345);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 56;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            // 
            // CmbTypeOfEmployee
            // 
            this.CmbTypeOfEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTypeOfEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeOfEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbTypeOfEmployee.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTypeOfEmployee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbTypeOfEmployee.FormattingEnabled = true;
            this.CmbTypeOfEmployee.Items.AddRange(new object[] {
            "Mechanic",
            "Driver",
            "Manager/Administrator"});
            this.CmbTypeOfEmployee.Location = new System.Drawing.Point(300, 238);
            this.CmbTypeOfEmployee.Name = "CmbTypeOfEmployee";
            this.CmbTypeOfEmployee.Size = new System.Drawing.Size(293, 31);
            this.CmbTypeOfEmployee.TabIndex = 54;
            // 
            // lblTypeOfEmp
            // 
            this.lblTypeOfEmp.AutoSize = true;
            this.lblTypeOfEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeOfEmp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfEmp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTypeOfEmp.Location = new System.Drawing.Point(87, 240);
            this.lblTypeOfEmp.Name = "lblTypeOfEmp";
            this.lblTypeOfEmp.Size = new System.Drawing.Size(207, 25);
            this.lblTypeOfEmp.TabIndex = 55;
            this.lblTypeOfEmp.Text = "Enter Type of Employee:";
            // 
            // TxtIdNumber
            // 
            this.TxtIdNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtIdNumber.Location = new System.Drawing.Point(300, 275);
            this.TxtIdNumber.MaxLength = 15;
            this.TxtIdNumber.Name = "TxtIdNumber";
            this.TxtIdNumber.Size = new System.Drawing.Size(293, 29);
            this.TxtIdNumber.TabIndex = 51;
            this.TxtIdNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEnterEmail
            // 
            this.lblEnterEmail.AutoSize = true;
            this.lblEnterEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEnterEmail.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterEmail.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblEnterEmail.Location = new System.Drawing.Point(117, 312);
            this.lblEnterEmail.Name = "lblEnterEmail";
            this.lblEnterEmail.Size = new System.Drawing.Size(177, 25);
            this.lblEnterEmail.TabIndex = 52;
            this.lblEnterEmail.Text = "Enter Email Address:";
            // 
            // LblIdNumber
            // 
            this.LblIdNumber.AutoSize = true;
            this.LblIdNumber.BackColor = System.Drawing.Color.Transparent;
            this.LblIdNumber.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblIdNumber.Location = new System.Drawing.Point(147, 277);
            this.LblIdNumber.Name = "LblIdNumber";
            this.LblIdNumber.Size = new System.Drawing.Size(147, 25);
            this.LblIdNumber.TabIndex = 50;
            this.LblIdNumber.Text = "Enter ID Number:";
            // 
            // TxtEmailAdd
            // 
            this.TxtEmailAdd.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmailAdd.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEmailAdd.Location = new System.Drawing.Point(300, 310);
            this.TxtEmailAdd.MaxLength = 100;
            this.TxtEmailAdd.Name = "TxtEmailAdd";
            this.TxtEmailAdd.Size = new System.Drawing.Size(293, 29);
            this.TxtEmailAdd.TabIndex = 53;
            this.TxtEmailAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 407);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPasswordRecovery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlDeleteTripBackgroundImage.ResumeLayout(false);
            this.PnlDeleteTripBackgroundImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteTripBackgroundImage;
        private System.Windows.Forms.ToolTip TipDeleteTrip;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.ComboBox CmbTypeOfEmployee;
        private System.Windows.Forms.Label lblTypeOfEmp;
        private System.Windows.Forms.TextBox TxtIdNumber;
        private System.Windows.Forms.Label lblEnterEmail;
        private System.Windows.Forms.Label LblIdNumber;
        private System.Windows.Forms.TextBox TxtEmailAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPasswordRecovery;
        private System.Windows.Forms.Button BtnReturn;
    }
}