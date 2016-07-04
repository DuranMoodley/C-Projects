namespace Trucking_Company
{
    partial class frm_SignUpLoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SignUpLoadingScreen));
            this.prg_Loading = new System.Windows.Forms.ProgressBar();
            this.tmr_Loading = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // prg_Loading
            // 
            this.prg_Loading.Location = new System.Drawing.Point(71, 315);
            this.prg_Loading.Name = "prg_Loading";
            this.prg_Loading.Size = new System.Drawing.Size(554, 23);
            this.prg_Loading.TabIndex = 0;
            // 
            // tmr_Loading
            // 
            this.tmr_Loading.Enabled = true;
            this.tmr_Loading.Tick += new System.EventHandler(this.tmr_Loading_Tick);
            // 
            // frm_SignUpLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 350);
            this.Controls.Add(this.prg_Loading);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_SignUpLoadingScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prg_Loading;
        private System.Windows.Forms.Timer tmr_Loading;
    }
}