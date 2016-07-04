/* FrmAddEmployeeHoursWorked.cs    
 * Lecturer : Rajesh Chanderman    
 * Records the hours worked by a particular employee, Sends it to the database
 * Last Modified : 10/12/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmEmployeeHoursWorked : Form
    {
        public FrmEmployeeHoursWorked()
        {
            InitializeComponent();
        }
        //*************************************************************************
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            //Open Database connection
            Database objDatabase = new Database();
            objDatabase.dbConnection(); 
            string employeeID;
            double hoursWorked;
            string employeeType;
           
            if (Validation())
            {
                //Retrieve values from the text boxes 
                GetFieldValues(out employeeID, out hoursWorked , out employeeType);
                objDatabase.UpdateEmpHoursDatabase(employeeType,employeeID, hoursWorked);
                objDatabase.CloseDbConnection();
            }            
        }
        //*************************************************************************
        public void GetFieldValues(out string employeeID, out double hoursWorked, out string type)
        {
            employeeID = CmbEmployeeID.Text;
            hoursWorked = Double.Parse(TxtHoursWorked.Text);
            type = CmbTypeOfEmployee.Text;
        }
        //*************************************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;

            if (string.IsNullOrEmpty(CmbTypeOfEmployee.Text))
            {
                isValid = false;
                MessageBox.Show("Please select a Employee of Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbEmployeeID.Text))
            {
                isValid = false;
                MessageBox.Show("Please select an Employee ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtHoursWorked.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("The Hours worked may not have a value or the value may be in an incorrect format.", 
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //*************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
           Dispose();          
        }
        //*************************************************************************
        private void CmbEmployeeID_DropDown(object sender, EventArgs e)
        {
            try
            {
                 CmbEmployeeID.Items.Clear();
                //Open db connection
                Database objDatabase = new Database();
                objDatabase.dbConnection();

                //Check if employee type is selected
                if (string.IsNullOrEmpty(CmbTypeOfEmployee.Text) == false)
                {
                    //Change query based on type of employee
                    if (CmbTypeOfEmployee.Text.Equals("Mechanic"))
                    {
                        objDatabase.Query = "SELECT MECHANIC_ID FROM Mechanic";
                    }
                    else if (CmbTypeOfEmployee.Text.Equals("Driver"))
                    {
                        objDatabase.Query = "SELECT DRIVER_ID FROM Driver";
                    }

                    //Read through the database dataset. Fill combo box
                    SqlDataReader sqlDR = objDatabase.GetDataReader();
                    while (sqlDR.Read())
                    {
                        CmbEmployeeID.Items.Add(sqlDR[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Employee of Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        //*************************************************************************
    }
}
