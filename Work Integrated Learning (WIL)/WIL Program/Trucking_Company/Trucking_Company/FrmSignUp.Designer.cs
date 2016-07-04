namespace Trucking_Company
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.PnlSignUpBackgroundImage = new System.Windows.Forms.Panel();
            this.LblSignUp = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblUsername = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.BtnAboutVacationHub = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.ErrUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipSignUpForm = new System.Windows.Forms.ToolTip(this.components);
            this.PnlForBorder = new System.Windows.Forms.Panel();
            this.PnlSignUpBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPassword)).BeginInit();
            this.PnlForBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSignUpBackgroundImage
            // 
            this.PnlSignUpBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.PnlSignUpBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlSignUpBackgroundImage.BackgroundImage")));
            this.PnlSignUpBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlSignUpBackgroundImage.Controls.Add(this.LblSignUp);
            this.PnlSignUpBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.PnlSignUpBackgroundImage.Name = "PnlSignUpBackgroundImage";
            this.PnlSignUpBackgroundImage.Size = new System.Drawing.Size(716, 225);
            this.PnlSignUpBackgroundImage.TabIndex = 20;
            // 
            // LblSignUp
            // 
            this.LblSignUp.AutoSize = true;
            this.LblSignUp.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSignUp.ForeColor = System.Drawing.Color.SteelBlue;
            this.LblSignUp.Location = new System.Drawing.Point(8, 5);
            this.LblSignUp.Name = "LblSignUp";
            this.LblSignUp.Size = new System.Drawing.Size(165, 43);
            this.LblSignUp.TabIndex = 0;
            this.LblSignUp.Text = "SIGN UP";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblPassword.Location = new System.Drawing.Point(75, 337);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(106, 29);
            this.LblPassword.TabIndex = 19;
            this.LblPassword.Text = "Password:";
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblUsername.Location = new System.Drawing.Point(72, 298);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(109, 29);
            this.LblUsername.TabIndex = 18;
            this.LblUsername.Text = "Username:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtPassword.Location = new System.Drawing.Point(187, 335);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '♦';
            this.TxtPassword.Size = new System.Drawing.Size(456, 32);
            this.TxtPassword.TabIndex = 17;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TxtUsername.Location = new System.Drawing.Point(187, 298);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(456, 32);
            this.TxtUsername.TabIndex = 16;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsername.Leave += new System.EventHandler(this.txt_Username_Leave);
            // 
            // BtnAboutVacationHub
            // 
            this.BtnAboutVacationHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAboutVacationHub.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnAboutVacationHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAboutVacationHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnAboutVacationHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAboutVacationHub.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAboutVacationHub.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnAboutVacationHub.Location = new System.Drawing.Point(379, 413);
            this.BtnAboutVacationHub.Name = "BtnAboutVacationHub";
            this.BtnAboutVacationHub.Size = new System.Drawing.Size(84, 37);
            this.BtnAboutVacationHub.TabIndex = 23;
            this.BtnAboutVacationHub.Text = "&About";
            this.TipSignUpForm.SetToolTip(this.BtnAboutVacationHub, "Click to find out more about us.");
            this.BtnAboutVacationHub.UseVisualStyleBackColor = true;
            this.BtnAboutVacationHub.Click += new System.EventHandler(this.btn_AboutVacationHub_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(559, 413);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 37);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnSignUp.Location = new System.Drawing.Point(469, 413);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(84, 37);
            this.BtnSignUp.TabIndex = 21;
            this.BtnSignUp.Text = "&Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // ErrUsername
            // 
            this.ErrUsername.ContainerControl = this;
            this.ErrUsername.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrUsername.Icon")));
            // 
            // ErrPassword
            // 
            this.ErrPassword.ContainerControl = this;
            this.ErrPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrPassword.Icon")));
            // 
            // PnlForBorder
            // 
            this.PnlForBorder.BackColor = System.Drawing.Color.White;
            this.PnlForBorder.Controls.Add(this.LblPassword);
            this.PnlForBorder.Controls.Add(this.PnlSignUpBackgroundImage);
            this.PnlForBorder.Controls.Add(this.LblUsername);
            this.PnlForBorder.Controls.Add(this.TxtUsername);
            this.PnlForBorder.Controls.Add(this.TxtPassword);
            this.PnlForBorder.Controls.Add(this.BtnSignUp);
            this.PnlForBorder.Controls.Add(this.BtnCancel);
            this.PnlForBorder.Controls.Add(this.BtnAboutVacationHub);
            this.PnlForBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlForBorder.Location = new System.Drawing.Point(4, 4);
            this.PnlForBorder.Name = "PnlForBorder";
            this.PnlForBorder.Size = new System.Drawing.Size(716, 495);
            this.PnlForBorder.TabIndex = 1;
            // 
            // FrmSignUp
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
            this.Name = "FrmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlSignUpBackgroundImage.ResumeLayout(false);
            this.PnlSignUpBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrPassword)).EndInit();
            this.PnlForBorder.ResumeLayout(false);
            this.PnlForBorder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSignUpBackgroundImage;
        private System.Windows.Forms.Label LblSignUp;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Button BtnAboutVacationHub;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.ErrorProvider ErrUsername;
        private System.Windows.Forms.ErrorProvider ErrPassword;
        private System.Windows.Forms.ToolTip TipSignUpForm;
        private System.Windows.Forms.Panel PnlForBorder;
    }
}