namespace prjDurbanArtGalleryApp
{
    partial class frmSearchPainting
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
            this.lblPaintingName = new System.Windows.Forms.Label();
            this.txtPaintingName = new System.Windows.Forms.TextBox();
            this.dgvPainting = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuMainBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainting)).BeginInit();
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
            this.mnuMainBar.Size = new System.Drawing.Size(594, 23);
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
            // lblPaintingName
            // 
            this.lblPaintingName.AutoSize = true;
            this.lblPaintingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaintingName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPaintingName.Location = new System.Drawing.Point(37, 43);
            this.lblPaintingName.Name = "lblPaintingName";
            this.lblPaintingName.Size = new System.Drawing.Size(202, 24);
            this.lblPaintingName.TabIndex = 11;
            this.lblPaintingName.Text = "Enter Painting Name";
            // 
            // txtPaintingName
            // 
            this.txtPaintingName.Location = new System.Drawing.Point(245, 47);
            this.txtPaintingName.Name = "txtPaintingName";
            this.txtPaintingName.Size = new System.Drawing.Size(189, 20);
            this.txtPaintingName.TabIndex = 15;
            // 
            // dgvPainting
            // 
            this.dgvPainting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPainting.Location = new System.Drawing.Point(41, 75);
            this.dgvPainting.Name = "dgvPainting";
            this.dgvPainting.Size = new System.Drawing.Size(541, 150);
            this.dgvPainting.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(506, 231);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSearchPainting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPainting);
            this.Controls.Add(this.txtPaintingName);
            this.Controls.Add(this.lblPaintingName);
            this.Controls.Add(this.mnuMainBar);
            this.Name = "frmSearchPainting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application - Search Painting";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPainting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.Label lblPaintingName;
        private System.Windows.Forms.TextBox txtPaintingName;
        private System.Windows.Forms.DataGridView dgvPainting;
        private System.Windows.Forms.Button btnSearch;
    }
}