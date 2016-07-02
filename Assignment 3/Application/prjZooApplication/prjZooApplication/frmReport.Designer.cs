namespace prjZooApplication
{
    partial class frmReport
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
            this.tbcReport = new System.Windows.Forms.TabControl();
            this.tbpSchedules = new System.Windows.Forms.TabPage();
            this.btnShowSchedule = new System.Windows.Forms.Button();
            this.lstvSchedules = new System.Windows.Forms.ListView();
            this.tbAnimal = new System.Windows.Forms.TabPage();
            this.btnBirds = new System.Windows.Forms.Button();
            this.btnElephant = new System.Windows.Forms.Button();
            this.btnLion = new System.Windows.Forms.Button();
            this.lstvAnimals = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbcReport.SuspendLayout();
            this.tbpSchedules.SuspendLayout();
            this.tbAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcReport
            // 
            this.tbcReport.Controls.Add(this.tbpSchedules);
            this.tbcReport.Controls.Add(this.tbAnimal);
            this.tbcReport.Location = new System.Drawing.Point(5, 3);
            this.tbcReport.Name = "tbcReport";
            this.tbcReport.SelectedIndex = 0;
            this.tbcReport.Size = new System.Drawing.Size(715, 339);
            this.tbcReport.TabIndex = 0;
            // 
            // tbpSchedules
            // 
            this.tbpSchedules.Controls.Add(this.btnShowSchedule);
            this.tbpSchedules.Controls.Add(this.lstvSchedules);
            this.tbpSchedules.Location = new System.Drawing.Point(4, 22);
            this.tbpSchedules.Name = "tbpSchedules";
            this.tbpSchedules.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSchedules.Size = new System.Drawing.Size(707, 313);
            this.tbpSchedules.TabIndex = 0;
            this.tbpSchedules.Text = "Schedules";
            this.tbpSchedules.UseVisualStyleBackColor = true;
            // 
            // btnShowSchedule
            // 
            this.btnShowSchedule.Location = new System.Drawing.Point(294, 15);
            this.btnShowSchedule.Name = "btnShowSchedule";
            this.btnShowSchedule.Size = new System.Drawing.Size(112, 22);
            this.btnShowSchedule.TabIndex = 7;
            this.btnShowSchedule.Text = "Show Schedule";
            this.btnShowSchedule.UseVisualStyleBackColor = true;
            this.btnShowSchedule.Click += new System.EventHandler(this.btnMorning_Click);
            // 
            // lstvSchedules
            // 
            this.lstvSchedules.GridLines = true;
            this.lstvSchedules.Location = new System.Drawing.Point(34, 43);
            this.lstvSchedules.Name = "lstvSchedules";
            this.lstvSchedules.Size = new System.Drawing.Size(636, 254);
            this.lstvSchedules.TabIndex = 0;
            this.lstvSchedules.UseCompatibleStateImageBehavior = false;
            // 
            // tbAnimal
            // 
            this.tbAnimal.Controls.Add(this.btnBirds);
            this.tbAnimal.Controls.Add(this.btnElephant);
            this.tbAnimal.Controls.Add(this.btnLion);
            this.tbAnimal.Controls.Add(this.lstvAnimals);
            this.tbAnimal.Location = new System.Drawing.Point(4, 22);
            this.tbAnimal.Name = "tbAnimal";
            this.tbAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tbAnimal.Size = new System.Drawing.Size(707, 313);
            this.tbAnimal.TabIndex = 1;
            this.tbAnimal.Text = "Animals";
            this.tbAnimal.UseVisualStyleBackColor = true;
            // 
            // btnBirds
            // 
            this.btnBirds.Location = new System.Drawing.Point(544, 25);
            this.btnBirds.Name = "btnBirds";
            this.btnBirds.Size = new System.Drawing.Size(112, 22);
            this.btnBirds.TabIndex = 3;
            this.btnBirds.Text = "Birds";
            this.btnBirds.UseVisualStyleBackColor = true;
            this.btnBirds.Click += new System.EventHandler(this.btnBirds_Click);
            // 
            // btnElephant
            // 
            this.btnElephant.Location = new System.Drawing.Point(6, 25);
            this.btnElephant.Name = "btnElephant";
            this.btnElephant.Size = new System.Drawing.Size(112, 22);
            this.btnElephant.TabIndex = 2;
            this.btnElephant.Text = "Elephant";
            this.btnElephant.UseVisualStyleBackColor = true;
            this.btnElephant.Click += new System.EventHandler(this.btnElephant_Click);
            // 
            // btnLion
            // 
            this.btnLion.Location = new System.Drawing.Point(273, 25);
            this.btnLion.Name = "btnLion";
            this.btnLion.Size = new System.Drawing.Size(112, 22);
            this.btnLion.TabIndex = 1;
            this.btnLion.Text = "Lion";
            this.btnLion.UseVisualStyleBackColor = true;
            this.btnLion.Click += new System.EventHandler(this.btnLion_Click);
            // 
            // lstvAnimals
            // 
            this.lstvAnimals.GridLines = true;
            this.lstvAnimals.Location = new System.Drawing.Point(6, 53);
            this.lstvAnimals.Name = "lstvAnimals";
            this.lstvAnimals.Size = new System.Drawing.Size(650, 223);
            this.lstvAnimals.TabIndex = 0;
            this.lstvAnimals.UseCompatibleStateImageBehavior = false;
            this.lstvAnimals.View = System.Windows.Forms.View.List;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(5, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 22);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(608, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(732, 367);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbcReport);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Application - Report";
            this.tbcReport.ResumeLayout(false);
            this.tbpSchedules.ResumeLayout(false);
            this.tbAnimal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcReport;
        private System.Windows.Forms.TabPage tbpSchedules;
        private System.Windows.Forms.TabPage tbAnimal;
        private System.Windows.Forms.Button btnBirds;
        private System.Windows.Forms.Button btnElephant;
        private System.Windows.Forms.Button btnLion;
        private System.Windows.Forms.ListView lstvAnimals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lstvSchedules;
        private System.Windows.Forms.Button btnShowSchedule;

    }
}