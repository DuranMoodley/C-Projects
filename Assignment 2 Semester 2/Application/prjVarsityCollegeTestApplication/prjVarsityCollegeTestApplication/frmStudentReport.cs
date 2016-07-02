/* frmStudentReport.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Displays the Student Results
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmStudentReport : Form
    {
        //*********************************************
        public frmStudentReport(int studentMark, int incorrectAnswers , double finalPercentage)
        {
            InitializeComponent();
            SetFields(studentMark, incorrectAnswers, finalPercentage);
        }
        //*********************************************
        public void SetFields(int studMark , int numOfIncorrectAns , double percentageMark)
        {
            txtStudentNumber.Text = GetStudentNumber();
            txtCorrectAns.Text = studMark.ToString();
            txtIncorrectAns.Text = numOfIncorrectAns.ToString();
            txtFinalPercentage.Text = percentageMark.ToString();
        }
        //*********************************************
        public string GetStudentNumber()
        {
            string studentNumber;
            FetchData objFetch = new FetchData();
            string[,] arrStudentRecord = objFetch.LoadArrayFromFile("CurrentStudentDetails.txt", 1);
            studentNumber = arrStudentRecord[0, 0];
            return studentNumber;
        }
        //*********************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*********************************************
        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            Student objStudent;
            SaveRecords objSave;
            string studentRecord;           
            string studentNumber = GetStudentNumber();
            double finalMarkPercentage = double.Parse(txtFinalPercentage.Text);
                     
            //Send Student Record to Student Report text file
            //This file will store each student who completes the Ice Task.
            objStudent = new Student(studentNumber, finalMarkPercentage);
            studentRecord = objStudent.ToString();
            objSave = new SaveRecords(studentRecord);
            objSave.WriteToTextFile();

            MessageBox.Show("To Save your Result Click File --> Save As"
                           , "Information", MessageBoxButtons.OK,
                              MessageBoxIcon.Information);

            SendStudentsMarks();        
        }
        //*********************************************
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                SaveRecords objSaveReport;               
                string record;
                string headings;
                string dashes;
                string studentNumber;
                int correctAnswers;
                int incorrectAns;
                double finalPercentage;

                //Retrieve values from controls
                GetFields(out studentNumber, out correctAnswers, out incorrectAns, out finalPercentage);

                //Write and Save File to user specified location
                sfdSaveReport.ShowDialog();
                dashes = "---------------------------------------------------------------------------------------" 
                         + Environment.NewLine;
                headings = dashes + "STUDENT NUMBER\tCORRECT ANSWERS\tINCORRECT ANSWERS\tFINAL PERCANTAGE" 
                         + Environment.NewLine;
                record = headings + dashes + studentNumber + "\t\t" + correctAnswers + "\t\t" + incorrectAns + "\t\t" + finalPercentage 
                        + Environment.NewLine + dashes;
             
                objSaveReport = new SaveRecords(record);
                objSaveReport.WriteToTextFile(sfdSaveReport.FileName, true);  
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);              
            }          
        }
        //*********************************************
        public void GetFields(out string studNumber , out int correctAns, out int incorrectAns,
                              out double percentage)
        {
            studNumber = txtStudentNumber.Text;
            correctAns = int.Parse(txtCorrectAns.Text);
            incorrectAns = int.Parse(txtIncorrectAns.Text);
            percentage = double.Parse(txtFinalPercentage.Text);
        }
        //*********************************************
        public void SendEmails(string personEmailAddress, string studentsMarks)
        {
            try
            {
                //Sends an email to people.
                MailMessage mail = new MailMessage("duranmoodley97@gmail.com", personEmailAddress);
                SmtpClient client = new SmtpClient();
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("duranmoodley97@gmail.com", "ecsxvrkt");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                mail.Subject = "Ice Task Students Report";
                mail.Body = studentsMarks;
                client.Send(mail);               
            }
            catch (SmtpException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************
        public int GetNumberOfStudents()
        {
            //Retrieve the amount of students in the class
            int amountOfStudents;
            StreamReader objReader = new StreamReader("AmountOfStudents.txt");
            amountOfStudents = int.Parse(objReader.ReadLine());
            objReader.Close();

            return amountOfStudents;
        }
        //*************************************************************
        public void SendStudentsMarks()
        {
            //Sends all the Students Marks to the Lecturer
            //All the Records in the Student Report is Clear so that the next Ice Task can commence.
            string studentsMarks;
            FetchData objFetch = new FetchData();
            int numberOfLinesInFile = objFetch.CountLinesInFile("StudentReport.txt");
            int numberOfStudents = GetNumberOfStudents();
            string[,] arrStudentMarks = objFetch.LoadArrayFromFile("StudentReport.txt", 2);
            objFetch.ConcatenateArrayContents(arrStudentMarks, out studentsMarks);

            if (numberOfLinesInFile == numberOfStudents)
            {
                SendEmails("duranmoodley97@gmail.com", studentsMarks);
                File.WriteAllText("StudentReport.txt", "");
            }
        }
    }
}
