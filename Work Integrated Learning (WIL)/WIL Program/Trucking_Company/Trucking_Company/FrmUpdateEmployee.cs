/* FrmUpdateEmployee.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates an Employee Record in the Database
 * Last Modified : 10/13/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmUpdateEmployee : Form
    {
        public FrmUpdateEmployee()
        {
            InitializeComponent();
        }
        //**************************************************************************
        public void GetFieldValues(out string EmpID, out string EmpName, out string EmpSurname, out string EmpStatus)
        {
            //Retrieve values
            EmpID = TxtEmployeeID.Text;
            EmpName = TxtEmployeeName.Text;
            EmpSurname = TxtEmployeeSurname.Text;
            EmpStatus = CmbEmployeeStatus.Text;
        }
        //**************************************************************************
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Open Database Connection
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            string EmpID;
            string EmpName;
            string EmpSurname;
            string EmpStatus;

            //Retrieve values and give values to variables
            //Contruct update query, update record to database
            if (Validation())
            {
                GetFieldValues(out EmpID, out EmpName, out EmpSurname, out EmpStatus);
                objDatabase.Query = "UPDATE Employee"
                + " SET EmployeeName = @empName , EmployeeSurname = @employeeSurname, EmployeeStatus = @employeeStatus"
                + " WHERE EmployeeIdNumber = @employeeIdNumber";
                objDatabase.UpdateEmployeesDatabase(EmpID, EmpName, EmpSurname, EmpStatus);
                objDatabase.CloseDbConnection();
            }
        }
        //**************************************************************************
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Search for the particular record being updated via Employee Id number
                ChangeControlProperties();
                TxtEmployeeID.Enabled = false;
                Database objDatabase = new Database();
                SqlDataReader sqlDR;
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT * FROM Employee WHERE EmployeeIdNumber ='" + TxtEmployeeID.Text + "'";
                sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    TxtEmployeeName.Text = sqlDR["EmployeeName"].ToString();
                    TxtEmployeeSurname.Text = sqlDR["EmployeeSurname"].ToString();
                    CmbEmployeeStatus.Text = sqlDR["EmployeeStatus"].ToString();
                }
                BtnUpdate.Enabled = true;
                objDatabase.CloseDbConnection();
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
        //**************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {          
            this.Dispose();
        }
        //**************************************************************************
        public void ChangeControlProperties()
        {
            TxtEmployeeName.Enabled = true;
            CmbEmployeeStatus.Enabled = true;
            TxtEmployeeSurname.Enabled = true;
        }
        //**************************************************************************
        public bool Validation()
        {
            bool isValid = true;


            if (TxtEmployeeID.Text.Equals("Please Enter ID Number. Then Click Search"))
            {
                isValid = false;
                MessageBox.Show("Please enter an Employee ID and click search", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeeName.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter Employee Name", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmployeeSurname.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter Employee Surname", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbEmployeeStatus.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select an Employee Status", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtEmployeeID.Text.Length != 11)
            {
                isValid = false;
                MessageBox.Show("Employee ID is Incorrect. Please make sure it is 11 digits",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
    }
}
