namespace prjVarsityCollegeTestApplication
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
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.prb = new System.Windows.Forms.ProgressBar();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // picSplash
            // 
            this.picSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplash.Image = ((System.Drawing.Image)(resources.GetObject("picSplash.Image")));
            this.picSplash.Location = new System.Drawing.Point(0, 0);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(273, 231);
            this.picSplash.TabIndex = 0;
            this.picSplash.TabStop = false;
            // 
            // prb
            // 
            this.prb.Location = new System.Drawing.Point(43, 193);
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(196, 23);
            this.prb.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(273, 231);
            this.Controls.Add(this.prb);
            this.Controls.Add(this.picSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.ProgressBar prb;
        private System.Windows.Forms.Timer tmr;
    }
}