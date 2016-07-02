namespace prjDurbanArtGalleryApp
{
    partial class frmMenu
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
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddPainting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPaintingUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOwnerUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemViewReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemPaintings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemOwner = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSelectOptions = new System.Windows.Forms.Label();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.BackColor = System.Drawing.Color.IndianRed;
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuActions});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(524, 24);
            this.mnuMainBar.TabIndex = 0;
            this.mnuMainBar.Text = "mnuMainBar";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(92, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuActions
            // 
            this.mnuActions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddPainting,
            this.mnuItemUpdate,
            this.mnuItemDelete,
            this.mnuItemSearch,
            this.mnuItemViewReport});
            this.mnuActions.ForeColor = System.Drawing.Color.Black;
            this.mnuActions.Name = "mnuActions";
            this.mnuActions.Size = new System.Drawing.Size(59, 20);
            this.mnuActions.Text = "Actions";
            // 
            // mnuItemAddPainting
            // 
            this.mnuItemAddPainting.Name = "mnuItemAddPainting";
            this.mnuItemAddPainting.Size = new System.Drawing.Size(156, 22);
            this.mnuItemAddPainting.Text = "Add Painting ";
            this.mnuItemAddPainting.Click += new System.EventHandler(this.mnuItemAddPainting_Click);
            // 
            // mnuItemUpdate
            // 
            this.mnuItemUpdate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPaintingUpdate,
            this.mnuItemOwnerUpdate});
            this.mnuItemUpdate.Name = "mnuItemUpdate";
            this.mnuItemUpdate.Size = new System.Drawing.Size(156, 22);
            this.mnuItemUpdate.Text = "Update";
            // 
            // mnuItemPaintingUpdate
            // 
            this.mnuItemPaintingUpdate.Name = "mnuItemPaintingUpdate";
            this.mnuItemPaintingUpdate.Size = new System.Drawing.Size(118, 22);
            this.mnuItemPaintingUpdate.Text = "Painting";
            this.mnuItemPaintingUpdate.Click += new System.EventHandler(this.mnuItemPaintingUpdate_Click);
            // 
            // mnuItemOwnerUpdate
            // 
            this.mnuItemOwnerUpdate.Name = "mnuItemOwnerUpdate";
            this.mnuItemOwnerUpdate.Size = new System.Drawing.Size(118, 22);
            this.mnuItemOwnerUpdate.Text = "Artist";
            this.mnuItemOwnerUpdate.Click += new System.EventHandler(this.mnuItemOwnerUpdate_Click);
            // 
            // mnuItemDelete
            // 
            this.mnuItemDelete.Name = "mnuItemDelete";
            this.mnuItemDelete.Size = new System.Drawing.Size(156, 22);
            this.mnuItemDelete.Text = "Delete Painting";
            this.mnuItemDelete.Click += new System.EventHandler(this.mnuItemDelete_Click);
            // 
            // mnuItemSearch
            // 
            this.mnuItemSearch.Name = "mnuItemSearch";
            this.mnuItemSearch.Size = new System.Drawing.Size(156, 22);
            this.mnuItemSearch.Text = "Search Painting";
            this.mnuItemSearch.Click += new System.EventHandler(this.mnuItemSearch_Click);
            // 
            // mnuItemViewReport
            // 
            this.mnuItemViewReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemPaintings,
            this.mnuItemOwner});
            this.mnuItemViewReport.Name = "mnuItemViewReport";
            this.mnuItemViewReport.Size = new System.Drawing.Size(156, 22);
            this.mnuItemViewReport.Text = "View Report";
            // 
            // mnuItemPaintings
            // 
            this.mnuItemPaintings.Name = "mnuItemPaintings";
            this.mnuItemPaintings.Size = new System.Drawing.Size(152, 22);
            this.mnuItemPaintings.Text = "Paintings";
            this.mnuItemPaintings.Click += new System.EventHandler(this.mnuItemPaintings_Click);
            // 
            // mnuItemOwner
            // 
            this.mnuItemOwner.Name = "mnuItemOwner";
            this.mnuItemOwner.Size = new System.Drawing.Size(152, 22);
            this.mnuItemOwner.Text = "Artist";
            this.mnuItemOwner.Click += new System.EventHandler(this.mnuItemOwner_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblWelcome.Location = new System.Drawing.Point(180, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(143, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "WELCOME";
            // 
            // lblSelectOptions
            // 
            this.lblSelectOptions.AutoSize = true;
            this.lblSelectOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelectOptions.Location = new System.Drawing.Point(23, 96);
            this.lblSelectOptions.Name = "lblSelectOptions";
            this.lblSelectOptions.Size = new System.Drawing.Size(485, 29);
            this.lblSelectOptions.TabIndex = 2;
            this.lblSelectOptions.Text = "Please Select Actions for further Options";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(524, 176);
            this.Controls.Add(this.lblSelectOptions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuMainBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durban Art Gallery Application- Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuActions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddPainting;
        private System.Windows.Forms.ToolStripMenuItem mnuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuItemViewReport;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPaintingUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOwnerUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemPaintings;
        private System.Windows.Forms.ToolStripMenuItem mnuItemOwner;
    }
}

