namespace prjDurbanArtGalleryApp
{
    partial class frmAddPainting
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
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPaintingIdNumber = new System.Windows.Forms.Label();
            this.lblPaintingName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSectionCode = new System.Windows.Forms.Label();
            this.grbPaintingDetails = new System.Windows.Forms.GroupBox();
            this.cmbxSectionCode = new System.Windows.Forms.ComboBox();
            this.cmbxPaintingStatus = new System.Windows.Forms.ComboBox();
            this.lblPaintingStatus = new System.Windows.Forms.Label();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtPaintingName = new System.Windows.Forms.TextBox();
            this.txtPaintingID = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.mnuMainBar.SuspendLayout();
            this.grbPaintingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.BackColor = System.Drawing.Color.IndianRed;
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMainBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(561, 23);
            this.mnuMainBar.TabIndex = 0;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 19);
            this.mnuFile.Text = "File";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(99, 22);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.mnuItemBack_Click);
            // 
            // lblPaintingIdNumber
            // 
            this.lblPaintingIdNumber.AutoSize = true;
            this.lblPaintingIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingIdNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingIdNumber.Location = new System.Drawing.Point(24, 33);
            this.lblPaintingIdNumber.Name = "lblPaintingIdNumber";
            this.lblPaintingIdNumber.Size = new System.Drawing.Size(110, 24);
            this.lblPaintingIdNumber.TabIndex = 1;
            this.lblPaintingIdNumber.Text = "Painting ID";
            // 
            // lblPaintingName
            // 
            this.lblPaintingName.AutoSize = true;
            this.lblPaintingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingName.Location = new System.Drawing.Point(24, 76);
            this.lblPaintingName.Name = "lblPaintingName";
            this.lblPaintingName.Size = new System.Drawing.Size(146, 24);
            this.lblPaintingName.TabIndex = 2;
            this.lblPaintingName.Text = "Painting Name";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCost.Location = new System.Drawing.Point(24, 117);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(209, 24);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Painting Selling Price";
            // 
            // lblSectionCode
            // 
            this.lblSectionCode.AutoSize = true;
            this.lblSectionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSectionCode.Location = new System.Drawing.Point(24, 152);
            this.lblSectionCode.Name = "lblSectionCode";
            this.lblSectionCode.Size = new System.Drawing.Size(217, 24);
            this.lblSectionCode.TabIndex = 4;
            this.lblSectionCode.Text = "Painting Section Code";
            // 
            // grbPaintingDetails
            // 
            this.grbPaintingDetails.Controls.Add(this.cmbxSectionCode);
            this.grbPaintingDetails.Controls.Add(this.cmbxPaintingStatus);
            this.grbPaintingDetails.Controls.Add(this.lblPaintingStatus);
            this.grbPaintingDetails.Controls.Add(this.txtCostPrice);
            this.grbPaintingDetails.Controls.Add(this.txtPaintingName);
            this.grbPaintingDetails.Controls.Add(this.txtPaintingID);
            this.grbPaintingDetails.Controls.Add(this.lblPaintingIdNumber);
            this.grbPaintingDetails.Controls.Add(this.lblSectionCode);
            this.grbPaintingDetails.Controls.Add(this.lblPaintingName);
            this.grbPaintingDetails.Controls.Add(this.lblCost);
            this.grbPaintingDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbPaintingDetails.Location = new System.Drawing.Point(37, 48);
            this.grbPaintingDetails.Name = "grbPaintingDetails";
            this.grbPaintingDetails.Size = new System.Drawing.Size(483, 227);
            this.grbPaintingDetails.TabIndex = 5;
            this.grbPaintingDetails.TabStop = false;
            this.grbPaintingDetails.Text = "Painting Details";
            // 
            // cmbxSectionCode
            // 
            this.cmbxSectionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSectionCode.FormattingEnabled = true;
            this.cmbxSectionCode.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbxSectionCode.Location = new System.Drawing.Point(257, 152);
            this.cmbxSectionCode.Name = "cmbxSectionCode";
            this.cmbxSectionCode.Size = new System.Drawing.Size(189, 21);
            this.cmbxSectionCode.TabIndex = 10;
            // 
            // cmbxPaintingStatus
            // 
            this.cmbxPaintingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaintingStatus.FormattingEnabled = true;
            this.cmbxPaintingStatus.Items.AddRange(new object[] {
            "Sold",
            "Available"});
            this.cmbxPaintingStatus.Location = new System.Drawing.Point(257, 190);
            this.cmbxPaintingStatus.Name = "cmbxPaintingStatus";
            this.cmbxPaintingStatus.Size = new System.Drawing.Size(189, 21);
            this.cmbxPaintingStatus.TabIndex = 7;
            // 
            // lblPaintingStatus
            // 
            this.lblPaintingStatus.AutoSize = true;
            this.lblPaintingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingStatus.Location = new System.Drawing.Point(24, 190);
            this.lblPaintingStatus.Name = "lblPaintingStatus";
            this.lblPaintingStatus.Size = new System.Drawing.Size(147, 24);
            this.lblPaintingStatus.TabIndex = 9;
            this.lblPaintingStatus.Text = "Painting Status";
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Location = new System.Drawing.Point(257, 117);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(189, 20);
            this.txtCostPrice.TabIndex = 3;
            // 
            // txtPaintingName
            // 
            this.txtPaintingName.Location = new System.Drawing.Point(257, 76);
            this.txtPaintingName.Name = "txtPaintingName";
            this.txtPaintingName.Size = new System.Drawing.Size(189, 20);
            this.txtPaintingName.TabIndex = 2;
            // 
            // txtPaintingID
            // 
            this.txtPaintingID.Location = new System.Drawing.Point(257, 33);
            this.txtPaintingID.Name = "txtPaintingID";
            this.txtPaintingID.Size = new System.Drawing.Size(189, 20);
            this.txtPaintingID.TabIndex = 1;
            this.txtPaintingID.Text = "Click this Box to Generate ID";
            this.txtPaintingID.MouseEnter += new System.EventHandler(this.txtPaintingID_MouseEnter);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(204, 281);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmAddPainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(561, 316);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbPaintingDetails);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmAddPainting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Add Painting";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.grbPaintingDetails.ResumeLayout(false);
            this.grbPaintingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.Label lblPaintingIdNumber;
        private System.Windows.Forms.Label lblPaintingName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSectionCode;
        private System.Windows.Forms.GroupBox grbPaintingDetails;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtPaintingName;
        private System.Windows.Forms.TextBox txtPaintingID;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPaintingStatus;
        private System.Windows.Forms.ComboBox cmbxPaintingStatus;
        private System.Windows.Forms.ComboBox cmbxSectionCode;
    }
}