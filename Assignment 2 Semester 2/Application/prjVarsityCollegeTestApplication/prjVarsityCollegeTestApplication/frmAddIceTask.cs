/* AddIceTask.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * The lecturer can add an ice task by entering in the answer to each questions
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmAddIceTask : Form
    {
        public frmAddIceTask()
        {
            InitializeComponent();
        }
        //***************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {
            frmLecturerMenu objMenu = new frmLecturerMenu();
            objMenu.Visible = true;
            this.Dispose();
        }
        //***************************************************
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //***************************************************       
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                string[] arrAnswers = new string[20];
                string[] arrQuestions = new string[20];
                IceTask objIceTask;
                bool validated;

                //Insert text box values into array
                //Parse Array into object.
                GetQuestions(ref arrQuestions);
                GetAnswers(ref arrAnswers);
                validated = ValidateAnswers(arrAnswers);

                if (validated)
                {
                    objIceTask = new IceTask(arrAnswers, arrQuestions);
                    frmVerifyAnswers objVerify = new frmVerifyAnswers(objIceTask, "Add Ice Task");
                    objVerify.Visible = true;
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please Load Answers to All 20 Questions", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(IndexOutOfRangeException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);        
            }          
        }
        //***************************************************
        public void GetQuestions(ref string [] answersQuestions)
        {
            try
            {
                answersQuestions[0] = txtQuestion1.Text;
                answersQuestions[1] = txtQuestion2.Text;
                answersQuestions[2] = txtQuestion3.Text;
                answersQuestions[3] = txtQuestion4.Text;
                answersQuestions[4] = txtQuestion5.Text;
                answersQuestions[5] = txtQuestion6.Text;
                answersQuestions[6] = txtQuestion7.Text;
                answersQuestions[7] = txtQuestion8.Text;
                answersQuestions[8] = txtQuestion9.Text;
                answersQuestions[9] = txtQuestion10.Text;
                answersQuestions[10] = txtQuestion11.Text;
                answersQuestions[11] = txtQuestion12.Text;
                answersQuestions[12] = txtQuestion13.Text;
                answersQuestions[13] = txtQuestion14.Text;
                answersQuestions[14] = txtQuestion15.Text;
                answersQuestions[15] = txtQuestion16.Text;
                answersQuestions[16] = txtQuestion17.Text;
                answersQuestions[17] = txtQuestion18.Text;
                answersQuestions[18] = txtQuestion19.Text;
                answersQuestions[19] = txtQuestion20.Text;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }             
        }
        //***************************************************
        public void GetAnswers(ref string [] answersArr)
        {
            try
            {
                answersArr[0] = txtAnswer1.Text;
                answersArr[1] = txtAnswers2.Text;
                answersArr[2] = txtAnswer3.Text;
                answersArr[3] = txtAnswer4.Text;
                answersArr[4] = txtAnswer5.Text;
                answersArr[5] = txtAnswers6.Text;
                answersArr[6] = txtAnswers7.Text;
                answersArr[7] = txtAnswers8.Text;
                answersArr[8] = txtAnswers9.Text;
                answersArr[9] = txtAnswers10.Text;
                answersArr[10] = txtAnswers11.Text;
                answersArr[11] = txtAnswers12.Text;
                answersArr[12] = txtAnswers13.Text;
                answersArr[13] = txtAnswers14.Text;
                answersArr[14] = txtAnswers15.Text;
                answersArr[15] = txtAnswers16.Text;
                answersArr[16] = txtAnswers17.Text;
                answersArr[17] = txtAnswers18.Text;
                answersArr[18] = txtAnswers19.Text;
                answersArr[19] = txtAnswers20.Text;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }             
        }
        //***************************************************
        public bool ValidateAnswers(string [] answerArr)
        {
            //Search for a Null value in the answer array
            //If found, Change flag variable.
            bool isValid = true;
            try
            {
                int counter = 0;
                while (counter < answerArr.Length && isValid == true)
                {
                    if (string.IsNullOrEmpty(answerArr[counter]))
                    {
                        isValid = false;
                    }
                    counter++;
                }
            }
            catch (IndexOutOfRangeException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }    
            
            return isValid;
        }
    }
}
