/* frmStudentsMarkReport.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Displays all the Students Marks to the Lecturer
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.IO;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmStudentsMarkReport : Form
    {
        public frmStudentsMarkReport()
        {
            InitializeComponent();         
        }
        //*********************************************************** 
        private void frmStudentsMarkReport_Load(object sender, EventArgs e)
        {
            DisplayStudentMarks();
        }
        //*********************************************************** 
        public void DisplayStudentMarks()
        {
            //Retrieve records from file,Display in list box
            FetchData objFetch = new FetchData();
            string[,] arrStudentRecord = objFetch.LoadArrayFromFile("StudentReport.txt", 2);
            lstReport.Items.Add("Student Numbers     Mark(%)");
            try
            {              
                for (int row = 0; row < arrStudentRecord.GetLength(0); row++)
                {
                    lstReport.Items.Add(arrStudentRecord[row, 0] + "\t\t " + arrStudentRecord[row, 1]);                               
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);               
            }      
        }
        //************************************************************
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLecturerMenu objMenu = new frmLecturerMenu();
            objMenu.Visible = true;
        }    
    }
}
