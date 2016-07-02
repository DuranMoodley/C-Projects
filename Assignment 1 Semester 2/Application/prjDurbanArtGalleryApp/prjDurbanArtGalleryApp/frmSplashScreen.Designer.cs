namespace prjDurbanArtGalleryApp
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
            this.picSplashScreen = new System.Windows.Forms.PictureBox();
            this.prbSplash = new System.Windows.Forms.ProgressBar();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picSplashScreen
            // 
            this.picSplashScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplashScreen.Image = ((System.Drawing.Image)(resources.GetObject("picSplashScreen.Image")));
            this.picSplashScreen.Location = new System.Drawing.Point(0, 0);
            this.picSplashScreen.Name = "picSplashScreen";
            this.picSplashScreen.Size = new System.Drawing.Size(385, 261);
            this.picSplashScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSplashScreen.TabIndex = 0;
            this.picSplashScreen.TabStop = false;
            // 
            // prbSplash
            // 
            this.prbSplash.Location = new System.Drawing.Point(81, 217);
            this.prbSplash.Name = "prbSplash";
            this.prbSplash.Size = new System.Drawing.Size(222, 23);
            this.prbSplash.TabIndex = 1;
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 25;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.Controls.Add(this.prbSplash);
            this.Controls.Add(this.picSplashScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplashScreen;
        private System.Windows.Forms.ProgressBar prbSplash;
        private System.Windows.Forms.Timer tmr;
    }
}