namespace prjVarsityCollegeTestApplication
{
    partial class frmRules
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
            this.lblRule1 = new System.Windows.Forms.Label();
            this.lblRule1Continued = new System.Windows.Forms.Label();
            this.lblRule2 = new System.Windows.Forms.Label();
            this.lblRule3 = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblRule4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRule1
            // 
            this.lblRule1.AutoSize = true;
            this.lblRule1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1.Location = new System.Drawing.Point(31, 20);
            this.lblRule1.Name = "lblRule1";
            this.lblRule1.Size = new System.Drawing.Size(526, 16);
            this.lblRule1.TabIndex = 0;
            this.lblRule1.Text = "Point#1 - Before Answering the questions. Make sure you open the Ice Task";
            // 
            // lblRule1Continued
            // 
            this.lblRule1Continued.AutoSize = true;
            this.lblRule1Continued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule1Continued.Location = new System.Drawing.Point(96, 45);
            this.lblRule1Continued.Name = "lblRule1Continued";
            this.lblRule1Continued.Size = new System.Drawing.Size(135, 16);
            this.lblRule1Continued.TabIndex = 1;
            this.lblRule1Continued.Text = "Click File --> Open";
            // 
            // lblRule2
            // 
            this.lblRule2.AutoSize = true;
            this.lblRule2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule2.Location = new System.Drawing.Point(31, 74);
            this.lblRule2.Name = "lblRule2";
            this.lblRule2.Size = new System.Drawing.Size(383, 16);
            this.lblRule2.TabIndex = 2;
            this.lblRule2.Text = "Point#2: If you Select Exit, All your answers will be lost.";
            // 
            // lblRule3
            // 
            this.lblRule3.AutoSize = true;
            this.lblRule3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule3.Location = new System.Drawing.Point(31, 103);
            this.lblRule3.Name = "lblRule3";
            this.lblRule3.Size = new System.Drawing.Size(575, 16);
            this.lblRule3.TabIndex = 3;
            this.lblRule3.Text = "Point#3: If you answered all questions. You will be allowed to change your answer" +
    "s";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContinue.FlatAppearance.BorderSize = 3;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnContinue.Location = new System.Drawing.Point(204, 163);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(225, 27);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblRule4
            // 
            this.lblRule4.AutoSize = true;
            this.lblRule4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRule4.Location = new System.Drawing.Point(31, 132);
            this.lblRule4.Name = "lblRule4";
            this.lblRule4.Size = new System.Drawing.Size(423, 16);
            this.lblRule4.TabIndex = 7;
            this.lblRule4.Text = "Point#4: At the End you will be allowed to Save your Results.";
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(667, 196);
            this.Controls.Add(this.lblRule4);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblRule3);
            this.Controls.Add(this.lblRule2);
            this.Controls.Add(this.lblRule1Continued);
            this.Controls.Add(this.lblRule1);
            this.Name = "frmRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Varsity College Test Application - Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRule1;
        private System.Windows.Forms.Label lblRule1Continued;
        private System.Windows.Forms.Label lblRule2;
        private System.Windows.Forms.Label lblRule3;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblRule4;
    }
}