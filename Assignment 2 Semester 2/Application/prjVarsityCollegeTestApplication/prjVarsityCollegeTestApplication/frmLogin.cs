/* frmLogin.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Prompts the user to enter in a Valid student number
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            try
            {
                Thread objThread = new Thread(new ThreadStart(SplashScreenStart));
                objThread.Start();
                Thread.Sleep(3000);
                objThread.Abort();
                InitializeComponent();
            }
            catch (ThreadAbortException exec)
            {
                MessageBox.Show(exec.Message);           
            }
            catch(ThreadInterruptedException exe)
            {
                MessageBox.Show(exe.Message);           
            }
            catch(ThreadStartException ex)
            {
                MessageBox.Show(ex.Message);             
            }
            catch (Exception execep)
            {
                MessageBox.Show(execep.Message);
            }           
        }
        //*********************************************************
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentNumber;
            string lecturerName;

            /*if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (txtStudentNumber.Text.Equals("11111111"))
                {
                    frmLecturerMenu objLecturer = new frmLecturerMenu();
                    objLecturer.Visible = true;
                    this.Hide();
                }
                else
                {                  
                    SaveStudentNumber(out studentNumber);
                    this.Hide();
                    frmRules objRules = new frmRules();
                    objRules.Visible = true;
                }
            }*/

            if (isLecturerValid(txtStudentNumber.Text, out lecturerName))
            {
                frmLecturerMenu objLecturer = new frmLecturerMenu(lecturerName);
                objLecturer.Visible = true;
                this.Hide();
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    SaveStudentNumber(out studentNumber);
                    this.Hide();
                    frmRules objRules = new frmRules();
                    objRules.Visible = true;
                }
            }  
        }
        //*********************************************************
        private void txtStudentNumber_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtStudentNumber.Text) )
            {
                e.Cancel = true;
                txtStudentNumber.Focus();
                erpStudentNumber.SetError(txtStudentNumber, "Please Enter your Student Number eg.12345678");
            }
            else if(txtStudentNumber.Text.Length != 8 )
            {
                e.Cancel = true;
                txtStudentNumber.Focus();
                erpStudentNumber.SetError(txtStudentNumber, "Please Enter the Correct Number of Digits eg. 12345678");
            }
            else
            {
                e.Cancel = false;
            }
        }
        //*********************************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //*********************************************************     
        public void SaveStudentNumber(out string studNumber)
        {
            //Send Student Record to Student File.
            studNumber = txtStudentNumber.Text;
            int studentMark = 0;
            string studentRecord = studNumber + "," + studentMark;
            SaveRecords objSave = new SaveRecords(studentRecord);          
            objSave.WriteToTextFile("CurrentStudentDetails.txt", false);
        }
        //*********************************************************     
        public void SplashScreenStart()
        {
            Application.Run(new frmSplashScreen());
        }
        //*********************************************************     
        public bool isLecturerValid(string lecturerNumber, out string lecName )
        {
            DbConnect objDb = new DbConnect();
            SqlDataReader sqlDr;
            objDb.dbConnection();
            objDb.Query = "SELECT * FROM tblLecturer";
            sqlDr = objDb.GetDataReader();
            bool found = false;
            lecName = "";
            while (sqlDr.Read() && found == false)
            {
                if (sqlDr["LecturerID"].ToString().Equals(lecturerNumber))
                {
                    found = true;
                    lecName = sqlDr["LecturerName"].ToString();
                }
            }

            return found;
        }
    }
}
