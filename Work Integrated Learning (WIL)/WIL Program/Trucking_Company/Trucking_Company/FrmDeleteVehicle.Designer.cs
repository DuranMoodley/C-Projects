namespace Trucking_Company
{
    partial class FrmDeleteVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteVehicle));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.TxtVehicleNumberReplacement = new System.Windows.Forms.TextBox();
            this.LblVehicleNumberReplacement = new System.Windows.Forms.Label();
            this.TxtVehicleNumber = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblVehicleNum = new System.Windows.Forms.Label();
            this.PnlDeleteVehicleBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDeleteVehicle = new System.Windows.Forms.Label();
            this.TipDeleteVehicleForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlDeleteVehicleBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumberReplacement);
            this.PnlForBorder.Controls.Add(this.LblVehicleNumberReplacement);
            this.PnlForBorder.Controls.Add(this.TxtVehicleNumber);
            this.PnlForBorder.Controls.Add(this.BtnDelete);
            this.PnlForBorder.Controls.Add(this.LblVehicleNum);
            this.PnlForBorder.Controls.Add(this.PnlDeleteVehicleBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // TxtVehicleNumberReplacement
            // 
            this.TxtVehicleNumberReplacement.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumberReplacement.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumberReplacement.Location = new System.Drawing.Point(300, 307);
            this.TxtVehicleNumberReplacement.Name = "TxtVehicleNumberReplacement";
            this.TxtVehicleNumberReplacement.Size = new System.Drawing.Size(324, 29);
            this.TxtVehicleNumberReplacement.TabIndex = 31;
            this.TxtVehicleNumberReplacement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblVehicleNumberReplacement
            // 
            this.LblVehicleNumberReplacement.AutoSize = true;
            this.LblVehicleNumberReplacement.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNumberReplacement.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNumberReplacement.Location = new System.Drawing.Point(43, 309);
            this.LblVehicleNumberReplacement.Name = "LblVehicleNumberReplacement";
            this.LblVehicleNumberReplacement.Size = new System.Drawing.Size(251, 25);
            this.LblVehicleNumberReplacement.TabIndex = 30;
            this.LblVehicleNumberReplacement.Text = "Vehicle Number Replacement:";
            // 
            // TxtVehicleNumber
            // 
            this.TxtVehicleNumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVehicleNumber.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtVehicleNumber.Location = new System.Drawing.Point(300, 272);
            this.TxtVehicleNumber.Name = "TxtVehicleNumber";
            this.TxtVehicleNumber.Size = new System.Drawing.Size(324, 29);
            this.TxtVehicleNumber.TabIndex = 29;
            this.TxtVehicleNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.Location = new System.Drawing.Point(540, 342);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 37);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "&Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblVehicleNum
            // 
            this.LblVehicleNum.AutoSize = true;
            this.LblVehicleNum.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVehicleNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblVehicleNum.Location = new System.Drawing.Point(152, 274);
            this.LblVehicleNum.Name = "LblVehicleNum";
            this.LblVehicleNum.Size = new System.Drawing.Size(142, 25);
            this.LblVehicleNum.TabIndex = 24;
            this.LblVehicleNum.Text = "Vehicle Number:";
            // 
            // PnlDeleteVehicleBackgroundImage
            // 
            this.PnlDeleteVehicleBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeleteVehicleBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeleteVehicleBackgroundImage.Controls.Add(this.LblDeleteVehicle);
            this.PnlDeleteVehicleBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeleteVehicleBackgroundImage.Name = "PnlDeleteVehicleBackgroundImage";
            this.PnlDeleteVehicleBackgroundImage.Size = new System.Drawing.Size(716, 156);
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
            // LblDeleteVehicle
            // 
            this.LblDeleteVehicle.AutoSize = true;
            this.LblDeleteVehicle.BackColor = System.Drawing.Color.Transparent;
            this.LblDeleteVehicle.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeleteVehicle.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDeleteVehicle.Location = new System.Drawing.Point(195, 56);
            this.LblDeleteVehicle.Name = "LblDeleteVehicle";
            this.LblDeleteVehicle.Size = new System.Drawing.Size(336, 43);
            this.LblDeleteVehicle.TabIndex = 9;
            this.LblDeleteVehicle.Text = "DELETE VEHICLE";
            // 
            // FrmDeleteVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 506);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDeleteVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeleteVehicleBackgroundImage.ResumeLayout(false);
            this.PnlDeleteVehicleBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeleteVehicleBackgroundImage;
        private System.Windows.Forms.Label LblDeleteVehicle;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeleteVehicleForm;
        private System.Windows.Forms.Label LblVehicleNum;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtVehicleNumber;
        private System.Windows.Forms.TextBox TxtVehicleNumberReplacement;
        private System.Windows.Forms.Label LblVehicleNumberReplacement;
    }
}