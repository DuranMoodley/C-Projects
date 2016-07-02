/* frmAddElephant.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Takes input from user and sends to file
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Windows.Forms;
namespace prjZooApplication
{
    public partial class frmAddElephant : Form
    {
        public frmAddElephant()
        {
            InitializeComponent();
        }
        //*****************************************************************
        public void GetAnimalInformation(out string nameOfAnimal,
                                         out string genderOfAnimal, out string weightOfAnimal,
                                         out string ageOfAnimal, out string morningTime,
                                         out string afternoonTime, out string eveningTime,
                                         out string lengthOfTusk , out string tuskweight,
                                         out string tuskShape ,out string trunkLength ,
                                         out string earLength)
        {           
            nameOfAnimal = txtName.Text;
            SetGender(out genderOfAnimal);
            weightOfAnimal = txtWeight.Text;
            ageOfAnimal = txtAge.Text;
            morningTime = cmbxMorningTime.Text;
            afternoonTime = cmbxAfternoonTime.Text;
            eveningTime = cmbxEveningTime.Text;
            lengthOfTusk = txtLengthOfTusk.Text;
            tuskweight = txtTuskWeight.Text;
            tuskShape = txtTuskShape.Text;
            trunkLength = txtTrunkLength.Text;
            earLength = txtEarLength.Text;           
        }
        //*******************************************************************************************
        private void btnSave_Click(object sender, EventArgs e)
        {           
             string animalName;
             string animalSex;
             string animalWeight;
             string animalAge; 
             string feedmorningTime;
             string feedafternoonTime; 
             string feedeveningTime;
             string elephantTuskLength;
             string elephantTuskweight;
             string elephantTuskShape; 
             string elephantTrunkLength;
             string elephantEarLength;
             Validation objValidation;
             SaveRecords objSave;
             Elephant objElephant;
             string entireRecord = "";
             SpeechOutput objSpeech = new SpeechOutput();
             string errorMessage = "Please enter correct values in the appropriate fields";

             GetAnimalInformation(out animalName,          out animalSex, out animalWeight, out animalAge,
                                  out feedmorningTime,     out feedafternoonTime, out feedeveningTime,
                                  out elephantTuskLength,  out elephantTuskweight, out elephantTuskShape,
                                  out elephantTrunkLength, out elephantEarLength);

             objValidation = new Validation(animalName, animalSex, animalWeight, animalAge, 
                                            feedmorningTime, feedafternoonTime, feedeveningTime);

            if(objValidation.CheckInformation() && 
                ValidateSpecificInformation(elephantTuskLength,elephantTuskweight,elephantTrunkLength,
                                            elephantEarLength,elephantTuskShape))
            {
                //Parse variables into object 
                objElephant = new Elephant(animalName, animalSex, animalAge, animalWeight, 
                                           elephantTuskLength, elephantTuskweight,elephantTuskShape,
                                           elephantTrunkLength, elephantEarLength);

                //Generate unique code 
                txtUniqueID.Text = objElephant.GenerateAnimalCode();

                entireRecord = Environment.NewLine + objElephant.ToString() + "," + objElephant.GetFoodType + "," +
                               objElephant.GetFoodQuantityNeeded + "," +
                               objElephant.MorningFeedingTime(feedmorningTime) + "," +
                               objElephant.AfternoonFeedingTime(feedafternoonTime) + "," +
                               objElephant.EveningFeedingTime(feedeveningTime);

                //Send the entire record to a text file
                objSave = new SaveRecords(entireRecord, "Elephant.txt");
                objSave.WriteToTextFile("yes");            
            }
            else
            {
                objSpeech.ConvertTextToSpeech(errorMessage);
                MessageBox.Show(errorMessage,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }
        //**********************************************************************************************
        public bool ValidateSpecificInformation(string lengthOfTusk , string weightOfTusk , string lengthOfTrunk,
                                                string lengthOfEar , string shapeOfTusk)
        {
            bool elephantValid = true;
            double temporaryValue;
            int invalidInputs = 0;

            if (double.TryParse(lengthOfTusk, out temporaryValue) == false || 
                double.Parse(lengthOfTusk) < 0)
            {
                invalidInputs++;
            }
            else if(double.TryParse(lengthOfTrunk, out temporaryValue) == false || 
                    double.Parse(lengthOfTrunk) < 0)
            {
                invalidInputs++;
            }
            else if (double.TryParse(weightOfTusk, out temporaryValue) == false ||
                     double.Parse(weightOfTusk) < 0)
            {
                invalidInputs++;
            }
            else if (double.TryParse(lengthOfEar, out temporaryValue) == false || 
                     double.Parse(lengthOfEar) < 0)
            {
                invalidInputs++;
            }
            else if(string.IsNullOrEmpty(shapeOfTusk))
            {
                invalidInputs++;
            }

            if(invalidInputs != 0)
            {
                elephantValid = false;
            }

            return elephantValid;
        }
        //***********************************************************************************************
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //***********************************************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmSelectCategory objCategory = new frmSelectCategory();
            objCategory.Visible = true;
        }
        //***********************************************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtUniqueID.Clear();
            txtWeight.Clear();
            txtAge.Clear();
            txtTuskWeight.Clear();
            txtTuskShape.Clear();
            txtTrunkLength.Clear();
            txtEarLength.Clear();
            txtLengthOfTusk.Clear();

            ResetControls(false, -1);
        }
        //*****************************************************************************************
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

            cmbxAfternoonTime.SelectedIndex = indexForComboBox;
            cmbxEveningTime.SelectedIndex = indexForComboBox;
            cmbxMorningTime.SelectedIndex = indexForComboBox;           
        }
        //*****************************************************************************
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
    }
}
