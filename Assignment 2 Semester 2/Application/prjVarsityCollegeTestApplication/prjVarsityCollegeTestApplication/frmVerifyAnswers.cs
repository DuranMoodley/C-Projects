/* frmVerifyAnswers.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Allows the student and lecturer to change answers
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmVerifyAnswers : Form
    {
        //*******************************************************
        public frmVerifyAnswers(IceTask objIce, string formName)
        {
            InitializeComponent();            
            InsertItemsToListbox(objIce);

            if(formName.Equals("Student Test"))
            {
                mnuMainBar.Visible = false;
                btnConfirm.Visible = false;               
                MessageBox.Show("To Change an answer"
                                 + Environment.NewLine +
                                 "Select the Question" +
                                  Environment.NewLine +
                                  "Then enter the new Answer in the Text Field Provided eg.5-A" +
                                  Environment.NewLine +
                                 "Click Edit to Change your Answer"
                                ,"Information", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);                
                btnCalculateMark.Visible = true;
            }
        }
        //*******************************************************
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string iceTaskAnswers = GetListboxItem().ToString();
            SaveRecords objSave = new SaveRecords(iceTaskAnswers);
            objSave.WriteToTextFile("Answers.txt", true);

            frmLecturerMenu objMenu = new frmLecturerMenu();
            objMenu.Visible = true;
            this.Dispose();
        }        
        //*******************************************************
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedIndexFirstNine;
            int selectedIndexLastTen;          
            string correctedAnswered = txtEdit.Text.Trim();
            bool validated = Validation(correctedAnswered);

            if (validated)
            {
                if (lstFirstNineAnswers.SelectedIndex >= 0)
                {
                    selectedIndexFirstNine = lstFirstNineAnswers.SelectedIndex;
                    lstFirstNineAnswers.Items.Remove(lstFirstNineAnswers.Items[selectedIndexFirstNine]);
                    lstFirstNineAnswers.Items.Add(correctedAnswered);
                    txtEdit.Clear();
                }
                else if (lstLastTenAnswers.SelectedIndex >= 0)
                {
                    selectedIndexLastTen = lstLastTenAnswers.SelectedIndex;
                    lstLastTenAnswers.Items.Remove(lstLastTenAnswers.Items[selectedIndexLastTen]);
                    lstLastTenAnswers.Items.Add(correctedAnswered);
                    txtEdit.Clear();
                }
            }         
        }
        //*******************************************************
        public bool Validation(string answer)
        {
            bool isValid = true;
            string errorMessage = "";

            if (lstLastTenAnswers.SelectedIndex == -1 && lstFirstNineAnswers.SelectedIndex == -1)
            {
                errorMessage = "Please Select A Question";
                isValid = false;
            }
            else if (answer.IndexOf('-') == -1)
            {
               errorMessage = "Please Make sure your correct Answer as a Dash between the Question Number eg 5-A";
                isValid = false;
            }
            else if (string.IsNullOrEmpty(txtEdit.Text))
            {
               errorMessage = "Please Make sure your correct answer is filled in";
                isValid = false;
            }

            if (isValid == false)
            {
                MessageBox.Show(errorMessage, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //*******************************************************
        public void InsertItemsToListbox(IceTask objIce)
        {
            string[] arrAnswers = objIce.GetAnswersArr();
            string[] arrQuestions = objIce.GetQuestions();

            lstFirstNineAnswers.Items.AddRange(new object[]{                 
                 arrQuestions[0] + "-" + arrAnswers[0],
                 arrQuestions[1] + "-" + arrAnswers[1], 
                 arrQuestions[2] + "-" + arrAnswers[2],
                 arrQuestions[3] + "-" + arrAnswers[3],
                 arrQuestions[4] + "-" + arrAnswers[4],
                 arrQuestions[5] + "-" + arrAnswers[5],
                 arrQuestions[6] + "-" + arrAnswers[6],
                 arrQuestions[7]+ "-" +  arrAnswers[7],
                 arrQuestions[8] + "-" + arrAnswers[8]
             });

            lstLastTenAnswers.Items.AddRange(new object[]{ 
              arrQuestions[9] + "-" + arrAnswers[9],
              arrQuestions[10] + "-" + arrAnswers[10],
              arrQuestions[11] + "-" + arrAnswers[11],
              arrQuestions[12] + "-" + arrAnswers[12],
              arrQuestions[13] + "-" + arrAnswers[13],
              arrQuestions[14] + "-" + arrAnswers[14],
              arrQuestions[15] + "-" + arrAnswers[15],
              arrQuestions[16] + "-" + arrAnswers[16],
              arrQuestions[17] + "-" + arrAnswers[17],
              arrQuestions[18] + "-" + arrAnswers[18],
              arrQuestions[19] + "-" + arrAnswers[19]
            });
            lstFirstNineAnswers.Sorted = true;
        }
        //**********************************************************
        private void mnuItemMainMenu_Click(object sender, EventArgs e)
        {
            frmLecturerMenu objMenu = new frmLecturerMenu();
            objMenu.Visible = true;
            this.Dispose();
        }
        //**********************************************************
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
        //**********************************************************          
        public StringBuilder GetListboxItem()
        {
            StringBuilder objRecord = new StringBuilder();
            foreach (var item in lstFirstNineAnswers.Items)
            {
                objRecord.Append(item.ToString());
                objRecord.Append(Environment.NewLine);
            }

            foreach (var itemTwo in lstLastTenAnswers.Items)
            {
                objRecord.Append(itemTwo.ToString());
                objRecord.Append(Environment.NewLine);
            }
            return objRecord;
        }
        //**********************************************************  
        private void btnCalculateMark_Click(object sender, EventArgs e)
        {
            string[] arrStudentFinalAnswers = new string[20];
            string[] arrCorrectAnswers = new string[20];
            int correctAns = 0;
            int incorrectAns = 0;
            double finalPercentage;

            GetfinalStudentAnswers(ref arrStudentFinalAnswers);
            GetCorrectAnswers(ref arrCorrectAnswers);
            CalculateStudentResults(ref correctAns, out incorrectAns, out finalPercentage,
                                    arrStudentFinalAnswers, arrCorrectAnswers);

            frmStudentReport objReport = new frmStudentReport(correctAns, incorrectAns, finalPercentage);
            objReport.Visible = true;
            this.Dispose();
        }
        //**********************************************************  
        public void GetfinalStudentAnswers(ref string [] studentAnswers)
        {
            int secondlistBoxCounter = 0;
            int firstListBoxCounter = 0;

            //Retrieve Final Student Answers from List box One
            //Insert into array.
            for (int arrCounter = 0; arrCounter < studentAnswers.Length; arrCounter++)
            {
                if (arrCounter > 8)
                {
                    lstFirstNineAnswers.ClearSelected();
                    break;
                }
                lstFirstNineAnswers.SelectedIndex = firstListBoxCounter;
                studentAnswers[arrCounter] = lstFirstNineAnswers.SelectedItem.ToString();
                firstListBoxCounter++;                                    
            }

            //Retrieve student Answers from List Box two
            //Insert into array
            for(int arrCounter = 9 ; arrCounter<studentAnswers.Length ; arrCounter++)
            {
                lstLastTenAnswers.SelectedIndex = secondlistBoxCounter;
                studentAnswers[arrCounter] = lstLastTenAnswers.SelectedItem.ToString();
                secondlistBoxCounter++;                
            }
        }
        //**********************************************************  
        public void GetCorrectAnswers(ref string [] arrCorrectAns)
        {
            try
            {
                StreamReader objRead = new StreamReader("Answers.txt");
                int arrCorrectAnsCounter = 0;
                string recordFromFile;

                while ((recordFromFile = objRead.ReadLine()) != null && arrCorrectAnsCounter < arrCorrectAns.Length)
                {
                    arrCorrectAns[arrCorrectAnsCounter] = recordFromFile;
                    arrCorrectAnsCounter++;
                }

                objRead.Close();
            }
            catch (IndexOutOfRangeException exec)
            {
                MessageBox.Show(exec.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }      
        }
        //**********************************************************  
        public void CalculateStudentResults(ref int correctAnswers , out int incorrectAnswers,
                                            out double finalPercentage , string [] arrStudentAns,
                                            string [] arrCorrectAnsw)
        {
            incorrectAnswers = 0;
            finalPercentage = 0;
            try
            {
                for (int counter = 0; counter < arrCorrectAnsw.Length; counter++)
                {
                    if (arrCorrectAnsw[counter].Equals(arrStudentAns[counter]))
                    {
                        correctAnswers++;
                    }
                }

                incorrectAnswers = (20 - correctAnswers);
                finalPercentage = correctAnswers * 5;
            }
            catch (IndexOutOfRangeException exe)
            {
                MessageBox.Show(exe.Message);               
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }          
        }
        //**********************************************************************
        private void lstFirstNineAnswers_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lstLastTenAnswers.ClearSelected();
                txtEdit.Text = lstFirstNineAnswers.SelectedItem.ToString();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exes)
            {
                MessageBox.Show(exes.Message);
            }          
        }
        //**********************************************************************
        private void lstLastTenAnswers_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lstFirstNineAnswers.ClearSelected();
                txtEdit.Text = lstLastTenAnswers.SelectedItem.ToString();
            }
            catch (NullReferenceException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        //**********************************************************************      
    }
}
