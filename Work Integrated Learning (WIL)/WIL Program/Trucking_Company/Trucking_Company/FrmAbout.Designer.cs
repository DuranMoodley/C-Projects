namespace Trucking_Company
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.GrpMessage = new System.Windows.Forms.GroupBox();
            this.LblMessage = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.LblMotto = new System.Windows.Forms.Label();
            this.TipAboutVacationHub = new System.Windows.Forms.ToolTip(this.components);
            this.GrpMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpMessage
            // 
            this.GrpMessage.Controls.Add(this.LblMessage);
            this.GrpMessage.Controls.Add(this.BtnReturn);
            this.GrpMessage.Controls.Add(this.LblMotto);
            this.GrpMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpMessage.ForeColor = System.Drawing.Color.White;
            this.GrpMessage.Location = new System.Drawing.Point(12, 0);
            this.GrpMessage.Name = "GrpMessage";
            this.GrpMessage.Size = new System.Drawing.Size(684, 502);
            this.GrpMessage.TabIndex = 40;
            this.GrpMessage.TabStop = false;
            this.GrpMessage.Text = "About Cargo Fleet";
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.ForeColor = System.Drawing.Color.White;
            this.LblMessage.Location = new System.Drawing.Point(6, 94);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(668, 220);
            this.LblMessage.TabIndex = 23;
            this.LblMessage.Text = resources.GetString("LblMessage.Text");
            // 
            // BtnReturn
            // 
            this.BtnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnReturn.BackgroundImage")));
            this.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnReturn.FlatAppearance.BorderSize = 0;
            this.BtnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReturn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnReturn.Location = new System.Drawing.Point(642, 21);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(36, 28);
            this.BtnReturn.TabIndex = 40;
            this.TipAboutVacationHub.SetToolTip(this.BtnReturn, "Return to main menu");
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblMotto
            // 
            this.LblMotto.AutoSize = true;
            this.LblMotto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblMotto.Location = new System.Drawing.Point(190, 476);
            this.LblMotto.Name = "LblMotto";
            this.LblMotto.Size = new System.Drawing.Size(288, 23);
            this.LblMotto.TabIndex = 38;
            this.LblMotto.Text = "\"THE NEXT EVOLUTION IN TRUCKING\"";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 514);
            this.ControlBox = false;
            this.Controls.Add(this.GrpMessage);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.GrpMessage.ResumeLayout(false);
            this.GrpMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpMessage;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnReturn;
        private System.Windows.Forms.ToolTip TipAboutVacationHub;
        private System.Windows.Forms.Label LblMotto;
    }
}