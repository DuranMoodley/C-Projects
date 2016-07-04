namespace Trucking_Company
{
    partial class FrmSignUpSuccessful
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUpSuccessful));
            this.GrpCongratulationsMessage = new System.Windows.Forms.GroupBox();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.PnlSignUpSuccessfulBackgroundImage = new System.Windows.Forms.Panel();
            this.GrpCongratulationsMessage.SuspendLayout();
            this.PnlForBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpCongratulationsMessage
            // 
            this.GrpCongratulationsMessage.BackColor = System.Drawing.SystemColors.Window;
            this.GrpCongratulationsMessage.Controls.Add(this.BtnContinue);
            this.GrpCongratulationsMessage.Controls.Add(this.LblMessage);
            this.GrpCongratulationsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpCongratulationsMessage.Location = new System.Drawing.Point(39, 297);
            this.GrpCongratulationsMessage.Name = "GrpCongratulationsMessage";
            this.GrpCongratulationsMessage.Size = new System.Drawing.Size(633, 135);
            this.GrpCongratulationsMessage.TabIndex = 3;
            this.GrpCongratulationsMessage.TabStop = false;
            this.GrpCongratulationsMessage.Text = "Congratulations";
            // 
            // BtnContinue
            // 
            this.BtnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContinue.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContinue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnContinue.Location = new System.Drawing.Point(519, 92);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(108, 37);
            this.BtnContinue.TabIndex = 5;
            this.BtnContinue.Text = "&Continue";
            this.BtnContinue.UseVisualStyleBackColor = true;
            this.BtnContinue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(6, 40);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(402, 32);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "You are now successfully in our database!\r\nPlease continue to our login in screen" +
    " and enter in your credentials.\r\n";
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlForBorder.Controls.Add(this.PnlSignUpSuccessfulBackgroundImage);
            this.PnlForBorder.Controls.Add(this.GrpCongratulationsMessage);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 2;
            // 
            // PnlSignUpSuccessfulBackgroundImage
            // 
            this.PnlSignUpSuccessfulBackgroundImage.BackColor = System.Drawing.Color.Black;
            this.PnlSignUpSuccessfulBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlSignUpSuccessfulBackgroundImage.BackgroundImage")));
            this.PnlSignUpSuccessfulBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlSignUpSuccessfulBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlSignUpSuccessfulBackgroundImage.Name = "PnlSignUpSuccessfulBackgroundImage";
            this.PnlSignUpSuccessfulBackgroundImage.Size = new System.Drawing.Size(716, 213);
            this.PnlSignUpSuccessfulBackgroundImage.TabIndex = 4;
            // 
            // FrmSignUpSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmSignUpSuccessful";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GrpCongratulationsMessage.ResumeLayout(false);
            this.GrpCongratulationsMessage.PerformLayout();
            this.PnlForBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpCongratulationsMessage;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Panel PnlSignUpSuccessfulBackgroundImage;
    }
}