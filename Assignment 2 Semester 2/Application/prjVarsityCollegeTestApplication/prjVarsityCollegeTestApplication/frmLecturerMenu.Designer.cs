namespace prjVarsityCollegeTestApplication
{
    partial class frmLecturerMenu
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
            this.mnuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddIceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemAddLecturer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtAmtOfStudents = new System.Windows.Forms.TextBox();
            this.lblAmtOfStudents = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLecturerName = new System.Windows.Forms.Label();
            this.mnuMainBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainBar
            // 
            this.mnuMainBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemFile,
            this.mnuItemActions});
            this.mnuMainBar.Location = new System.Drawing.Point(0, 0);
            this.mnuMainBar.Name = "mnuMainBar";
            this.mnuMainBar.Size = new System.Drawing.Size(433, 24);
            this.mnuMainBar.TabIndex = 0;
            this.mnuMainBar.Text = "menuStrip1";
            // 
            // mnuItemFile
            // 
            this.mnuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemExit});
            this.mnuItemFile.Name = "mnuItemFile";
            this.mnuItemFile.Size = new System.Drawing.Size(37, 20);
            this.mnuItemFile.Text = "File";
            // 
            // mnuItemExit
            // 
            this.mnuItemExit.Name = "mnuItemExit";
            this.mnuItemExit.Size = new System.Drawing.Size(92, 22);
            this.mnuItemExit.Text = "Exit";
            this.mnuItemExit.Click += new System.EventHandler(this.mnuItemExit_Click);
            // 
            // mnuItemActions
            // 
            this.mnuItemActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemAddIceTask,
            this.viewStudentMarksToolStripMenuItem,
            this.mnuItemAddLecturer});
            this.mnuItemActions.Name = "mnuItemActions";
            this.mnuItemActions.Size = new System.Drawing.Size(59, 20);
            this.mnuItemActions.Text = "Actions";
            // 
            // mnuItemAddIceTask
            // 
            this.mnuItemAddIceTask.Name = "mnuItemAddIceTask";
            this.mnuItemAddIceTask.Size = new System.Drawing.Size(178, 22);
            this.mnuItemAddIceTask.Text = "Add ICE Task";
            this.mnuItemAddIceTask.Click += new System.EventHandler(this.mnuItemAddIceTask_Click);
            // 
            // viewStudentMarksToolStripMenuItem
            // 
            this.viewStudentMarksToolStripMenuItem.Name = "viewStudentMarksToolStripMenuItem";
            this.viewStudentMarksToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.viewStudentMarksToolStripMenuItem.Text = "View Student Marks";
            this.viewStudentMarksToolStripMenuItem.Click += new System.EventHandler(this.viewStudentMarksToolStripMenuItem_Click);
            // 
            // mnuItemAddLecturer
            // 
            this.mnuItemAddLecturer.Name = "mnuItemAddLecturer";
            this.mnuItemAddLecturer.Size = new System.Drawing.Size(178, 22);
            this.mnuItemAddLecturer.Text = "Add Lecturer";
            this.mnuItemAddLecturer.Click += new System.EventHandler(this.mnuItemAddLecturer_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(153, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 12;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(106, 102);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(0, 25);
            this.lblInstructions.TabIndex = 13;
            // 
            // txtAmtOfStudents
            // 
            this.txtAmtOfStudents.Location = new System.Drawing.Point(316, 247);
            this.txtAmtOfStudents.Name = "txtAmtOfStudents";
            this.txtAmtOfStudents.Size = new System.Drawing.Size(40, 20);
            this.txtAmtOfStudents.TabIndex = 14;
            // 
            // lblAmtOfStudents
            // 
            this.lblAmtOfStudents.AutoSize = true;
            this.lblAmtOfStudents.Location = new System.Drawing.Point(72, 251);
            this.lblAmtOfStudents.Name = "lblAmtOfStudents";
            this.lblAmtOfStudents.Size = new System.Drawing.Size(238, 13);
            this.lblAmtOfStudents.TabIndex = 15;
            this.lblAmtOfStudents.Text = "Please Enter the Amount of Students in the Class";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(362, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 27);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLecturerName
            // 
            this.lblLecturerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLecturerName.AutoSize = true;
            this.lblLecturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturerName.Location = new System.Drawing.Point(106, 66);
            this.lblLecturerName.Name = "lblLecturerName";
            this.lblLecturerName.Size = new System.Drawing.Size(0, 25);
            this.lblLecturerName.TabIndex = 17;
            // 
            // frmLecturerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(433, 273);
            this.Controls.Add(this.lblLecturerName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAmtOfStudents);
            this.Controls.Add(this.txtAmtOfStudents);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.mnuMainBar);
            this.MainMenuStrip = this.mnuMainBar;
            this.Name = "frmLecturerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varsity College Test Application - Menu";
            this.mnuMainBar.ResumeLayout(false);
            this.mnuMainBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainBar;
        private System.Windows.Forms.ToolStripMenuItem mnuItemFile;
        private System.Windows.Forms.ToolStripMenuItem mnuItemExit;
        private System.Windows.Forms.ToolStripMenuItem mnuItemActions;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddIceTask;
        private System.Windows.Forms.ToolStripMenuItem viewStudentMarksToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtAmtOfStudents;
        private System.Windows.Forms.Label lblAmtOfStudents;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem mnuItemAddLecturer;
        private System.Windows.Forms.Label lblLecturerName;
    }
}