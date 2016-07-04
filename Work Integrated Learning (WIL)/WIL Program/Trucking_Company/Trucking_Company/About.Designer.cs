namespace Trucking_Company
{
    partial class frm_About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
            this.grp_About_SignUp = new System.Windows.Forms.GroupBox();
            this.lbl_AboutMessage_SignUp = new System.Windows.Forms.Label();
            this.btn_Return_SignUp = new System.Windows.Forms.Button();
            this.lbl_Motto = new System.Windows.Forms.Label();
            this.tip_AboutVacationHub = new System.Windows.Forms.ToolTip(this.components);
            this.grp_About_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_About_SignUp
            // 
            this.grp_About_SignUp.Controls.Add(this.lbl_AboutMessage_SignUp);
            this.grp_About_SignUp.Controls.Add(this.btn_Return_SignUp);
            this.grp_About_SignUp.Controls.Add(this.lbl_Motto);
            this.grp_About_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_About_SignUp.ForeColor = System.Drawing.Color.White;
            this.grp_About_SignUp.Location = new System.Drawing.Point(12, 0);
            this.grp_About_SignUp.Name = "grp_About_SignUp";
            this.grp_About_SignUp.Size = new System.Drawing.Size(684, 502);
            this.grp_About_SignUp.TabIndex = 40;
            this.grp_About_SignUp.TabStop = false;
            this.grp_About_SignUp.Text = "About Express Cor";
            // 
            // lbl_AboutMessage_SignUp
            // 
            this.lbl_AboutMessage_SignUp.AutoSize = true;
            this.lbl_AboutMessage_SignUp.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AboutMessage_SignUp.ForeColor = System.Drawing.Color.White;
            this.lbl_AboutMessage_SignUp.Location = new System.Drawing.Point(6, 52);
            this.lbl_AboutMessage_SignUp.Name = "lbl_AboutMessage_SignUp";
            this.lbl_AboutMessage_SignUp.Size = new System.Drawing.Size(601, 220);
            this.lbl_AboutMessage_SignUp.TabIndex = 23;
            this.lbl_AboutMessage_SignUp.Text = resources.GetString("lbl_AboutMessage_SignUp.Text");
            // 
            // btn_Return_SignUp
            // 
            this.btn_Return_SignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Return_SignUp.BackgroundImage")));
            this.btn_Return_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Return_SignUp.FlatAppearance.BorderSize = 0;
            this.btn_Return_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Return_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Return_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return_SignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return_SignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_Return_SignUp.Location = new System.Drawing.Point(642, 21);
            this.btn_Return_SignUp.Name = "btn_Return_SignUp";
            this.btn_Return_SignUp.Size = new System.Drawing.Size(36, 28);
            this.btn_Return_SignUp.TabIndex = 40;
            this.tip_AboutVacationHub.SetToolTip(this.btn_Return_SignUp, "Return to sign up");
            this.btn_Return_SignUp.UseVisualStyleBackColor = true;
            this.btn_Return_SignUp.Click += new System.EventHandler(this.btn_Return_SignUp_Click);
            // 
            // lbl_Motto
            // 
            this.lbl_Motto.AutoSize = true;
            this.lbl_Motto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Motto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Motto.Location = new System.Drawing.Point(168, 476);
            this.lbl_Motto.Name = "lbl_Motto";
            this.lbl_Motto.Size = new System.Drawing.Size(328, 23);
            this.lbl_Motto.TabIndex = 38;
            this.lbl_Motto.Text = "\"THE NEXT EVOLUTION IN CARGO FLEETS\"";
            // 
            // frm_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 514);
            this.ControlBox = false;
            this.Controls.Add(this.grp_About_SignUp);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grp_About_SignUp.ResumeLayout(false);
            this.grp_About_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_About_SignUp;
        private System.Windows.Forms.Label lbl_AboutMessage_SignUp;
        private System.Windows.Forms.Button btn_Return_SignUp;
        private System.Windows.Forms.ToolTip tip_AboutVacationHub;
        private System.Windows.Forms.Label lbl_Motto;
    }
}