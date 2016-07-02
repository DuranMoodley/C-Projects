/* frmRules.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Displays the rules to the Student.
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmRules : Form
    {
        public frmRules()
        {
            InitializeComponent();
        }
        //*****************************************************************
        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmTest objTest = new frmTest();
            objTest.Visible = true;
        }
    }
}
