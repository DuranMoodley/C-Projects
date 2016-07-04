namespace Trucking_Company
{
    partial class FrmUpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateEmployee));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.CmbEmployeeStatus = new System.Windows.Forms.ComboBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtEmployeeID = new System.Windows.Forms.TextBox();
            this.LblEmployeeStatus = new System.Windows.Forms.Label();
            this.LblEmployeeSurname = new System.Windows.Forms.Label();
            this.LblEmployeeName = new System.Windows.Forms.Label();
            this.LblEmployeeID = new System.Windows.Forms.Label();
            this.PnlUpdateEmployeeBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblUpdateEmployee = new System.Windows.Forms.Label();
            this.TipUpdateEmployeeForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlUpdateEmployeeBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.CmbEmployeeStatus);
            this.PnlForBorder.Controls.Add(this.BtnUpdate);
            this.PnlForBorder.Controls.Add(this.BtnSearch);
            this.PnlForBorder.Controls.Add(this.TxtEmployeeSurname);
            this.PnlForBorder.Controls.Add(this.TxtEmployeeName);
            this.PnlForBorder.Controls.Add(this.TxtEmployeeID);
            this.PnlForBorder.Controls.Add(this.LblEmployeeStatus);
            this.PnlForBorder.Controls.Add(this.LblEmployeeSurname);
            this.PnlForBorder.Controls.Add(this.LblEmployeeName);
            this.PnlForBorder.Controls.Add(this.LblEmployeeID);
            this.PnlForBorder.Controls.Add(this.PnlUpdateEmployeeBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // CmbEmployeeStatus
            // 
            this.CmbEmployeeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmployeeStatus.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmployeeStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbEmployeeStatus.FormattingEnabled = true;
            this.CmbEmployeeStatus.Items.AddRange(new object[] {
            "Active",
            "Disable"});
            this.CmbEmployeeStatus.Location = new System.Drawing.Point(231, 367);
            this.CmbEmployeeStatus.Name = "CmbEmployeeStatus";
            this.CmbEmployeeStatus.Size = new System.Drawing.Size(388, 31);
            this.CmbEmployeeStatus.TabIndex = 35;
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
            this.BtnUpdate.Location = new System.Drawing.Point(445, 404);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 37);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "&Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
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
            this.BtnSearch.Location = new System.Drawing.Point(535, 404);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 37);
            this.BtnSearch.TabIndex = 29;
            this.BtnSearch.Text = "&Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtEmployeeSurname
            // 
            this.TxtEmployeeSurname.Enabled = false;
            this.TxtEmployeeSurname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeSurname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEmployeeSurname.Location = new System.Drawing.Point(231, 332);
            this.TxtEmployeeSurname.Name = "TxtEmployeeSurname";
            this.TxtEmployeeSurname.Size = new System.Drawing.Size(388, 29);
            this.TxtEmployeeSurname.TabIndex = 7;
            this.TxtEmployeeSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Enabled = false;
            this.TxtEmployeeName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEmployeeName.Location = new System.Drawing.Point(231, 297);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(388, 29);
            this.TxtEmployeeName.TabIndex = 6;
            this.TxtEmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtEmployeeID
            // 
            this.TxtEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtEmployeeID.Location = new System.Drawing.Point(231, 262);
            this.TxtEmployeeID.Name = "TxtEmployeeID";
            this.TxtEmployeeID.Size = new System.Drawing.Size(388, 29);
            this.TxtEmployeeID.TabIndex = 5;
            this.TxtEmployeeID.Text = "Please enter your ID number and click search";
            this.TxtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmployeeStatus
            // 
            this.LblEmployeeStatus.AutoSize = true;
            this.LblEmployeeStatus.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeStatus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeStatus.Location = new System.Drawing.Point(75, 369);
            this.LblEmployeeStatus.Name = "LblEmployeeStatus";
            this.LblEmployeeStatus.Size = new System.Drawing.Size(150, 25);
            this.LblEmployeeStatus.TabIndex = 4;
            this.LblEmployeeStatus.Text = "Employee Status:";
            // 
            // LblEmployeeSurname
            // 
            this.LblEmployeeSurname.AutoSize = true;
            this.LblEmployeeSurname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeSurname.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeSurname.Location = new System.Drawing.Point(137, 334);
            this.LblEmployeeSurname.Name = "LblEmployeeSurname";
            this.LblEmployeeSurname.Size = new System.Drawing.Size(88, 25);
            this.LblEmployeeSurname.TabIndex = 3;
            this.LblEmployeeSurname.Text = "Surname:";
            // 
            // LblEmployeeName
            // 
            this.LblEmployeeName.AutoSize = true;
            this.LblEmployeeName.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeName.Location = new System.Drawing.Point(162, 299);
            this.LblEmployeeName.Name = "LblEmployeeName";
            this.LblEmployeeName.Size = new System.Drawing.Size(63, 25);
            this.LblEmployeeName.TabIndex = 2;
            this.LblEmployeeName.Text = "Name:";
            // 
            // LblEmployeeID
            // 
            this.LblEmployeeID.AutoSize = true;
            this.LblEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeID.Location = new System.Drawing.Point(192, 264);
            this.LblEmployeeID.Name = "LblEmployeeID";
            this.LblEmployeeID.Size = new System.Drawing.Size(33, 25);
            this.LblEmployeeID.TabIndex = 1;
            this.LblEmployeeID.Text = "ID:";
            // 
            // PnlUpdateEmployeeBackgroundImage
            // 
            this.PnlUpdateEmployeeBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlUpdateEmployeeBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlUpdateEmployeeBackgroundImage.Controls.Add(this.LblUpdateEmployee);
            this.PnlUpdateEmployeeBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlUpdateEmployeeBackgroundImage.Name = "PnlUpdateEmployeeBackgroundImage";
            this.PnlUpdateEmployeeBackgroundImage.Size = new System.Drawing.Size(716, 206);
            this.PnlUpdateEmployeeBackgroundImage.TabIndex = 0;
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
            this.TipUpdateEmployeeForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblUpdateEmployee
            // 
            this.LblUpdateEmployee.AutoSize = true;
            this.LblUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.LblUpdateEmployee.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdateEmployee.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblUpdateEmployee.Location = new System.Drawing.Point(168, 76);
            this.LblUpdateEmployee.Name = "LblUpdateEmployee";
            this.LblUpdateEmployee.Size = new System.Drawing.Size(380, 43);
            this.LblUpdateEmployee.TabIndex = 12;
            this.LblUpdateEmployee.Text = "UPDATE EMPLOYEE";
            // 
            // FrmUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmUpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlUpdateEmployeeBackgroundImage.ResumeLayout(false);
            this.PnlUpdateEmployeeBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlUpdateEmployeeBackgroundImage;
        private System.Windows.Forms.Label LblUpdateEmployee;
        private System.Windows.Forms.Label LblEmployeeStatus;
        private System.Windows.Forms.Label LblEmployeeSurname;
        private System.Windows.Forms.Label LblEmployeeName;
        private System.Windows.Forms.Label LblEmployeeID;
        private System.Windows.Forms.TextBox TxtEmployeeSurname;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtEmployeeID;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ComboBox CmbEmployeeStatus;
        private System.Windows.Forms.ToolTip TipUpdateEmployeeForm;
    }
}