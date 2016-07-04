/* FrmAddEmployee.cs    
 * Lecturer : Rajesh Chanderman    
 * Adds an employee to the Employee Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmAddEmployee : Form
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void BtnSubmit_Click(object sender, EventArgs e)
        {           
            string idNumber;
            string empName;
            string empSurname;
            string empTitle;
            string empUsername;          
            string empStatus;
            Employee objEmployee;
            
            if (Validation())
            {
                GetFieldValues(out idNumber, out empName, out empSurname, out empTitle, out empUsername, out empStatus);
                objEmployee = new Employee(idNumber, empName, empSurname, empTitle, 
                                           empUsername, empStatus);
                objEmployee.GeneratePassword();
                TxtEmployeePassword.Text = objEmployee.EmployeePassword;
                SendToDatabase(objEmployee);
                loadingScreenAfterAddedEmployee_frm();
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void GetFieldValues(out string idNum, out string name, out string surname, out string title, out string username, out string status)
        {
            idNum = TxtEmployeeIDNumber.Text;
            name = TxtEmployeeName.Text;
            surname = TxtEmployeeSurname.Text;
            title = CmbTitle.Text;
            username = TxtEmployeeUsername.Text;         
            status = CmbxEmpStat.Text;
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public bool Validation()
        {
            bool isValid = true;
           
            if (CmbTitle.Text.Equals("Please select a title..."))
            {
                isValid = false;
                MessageBox.Show("Please Select an Employee Title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeeName.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in an Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeeSurname.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in the Employee's Surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtEmployeeIDNumber.Text.Length != 11)
            {
                isValid = false;
                MessageBox.Show("Employee ID is Incorrect. Please make sure it is 11 digits",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeeUsername.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in the Employee's Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeePassword.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CmbxEmpStat.Text.Equals("Please Select an Employee Status..."))
            {
                isValid = false;
                MessageBox.Show("Please Select the Employee's status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void SendToDatabase(Employee objEmp)
        {
            string output = "Employee Information has been Saved";
            Database objDatabase = new Database();
            objDatabase.dbConnection();

            //Check each employee password.
            //Depending on the first 2 characters will determine the table. Driver, Mechanic, Normal Employee
            if (objEmp.EmployeePassword.StartsWith("DR"))
            {
                objDatabase.Query = "INSERT INTO Driver(DRIVER_ID,DRIVER_NAME,DRIVER_SURNAME,DRIVER_PASSWORD)" +
                                    "VALUES(@uniqueID,@name,@surname,@password)";
                objDatabase.InsertIntoDriverTable(objEmp.EmployeeID, objEmp.EmployeeName, objEmp.EmployeeSurname, 
                                                 objEmp.EmployeePassword,output);
            }
            else if(objEmp.EmployeePassword.StartsWith("ME"))
            {
                objDatabase.Query = "INSERT INTO Mechanic(MECHANIC_ID,MECHANIC_NAME,MECHANIC_SURNAME,MECHANIC_PASSWORD)" +
                                    "VALUES(@uniqueID,@name,@surname,@password)";
                objDatabase.InsertIntoDriverTable(objEmp.EmployeeID, objEmp.EmployeeName, 
                                                 objEmp.EmployeeSurname, objEmp.EmployeePassword, output);
            }
            else
            {
                objDatabase.Query = "INSERT INTO Employee(EmployeeIdNumber,EmployeeName,EmployeeSurname,EmployeeTitle,EmployeeUsername,EmployeePassword,EmployeeStatus)" +
                   "VALUES(@uniqueID,@name,@surname,@title,@username,@password,@status)";
                objDatabase.InsertIntoEmployeeTable(objEmp.EmployeeID, objEmp.EmployeeName,
                                                    objEmp.EmployeeSurname, objEmp.EmployeeTitle,
                                                    objEmp.EmployeeUsername, objEmp.EmployeePassword,
                                                    objEmp.EmployeeStatus, output);
            }

            objDatabase.CloseDbConnection();
            
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadingScreenAfterAddedEmployee_frm()
        {
            FrmLoadingScreenAfterAddedEmployee loadingScreenAfterAddedEmployee = new FrmLoadingScreenAfterAddedEmployee();
            loadingScreenAfterAddedEmployee.Show();
            Dispose();
        }
        //_______________________________________________________________________________________________________________________________________________________________
    }
}
