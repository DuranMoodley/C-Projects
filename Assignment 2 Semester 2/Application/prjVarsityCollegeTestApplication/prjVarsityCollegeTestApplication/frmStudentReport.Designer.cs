namespace prjVarsityCollegeTestApplication
{
    partial class frmStudentReport
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
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblFinalPercentage = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtCorrectAns = new System.Windows.Forms.TextBox();
            this.txtFinalPercentage = new System.Windows.Forms.TextBox();
            this.mnuMainBar = new System.Windows.Forms.MenuStrip();
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblIncorrectAns = new System.Windows.Forms.Label();
            this.txtIncorrectAns = new System.Windows.Forms.TextBox();
            this.sfdSaveReport = new System.Windows.Forms.SaveFileDialog();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(12, 34);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(181, 25);
            this.lblStudentNumber.TabIndex = 12;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(12, 67);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(185, 25);
            this.lblCorrectAnswers.TabIndex = 13;
            this.lblCorrectAnswers.Text = "Correct Answers";
            // 
            // lblFinalPercentage
            // 
            this.lblFinalPercentage.AutoSize = true;
            this.lblFinalPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPercentage.Location = new System.Drawing.Point(12, 137);
            this.lblFinalPercentage.Name = "lblFinalPercentage";
            this.lblFinalPercentage.Size = new System.Drawing.Size(234, 25);
            this.lblFinalPercentage.TabIndex = 14;
            this.lblFinalPercentage.Text = "Final Percentage (%)";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Enabled = false;
            this.txtStudentNumber.Location = new System.Drawing.Point(281, 39);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(178, 20);
            this.txtStudentNumber.TabIndex = 15;
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.Enabled = false;
            this.txtCorrectAns.Location = new System.Drawing.Point(281, 72);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.Size = new System.Drawing.Size(178, 20);
            this.txtCorrectAns.TabIndex = 16;
            // 
            // txtFinalPercentage
            // 
            this.txtFinalPercentage.Enabled = false;
            this.txtFinalPercentage.Location = new System.Drawing.Point(281, 142);
            this.txtFinalPercentage.Name = "txtFinalPercentage";
            this.txtFinalPercentage.Size = new System.Drawing.Size(178, 20);
            this.txtFinalPercentage.TabIndex = 17;
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(493, 24);
            this.mnuMainBar.TabIndex = 18;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveAs});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(114, 22);
            this.mnuSaveAs.Text = "Save As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(383, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(76, 29);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblIncorrectAns
            // 
            this.lblIncorrectAns.AutoSize = true;
            this.lblIncorrectAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncorrectAns.Location = new System.Drawing.Point(12, 101);
            this.lblIncorrectAns.Name = "lblIncorrectAns";
            this.lblIncorrectAns.Size = new System.Drawing.Size(200, 25);
            this.lblIncorrectAns.TabIndex = 20;
            this.lblIncorrectAns.Text = "Incorrect Answers";
            // 
            // txtIncorrectAns
            // 
            this.txtIncorrectAns.Enabled = false;
            this.txtIncorrectAns.Location = new System.Drawing.Point(281, 107);
            this.txtIncorrectAns.Name = "txtIncorrectAns";
            this.txtIncorrectAns.Size = new System.Drawing.Size(178, 20);
            this.txtIncorrectAns.TabIndex = 21;
            // 
            // sfdSaveReport
            // 
            this.sfdSaveReport.FileName = "IceTaskReport";
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(493, 213);
            this.Controls.Add(this.txtIncorrectAns);
            this.Controls.Add(this.lblIncorrectAns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFinalPercentage);
            this.Controls.Add(this.txtCorrectAns);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lblFinalPercentage);
            this.Controls.Add(this.lblCorrectAnswers);
            this.Controls.Add(this.lblStudentNumber);
            this.Controls.Add(this.mnuMainBar);
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmStudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varsity College Test Application - Report";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label lblFinalPercentage;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtCorrectAns;
        private System.Windows.Forms.TextBox txtFinalPercentage;
        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIncorrectAns;
        private System.Windows.Forms.TextBox txtIncorrectAns;
        private System.Windows.Forms.SaveFileDialog sfdSaveReport;
    }
}