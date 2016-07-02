namespace prjZooApplication
{
    partial class frmDelete
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
            this.lblUniqueId = new System.Windows.Forms.Label();
            this.cmbxUniqueID = new System.Windows.Forms.ComboBox();
            this.lblReasonForDeletion = new System.Windows.Forms.Label();
            this.rhtxReason = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeletedRecs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUniqueId
            // 
            this.lblUniqueId.AutoSize = true;
            this.lblUniqueId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUniqueId.Location = new System.Drawing.Point(103, 24);
            this.lblUniqueId.Name = "lblUniqueId";
            this.lblUniqueId.Size = new System.Drawing.Size(146, 20);
            this.lblUniqueId.TabIndex = 1;
            this.lblUniqueId.Text = "Select Unique ID";
            // 
            // cmbxUniqueID
            // 
            this.cmbxUniqueID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUniqueID.FormattingEnabled = true;
            this.cmbxUniqueID.Location = new System.Drawing.Point(116, 47);
            this.cmbxUniqueID.Name = "cmbxUniqueID";
            this.cmbxUniqueID.Size = new System.Drawing.Size(123, 21);
            this.cmbxUniqueID.TabIndex = 2;
            // 
            // lblReasonForDeletion
            // 
            this.lblReasonForDeletion.AutoSize = true;
            this.lblReasonForDeletion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReasonForDeletion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReasonForDeletion.Location = new System.Drawing.Point(93, 88);
            this.lblReasonForDeletion.Name = "lblReasonForDeletion";
            this.lblReasonForDeletion.Size = new System.Drawing.Size(170, 20);
            this.lblReasonForDeletion.TabIndex = 3;
            this.lblReasonForDeletion.Text = "Reason for Deletion";
            // 
            // rhtxReason
            // 
            this.rhtxReason.Location = new System.Drawing.Point(97, 120);
            this.rhtxReason.Name = "rhtxReason";
            this.rhtxReason.Size = new System.Drawing.Size(163, 66);
            this.rhtxReason.TabIndex = 4;
            this.rhtxReason.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 37);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeletedRecs
            // 
            this.btnDeletedRecs.Location = new System.Drawing.Point(276, 12);
            this.btnDeletedRecs.Name = "btnDeletedRecs";
            this.btnDeletedRecs.Size = new System.Drawing.Size(82, 37);
            this.btnDeletedRecs.TabIndex = 7;
            this.btnDeletedRecs.Text = "View Deleted Records";
            this.btnDeletedRecs.UseVisualStyleBackColor = true;
            this.btnDeletedRecs.Click += new System.EventHandler(this.btnDeletedRecs_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(370, 251);
            this.Controls.Add(this.btnDeletedRecs);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rhtxReason);
            this.Controls.Add(this.lblReasonForDeletion);
            this.Controls.Add(this.cmbxUniqueID);
            this.Controls.Add(this.lblUniqueId);
            this.Name = "frmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Application - Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUniqueId;
        private System.Windows.Forms.ComboBox cmbxUniqueID;
        private System.Windows.Forms.Label lblReasonForDeletion;
        private System.Windows.Forms.RichTextBox rhtxReason;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeletedRecs;
    }
}