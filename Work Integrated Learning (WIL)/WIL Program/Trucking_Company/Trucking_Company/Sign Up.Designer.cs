namespace Trucking_Company
{
    partial class frm_SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SignUp));
            this.pnl_SignUpBackgroundImage = new System.Windows.Forms.Panel();
            this.lbl_SignUp = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_AboutVacationHub = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.err_Username = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.tip_SignUpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_SignUpBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Password)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_SignUpBackgroundImage
            // 
            this.pnl_SignUpBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.pnl_SignUpBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_SignUpBackgroundImage.BackgroundImage")));
            this.pnl_SignUpBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_SignUpBackgroundImage.Controls.Add(this.lbl_SignUp);
            this.pnl_SignUpBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SignUpBackgroundImage.Name = "pnl_SignUpBackgroundImage";
            this.pnl_SignUpBackgroundImage.Size = new System.Drawing.Size(716, 243);
            this.pnl_SignUpBackgroundImage.TabIndex = 20;
            // 
            // lbl_SignUp
            // 
            this.lbl_SignUp.AutoSize = true;
            this.lbl_SignUp.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SignUp.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_SignUp.Location = new System.Drawing.Point(8, 200);
            this.lbl_SignUp.Name = "lbl_SignUp";
            this.lbl_SignUp.Size = new System.Drawing.Size(165, 43);
            this.lbl_SignUp.TabIndex = 0;
            this.lbl_SignUp.Text = "SIGN UP";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Password.Location = new System.Drawing.Point(75, 337);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 29);
            this.lbl_Password.TabIndex = 19;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Username.Location = new System.Drawing.Point(72, 298);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(109, 29);
            this.lbl_Username.TabIndex = 18;
            this.lbl_Username.Text = "Username:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Password.Location = new System.Drawing.Point(187, 335);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(456, 32);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Username.Location = new System.Drawing.Point(187, 298);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(456, 32);
            this.txt_Username.TabIndex = 16;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            // 
            // btn_AboutVacationHub
            // 
            this.btn_AboutVacationHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AboutVacationHub.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_AboutVacationHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AboutVacationHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AboutVacationHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AboutVacationHub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AboutVacationHub.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_AboutVacationHub.Location = new System.Drawing.Point(379, 422);
            this.btn_AboutVacationHub.Name = "btn_AboutVacationHub";
            this.btn_AboutVacationHub.Size = new System.Drawing.Size(84, 28);
            this.btn_AboutVacationHub.TabIndex = 23;
            this.btn_AboutVacationHub.Text = "&About";
            this.tip_SignUpInfo.SetToolTip(this.btn_AboutVacationHub, "Click to find out more about us.");
            this.btn_AboutVacationHub.UseVisualStyleBackColor = true;
            this.btn_AboutVacationHub.Click += new System.EventHandler(this.btn_AboutVacationHub_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(559, 422);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(84, 28);
            this.btn_Cancel.TabIndex = 22;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_SignUp.Location = new System.Drawing.Point(469, 422);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(84, 28);
            this.btn_SignUp.TabIndex = 21;
            this.btn_SignUp.Text = "&Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // err_Username
            // 
            this.err_Username.ContainerControl = this;
            this.err_Username.Icon = ((System.Drawing.Icon)(resources.GetObject("err_Username.Icon")));
            // 
            // err_Password
            // 
            this.err_Password.ContainerControl = this;
            this.err_Password.Icon = ((System.Drawing.Icon)(resources.GetObject("err_Password.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.pnl_SignUpBackgroundImage);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.btn_SignUp);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_AboutVacationHub);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 495);
            this.panel1.TabIndex = 1;
            // 
            // frm_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_SignUpBackgroundImage.ResumeLayout(false);
            this.pnl_SignUpBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Password)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_SignUpBackgroundImage;
        private System.Windows.Forms.Label lbl_SignUp;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_AboutVacationHub;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.ErrorProvider err_Username;
        private System.Windows.Forms.ErrorProvider err_Password;
        private System.Windows.Forms.ToolTip tip_SignUpInfo;
        private System.Windows.Forms.Panel panel1;
    }
}