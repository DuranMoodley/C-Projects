namespace prjZooApplication
{
    partial class frmSelectCategory
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
            this.btnLion = new System.Windows.Forms.Button();
            this.btnElephant = new System.Windows.Forms.Button();
            this.btnBirds = new System.Windows.Forms.Button();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLion
            // 
            this.btnLion.Location = new System.Drawing.Point(106, 44);
            this.btnLion.Name = "btnLion";
            this.btnLion.Size = new System.Drawing.Size(138, 28);
            this.btnLion.TabIndex = 0;
            this.btnLion.Text = "Lion";
            this.btnLion.UseVisualStyleBackColor = true;
            this.btnLion.Click += new System.EventHandler(this.btnLion_Click);
            // 
            // btnElephant
            // 
            this.btnElephant.Location = new System.Drawing.Point(106, 78);
            this.btnElephant.Name = "btnElephant";
            this.btnElephant.Size = new System.Drawing.Size(138, 28);
            this.btnElephant.TabIndex = 1;
            this.btnElephant.Text = "Elephant";
            this.btnElephant.UseVisualStyleBackColor = true;
            this.btnElephant.Click += new System.EventHandler(this.btnElephant_Click);
            // 
            // btnBirds
            // 
            this.btnBirds.Location = new System.Drawing.Point(106, 112);
            this.btnBirds.Name = "btnBirds";
            this.btnBirds.Size = new System.Drawing.Size(138, 24);
            this.btnBirds.TabIndex = 2;
            this.btnBirds.Text = "Birds";
            this.btnBirds.UseVisualStyleBackColor = true;
            this.btnBirds.Click += new System.EventHandler(this.btnBirds_Click);
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(357, 24);
            this.mnuMainBar.TabIndex = 5;
            this.mnuMainBar.Text = "mnuCategories";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemBack,
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuItemBack
            // 
            this.mnuItemBack.Name = "mnuItemBack";
            this.mnuItemBack.Size = new System.Drawing.Size(99, 22);
            this.mnuItemBack.Text = "Back";
            this.mnuItemBack.Click += new System.EventHandler(this.mnuItemBack_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(99, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // frmSelectCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(357, 146);
            this.Controls.Add(this.mnuMainBar);
            this.Controls.Add(this.btnBirds);
            this.Controls.Add(this.btnElephant);
            this.Controls.Add(this.btnLion);
            this.Name = "frmSelectCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Application - Categories";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLion;
        private System.Windows.Forms.Button btnElephant;
        private System.Windows.Forms.Button btnBirds;
        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemBack;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
    }
}