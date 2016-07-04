namespace Trucking_Company
{
    partial class frm_SignUpSuccessful
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
            this.grp_CongratulationsMessage = new System.Windows.Forms.GroupBox();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pnl_SuccessfulBackgroundImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_CongratulationsMessage.SuspendLayout();
            this.pnl_SuccessfulBackgroundImage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_CongratulationsMessage
            // 
            this.grp_CongratulationsMessage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grp_CongratulationsMessage.Controls.Add(this.btn_Continue);
            this.grp_CongratulationsMessage.Controls.Add(this.lbl_Message);
            this.grp_CongratulationsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_CongratulationsMessage.Location = new System.Drawing.Point(39, 297);
            this.grp_CongratulationsMessage.Name = "grp_CongratulationsMessage";
            this.grp_CongratulationsMessage.Size = new System.Drawing.Size(633, 135);
            this.grp_CongratulationsMessage.TabIndex = 3;
            this.grp_CongratulationsMessage.TabStop = false;
            this.grp_CongratulationsMessage.Text = "Congratulations";
            // 
            // btn_Continue
            // 
            this.btn_Continue.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Continue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Continue.Location = new System.Drawing.Point(519, 92);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(108, 37);
            this.btn_Continue.TabIndex = 5;
            this.btn_Continue.Text = "&Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.btn_Continue_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.Location = new System.Drawing.Point(6, 40);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(402, 32);
            this.lbl_Message.TabIndex = 0;
            this.lbl_Message.Text = "You are now successfully in our database!\r\nPlease continue to our login in screen" +
    " and enter in your credentials.\r\n";
            // 
            // pnl_SuccessfulBackgroundImage
            // 
            this.pnl_SuccessfulBackgroundImage.BackColor = System.Drawing.Color.White;
            this.pnl_SuccessfulBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_SuccessfulBackgroundImage.Controls.Add(this.panel1);
            this.pnl_SuccessfulBackgroundImage.Controls.Add(this.grp_CongratulationsMessage);
            this.pnl_SuccessfulBackgroundImage.Location = new System.Drawing.Point(4, 4);
            this.pnl_SuccessfulBackgroundImage.Name = "pnl_SuccessfulBackgroundImage";
            this.pnl_SuccessfulBackgroundImage.Size = new System.Drawing.Size(716, 495);
            this.pnl_SuccessfulBackgroundImage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 206);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(199, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "I need to add a picture here";
            // 
            // frm_SignUpSuccessful
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_SuccessfulBackgroundImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_SignUpSuccessful";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grp_CongratulationsMessage.ResumeLayout(false);
            this.grp_CongratulationsMessage.PerformLayout();
            this.pnl_SuccessfulBackgroundImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_CongratulationsMessage;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Panel pnl_SuccessfulBackgroundImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}