using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjZooApplication
{
    public partial class frmAddNewZooKeeper : Form
    {
        public frmAddNewZooKeeper()
        {
            InitializeComponent();
        }
        //*************************************************************
        private void btnAddZookeeper_Click(object sender, EventArgs e)
        {
            string userName;
            bool isValid = true ;
            Validation objValidate = new Validation();
            SaveRecords objSave;
            string employeeRecord ;
            string empPassword = GenerateEmployeePassword();

            //Get Employee Name and Validate It
            GetInformation(out userName);
            objValidate.CheckNull(ref isValid, userName);

            //If input is valid Save to Text file
            if(isValid == true)
            {
                txtPassword.Text = empPassword;
                employeeRecord = Environment.NewLine + empPassword + "," + userName;
                objSave = new SaveRecords(employeeRecord, "EmployeeList.txt");
                objSave.WriteToTextFile("yes");
            }
            else
            {
                MessageBox.Show("Please Enter a Value in the User Name Field", "Error", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        //*************************************************************
        public void GetInformation(out string userName)
        {
            userName = txtUserName.Text;
        }
        //*************************************************************
        public virtual string GenerateEmployeePassword()
        {
            Random objRandomCode = new Random();
            string password = "";
          
            password = "Z" + objRandomCode.Next(100, 999);

            return password;
        }
        //****************************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //****************************************************************************
        private void Clear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}
