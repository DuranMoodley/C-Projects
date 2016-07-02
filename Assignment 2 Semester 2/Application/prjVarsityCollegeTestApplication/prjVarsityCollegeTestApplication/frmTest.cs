/* frmTest.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Starts the Ice Task,Allows the user/student to click on the relevant option
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmTest : Form
    {
        private string studentAnswer;
        int counter = 0;
        private int questionNumber = 1;
        IceTask objIceTask;
        private string[] arrAnswers = new string[20];
        private string[] arrQuestions = new string[20];

        public frmTest()
        {
            InitializeComponent();
            GetStudentNumber();
        }
        //***********************************************************
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //***********************************************************
        public void GetStudentNumber()
        {
            //Retrieve the current student Number
            //Display in Text Field.
            string studentNumber = "";        
            FetchData objData = new FetchData();
            string[,] arrStudent = objData.LoadArrayFromFile("CurrentStudentDetails.txt", 1);
            studentNumber = arrStudent[0, 0];
            txtStudentNumber.Text = studentNumber;           
        }
        //***********************************************************
        private void mnuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {      
                ofdIceTask.Title = "Open Ice Task";   
                ofdIceTask.ShowDialog();
                Process.Start(ofdIceTask.FileName);
                ofdIceTask.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                   
        }
        //***********************************************************
        private void btnNext_Click(object sender, EventArgs e)
        {           
            //Insert Values into object.
            arrQuestions[counter] = lblQuestionNumber.Text;
            arrAnswers[counter] = studentAnswer;        
            questionNumber++;
            counter++;
            SetLabels(questionNumber, counter);
                      
            //Check if the user has answered 20 Questions.
            if(CheckAmountAnswered())
            {
                ChangeControlProperties();
                objIceTask = new IceTask(arrAnswers, arrQuestions);
            }
            prb.Increment(5);
        }
        //***********************************************************
        private void btnOption1_Click(object sender, EventArgs e)
        {
            studentAnswer = btnOption1.Text;
            txtUserAnswer.Text = btnOption1.Text;
        }
        //***********************************************************
        private void btnOption2_Click(object sender, EventArgs e)
        {
            studentAnswer = btnOption2.Text;
            txtUserAnswer.Text = btnOption2.Text;
        }
        //***********************************************************
        private void btnOption3_Click(object sender, EventArgs e)
        {
            studentAnswer = btnOption3.Text;
            txtUserAnswer.Text = btnOption3.Text;
        }
        //***********************************************************
        private void btnOption4_Click(object sender, EventArgs e)
        {
            studentAnswer = btnOption4.Text;
            txtUserAnswer.Text = btnOption4.Text;
        }
        //***********************************************************
        public void SetLabels(int questionNum , int questionAnswered)
        {
            lblQuestionNumber.Text = questionNum.ToString();
            lblAmtAnswered.Text = questionAnswered.ToString();
        }
        //***********************************************************
        public bool CheckAmountAnswered()
        {
            bool isAllQuestionsAnswered = false;
            int amtQuestionsAnswered = int.Parse(lblAmtAnswered.Text);

            if (amtQuestionsAnswered == 20)
            {
                isAllQuestionsAnswered = true;
            }
            
            return isAllQuestionsAnswered;
        }
        //***********************************************************
        public void ChangeControlProperties()
        {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
            btnOption5.Enabled = false;
            btnSubmit.Visible = true;
            lblQuestionNumber.Visible = false;
            lblQuestion.Visible = false;
            lblEndOfIceTask.Visible = true;
            lblPleaseClickSubmit.Visible = true;
            btnNext.Enabled = false;
            txtUserAnswer.Visible = false;
        }
        //***********************************************************
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmVerifyAnswers objVerify = new frmVerifyAnswers(objIceTask, "Student Test");
            objVerify.Visible = true;
        }
        //***********************************************************
        private void mnuHelp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRules objRules = new frmRules();
            objRules.Visible = true;
        }
        //***********************************************************
        private void btnOption5_Click(object sender, EventArgs e)
        {
            studentAnswer = btnOption5.Text;
            txtUserAnswer.Text = btnOption5.Text;
        }
     }
  }

