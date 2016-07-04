/* FrmDeativateEmployee.cs    
 * Lecturer : Rajesh Chanderman    
 * Diables an employee in the database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmDeactivateEmployee : Form
    {
        public FrmDeactivateEmployee()
        {
            InitializeComponent();
            PopulateComboBox();
        }
        //*************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //*************************************************************
        public void PopulateComboBox()
        {
            try
            {
                //Open db connection
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT EmployeeIdNumber FROM Employee";

                //Read through the database dataset. Fill combo box
                SqlDataReader sqlDR = objDatabase.GetDataReader();
                while (sqlDR.Read())
                {
                    CmbEmployeeID.Items.Add(sqlDR[0]);
                }

                objDatabase.CloseDbConnection(); 
            }
            catch (SqlException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //*************************************************************
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CmbEmployeeID.Text) == false)
            {
                string employeeId = CmbEmployeeID.Text;
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                objDatabase.Query = "UPDATE Employee SET EmployeeStatus = 'Disabled'" +
                                    " WHERE EmployeeIdNumber = @empId";
                objDatabase.DisableEmployee(employeeId);
                objDatabase.CloseDbConnection();
            }
            else
            {
                MessageBox.Show("Please Enter in an Employee id Number",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
