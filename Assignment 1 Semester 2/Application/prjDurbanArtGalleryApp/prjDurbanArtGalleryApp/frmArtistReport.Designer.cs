namespace prjDurbanArtGalleryApp
{
    partial class frmArtistReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaintingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ownerds = new prjDurbanArtGalleryApp.Ownerds();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.rpvOwners = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblOwnerID = new System.Windows.Forms.Label();
            this.cmbxArtistId = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.PaintingsTableAdapter = new prjDurbanArtGalleryApp.OwnerdsTableAdapters.PaintingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ownerds)).BeginInit();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PaintingsBindingSource
            // 
            this.PaintingsBindingSource.DataMember = "Paintings";
            this.PaintingsBindingSource.DataSource = this.Ownerds;
            // 
            // Ownerds
            // 
            this.Ownerds.DataSetName = "Ownerds";
            this.Ownerds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.BackColor = System.Drawing.Color.IndianRed;
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMainBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(662, 23);
            this.mnuMainBar.TabIndex = 6;
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
            // rpvOwners
            // 
            reportDataSource1.Name = "Owner";
            reportDataSource1.Value = this.PaintingsBindingSource;
            this.rpvOwners.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvOwners.LocalReport.ReportEmbeddedResource = "prjDurbanArtGalleryApp.rptOwners.rdlc";
            this.rpvOwners.Location = new System.Drawing.Point(0, 78);
            this.rpvOwners.Name = "rpvOwners";
            this.rpvOwners.Size = new System.Drawing.Size(662, 344);
            this.rpvOwners.TabIndex = 7;
            // 
            // lblOwnerID
            // 
            this.lblOwnerID.AutoSize = true;
            this.lblOwnerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOwnerID.Location = new System.Drawing.Point(78, 37);
            this.lblOwnerID.Name = "lblOwnerID";
            this.lblOwnerID.Size = new System.Drawing.Size(159, 24);
            this.lblOwnerID.TabIndex = 8;
            this.lblOwnerID.Text = "Artist ID number";
            // 
            // cmbxArtistId
            // 
            this.cmbxArtistId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxArtistId.FormattingEnabled = true;
            this.cmbxArtistId.Location = new System.Drawing.Point(280, 40);
            this.cmbxArtistId.Name = "cmbxArtistId";
            this.cmbxArtistId.Size = new System.Drawing.Size(215, 21);
            this.cmbxArtistId.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(540, 40);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 22);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // PaintingsTableAdapter
            // 
            this.PaintingsTableAdapter.ClearBeforeFill = true;
            // 
            // frmArtistReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(662, 420);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbxArtistId);
            this.Controls.Add(this.lblOwnerID);
            this.Controls.Add(this.rpvOwners);
            this.Controls.Add(this.mnuMainBar);
            this.Name = "frmArtistReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery - Artist Report";
            ((System.ComponentModel.ISupportInitialize)(this.PaintingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ownerds)).EndInit();
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private Microsoft.Reporting.WinForms.ReportViewer rpvOwners;
        private System.Windows.Forms.Label lblOwnerID;
        private System.Windows.Forms.ComboBox cmbxArtistId;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.BindingSource PaintingsBindingSource;
        private Ownerds Ownerds;
        private OwnerdsTableAdapters.PaintingsTableAdapter PaintingsTableAdapter;
    }
}