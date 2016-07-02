namespace prjDurbanArtGalleryApp
{
    partial class frmAddArtist
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
            this.mnuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.grpOwnerDetails = new System.Windows.Forms.GroupBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtOwnerCellNumber = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.txtOwnerId = new System.Windows.Forms.TextBox();
            this.lblOwnerContactNumber = new System.Windows.Forms.Label();
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mnuMainBar.SuspendLayout();
            this.grpOwnerDetails.SuspendLayout();
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
            this.mnuMainBar.Size = new System.Drawing.Size(538, 23);
            this.mnuMainBar.TabIndex = 1;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHelp});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 19);
            this.mnuFile.Text = "File";
            // 
            // mnuItemHelp
            // 
            this.mnuItemHelp.Name = "mnuItemHelp";
            this.mnuItemHelp.Size = new System.Drawing.Size(99, 22);
            this.mnuItemHelp.Text = "Help";
            // 
            // grpOwnerDetails
            // 
            this.grpOwnerDetails.Controls.Add(this.txtSurname);
            this.grpOwnerDetails.Controls.Add(this.lblSurname);
            this.grpOwnerDetails.Controls.Add(this.txtOwnerCellNumber);
            this.grpOwnerDetails.Controls.Add(this.txtOwnerName);
            this.grpOwnerDetails.Controls.Add(this.txtOwnerId);
            this.grpOwnerDetails.Controls.Add(this.lblOwnerContactNumber);
            this.grpOwnerDetails.Controls.Add(this.lblOwnerName);
            this.grpOwnerDetails.Controls.Add(this.lblOwnerID);
            this.grpOwnerDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOwnerDetails.Location = new System.Drawing.Point(45, 36);
            this.grpOwnerDetails.Name = "grpOwnerDetails";
            this.grpOwnerDetails.Size = new System.Drawing.Size(456, 186);
            this.grpOwnerDetails.TabIndex = 2;
            this.grpOwnerDetails.TabStop = false;
            this.grpOwnerDetails.Text = "Owner Details";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(250, 102);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(189, 20);
            this.txtSurname.TabIndex = 10;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSurname.Location = new System.Drawing.Point(15, 98);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(146, 24);
            this.lblSurname.TabIndex = 9;
            this.lblSurname.Text = "Artist Surname";
            // 
            // txtOwnerCellNumber
            // 
            this.txtOwnerCellNumber.Location = new System.Drawing.Point(250, 137);
            this.txtOwnerCellNumber.MaxLength = 10;
            this.txtOwnerCellNumber.Name = "txtOwnerCellNumber";
            this.txtOwnerCellNumber.Size = new System.Drawing.Size(189, 20);
            this.txtOwnerCellNumber.TabIndex = 8;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(251, 68);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(189, 20);
            this.txtOwnerName.TabIndex = 7;
            // 
            // txtOwnerId
            // 
            this.txtOwnerId.Location = new System.Drawing.Point(251, 32);
            this.txtOwnerId.MaxLength = 11;
            this.txtOwnerId.Name = "txtOwnerId";
            this.txtOwnerId.Size = new System.Drawing.Size(189, 20);
            this.txtOwnerId.TabIndex = 6;
            // 
            // lblOwnerContactNumber
            // 
            this.lblOwnerContactNumber.AutoSize = true;
            this.lblOwnerContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerContactNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerContactNumber.Location = new System.Drawing.Point(15, 133);
            this.lblOwnerContactNumber.Name = "lblOwnerContactNumber";
            this.lblOwnerContactNumber.Size = new System.Drawing.Size(213, 24);
            this.lblOwnerContactNumber.TabIndex = 4;
            this.lblOwnerContactNumber.Text = "Artist Contact Number";
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerName.Location = new System.Drawing.Point(15, 64);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(117, 24);
            this.lblOwnerName.TabIndex = 3;
            this.lblOwnerName.Text = "Artist Name";
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerID.Location = new System.Drawing.Point(15, 28);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(159, 24);
            this.lblOwnerID.TabIndex = 2;
            this.lblOwnerID.Text = "Artist ID number";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(231, 228);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(94, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAddPaintingContinued
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(538, 263);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpOwnerDetails);
            this.Controls.Add(this.mnuMainBar);
            this.Name = "frmAddPaintingContinued";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Add Painting Continued";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.grpOwnerDetails.ResumeLayout(false);
            this.grpOwnerDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHelp;
        private System.Windows.Forms.GroupBox grpOwnerDetails;
        private System.Windows.Forms.Label lblOwnerContactNumber;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.TextBox txtOwnerCellNumber;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.TextBox txtOwnerId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
    }
}