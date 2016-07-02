namespace prjZooApplication
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.pctSplashImage = new System.Windows.Forms.PictureBox();
            this.prbSplashScreen = new System.Windows.Forms.ProgressBar();
            this.tmrSplashScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctSplashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSplashImage
            // 
            this.pctSplashImage.Image = ((System.Drawing.Image)(resources.GetObject("pctSplashImage.Image")));
            this.pctSplashImage.Location = new System.Drawing.Point(3, -2);
            this.pctSplashImage.Name = "pctSplashImage";
            this.pctSplashImage.Size = new System.Drawing.Size(451, 299);
            this.pctSplashImage.TabIndex = 0;
            this.pctSplashImage.TabStop = false;
            // 
            // prbSplashScreen
            // 
            this.prbSplashScreen.Location = new System.Drawing.Point(106, 256);
            this.prbSplashScreen.Name = "prbSplashScreen";
            this.prbSplashScreen.Size = new System.Drawing.Size(223, 32);
            this.prbSplashScreen.TabIndex = 1;
            // 
            // tmrSplashScreen
            // 
            this.tmrSplashScreen.Enabled = true;
            this.tmrSplashScreen.Interval = 25;
            this.tmrSplashScreen.Tick += new System.EventHandler(this.tmrSplashScreen_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 300);
            this.Controls.Add(this.prbSplashScreen);
            this.Controls.Add(this.pctSplashImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pctSplashImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSplashImage;
        private System.Windows.Forms.ProgressBar prbSplashScreen;
        private System.Windows.Forms.Timer tmrSplashScreen;

    }
}