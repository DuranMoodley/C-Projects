/* frmAddLecturer.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Adds a lecturer to the database
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmAddLecturer : Form
    {
        public frmAddLecturer()
        {
            InitializeComponent();
        }
        //*************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLecturerMenu objMenu = new frmLecturerMenu();
            objMenu.Visible = true;
        }
        //*************************************************************
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Lecturer objLecturer = new Lecturer();
            DbConnect objDb = new DbConnect();

            if (Validation())
            {
                //Inserts values into the database using the object data
                GetFieldValues(objLecturer);
                objDb.dbConnection();
                objDb.Query = "INSERT INTO tblLecturer(LecturerID,LecturerName) VALUES " +
                    "(@lecturerId,@lecturerName)";
                objDb.InsertIntoDatabase(objLecturer.LecturerIdNumber, objLecturer.LecturerName);
                objDb.CloseDbConnection();
            }
        }
        //*************************************************************
        public bool Validation()
        {
            bool isValid = true;
            string outputMessage = "";

            if (string.IsNullOrEmpty(txtLecturerName.Text))
            {
                isValid = false;
                outputMessage = "Please Enter the Lecturer Name";
            }
            else if (string.IsNullOrEmpty(txtEmpNum.Text))
            {
                isValid = false;
                outputMessage = "Please Enter the Lecturer id number";
            }

            if (isValid == false)
            {
                MessageBox.Show(outputMessage, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //*************************************************************
        public void GetFieldValues(Lecturer obj)
        {
            //Fills the object with values from the controls
            obj.LecturerName = txtLecturerName.Text;
            obj.LecturerIdNumber = txtEmpNum.Text;
        }
    }
}
