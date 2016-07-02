namespace prjZooApplication
{
    partial class frmAddLion
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
            this.tbcLion = new System.Windows.Forms.TabControl();
            this.tbBasicInfo = new System.Windows.Forms.TabPage();
            this.lblExampleWeight = new System.Windows.Forms.Label();
            this.cmbxEveningTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimeEvening = new System.Windows.Forms.Label();
            this.cmbxAfternoonTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimeAfternoon = new System.Windows.Forms.Label();
            this.cmbxMorningTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimesMorning = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSpecificInfo = new System.Windows.Forms.TabPage();
            this.lblClawExample = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.lblMane = new System.Windows.Forms.Label();
            this.txtClawLength = new System.Windows.Forms.TextBox();
            this.lblClaw = new System.Windows.Forms.Label();
            this.txtSkinType = new System.Windows.Forms.TextBox();
            this.lblSkinType = new System.Windows.Forms.Label();
            this.txtSkinColour = new System.Windows.Forms.TextBox();
            this.lblLionSkinColour = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbcLion.SuspendLayout();
            this.tbBasicInfo.SuspendLayout();
            this.tbSpecificInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcLion
            // 
            this.tbcLion.Controls.Add(this.tbBasicInfo);
            this.tbcLion.Controls.Add(this.tbSpecificInfo);
            this.tbcLion.Location = new System.Drawing.Point(12, 12);
            this.tbcLion.Name = "tbcLion";
            this.tbcLion.SelectedIndex = 0;
            this.tbcLion.Size = new System.Drawing.Size(413, 449);
            this.tbcLion.TabIndex = 0;
            // 
            // tbBasicInfo
            // 
            this.tbBasicInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbBasicInfo.Controls.Add(this.lblExampleWeight);
            this.tbBasicInfo.Controls.Add(this.cmbxEveningTime);
            this.tbBasicInfo.Controls.Add(this.lblFeedingTimeEvening);
            this.tbBasicInfo.Controls.Add(this.cmbxAfternoonTime);
            this.tbBasicInfo.Controls.Add(this.lblFeedingTimeAfternoon);
            this.tbBasicInfo.Controls.Add(this.cmbxMorningTime);
            this.tbBasicInfo.Controls.Add(this.lblFeedingTimesMorning);
            this.tbBasicInfo.Controls.Add(this.txtAge);
            this.tbBasicInfo.Controls.Add(this.lblAge);
            this.tbBasicInfo.Controls.Add(this.txtWeight);
            this.tbBasicInfo.Controls.Add(this.lblWeight);
            this.tbBasicInfo.Controls.Add(this.radFemale);
            this.tbBasicInfo.Controls.Add(this.radMale);
            this.tbBasicInfo.Controls.Add(this.lblGender);
            this.tbBasicInfo.Controls.Add(this.txtUniqueID);
            this.tbBasicInfo.Controls.Add(this.lblID);
            this.tbBasicInfo.Controls.Add(this.txtName);
            this.tbBasicInfo.Controls.Add(this.lblName);
            this.tbBasicInfo.Location = new System.Drawing.Point(4, 22);
            this.tbBasicInfo.Name = "tbBasicInfo";
            this.tbBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbBasicInfo.Size = new System.Drawing.Size(405, 423);
            this.tbBasicInfo.TabIndex = 0;
            this.tbBasicInfo.Text = "Basic Information";
            // 
            // lblExampleWeight
            // 
            this.lblExampleWeight.AutoSize = true;
            this.lblExampleWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExampleWeight.Location = new System.Drawing.Point(215, 186);
            this.lblExampleWeight.Name = "lblExampleWeight";
            this.lblExampleWeight.Size = new System.Drawing.Size(122, 13);
            this.lblExampleWeight.TabIndex = 36;
            this.lblExampleWeight.Text = "Eg. 20 instead of 20 kgs";
            // 
            // cmbxEveningTime
            // 
            this.cmbxEveningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEveningTime.FormattingEnabled = true;
            this.cmbxEveningTime.Items.AddRange(new object[] {
            "18:30pm",
            "21:00pm",
            "23:00pm"});
            this.cmbxEveningTime.Location = new System.Drawing.Point(218, 328);
            this.cmbxEveningTime.Name = "cmbxEveningTime";
            this.cmbxEveningTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxEveningTime.TabIndex = 35;
            // 
            // lblFeedingTimeEvening
            // 
            this.lblFeedingTimeEvening.AutoSize = true;
            this.lblFeedingTimeEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimeEvening.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimeEvening.Location = new System.Drawing.Point(16, 329);
            this.lblFeedingTimeEvening.Name = "lblFeedingTimeEvening";
            this.lblFeedingTimeEvening.Size = new System.Drawing.Size(186, 20);
            this.lblFeedingTimeEvening.TabIndex = 34;
            this.lblFeedingTimeEvening.Text = "Feeding Time Evening";
            // 
            // cmbxAfternoonTime
            // 
            this.cmbxAfternoonTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAfternoonTime.FormattingEnabled = true;
            this.cmbxAfternoonTime.Items.AddRange(new object[] {
            "12:30pm",
            "15:30pm",
            "17:30pm"});
            this.cmbxAfternoonTime.Location = new System.Drawing.Point(218, 290);
            this.cmbxAfternoonTime.Name = "cmbxAfternoonTime";
            this.cmbxAfternoonTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxAfternoonTime.TabIndex = 33;
            // 
            // lblFeedingTimeAfternoon
            // 
            this.lblFeedingTimeAfternoon.AutoSize = true;
            this.lblFeedingTimeAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimeAfternoon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimeAfternoon.Location = new System.Drawing.Point(16, 291);
            this.lblFeedingTimeAfternoon.Name = "lblFeedingTimeAfternoon";
            this.lblFeedingTimeAfternoon.Size = new System.Drawing.Size(202, 20);
            this.lblFeedingTimeAfternoon.TabIndex = 32;
            this.lblFeedingTimeAfternoon.Text = "Feeding Time Afternoon";
            // 
            // cmbxMorningTime
            // 
            this.cmbxMorningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMorningTime.FormattingEnabled = true;
            this.cmbxMorningTime.Items.AddRange(new object[] {
            "08:00am",
            "11:00am"});
            this.cmbxMorningTime.Location = new System.Drawing.Point(218, 251);
            this.cmbxMorningTime.Name = "cmbxMorningTime";
            this.cmbxMorningTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxMorningTime.TabIndex = 31;
            // 
            // lblFeedingTimesMorning
            // 
            this.lblFeedingTimesMorning.AutoSize = true;
            this.lblFeedingTimesMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimesMorning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimesMorning.Location = new System.Drawing.Point(16, 252);
            this.lblFeedingTimesMorning.Name = "lblFeedingTimesMorning";
            this.lblFeedingTimesMorning.Size = new System.Drawing.Size(186, 20);
            this.lblFeedingTimesMorning.TabIndex = 30;
            this.lblFeedingTimesMorning.Text = "Feeding Time Morning";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(218, 206);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(170, 20);
            this.txtAge.TabIndex = 29;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAge.Location = new System.Drawing.Point(16, 206);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 20);
            this.lblAge.TabIndex = 28;
            this.lblAge.Text = "Age";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(218, 163);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(170, 20);
            this.txtWeight.TabIndex = 27;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWeight.Location = new System.Drawing.Point(16, 163);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 20);
            this.lblWeight.TabIndex = 26;
            this.lblWeight.Text = "Weight";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radFemale.Location = new System.Drawing.Point(329, 125);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 17;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radMale.Location = new System.Drawing.Point(218, 125);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 16;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(16, 125);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "Gender";
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Enabled = false;
            this.txtUniqueID.Location = new System.Drawing.Point(218, 85);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.Size = new System.Drawing.Size(170, 20);
            this.txtUniqueID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(16, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 20);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "Unique ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(218, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(16, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 20);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name Of Animal";
            // 
            // tbSpecificInfo
            // 
            this.tbSpecificInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSpecificInfo.Controls.Add(this.btnClear);
            this.tbSpecificInfo.Controls.Add(this.lblClawExample);
            this.tbSpecificInfo.Controls.Add(this.btnSave);
            this.tbSpecificInfo.Controls.Add(this.radNo);
            this.tbSpecificInfo.Controls.Add(this.radYes);
            this.tbSpecificInfo.Controls.Add(this.lblMane);
            this.tbSpecificInfo.Controls.Add(this.txtClawLength);
            this.tbSpecificInfo.Controls.Add(this.lblClaw);
            this.tbSpecificInfo.Controls.Add(this.txtSkinType);
            this.tbSpecificInfo.Controls.Add(this.lblSkinType);
            this.tbSpecificInfo.Controls.Add(this.txtSkinColour);
            this.tbSpecificInfo.Controls.Add(this.lblLionSkinColour);
            this.tbSpecificInfo.Location = new System.Drawing.Point(4, 22);
            this.tbSpecificInfo.Name = "tbSpecificInfo";
            this.tbSpecificInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbSpecificInfo.Size = new System.Drawing.Size(405, 423);
            this.tbSpecificInfo.TabIndex = 1;
            this.tbSpecificInfo.Text = "Specific Information";
            // 
            // lblClawExample
            // 
            this.lblClawExample.AutoSize = true;
            this.lblClawExample.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClawExample.Location = new System.Drawing.Point(204, 193);
            this.lblClawExample.Name = "lblClawExample";
            this.lblClawExample.Size = new System.Drawing.Size(119, 13);
            this.lblClawExample.TabIndex = 37;
            this.lblClawExample.Text = "Eg. 20 instead of 20 cm";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 21);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radNo.Location = new System.Drawing.Point(304, 225);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(39, 17);
            this.radNo.TabIndex = 14;
            this.radNo.TabStop = true;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radYes.Location = new System.Drawing.Point(207, 225);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(43, 17);
            this.radYes.TabIndex = 13;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // lblMane
            // 
            this.lblMane.AutoSize = true;
            this.lblMane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMane.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMane.Location = new System.Drawing.Point(25, 222);
            this.lblMane.Name = "lblMane";
            this.lblMane.Size = new System.Drawing.Size(53, 20);
            this.lblMane.TabIndex = 12;
            this.lblMane.Text = "Mane";
            // 
            // txtClawLength
            // 
            this.txtClawLength.Location = new System.Drawing.Point(207, 170);
            this.txtClawLength.Name = "txtClawLength";
            this.txtClawLength.Size = new System.Drawing.Size(136, 20);
            this.txtClawLength.TabIndex = 11;
            // 
            // lblClaw
            // 
            this.lblClaw.AutoSize = true;
            this.lblClaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClaw.Location = new System.Drawing.Point(25, 168);
            this.lblClaw.Name = "lblClaw";
            this.lblClaw.Size = new System.Drawing.Size(147, 20);
            this.lblClaw.TabIndex = 10;
            this.lblClaw.Text = "Lion Claw Length";
            // 
            // txtSkinType
            // 
            this.txtSkinType.Location = new System.Drawing.Point(207, 111);
            this.txtSkinType.Name = "txtSkinType";
            this.txtSkinType.Size = new System.Drawing.Size(136, 20);
            this.txtSkinType.TabIndex = 9;
            // 
            // lblSkinType
            // 
            this.lblSkinType.AutoSize = true;
            this.lblSkinType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkinType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSkinType.Location = new System.Drawing.Point(25, 109);
            this.lblSkinType.Name = "lblSkinType";
            this.lblSkinType.Size = new System.Drawing.Size(126, 20);
            this.lblSkinType.TabIndex = 8;
            this.lblSkinType.Text = "Lion Skin Type";
            // 
            // txtSkinColour
            // 
            this.txtSkinColour.Location = new System.Drawing.Point(207, 59);
            this.txtSkinColour.Name = "txtSkinColour";
            this.txtSkinColour.Size = new System.Drawing.Size(136, 20);
            this.txtSkinColour.TabIndex = 7;
            // 
            // lblLionSkinColour
            // 
            this.lblLionSkinColour.AutoSize = true;
            this.lblLionSkinColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLionSkinColour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLionSkinColour.Location = new System.Drawing.Point(25, 57);
            this.lblLionSkinColour.Name = "lblLionSkinColour";
            this.lblLionSkinColour.Size = new System.Drawing.Size(140, 20);
            this.lblLionSkinColour.TabIndex = 3;
            this.lblLionSkinColour.Text = "Lion Skin Colour";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(307, 467);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(118, 21);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 467);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 21);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 21);
            this.btnClear.TabIndex = 38;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmAddLion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(437, 500);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.tbcLion);
            this.Name = "frmAddLion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Application - Add Lion";
            this.tbcLion.ResumeLayout(false);
            this.tbBasicInfo.ResumeLayout(false);
            this.tbBasicInfo.PerformLayout();
            this.tbSpecificInfo.ResumeLayout(false);
            this.tbSpecificInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcLion;
        private System.Windows.Forms.TabPage tbBasicInfo;
        private System.Windows.Forms.TabPage tbSpecificInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtUniqueID;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblFeedingTimesMorning;
        private System.Windows.Forms.ComboBox cmbxMorningTime;
        private System.Windows.Forms.Label lblFeedingTimeAfternoon;
        private System.Windows.Forms.ComboBox cmbxAfternoonTime;
        private System.Windows.Forms.Label lblFeedingTimeEvening;
        private System.Windows.Forms.ComboBox cmbxEveningTime;
        private System.Windows.Forms.Label lblLionSkinColour;
        private System.Windows.Forms.TextBox txtSkinColour;
        private System.Windows.Forms.Label lblSkinType;
        private System.Windows.Forms.TextBox txtSkinType;
        private System.Windows.Forms.Label lblClaw;
        private System.Windows.Forms.TextBox txtClawLength;
        private System.Windows.Forms.Label lblMane;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblExampleWeight;
        private System.Windows.Forms.Label lblClawExample;
        private System.Windows.Forms.Button btnClear;
    }
}