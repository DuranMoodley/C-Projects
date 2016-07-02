namespace prjDurbanArtGalleryApp
{
    partial class frmUpdateOwner
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
            this.txtOwnerCellNumber = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblOwnerContactNumber = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.cmbxOwnerId = new System.Windows.Forms.ComboBox();
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
            this.mnuMainBar.Size = new System.Drawing.Size(488, 23);
            this.mnuMainBar.TabIndex = 3;
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
            // txtOwnerCellNumber
            // 
            this.txtOwnerCellNumber.Enabled = false;
            this.txtOwnerCellNumber.Location = new System.Drawing.Point(258, 163);
            this.txtOwnerCellNumber.MaxLength = 10;
            this.txtOwnerCellNumber.Name = "txtOwnerCellNumber";
            this.txtOwnerCellNumber.Size = new System.Drawing.Size(218, 20);
            this.txtOwnerCellNumber.TabIndex = 14;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Location = new System.Drawing.Point(258, 95);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(218, 20);
            this.txtOwnerName.TabIndex = 13;
            // 
            // lblOwnerContactNumber
            // 
            this.lblOwnerContactNumber.AutoSize = true;
            this.lblOwnerContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerContactNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerContactNumber.Location = new System.Drawing.Point(22, 163);
            this.lblOwnerContactNumber.Name = "lblOwnerContactNumber";
            this.lblOwnerContactNumber.Size = new System.Drawing.Size(213, 24);
            this.lblOwnerContactNumber.TabIndex = 11;
            this.lblOwnerContactNumber.Text = "Artist Contact Number";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerName.Location = new System.Drawing.Point(22, 91);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(117, 24);
            this.lblOwnerName.TabIndex = 10;
            this.lblOwnerName.Text = "Artist Name";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerID.Location = new System.Drawing.Point(22, 55);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(159, 24);
            this.lblOwnerID.TabIndex = 9;
            this.lblOwnerID.Text = "Artist ID number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(400, 203);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(26, 203);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSurname.Location = new System.Drawing.Point(22, 125);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(146, 24);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Text = "Artist Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(258, 129);
            this.txtSurname.MaxLength = 10;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(218, 20);
            this.txtSurname.TabIndex = 22;
            // 
            // cmbxOwnerId
            // 
            this.cmbxOwnerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOwnerId.FormattingEnabled = true;
            this.cmbxOwnerId.Location = new System.Drawing.Point(258, 60);
            this.cmbxOwnerId.Name = "cmbxOwnerId";
            this.cmbxOwnerId.Size = new System.Drawing.Size(218, 21);
            this.cmbxOwnerId.TabIndex = 23;
            // 
            // frmUpdateOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(488, 234);
            this.Controls.Add(this.cmbxOwnerId);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtOwnerCellNumber);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerContactNumber);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUpdateOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Update Artist";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.TextBox txtOwnerCellNumber;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblOwnerContactNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.ComboBox cmbxOwnerId;
    }
}