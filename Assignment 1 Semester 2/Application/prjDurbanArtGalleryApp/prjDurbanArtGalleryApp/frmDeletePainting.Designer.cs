namespace prjDurbanArtGalleryApp
{
    partial class frmDeletePainting
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbxPaintingID = new System.Windows.Forms.ComboBox();
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
            this.mnuMainBar.Size = new System.Drawing.Size(451, 23);
            this.mnuMainBar.TabIndex = 4;
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
            this.lblPaintingIdNumber.Location = new System.Drawing.Point(96, 48);
            this.lblPaintingIdNumber.Name = "lblPaintingIdNumber";
            this.lblPaintingIdNumber.Size = new System.Drawing.Size(110, 24);
            this.lblPaintingIdNumber.TabIndex = 10;
            this.lblPaintingIdNumber.Text = "Painting ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(175, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbxPaintingID
            // 
            this.cmbxPaintingID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaintingID.FormattingEnabled = true;
            this.cmbxPaintingID.Location = new System.Drawing.Point(239, 51);
            this.cmbxPaintingID.Name = "cmbxPaintingID";
            this.cmbxPaintingID.Size = new System.Drawing.Size(139, 21);
            this.cmbxPaintingID.TabIndex = 16;
            // 
            // frmDeletePainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(451, 121);
            this.Controls.Add(this.cmbxPaintingID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPaintingIdNumber);
            this.Controls.Add(this.mnuMainBar);
            this.Name = "frmDeletePainting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Delete Painting";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.Label lblPaintingIdNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbxPaintingID;
    }
}