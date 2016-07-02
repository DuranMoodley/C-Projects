namespace prjDurbanArtGalleryApp
{
    partial class frmUpdatePainting
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
            this.txtSectionCode = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtPaintingName = new System.Windows.Forms.TextBox();
            this.txtPaintingID = new System.Windows.Forms.TextBox();
            this.lblPaintingIdNumber = new System.Windows.Forms.Label();
            this.lblSectionCode = new System.Windows.Forms.Label();
            this.lblPaintingName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbxPaintingStatus = new System.Windows.Forms.ComboBox();
            this.lblPaintingStatus = new System.Windows.Forms.Label();
            this.lstPaintingIdNumbers = new System.Windows.Forms.ListBox();
            this.mnuMainBar.SuspendLayout();
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
            this.mnuMainBar.Size = new System.Drawing.Size(705, 23);
            this.mnuMainBar.TabIndex = 2;
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
            // txtSectionCode
            // 
            this.txtSectionCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSectionCode.Enabled = false;
            this.txtSectionCode.Location = new System.Drawing.Point(257, 182);
            this.txtSectionCode.MaxLength = 1;
            this.txtSectionCode.Name = "txtSectionCode";
            this.txtSectionCode.Size = new System.Drawing.Size(189, 20);
            this.txtSectionCode.TabIndex = 16;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Enabled = false;
            this.txtCostPrice.Location = new System.Drawing.Point(257, 143);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(189, 20);
            this.txtCostPrice.TabIndex = 15;
            // 
            // txtPaintingName
            // 
            this.txtPaintingName.Enabled = false;
            this.txtPaintingName.Location = new System.Drawing.Point(257, 102);
            this.txtPaintingName.Name = "txtPaintingName";
            this.txtPaintingName.Size = new System.Drawing.Size(189, 20);
            this.txtPaintingName.TabIndex = 14;
            // 
            // txtPaintingID
            // 
            this.txtPaintingID.Location = new System.Drawing.Point(257, 59);
            this.txtPaintingID.Name = "txtPaintingID";
            this.txtPaintingID.Size = new System.Drawing.Size(189, 20);
            this.txtPaintingID.TabIndex = 13;
            this.txtPaintingID.Text = "Enter ID number. The Click Search";
            // 
            // lblPaintingIdNumber
            // 
            this.lblPaintingIdNumber.AutoSize = true;
            this.lblPaintingIdNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingIdNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingIdNumber.Location = new System.Drawing.Point(12, 59);
            this.lblPaintingIdNumber.Name = "lblPaintingIdNumber";
            this.lblPaintingIdNumber.Size = new System.Drawing.Size(110, 24);
            this.lblPaintingIdNumber.TabIndex = 9;
            this.lblPaintingIdNumber.Text = "Painting ID";
            // 
            // lblSectionCode
            // 
            this.lblSectionCode.AutoSize = true;
            this.lblSectionCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionCode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSectionCode.Location = new System.Drawing.Point(12, 182);
            this.lblSectionCode.Name = "lblSectionCode";
            this.lblSectionCode.Size = new System.Drawing.Size(217, 24);
            this.lblSectionCode.TabIndex = 12;
            this.lblSectionCode.Text = "Painting Section Code";
            // 
            // lblPaintingName
            // 
            this.lblPaintingName.AutoSize = true;
            this.lblPaintingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingName.Location = new System.Drawing.Point(12, 102);
            this.lblPaintingName.Name = "lblPaintingName";
            this.lblPaintingName.Size = new System.Drawing.Size(146, 24);
            this.lblPaintingName.TabIndex = 10;
            this.lblPaintingName.Text = "Painting Name";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCost.Location = new System.Drawing.Point(12, 143);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(243, 24);
            this.lblCost.TabIndex = 11;
            this.lblCost.Text = "Painting Selling Price (R)";
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(16, 260);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(370, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbxPaintingStatus
            // 
            this.cmbxPaintingStatus.Enabled = false;
            this.cmbxPaintingStatus.FormattingEnabled = true;
            this.cmbxPaintingStatus.Items.AddRange(new object[] {
            "Sold",
            "unavailable"});
            this.cmbxPaintingStatus.Location = new System.Drawing.Point(256, 218);
            this.cmbxPaintingStatus.Name = "cmbxPaintingStatus";
            this.cmbxPaintingStatus.Size = new System.Drawing.Size(189, 21);
            this.cmbxPaintingStatus.TabIndex = 19;
            // 
            // lblPaintingStatus
            // 
            this.lblPaintingStatus.AutoSize = true;
            this.lblPaintingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingStatus.Location = new System.Drawing.Point(12, 218);
            this.lblPaintingStatus.Name = "lblPaintingStatus";
            this.lblPaintingStatus.Size = new System.Drawing.Size(147, 24);
            this.lblPaintingStatus.TabIndex = 20;
            this.lblPaintingStatus.Text = "Painting Status";
            // 
            // lstPaintingIdNumbers
            // 
            this.lstPaintingIdNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPaintingIdNumbers.FormattingEnabled = true;
            this.lstPaintingIdNumbers.HorizontalScrollbar = true;
            this.lstPaintingIdNumbers.ItemHeight = 20;
            this.lstPaintingIdNumbers.Location = new System.Drawing.Point(462, 59);
            this.lstPaintingIdNumbers.Name = "lstPaintingIdNumbers";
            this.lstPaintingIdNumbers.Size = new System.Drawing.Size(231, 224);
            this.lstPaintingIdNumbers.Sorted = true;
            this.lstPaintingIdNumbers.TabIndex = 21;
            this.lstPaintingIdNumbers.SelectedIndexChanged += new System.EventHandler(this.lstPaintingIdNumbers_SelectedIndexChanged);
            // 
            // frmUpdatePainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(705, 295);
            this.Controls.Add(this.lstPaintingIdNumbers);
            this.Controls.Add(this.cmbxPaintingStatus);
            this.Controls.Add(this.lblPaintingStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSectionCode);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtPaintingName);
            this.Controls.Add(this.txtPaintingID);
            this.Controls.Add(this.lblPaintingIdNumber);
            this.Controls.Add(this.lblSectionCode);
            this.Controls.Add(this.lblPaintingName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUpdatePainting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Update Painting";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.TextBox txtSectionCode;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtPaintingName;
        private System.Windows.Forms.TextBox txtPaintingID;
        private System.Windows.Forms.Label lblPaintingIdNumber;
        private System.Windows.Forms.Label lblSectionCode;
        private System.Windows.Forms.Label lblPaintingName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbxPaintingStatus;
        private System.Windows.Forms.Label lblPaintingStatus;
        private System.Windows.Forms.ListBox lstPaintingIdNumbers;
    }
}