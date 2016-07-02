/* frmDelete.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Deletes an animal from the system
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.IO;
namespace prjZooApplication
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
            InputComboxItems();
        }
        //**************************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //**************************************************************************
        public string GetUniqueID()
        {
            string animalId = cmbxUniqueID.Text;

            return animalId;
        }
        //**************************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uniqueAnimalIdNumber = GetUniqueID();
            string[,] updatedAnimalArray = new string [0,0];
            string[,] oldAnimalArray = new string [0,0];
            int updatedArrayIndex = 0;
            SaveRecords objSave;
            string entireAnimalRecord = "";
            string fileName = ""; 
                   
            if(Validate(uniqueAnimalIdNumber))
            {
                oldAnimalArray = LoadAnimalArray(out fileName);
                updatedAnimalArray = new string[(oldAnimalArray.GetLength(0) - 1),
                                                 oldAnimalArray.GetLength(1)];
                //Search for animal to be deleted
                //Insert contents from old into new updated array
                //But skip row that contains animal to be deleted
                for(int row  = 0 ; row <oldAnimalArray.GetLength(0);row++)
                {          
                    if(!uniqueAnimalIdNumber.Equals(oldAnimalArray[row,4]))
                    {
                      for (int col = 0; col < oldAnimalArray.GetLength(1); col++)
                      {
                          updatedAnimalArray[updatedArrayIndex, col] = oldAnimalArray[row, col];
                      }
                      updatedArrayIndex++;
                    }
                    else
                    {
                        BackupDeletedRecord();
                        continue;                       
                    }                  
                }

                //Send new contents to text file
                ConcatenateArrayContents(updatedAnimalArray, ref entireAnimalRecord);
                File.WriteAllText(fileName, "");
                objSave = new SaveRecords(entireAnimalRecord, fileName);         
                objSave.WriteToTextFile("no");
            }
            else
            {
                MessageBox.Show("Please Enter values in all fields", "Error", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //**************************************************************************
        public bool Validate(string idNumber)
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(rhtxReason.Text))
            {
                isValid = false;
            }

            return isValid;
        }
        //***************************************************************************
        public string [,] LoadAnimalArray(out string nameOfFile)
        {
            string idOfAnimal = GetUniqueID();
            FetchData objFetchData = new FetchData();
            string[,] arrAnimal;
            nameOfFile = "";

            if (idOfAnimal.Contains("L"))
            {
                arrAnimal = objFetchData.LoadArrayFromFile("Lion.txt", 14);
                nameOfFile = "Lion.txt";
            }
            else if (idOfAnimal.Contains("E"))
            {
                arrAnimal = objFetchData.LoadArrayFromFile("Elephant.txt", 15);
                nameOfFile = "Elephant.txt";
            }
            else
            {
                arrAnimal = objFetchData.LoadArrayFromFile("Birds.txt", 14);
                nameOfFile = "Birds.txt";

            }

            return arrAnimal;
        }
        //****************************************************************************
        public void ConcatenateArrayContents(string [,] animalArr , ref string records)
        {
            for (int row = 0; row < animalArr.GetLength(0); row++)
            {        
               for (int col = 0; col < animalArr.GetLength(1); col++)
               {
                   records += animalArr[row, col] + ",";   
               }
               records += Environment.NewLine;
            }
        }
        //****************************************************************************
        public void BackupDeletedRecord()
        {
            //Send deleted Record to back up file
            string animalId = GetUniqueID();
            string reason = rhtxReason.Text;
            string dateDeleted = DateTime.Now.ToString();
            string entireRecord = Environment.NewLine + animalId + "," + reason + "," + dateDeleted;
            SaveRecords objSaveRecords = new SaveRecords(entireRecord, "DeletedRecords.txt");
            objSaveRecords.WriteToTextFile("no");
            MessageBox.Show("Record has been deleted And Backed up", "Information", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //*****************************************************************************
        private void btnDeletedRecs_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", "DeletedRecords.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*****************************************************************************
        public void InputComboxItems()
        {
            try
            {
                FetchData objFetch = new FetchData();
                string[,] arrLion = objFetch.LoadArrayFromFile("Lion.txt", 14);
                string[,] arrElephant = objFetch.LoadArrayFromFile("Elephant.txt", 15);
                string[,] arrBirds = objFetch.LoadArrayFromFile("Birds.txt", 14);

                //Input column 4 values into combo box control
                for (int row = 0; row < arrLion.GetLength(0); row++)
                {
                    cmbxUniqueID.Items.Add(arrLion[row, 4]);
                }

                for (int row = 0; row < arrBirds.GetLength(0); row++)
                {
                    cmbxUniqueID.Items.Add(arrBirds[row, 4]);
                }

                for (int row = 0; row < arrElephant.GetLength(0); row++)
                {
                    cmbxUniqueID.Items.Add(arrElephant[row, 4]);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
