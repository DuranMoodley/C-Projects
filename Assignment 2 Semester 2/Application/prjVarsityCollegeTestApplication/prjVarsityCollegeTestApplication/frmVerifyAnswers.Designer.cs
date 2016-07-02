namespace prjVarsityCollegeTestApplication
{
    partial class frmVerifyAnswers
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lstFirstNineAnswers = new System.Windows.Forms.ListBox();
            this.btnCalculateMark = new System.Windows.Forms.Button();
            this.lstLastTenAnswers = new System.Windows.Forms.ListBox();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.FlatAppearance.BorderSize = 3;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirm.Location = new System.Drawing.Point(4, 352);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 29);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm ";
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEdit
            // 
            this.txtEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdit.Location = new System.Drawing.Point(285, 326);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(152, 20);
            this.txtEdit.TabIndex = 10;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(349, 352);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 29);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(216, 333);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(63, 13);
            this.lblEdit.TabIndex = 12;
            this.lblEdit.Text = "Edit Answer";
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(449, 24);
            this.mnuMainBar.TabIndex = 13;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemMainMenu,
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuItemMainMenu
            // 
            this.mnuItemMainMenu.Name = "mnuItemMainMenu";
            this.mnuItemMainMenu.Size = new System.Drawing.Size(135, 22);
            this.mnuItemMainMenu.Text = "Main Menu";
            this.mnuItemMainMenu.Click += new System.EventHandler(this.mnuItemMainMenu_Click);
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(135, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // lstFirstNineAnswers
            // 
            this.lstFirstNineAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFirstNineAnswers.FormattingEnabled = true;
            this.lstFirstNineAnswers.ItemHeight = 24;
            this.lstFirstNineAnswers.Location = new System.Drawing.Point(12, 33);
            this.lstFirstNineAnswers.Name = "lstFirstNineAnswers";
            this.lstFirstNineAnswers.Size = new System.Drawing.Size(171, 220);
            this.lstFirstNineAnswers.TabIndex = 14;
            this.lstFirstNineAnswers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstFirstNineAnswers_MouseClick);
            // 
            // btnCalculateMark
            // 
            this.btnCalculateMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCalculateMark.AutoSize = true;
            this.btnCalculateMark.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCalculateMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateMark.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalculateMark.FlatAppearance.BorderSize = 3;
            this.btnCalculateMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculateMark.Location = new System.Drawing.Point(183, 352);
            this.btnCalculateMark.Name = "btnCalculateMark";
            this.btnCalculateMark.Size = new System.Drawing.Size(96, 29);
            this.btnCalculateMark.TabIndex = 17;
            this.btnCalculateMark.Text = "Calculate Mark";
            this.btnCalculateMark.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalculateMark.UseVisualStyleBackColor = false;
            this.btnCalculateMark.Visible = false;
            this.btnCalculateMark.Click += new System.EventHandler(this.btnCalculateMark_Click);
            // 
            // lstLastTenAnswers
            // 
            this.lstLastTenAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLastTenAnswers.FormattingEnabled = true;
            this.lstLastTenAnswers.ItemHeight = 24;
            this.lstLastTenAnswers.Location = new System.Drawing.Point(265, 33);
            this.lstLastTenAnswers.Name = "lstLastTenAnswers";
            this.lstLastTenAnswers.Size = new System.Drawing.Size(172, 268);
            this.lstLastTenAnswers.Sorted = true;
            this.lstLastTenAnswers.TabIndex = 18;
            this.lstLastTenAnswers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstLastTenAnswers_MouseClick);
            // 
            // frmVerifyAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(449, 388);
            this.Controls.Add(this.lstLastTenAnswers);
            this.Controls.Add(this.btnCalculateMark);
            this.Controls.Add(this.lstFirstNineAnswers);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.mnuMainBar);
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmVerifyAnswers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varsity College Test Application - Check Answers";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ListBox lstFirstNineAnswers;
        private System.Windows.Forms.Button btnCalculateMark;
        private System.Windows.Forms.ListBox lstLastTenAnswers;
    }
}