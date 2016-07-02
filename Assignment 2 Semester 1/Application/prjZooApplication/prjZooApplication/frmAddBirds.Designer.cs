namespace prjZooApplication
{
    partial class frmAddBirds
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
            this.tbcAddBirds = new System.Windows.Forms.TabControl();
            this.tbpBasicInformation = new System.Windows.Forms.TabPage();
            this.lblExample = new System.Windows.Forms.Label();
            this.cmbxEveningTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimeEvening = new System.Windows.Forms.Label();
            this.cmbxAfternoonTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimeAfternoon = new System.Windows.Forms.Label();
            this.cmbxMorningTime = new System.Windows.Forms.ComboBox();
            this.lblFeedingTimesMorning = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtUniqueID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbpSpecificInformation = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBeakExample = new System.Windows.Forms.Label();
            this.lblLengthExample = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbxFeatherType = new System.Windows.Forms.ComboBox();
            this.lblFeatherType = new System.Windows.Forms.Label();
            this.txtBeakLength = new System.Windows.Forms.TextBox();
            this.lblBeakLength = new System.Windows.Forms.Label();
            this.txtWingColour = new System.Windows.Forms.TextBox();
            this.lblWingColour = new System.Windows.Forms.Label();
            this.txtWingLength = new System.Windows.Forms.TextBox();
            this.lblWingLength = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.tbcAddBirds.SuspendLayout();
            this.tbpBasicInformation.SuspendLayout();
            this.tbpSpecificInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcAddBirds
            // 
            this.tbcAddBirds.Controls.Add(this.tbpBasicInformation);
            this.tbcAddBirds.Controls.Add(this.tbpSpecificInformation);
            this.tbcAddBirds.Location = new System.Drawing.Point(12, 12);
            this.tbcAddBirds.Name = "tbcAddBirds";
            this.tbcAddBirds.SelectedIndex = 0;
            this.tbcAddBirds.Size = new System.Drawing.Size(414, 427);
            this.tbcAddBirds.TabIndex = 0;
            // 
            // tbpBasicInformation
            // 
            this.tbpBasicInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbpBasicInformation.Controls.Add(this.lblExample);
            this.tbpBasicInformation.Controls.Add(this.cmbxEveningTime);
            this.tbpBasicInformation.Controls.Add(this.lblFeedingTimeEvening);
            this.tbpBasicInformation.Controls.Add(this.cmbxAfternoonTime);
            this.tbpBasicInformation.Controls.Add(this.lblFeedingTimeAfternoon);
            this.tbpBasicInformation.Controls.Add(this.cmbxMorningTime);
            this.tbpBasicInformation.Controls.Add(this.lblFeedingTimesMorning);
            this.tbpBasicInformation.Controls.Add(this.txtAge);
            this.tbpBasicInformation.Controls.Add(this.lblAge);
            this.tbpBasicInformation.Controls.Add(this.lblWeight);
            this.tbpBasicInformation.Controls.Add(this.txtWeight);
            this.tbpBasicInformation.Controls.Add(this.radFemale);
            this.tbpBasicInformation.Controls.Add(this.radMale);
            this.tbpBasicInformation.Controls.Add(this.lblGender);
            this.tbpBasicInformation.Controls.Add(this.txtUniqueID);
            this.tbpBasicInformation.Controls.Add(this.lblID);
            this.tbpBasicInformation.Controls.Add(this.txtName);
            this.tbpBasicInformation.Controls.Add(this.lblName);
            this.tbpBasicInformation.Location = new System.Drawing.Point(4, 22);
            this.tbpBasicInformation.Name = "tbpBasicInformation";
            this.tbpBasicInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBasicInformation.Size = new System.Drawing.Size(406, 401);
            this.tbpBasicInformation.TabIndex = 0;
            this.tbpBasicInformation.Text = "Basic Information";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExample.Location = new System.Drawing.Point(220, 185);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(118, 13);
            this.lblExample.TabIndex = 38;
            this.lblExample.Text = "Eg.  20 instead of 20Kg";
            // 
            // cmbxEveningTime
            // 
            this.cmbxEveningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEveningTime.FormattingEnabled = true;
            this.cmbxEveningTime.Items.AddRange(new object[] {
            "18:30pm",
            "21:00pm",
            "23:00pm"});
            this.cmbxEveningTime.Location = new System.Drawing.Point(223, 332);
            this.cmbxEveningTime.Name = "cmbxEveningTime";
            this.cmbxEveningTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxEveningTime.TabIndex = 37;
            // 
            // lblFeedingTimeEvening
            // 
            this.lblFeedingTimeEvening.AutoSize = true;
            this.lblFeedingTimeEvening.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimeEvening.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimeEvening.Location = new System.Drawing.Point(6, 333);
            this.lblFeedingTimeEvening.Name = "lblFeedingTimeEvening";
            this.lblFeedingTimeEvening.Size = new System.Drawing.Size(186, 20);
            this.lblFeedingTimeEvening.TabIndex = 36;
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
            this.cmbxAfternoonTime.Location = new System.Drawing.Point(223, 291);
            this.cmbxAfternoonTime.Name = "cmbxAfternoonTime";
            this.cmbxAfternoonTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxAfternoonTime.TabIndex = 35;
            // 
            // lblFeedingTimeAfternoon
            // 
            this.lblFeedingTimeAfternoon.AutoSize = true;
            this.lblFeedingTimeAfternoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimeAfternoon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimeAfternoon.Location = new System.Drawing.Point(6, 292);
            this.lblFeedingTimeAfternoon.Name = "lblFeedingTimeAfternoon";
            this.lblFeedingTimeAfternoon.Size = new System.Drawing.Size(202, 20);
            this.lblFeedingTimeAfternoon.TabIndex = 34;
            this.lblFeedingTimeAfternoon.Text = "Feeding Time Afternoon";
            // 
            // cmbxMorningTime
            // 
            this.cmbxMorningTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMorningTime.FormattingEnabled = true;
            this.cmbxMorningTime.Items.AddRange(new object[] {
            "08:00am",
            "11:00am"});
            this.cmbxMorningTime.Location = new System.Drawing.Point(223, 252);
            this.cmbxMorningTime.Name = "cmbxMorningTime";
            this.cmbxMorningTime.Size = new System.Drawing.Size(170, 21);
            this.cmbxMorningTime.TabIndex = 33;
            // 
            // lblFeedingTimesMorning
            // 
            this.lblFeedingTimesMorning.AutoSize = true;
            this.lblFeedingTimesMorning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedingTimesMorning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeedingTimesMorning.Location = new System.Drawing.Point(6, 253);
            this.lblFeedingTimesMorning.Name = "lblFeedingTimesMorning";
            this.lblFeedingTimesMorning.Size = new System.Drawing.Size(186, 20);
            this.lblFeedingTimesMorning.TabIndex = 32;
            this.lblFeedingTimesMorning.Text = "Feeding Time Morning";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(223, 212);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(170, 20);
            this.txtAge.TabIndex = 31;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAge.Location = new System.Drawing.Point(6, 210);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(41, 20);
            this.lblAge.TabIndex = 30;
            this.lblAge.Text = "Age";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWeight.Location = new System.Drawing.Point(6, 164);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(65, 20);
            this.lblWeight.TabIndex = 29;
            this.lblWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(223, 164);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(170, 20);
            this.txtWeight.TabIndex = 28;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radFemale.Location = new System.Drawing.Point(334, 128);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 18;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radMale.Location = new System.Drawing.Point(223, 128);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 17;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(6, 128);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 16;
            this.lblGender.Text = "Gender";
            // 
            // txtUniqueID
            // 
            this.txtUniqueID.Enabled = false;
            this.txtUniqueID.Location = new System.Drawing.Point(223, 91);
            this.txtUniqueID.Name = "txtUniqueID";
            this.txtUniqueID.Size = new System.Drawing.Size(170, 20);
            this.txtUniqueID.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(6, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(90, 20);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Unique ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(6, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name Of Animal";
            // 
            // tbpSpecificInformation
            // 
            this.tbpSpecificInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbpSpecificInformation.Controls.Add(this.btnClear);
            this.tbpSpecificInformation.Controls.Add(this.lblBeakExample);
            this.tbpSpecificInformation.Controls.Add(this.lblLengthExample);
            this.tbpSpecificInformation.Controls.Add(this.btnSave);
            this.tbpSpecificInformation.Controls.Add(this.cmbxFeatherType);
            this.tbpSpecificInformation.Controls.Add(this.lblFeatherType);
            this.tbpSpecificInformation.Controls.Add(this.txtBeakLength);
            this.tbpSpecificInformation.Controls.Add(this.lblBeakLength);
            this.tbpSpecificInformation.Controls.Add(this.txtWingColour);
            this.tbpSpecificInformation.Controls.Add(this.lblWingColour);
            this.tbpSpecificInformation.Controls.Add(this.txtWingLength);
            this.tbpSpecificInformation.Controls.Add(this.lblWingLength);
            this.tbpSpecificInformation.Location = new System.Drawing.Point(4, 22);
            this.tbpSpecificInformation.Name = "tbpSpecificInformation";
            this.tbpSpecificInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSpecificInformation.Size = new System.Drawing.Size(406, 401);
            this.tbpSpecificInformation.TabIndex = 1;
            this.tbpSpecificInformation.Text = "Specific Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(273, 353);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 27);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBeakExample
            // 
            this.lblBeakExample.AutoSize = true;
            this.lblBeakExample.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBeakExample.Location = new System.Drawing.Point(207, 168);
            this.lblBeakExample.Name = "lblBeakExample";
            this.lblBeakExample.Size = new System.Drawing.Size(119, 13);
            this.lblBeakExample.TabIndex = 23;
            this.lblBeakExample.Text = "Eg. 20 instead of 20 cm";
            // 
            // lblLengthExample
            // 
            this.lblLengthExample.AutoSize = true;
            this.lblLengthExample.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLengthExample.Location = new System.Drawing.Point(207, 84);
            this.lblLengthExample.Name = "lblLengthExample";
            this.lblLengthExample.Size = new System.Drawing.Size(119, 13);
            this.lblLengthExample.TabIndex = 22;
            this.lblLengthExample.Text = "Eg. 20 instead of 20 cm";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 27);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbxFeatherType
            // 
            this.cmbxFeatherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFeatherType.FormattingEnabled = true;
            this.cmbxFeatherType.Items.AddRange(new object[] {
            "Vaned",
            "Contour"});
            this.cmbxFeatherType.Location = new System.Drawing.Point(210, 188);
            this.cmbxFeatherType.Name = "cmbxFeatherType";
            this.cmbxFeatherType.Size = new System.Drawing.Size(170, 21);
            this.cmbxFeatherType.TabIndex = 20;
            // 
            // lblFeatherType
            // 
            this.lblFeatherType.AutoSize = true;
            this.lblFeatherType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatherType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFeatherType.Location = new System.Drawing.Point(22, 189);
            this.lblFeatherType.Name = "lblFeatherType";
            this.lblFeatherType.Size = new System.Drawing.Size(115, 20);
            this.lblFeatherType.TabIndex = 19;
            this.lblFeatherType.Text = "Feather Type";
            // 
            // txtBeakLength
            // 
            this.txtBeakLength.Location = new System.Drawing.Point(210, 145);
            this.txtBeakLength.Name = "txtBeakLength";
            this.txtBeakLength.Size = new System.Drawing.Size(170, 20);
            this.txtBeakLength.TabIndex = 18;
            // 
            // lblBeakLength
            // 
            this.lblBeakLength.AutoSize = true;
            this.lblBeakLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeakLength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBeakLength.Location = new System.Drawing.Point(22, 145);
            this.lblBeakLength.Name = "lblBeakLength";
            this.lblBeakLength.Size = new System.Drawing.Size(111, 20);
            this.lblBeakLength.TabIndex = 17;
            this.lblBeakLength.Text = "Beak Length";
            // 
            // txtWingColour
            // 
            this.txtWingColour.Location = new System.Drawing.Point(210, 106);
            this.txtWingColour.Name = "txtWingColour";
            this.txtWingColour.Size = new System.Drawing.Size(170, 20);
            this.txtWingColour.TabIndex = 16;
            // 
            // lblWingColour
            // 
            this.lblWingColour.AutoSize = true;
            this.lblWingColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingColour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWingColour.Location = new System.Drawing.Point(22, 106);
            this.lblWingColour.Name = "lblWingColour";
            this.lblWingColour.Size = new System.Drawing.Size(106, 20);
            this.lblWingColour.TabIndex = 15;
            this.lblWingColour.Text = "Wing Colour";
            // 
            // txtWingLength
            // 
            this.txtWingLength.Location = new System.Drawing.Point(210, 61);
            this.txtWingLength.Name = "txtWingLength";
            this.txtWingLength.Size = new System.Drawing.Size(170, 20);
            this.txtWingLength.TabIndex = 14;
            // 
            // lblWingLength
            // 
            this.lblWingLength.AutoSize = true;
            this.lblWingLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWingLength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWingLength.Location = new System.Drawing.Point(22, 61);
            this.lblWingLength.Name = "lblWingLength";
            this.lblWingLength.Size = new System.Drawing.Size(110, 20);
            this.lblWingLength.TabIndex = 13;
            this.lblWingLength.Text = "Wing Length";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 445);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 21);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(308, 445);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(118, 21);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // frmAddBirds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbcAddBirds);
            this.Name = "frmAddBirds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoo Application- Add Birds";
            this.tbcAddBirds.ResumeLayout(false);
            this.tbpBasicInformation.ResumeLayout(false);
            this.tbpBasicInformation.PerformLayout();
            this.tbpSpecificInformation.ResumeLayout(false);
            this.tbpSpecificInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcAddBirds;
        private System.Windows.Forms.TabPage tbpSpecificInformation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TabPage tbpBasicInformation;
        private System.Windows.Forms.Label lblFeedingTimeEvening;
        private System.Windows.Forms.ComboBox cmbxAfternoonTime;
        private System.Windows.Forms.Label lblFeedingTimeAfternoon;
        private System.Windows.Forms.ComboBox cmbxMorningTime;
        private System.Windows.Forms.Label lblFeedingTimesMorning;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtUniqueID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbxEveningTime;
        private System.Windows.Forms.Label lblWingLength;
        private System.Windows.Forms.Label lblWingColour;
        private System.Windows.Forms.TextBox txtWingLength;
        private System.Windows.Forms.TextBox txtWingColour;
        private System.Windows.Forms.TextBox txtBeakLength;
        private System.Windows.Forms.Label lblBeakLength;
        private System.Windows.Forms.Label lblFeatherType;
        private System.Windows.Forms.ComboBox cmbxFeatherType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Label lblLengthExample;
        private System.Windows.Forms.Label lblBeakExample;
        private System.Windows.Forms.Button btnClear;
    }
}