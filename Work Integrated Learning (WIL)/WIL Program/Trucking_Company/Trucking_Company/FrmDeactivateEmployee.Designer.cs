namespace Trucking_Company
{
    partial class FrmDeactivateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeactivateEmployee));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.BtnDeactivate = new System.Windows.Forms.Button();
            this.CmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.LblEmployeeID = new System.Windows.Forms.Label();
            this.PnlDeactivateEmployeeBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblDeactivateEmployee = new System.Windows.Forms.Label();
            this.TipDeactivateEmployee = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlDeactivateEmployeeBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.BtnDeactivate);
            this.PnlForBorder.Controls.Add(this.CmbEmployeeID);
            this.PnlForBorder.Controls.Add(this.LblEmployeeID);
            this.PnlForBorder.Controls.Add(this.PnlDeactivateEmployeeBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // BtnDeactivate
            // 
            this.BtnDeactivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeactivate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeactivate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnDeactivate.Location = new System.Drawing.Point(485, 347);
            this.BtnDeactivate.Name = "BtnDeactivate";
            this.BtnDeactivate.Size = new System.Drawing.Size(93, 37);
            this.BtnDeactivate.TabIndex = 35;
            this.BtnDeactivate.Text = "&Deactivate";
            this.BtnDeactivate.UseVisualStyleBackColor = true;
            this.BtnDeactivate.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CmbEmployeeID
            // 
            this.CmbEmployeeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbEmployeeID.FormattingEnabled = true;
            this.CmbEmployeeID.Location = new System.Drawing.Point(282, 310);
            this.CmbEmployeeID.Name = "CmbEmployeeID";
            this.CmbEmployeeID.Size = new System.Drawing.Size(296, 31);
            this.CmbEmployeeID.TabIndex = 34;
            // 
            // LblEmployeeID
            // 
            this.LblEmployeeID.AutoSize = true;
            this.LblEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeID.Location = new System.Drawing.Point(160, 312);
            this.LblEmployeeID.Name = "LblEmployeeID";
            this.LblEmployeeID.Size = new System.Drawing.Size(116, 25);
            this.LblEmployeeID.TabIndex = 33;
            this.LblEmployeeID.Text = "Employee ID:";
            // 
            // PnlDeactivateEmployeeBackgroundImage
            // 
            this.PnlDeactivateEmployeeBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlDeactivateEmployeeBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlDeactivateEmployeeBackgroundImage.Controls.Add(this.LblDeactivateEmployee);
            this.PnlDeactivateEmployeeBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlDeactivateEmployeeBackgroundImage.Name = "PnlDeactivateEmployeeBackgroundImage";
            this.PnlDeactivateEmployeeBackgroundImage.Size = new System.Drawing.Size(716, 206);
            this.PnlDeactivateEmployeeBackgroundImage.TabIndex = 0;
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
            this.TipDeactivateEmployee.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblDeactivateEmployee
            // 
            this.LblDeactivateEmployee.AutoSize = true;
            this.LblDeactivateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.LblDeactivateEmployee.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeactivateEmployee.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblDeactivateEmployee.Location = new System.Drawing.Point(121, 74);
            this.LblDeactivateEmployee.Name = "LblDeactivateEmployee";
            this.LblDeactivateEmployee.Size = new System.Drawing.Size(468, 43);
            this.LblDeactivateEmployee.TabIndex = 13;
            this.LblDeactivateEmployee.Text = "DEACTIVATE EMPLOYEE";
            // 
            // FrmDeactivateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmDeactivateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlDeactivateEmployeeBackgroundImage.ResumeLayout(false);
            this.PnlDeactivateEmployeeBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlDeactivateEmployeeBackgroundImage;
        private System.Windows.Forms.Label LblDeactivateEmployee;
        private System.Windows.Forms.ComboBox CmbEmployeeID;
        private System.Windows.Forms.Label LblEmployeeID;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipDeactivateEmployee;
        private System.Windows.Forms.Button BtnDeactivate;
    }
}