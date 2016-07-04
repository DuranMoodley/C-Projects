namespace Trucking_Company
{
    partial class FrmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginScreen));
            this.PicExitButton = new System.Windows.Forms.PictureBox();
            this.PnlLoginBackgroundImage = new System.Windows.Forms.Panel();
            this.LblCompanyName = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TipLoginForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.ChkShowPassword = new System.Windows.Forms.CheckBox();
            this.LblForgotPassword = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ErrUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrPassword = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicExitButton)).BeginInit();
            this.PnlLoginBackgroundImage.SuspendLayout();
            this.PnlForBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // PicExitButton
            // 
            this.PicExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicExitButton.BackgroundImage")));
            this.PicExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicExitButton.Location = new System.Drawing.Point(674, 3);
            this.PicExitButton.Name = "PicExitButton";
            this.PicExitButton.Size = new System.Drawing.Size(39, 33);
            this.PicExitButton.TabIndex = 9;
            this.PicExitButton.TabStop = false;
            this.TipLoginForm.SetToolTip(this.PicExitButton, "Close Program");
            this.PicExitButton.Click += new System.EventHandler(this.PicExitButton_Click);
            // 
            // PnlLoginBackgroundImage
            // 
            this.PnlLoginBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.PnlLoginBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLoginBackgroundImage.BackgroundImage")));
            this.PnlLoginBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLoginBackgroundImage.Controls.Add(this.LblCompanyName);
            this.PnlLoginBackgroundImage.Controls.Add(this.PicExitButton);
            this.PnlLoginBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlLoginBackgroundImage.Name = "PnlLoginBackgroundImage";
            this.PnlLoginBackgroundImage.Size = new System.Drawing.Size(716, 286);
            this.PnlLoginBackgroundImage.TabIndex = 16;
            // 
            // LblCompanyName
            // 
            this.LblCompanyName.AutoSize = true;
            this.LblCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.LblCompanyName.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompanyName.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblCompanyName.Location = new System.Drawing.Point(3, 239);
            this.LblCompanyName.Name = "LblCompanyName";
            this.LblCompanyName.Size = new System.Drawing.Size(275, 43);
            this.LblCompanyName.TabIndex = 7;
            this.LblCompanyName.Text = "CARGO FLEET";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblPassword.Location = new System.Drawing.Point(104, 383);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(106, 29);
            this.LblPassword.TabIndex = 15;
            this.LblPassword.Text = "Password:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblUsername.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsername.Location = new System.Drawing.Point(101, 344);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(109, 29);
            this.LblUsername.TabIndex = 14;
            this.LblUsername.Text = "Username:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtPassword.Location = new System.Drawing.Point(216, 383);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(456, 32);
            this.TxtPassword.TabIndex = 13;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtUsername.Location = new System.Drawing.Point(216, 344);
            this.TxtUsername.MaxLength = 15;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(456, 32);
            this.TxtUsername.TabIndex = 12;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.ChkShowPassword);
            this.PnlForBorder.Controls.Add(this.LblForgotPassword);
            this.PnlForBorder.Controls.Add(this.BtnLogin);
            this.PnlForBorder.Controls.Add(this.TxtPassword);
            this.PnlForBorder.Controls.Add(this.PnlLoginBackgroundImage);
            this.PnlForBorder.Controls.Add(this.LblUsername);
            this.PnlForBorder.Controls.Add(this.TxtUsername);
            this.PnlForBorder.Controls.Add(this.LblPassword);
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 10;
            // 
            // ChkShowPassword
            // 
            this.ChkShowPassword.AutoSize = true;
            this.ChkShowPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChkShowPassword.Location = new System.Drawing.Point(469, 417);
            this.ChkShowPassword.Name = "ChkShowPassword";
            this.ChkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ChkShowPassword.TabIndex = 20;
            this.ChkShowPassword.Text = "&Show Password";
            this.ChkShowPassword.UseVisualStyleBackColor = true;
            this.ChkShowPassword.CheckedChanged += new System.EventHandler(this.ChkShowPassword_CheckedChanged);
            // 
            // LblForgotPassword
            // 
            this.LblForgotPassword.AutoSize = true;
            this.LblForgotPassword.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblForgotPassword.Location = new System.Drawing.Point(577, 418);
            this.LblForgotPassword.Name = "LblForgotPassword";
            this.LblForgotPassword.Size = new System.Drawing.Size(95, 13);
            this.LblForgotPassword.TabIndex = 19;
            this.LblForgotPassword.Text = "&Forgot Password ?";
            this.LblForgotPassword.Click += new System.EventHandler(this.LblForgotPassword_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(588, 450);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(84, 37);
            this.BtnLogin.TabIndex = 18;
            this.BtnLogin.Text = "&Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ErrUsername
            // 
            this.ErrUsername.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrUsername.ContainerControl = this;
            // 
            // ErrPassword
            // 
            this.ErrPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrPassword.ContainerControl = this;
            // 
            // FrmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(724, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PnlForBorder);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PicExitButton)).EndInit();
            this.PnlLoginBackgroundImage.ResumeLayout(false);
            this.PnlLoginBackgroundImage.PerformLayout();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicExitButton;
        private System.Windows.Forms.Panel PnlLoginBackgroundImage;
        private System.Windows.Forms.Label LblCompanyName;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.ToolTip TipLoginForm;
        private System.Windows.Forms.Panel PnlForBorder;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.ErrorProvider ErrUsername;
        private System.Windows.Forms.ErrorProvider ErrPassword;
        private System.Windows.Forms.Label LblForgotPassword;
        private System.Windows.Forms.CheckBox ChkShowPassword;
    }
}