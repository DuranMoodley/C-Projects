/* frmLecturerMenu.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * This allows the lecturer to select an option/Action to perform
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmLecturerMenu : Form
    {
        public frmLecturerMenu()
        {
            InitializeComponent();
            SetLabelText();
        }
        //*****************************************************
        public void SetLabelText()
        {
            lblInstructions.Text = "Please Select Actions" +
                                    Environment.NewLine +
                                    "  On the Menu Bar " +
                                    Environment.NewLine +
                                    "For Further Options";                                  
        }
        //*****************************************************
        public frmLecturerMenu(string lecturerName)
        {
            InitializeComponent();
            SetLabelText();
            lblWelcome.Text = "Welcome";
            lblLecturerName.Text = lecturerName;
        }
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
        //*****************************************************
        private void mnuItemAddIceTask_Click(object sender, EventArgs e)
        {
            frmAddIceTask objAddIceTask = new frmAddIceTask();
            objAddIceTask.Visible = true;
            this.Dispose();
        }
        //*****************************************************
        private void viewStudentMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmStudentsMarkReport objStudentMark = new frmStudentsMarkReport();
            objStudentMark.Visible = true;
        }
        //*****************************************************
        private void btnSave_Click(object sender, EventArgs e)
        {
            string amtOfStudents = txtAmtOfStudents.Text;
            bool validInput = Validation();        

            if(validInput)
            {
                SaveRecords objSave = new SaveRecords(amtOfStudents);
                objSave.WriteToTextFile("AmountOfStudents.txt", true);
            }
        }
        //*****************************************************      
        public bool Validation()
        {
            double temporaryValue;
            bool isValid = true;

            if (string.IsNullOrEmpty(txtAmtOfStudents.Text))
            {
                MessageBox.Show("Please Enter the Amount of Students in the Class"
                                 , "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                isValid = false;
            }
            else if (double.TryParse(txtAmtOfStudents.Text, out temporaryValue) == false ||
                     double.Parse(txtAmtOfStudents.Text) < 0)
            {
                MessageBox.Show("Please Enter a Valid Number"
                                 , "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }
        //**********************************************************************************
        private void mnuItemAddLecturer_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmAddLecturer objAddLecturer = new frmAddLecturer();
            objAddLecturer.Visible = true;
        }
    }
}
