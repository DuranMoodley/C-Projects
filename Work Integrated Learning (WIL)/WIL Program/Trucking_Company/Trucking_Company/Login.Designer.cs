namespace Trucking_Company
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.pic_ExitButton = new System.Windows.Forms.PictureBox();
            this.pnl_LoginBackgroundImage = new System.Windows.Forms.Panel();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.err_Username = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.tip_SignUp = new System.Windows.Forms.ToolTip(this.components);
            this.tip_Exit = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ExitButton)).BeginInit();
            this.pnl_LoginBackgroundImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Password)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_ExitButton
            // 
            this.pic_ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_ExitButton.BackgroundImage")));
            this.pic_ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_ExitButton.Location = new System.Drawing.Point(674, 3);
            this.pic_ExitButton.Name = "pic_ExitButton";
            this.pic_ExitButton.Size = new System.Drawing.Size(39, 33);
            this.pic_ExitButton.TabIndex = 9;
            this.pic_ExitButton.TabStop = false;
            this.tip_Exit.SetToolTip(this.pic_ExitButton, "Exit");
            this.pic_ExitButton.Click += new System.EventHandler(this.pic_ExitButton_Click);
            // 
            // pnl_LoginBackgroundImage
            // 
            this.pnl_LoginBackgroundImage.BackColor = System.Drawing.Color.Transparent;
            this.pnl_LoginBackgroundImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_LoginBackgroundImage.BackgroundImage")));
            this.pnl_LoginBackgroundImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_LoginBackgroundImage.Controls.Add(this.lbl_CompanyName);
            this.pnl_LoginBackgroundImage.Controls.Add(this.pic_ExitButton);
            this.pnl_LoginBackgroundImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_LoginBackgroundImage.Name = "pnl_LoginBackgroundImage";
            this.pnl_LoginBackgroundImage.Size = new System.Drawing.Size(724, 286);
            this.pnl_LoginBackgroundImage.TabIndex = 16;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Baskerville Old Face", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_CompanyName.Location = new System.Drawing.Point(3, 239);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(263, 43);
            this.lbl_CompanyName.TabIndex = 7;
            this.lbl_CompanyName.Text = "EXPRESS COR";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Password.Location = new System.Drawing.Point(104, 386);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 29);
            this.lbl_Password.TabIndex = 15;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Username.Location = new System.Drawing.Point(101, 347);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(109, 29);
            this.lbl_Username.TabIndex = 14;
            this.lbl_Username.Text = "Username:";
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Username.Location = new System.Drawing.Point(216, 347);
            this.txt_Username.MaxLength = 32900;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(456, 32);
            this.txt_Username.TabIndex = 13;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txt_Password.Location = new System.Drawing.Point(216, 384);
            this.txt_Password.MaxLength = 32900;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(456, 32);
            this.txt_Password.TabIndex = 12;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(588, 430);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(84, 37);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "&Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_SignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_SignUp.Location = new System.Drawing.Point(498, 430);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(84, 37);
            this.btn_SignUp.TabIndex = 10;
            this.btn_SignUp.Text = "&Sign Up";
            this.tip_SignUp.SetToolTip(this.btn_SignUp, "Click here to join the team!\r\n");
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
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.btn_SignUp);
            this.panel1.Controls.Add(this.pnl_LoginBackgroundImage);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 495);
            this.panel1.TabIndex = 10;
            // 
            // frm_Login
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
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pic_ExitButton)).EndInit();
            this.pnl_LoginBackgroundImage.ResumeLayout(false);
            this.pnl_LoginBackgroundImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Password)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ExitButton;
        private System.Windows.Forms.Panel pnl_LoginBackgroundImage;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.ErrorProvider err_Username;
        private System.Windows.Forms.ErrorProvider err_Password;
        private System.Windows.Forms.ToolTip tip_SignUp;
        private System.Windows.Forms.ToolTip tip_Exit;
        private System.Windows.Forms.Panel panel1;
    }
}