namespace prjDurbanArtGalleryApp
{
    partial class frmPaintingReport
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
            this.paintingds = new prjDurbanArtGalleryApp.Paintingds();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.rpvPaintings = new Microsoft.Reporting.WinForms.ReportViewer();
            this.paintingdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaintingsTableAdapter = new prjDurbanArtGalleryApp.PaintingdsTableAdapters.PaintingsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaintingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingds)).BeginInit();
            this.mnuMainBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingdsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintingsBindingSource
            // 
            this.PaintingsBindingSource.DataMember = "Paintings";
            this.PaintingsBindingSource.DataSource = this.paintingds;
            // 
            // paintingds
            // 
            this.paintingds.DataSetName = "Paintingds";
            this.paintingds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.BackColor = System.Drawing.Color.IndianRed;
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMainBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(803, 23);
            this.mnuMainBar.TabIndex = 5;
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
            // rpvPaintings
            // 
            this.rpvPaintings.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Paintings";
            reportDataSource1.Value = this.PaintingsBindingSource;
            this.rpvPaintings.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvPaintings.LocalReport.ReportEmbeddedResource = "prjDurbanArtGalleryApp.rptPaintings.rdlc";
            this.rpvPaintings.Location = new System.Drawing.Point(0, 23);
            this.rpvPaintings.Name = "rpvPaintings";
            this.rpvPaintings.Size = new System.Drawing.Size(803, 443);
            this.rpvPaintings.TabIndex = 6;
            // 
            // paintingdsBindingSource
            // 
            this.paintingdsBindingSource.DataSource = this.paintingds;
            this.paintingdsBindingSource.Position = 0;
            // 
            // PaintingsTableAdapter
            // 
            this.PaintingsTableAdapter.ClearBeforeFill = true;
            // 
            // frmPaintingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(803, 466);
            this.Controls.Add(this.rpvPaintings);
            this.Controls.Add(this.mnuMainBar);
            this.Name = "frmPaintingReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery- Painting Report";
            this.Load += new System.EventHandler(this.frmPaintingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaintingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintingds)).EndInit();
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintingdsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private Microsoft.Reporting.WinForms.ReportViewer rpvPaintings;
        private System.Windows.Forms.BindingSource paintingdsBindingSource;
        private Paintingds paintingds;
        private System.Windows.Forms.BindingSource PaintingsBindingSource;
        private PaintingdsTableAdapters.PaintingsTableAdapter PaintingsTableAdapter;
    }
}