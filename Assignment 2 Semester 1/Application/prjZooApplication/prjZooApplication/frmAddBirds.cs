/* frmAddBirds.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Get input from user and sends to a text file
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Windows.Forms;
namespace prjZooApplication
{
    public partial class frmAddBirds : Form
    {
        public frmAddBirds()
        {
            InitializeComponent();
        }
        //****************************************************************
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //****************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmSelectCategory objCategory = new frmSelectCategory();
            objCategory.Visible = true;
        }
        //****************************************************************
        public void GetAnimalInformation(out string nameOfAnimal,
                                         out string genderOfAnimal, out string weightOfAnimal,
                                         out string ageOfAnimal, out string morningTime,
                                         out string afternoonTime, out string eveningTime,
                                         out string lengthOfWing, out string colourOfWing,
                                         out string lengthOfBeak , out string typeOfFeather)
        {
            SetGender(out genderOfAnimal);
            GetTextBoxValues(out nameOfAnimal, txtName);
            GetTextBoxValues(out weightOfAnimal, txtWeight);
            GetTextBoxValues(out ageOfAnimal, txtAge);    
     
            morningTime = cmbxMorningTime.Text;
            afternoonTime = cmbxAfternoonTime.Text;
            eveningTime = cmbxEveningTime.Text;
            typeOfFeather = cmbxFeatherType.Text;

            GetTextBoxValues(out lengthOfWing,txtWingLength);
            GetTextBoxValues(out colourOfWing, txtWingColour);
            GetTextBoxValues(out lengthOfBeak, txtBeakLength);                   
        }
        //****************************************************************
        private void btnSave_Click(object sender, EventArgs e)
        {
            string animalName;
            string animalSex;
            string animalWeight;
            string animalAge;
            string feedingTimeMorning;
            string feedingTimeAfternoon;
            string feedingTimeEvening;
            string wingLength;
            string wingColour;
            string beakLength;
            string featherType;
            Validation objValidate;
            Birds objBirds;
            SaveRecords objSaveRecords;
            string entireBirdRecord = "";
            SpeechOutput objSpeech = new SpeechOutput();
            string errorMessage = "Please enter correct values in the appropriate fields";

            //Recieve all input from input controls.
            GetAnimalInformation(out animalName, out animalSex, out animalWeight, out animalAge,
                                 out feedingTimeMorning, out feedingTimeAfternoon, out feedingTimeEvening,
                                 out wingLength,out wingColour,out beakLength,out featherType);

            objValidate = new Validation(animalName, animalSex, animalWeight, animalAge, 
                                         feedingTimeMorning,feedingTimeAfternoon,feedingTimeEvening);

            if(objValidate.CheckInformation() && 
                ValidateSpecificInformation(wingLength,wingColour,beakLength,featherType))
            {
                objBirds = new Birds(animalName, animalSex, animalAge, animalWeight, wingLength,
                                     wingColour, beakLength, featherType);

                //Generate unique code 
                txtUniqueID.Text = objBirds.GenerateAnimalCode();

                entireBirdRecord =  Environment.NewLine + objBirds.ToString() + "," + objBirds.GetFoodType + "," +
                                    objBirds.GetFoodQuantityNeeded+ "," +
                                    objBirds.GetFeedingTimeMorning(feedingTimeMorning) + "," +
                                    objBirds.GetFeedingTimeAfternoon(feedingTimeAfternoon) + "," +
                                    objBirds.GetFeedingTimeEvening(feedingTimeAfternoon);

                //Send the entire record to a text file
                objSaveRecords = new SaveRecords(entireBirdRecord, "Birds.txt");
                objSaveRecords.WriteToTextFile("yes");        
            }
            else
            {
                objSpeech.ConvertTextToSpeech(errorMessage);
                MessageBox.Show(errorMessage,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                 
        }
        //****************************************************************
        public bool ValidateSpecificInformation(string wingSpan, string colour, string beaklen,
                                                string feather)
        {
            bool birdValid = true;                     
            Validation objValidate = new Validation();
            string[] arrBirdFields = { wingSpan, colour, beaklen, feather };
            int count = 0;
            
            while(count < arrBirdFields.Length && birdValid == true)
            {
                if(count == 0)
                {
                    objValidate.CheckFormatting(ref birdValid, arrBirdFields[count]);
                    continue;
                }
                else if(count == 2)
                {
                    objValidate.CheckFormatting(ref birdValid, arrBirdFields[count]);
                    continue;
                }

                objValidate.CheckNull(ref birdValid, arrBirdFields[count]);
                count++;
            }
          
            return birdValid;
        }
        //*****************************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUniqueID.Clear();
            txtWeight.Clear();
            txtAge.Clear();           
            txtBeakLength.Clear();
            txtWingColour.Clear();
            txtWingLength.Clear();

            ResetControls(false, -1);           
        }
        //**********************************************************************************
        public void ResetControls(bool controlState , int indexForComboBox)
        {
            if (radFemale.Checked)
            {
                radFemale.Checked = controlState;
            }
            else
            {
                radMale.Checked = controlState;
            }

            cmbxAfternoonTime.SelectedIndex = indexForComboBox;
            cmbxEveningTime.SelectedIndex = indexForComboBox;
            cmbxMorningTime.SelectedIndex = indexForComboBox;
            cmbxFeatherType.SelectedIndex = indexForComboBox;
        }
        //***********************************************************************************
        public void SetGender(out string gender)
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
        public void GetTextBoxValues(out string animalField, TextBox objText)
        {
            animalField = objText.Text;
        }
        //***************************************************************************************
    }
}
