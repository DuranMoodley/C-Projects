namespace Trucking_Company
{
    partial class FrmEmployeeHoursWorked
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeHoursWorked));
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.LblTypeOfEmployee = new System.Windows.Forms.Label();
            this.CmbTypeOfEmployee = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TxtHoursWorked = new System.Windows.Forms.TextBox();
            this.LblHoursWorked = new System.Windows.Forms.Label();
            this.CmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.LblEmployeeID = new System.Windows.Forms.Label();
            this.PnlAddEmployeeHoursWorkedBackgroundImage = new System.Windows.Forms.Panel();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblEmployeeHoursWorked = new System.Windows.Forms.Label();
            this.TipAddEmployeeHoursWorkedForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder.SuspendLayout();
            this.PnlAddEmployeeHoursWorkedBackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.LblTypeOfEmployee);
            this.PnlForBorder.Controls.Add(this.CmbTypeOfEmployee);
            this.PnlForBorder.Controls.Add(this.BtnSubmit);
            this.PnlForBorder.Controls.Add(this.TxtHoursWorked);
            this.PnlForBorder.Controls.Add(this.LblHoursWorked);
            this.PnlForBorder.Controls.Add(this.CmbEmployeeID);
            this.PnlForBorder.Controls.Add(this.LblEmployeeID);
            this.PnlForBorder.Controls.Add(this.PnlAddEmployeeHoursWorkedBackgroundImage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 0;
            // 
            // LblTypeOfEmployee
            // 
            this.LblTypeOfEmployee.AutoSize = true;
            this.LblTypeOfEmployee.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTypeOfEmployee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblTypeOfEmployee.Location = new System.Drawing.Point(93, 285);
            this.LblTypeOfEmployee.Name = "LblTypeOfEmployee";
            this.LblTypeOfEmployee.Size = new System.Drawing.Size(160, 25);
            this.LblTypeOfEmployee.TabIndex = 30;
            this.LblTypeOfEmployee.Text = "Type of Employee:";
            // 
            // CmbTypeOfEmployee
            // 
            this.CmbTypeOfEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.CmbTypeOfEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTypeOfEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTypeOfEmployee.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTypeOfEmployee.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbTypeOfEmployee.FormattingEnabled = true;
            this.CmbTypeOfEmployee.Items.AddRange(new object[] {
            "Mechanic",
            "Driver"});
            this.CmbTypeOfEmployee.Location = new System.Drawing.Point(259, 283);
            this.CmbTypeOfEmployee.Name = "CmbTypeOfEmployee";
            this.CmbTypeOfEmployee.Size = new System.Drawing.Size(376, 31);
            this.CmbTypeOfEmployee.TabIndex = 29;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.Color.White;
            this.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSubmit.Location = new System.Drawing.Point(551, 392);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 37);
            this.BtnSubmit.TabIndex = 28;
            this.BtnSubmit.Text = "&Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TxtHoursWorked
            // 
            this.TxtHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHoursWorked.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtHoursWorked.Location = new System.Drawing.Point(259, 357);
            this.TxtHoursWorked.MaxLength = 2;
            this.TxtHoursWorked.Name = "TxtHoursWorked";
            this.TxtHoursWorked.Size = new System.Drawing.Size(376, 29);
            this.TxtHoursWorked.TabIndex = 26;
            this.TxtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblHoursWorked
            // 
            this.LblHoursWorked.AutoSize = true;
            this.LblHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoursWorked.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblHoursWorked.Location = new System.Drawing.Point(121, 359);
            this.LblHoursWorked.Name = "LblHoursWorked";
            this.LblHoursWorked.Size = new System.Drawing.Size(132, 25);
            this.LblHoursWorked.TabIndex = 25;
            this.LblHoursWorked.Text = "Hours worked: ";
            // 
            // CmbEmployeeID
            // 
            this.CmbEmployeeID.BackColor = System.Drawing.SystemColors.Window;
            this.CmbEmployeeID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CmbEmployeeID.FormattingEnabled = true;
            this.CmbEmployeeID.Location = new System.Drawing.Point(259, 320);
            this.CmbEmployeeID.Name = "CmbEmployeeID";
            this.CmbEmployeeID.Size = new System.Drawing.Size(376, 31);
            this.CmbEmployeeID.TabIndex = 24;
            this.CmbEmployeeID.DropDown += new System.EventHandler(this.CmbEmployeeID_DropDown);
            // 
            // LblEmployeeID
            // 
            this.LblEmployeeID.AutoSize = true;
            this.LblEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblEmployeeID.Location = new System.Drawing.Point(137, 322);
            this.LblEmployeeID.Name = "LblEmployeeID";
            this.LblEmployeeID.Size = new System.Drawing.Size(116, 25);
            this.LblEmployeeID.TabIndex = 23;
            this.LblEmployeeID.Text = "Employee ID:";
            // 
            // PnlAddEmployeeHoursWorkedBackgroundImage
            // 
            this.PnlAddEmployeeHoursWorkedBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlAddEmployeeHoursWorkedBackgroundImage.Controls.Add(this.BtnReturn);
            this.PnlAddEmployeeHoursWorkedBackgroundImage.Controls.Add(this.LblEmployeeHoursWorked);
            this.PnlAddEmployeeHoursWorkedBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlAddEmployeeHoursWorkedBackgroundImage.Name = "PnlAddEmployeeHoursWorkedBackgroundImage";
            this.PnlAddEmployeeHoursWorkedBackgroundImage.Size = new System.Drawing.Size(716, 206);
            this.PnlAddEmployeeHoursWorkedBackgroundImage.TabIndex = 0;
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
            this.TipAddEmployeeHoursWorkedForm.SetToolTip(this.BtnReturn, "Return to menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblEmployeeHoursWorked
            // 
            this.LblEmployeeHoursWorked.AutoSize = true;
            this.LblEmployeeHoursWorked.BackColor = System.Drawing.Color.Transparent;
            this.LblEmployeeHoursWorked.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmployeeHoursWorked.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblEmployeeHoursWorked.Location = new System.Drawing.Point(79, 79);
            this.LblEmployeeHoursWorked.Name = "LblEmployeeHoursWorked";
            this.LblEmployeeHoursWorked.Size = new System.Drawing.Size(539, 43);
            this.LblEmployeeHoursWorked.TabIndex = 11;
            this.LblEmployeeHoursWorked.Text = "EMPLOYEE HOURS WORKED";
            // 
            // FrmEmployeeHoursWorked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmEmployeeHoursWorked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.PnlAddEmployeeHoursWorkedBackgroundImage.ResumeLayout(false);
            this.PnlAddEmployeeHoursWorkedBackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlAddEmployeeHoursWorkedBackgroundImage;
        private System.Windows.Forms.Label LblEmployeeHoursWorked;
        private System.Windows.Forms.ComboBox CmbEmployeeID;
        private System.Windows.Forms.Label LblEmployeeID;
        private System.Windows.Forms.TextBox TxtHoursWorked;
        private System.Windows.Forms.Label LblHoursWorked;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblTypeOfEmployee;
        private System.Windows.Forms.ComboBox CmbTypeOfEmployee;
        private System.Windows.Forms.ToolTip TipAddEmployeeHoursWorkedForm;
    }
}