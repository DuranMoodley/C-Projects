namespace Trucking_Company
{
    partial class FrmLoadingScreenAfterAddedEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadingScreenAfterAddedEmployee));
            this.PicGif = new System.Windows.Forms.PictureBox();
            this.PrgLoading = new System.Windows.Forms.ProgressBar();
            this.TmrLoading = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicGif)).BeginInit();
            this.SuspendLayout();
            // 
            // PicGif
            // 
            this.PicGif.Image = ((System.Drawing.Image)(resources.GetObject("PicGif.Image")));
            this.PicGif.Location = new System.Drawing.Point(3, 3);
            this.PicGif.Name = "PicGif";
            this.PicGif.Size = new System.Drawing.Size(766, 448);
            this.PicGif.TabIndex = 0;
            this.PicGif.TabStop = false;
            // 
            // PrgLoading
            // 
            this.PrgLoading.Location = new System.Drawing.Point(341, 367);
            this.PrgLoading.Name = "PrgLoading";
            this.PrgLoading.Size = new System.Drawing.Size(100, 23);
            this.PrgLoading.TabIndex = 2;
            this.PrgLoading.Visible = false;
            // 
            // TmrLoading
            // 
            this.TmrLoading.Enabled = true;
            this.TmrLoading.Tick += new System.EventHandler(this.tmr_Loading_Tick);
            // 
            // FrmLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(772, 453);
            this.ControlBox = false;
            this.Controls.Add(this.PrgLoading);
            this.Controls.Add(this.PicGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.PicGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicGif;
        private System.Windows.Forms.ProgressBar PrgLoading;
        private System.Windows.Forms.Timer TmrLoading;
    }
}