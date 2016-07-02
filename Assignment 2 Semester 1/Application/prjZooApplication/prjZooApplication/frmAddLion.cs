/* frmAddLion.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Gets information about the Animal
 * Sends a text file
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjZooApplication
{
    public partial class frmAddLion : Form
    {
        public frmAddLion()
        {
            InitializeComponent();
        }
        public void GetAnimalInformation(  out string nameOfAnimal, 
                                           out string genderOfAnimal , out string weightOfAnimal,
                                           out string ageOfAnimal, out string morningTime ,
                                           out string afternoonTime ,out string eveningTime,
                                           out string skinColour , out string skinType,
                                           out string clawLength , out string mane)
        {
            GetRadioButtonGenderValue(out genderOfAnimal);
            GetTextBoxValues(out nameOfAnimal, txtName);
            GetTextBoxValues(out weightOfAnimal, txtWeight);
            GetTextBoxValues(out ageOfAnimal, txtAge);


            morningTime = cmbxMorningTime.Text;
            afternoonTime = cmbxAfternoonTime.Text;
            eveningTime = cmbxEveningTime.Text;   
       
            GetRadioButtonManeValues(out mane);
            GetTextBoxValues(out skinColour, txtSkinColour);
            GetTextBoxValues(out skinType, txtSkinType);
            GetTextBoxValues(out clawLength, txtClawLength);             
        }       
        //*******************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmSelectCategory objCatergory = new frmSelectCategory();
            objCatergory.Visible = true;
        }
        //******************************************************************************************
        public bool ValidateLionSpecificInformation(string colour, string typeOfSkin, 
                                                    string lengthClaw, string maned)
        {
            bool lionValid = true;
            double temporaryValue;
            int invalidInputs = 0;

            if (string.IsNullOrEmpty(colour))
            {
                invalidInputs++;
            }
            else if (string.IsNullOrEmpty(typeOfSkin))
            {
                invalidInputs++;
            }
            else if (string.IsNullOrEmpty(maned))
            {
                invalidInputs++;
            }
            else if(double.TryParse(lengthClaw,out temporaryValue) == false ||
                    double.Parse(lengthClaw) < 0)
            {
                invalidInputs++;
            }

            if(invalidInputs != 0)
            {
                lionValid = false;
            }
            return lionValid;
        }
        //***************************************************************************      
        private void btnSave_Click(object sender, EventArgs e)
        {            
            string animalName;
            string animalGender;
            string animalAge;
            string animalWeight;
            string feedingTimeMorning;
            string feedingTimeAfternoon;
            string feedingTimeEvening;
            string lionSkinColour;
            string lionSkinType;
            string lionManed;
            string lionClawLength;
            SaveRecords objSave;
            Validation objValidate;
            Lion objLion;
            string entireLionRecord = "";
            SpeechOutput objSpeech = new SpeechOutput();
            string errorMessage = "Please enter correct values in the appropriate fields";

            // get values from textboxes
            GetAnimalInformation(out animalName, out animalGender,
                                 out animalWeight, out animalAge, out feedingTimeMorning,
                                 out feedingTimeAfternoon, out feedingTimeEvening,
                                 out lionSkinColour, out lionSkinType, out lionClawLength,
                                 out lionManed);

            objValidate = new Validation(animalName, animalGender,
                                         animalWeight, animalAge, feedingTimeMorning,
                                         feedingTimeAfternoon, feedingTimeEvening);

            //Validate all the values
            if (objValidate.CheckInformation() &&
               ValidateLionSpecificInformation(lionSkinColour, lionSkinType, lionClawLength, lionManed))
            {
                //Once Validated, Parse values into Object
                objLion = new Lion(animalName, animalGender, animalAge, animalWeight, lionSkinType,
                                   lionSkinColour, lionClawLength, lionManed);

                //Generate unique code
                txtUniqueID.Text = objLion.GenerateAnimalCode();

                //Concatenate values into string 
                entireLionRecord =  Environment.NewLine + objLion.ToString() + "," + objLion.GetFoodType + "," +
                                    objLion.GetFoodQuantityNeeded + "," +
                                    objLion.MorningFeedingTime(feedingTimeMorning) + "," +
                                    objLion.AfternoonFeedingTime(feedingTimeAfternoon) + "," +
                                    objLion.EveningFeedingTime(feedingTimeEvening) ;
             
                //Write the entire record to the text file
                objSave = new SaveRecords(entireLionRecord, "Lion.txt");
                objSave.WriteToTextFile("yes");
            }
            else
            {
                objSpeech.ConvertTextToSpeech(errorMessage);
                MessageBox.Show(errorMessage,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                               
        }
        //******************************************************************************
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //******************************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUniqueID.Clear();
            txtWeight.Clear();
            txtAge.Clear();           
            txtClawLength.Clear();
            txtSkinColour.Clear();
            txtSkinType.Clear();

            ResetControls(false, -1);

           
        }
        //*************************************************************************************
        public void ResetControls(bool controlState, int indexForComboBox)
        {
            if (radFemale.Checked)
            {
                radFemale.Checked = controlState;
            }
            else
            {
                radMale.Checked = controlState;
            }

            if (radNo.Checked)
            {
                radNo.Checked = controlState;
            }
            else
            {
                radYes.Checked = controlState;
            }

            cmbxAfternoonTime.SelectedIndex = indexForComboBox;
            cmbxEveningTime.SelectedIndex = indexForComboBox;
            cmbxMorningTime.SelectedIndex = indexForComboBox;            
        }
        public void GetRadioButtonGenderValue(out string gender)
        {
            //Get gender type
            if (radFemale.Checked)
            {
                gender = "Female";
            }
            else if (radMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "";
            }
        }
        //**************************************************************************************
        public void GetRadioButtonManeValues(out string lionMane)
        {
            if (radYes.Checked)
            {
                lionMane = "Yes";
            }
            else if (radNo.Checked)
            {
                 lionMane = "No";
            }
            else
            {
                lionMane = "";
            }
        }
        public void GetTextBoxValues(out string animalField, TextBox objText)
        {
            animalField = objText.Text;
        }
        //***************************************************************************************
    }
}
