/* FrmMonthlyDriverTimesheetReport.cs    
 * Lecturer : Rajesh Chanderman    
 * Driver Hours worked in a month
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmMonthlyMechanicTimsheetReport : Form
    {
        public FrmMonthlyMechanicTimsheetReport()
        {
            InitializeComponent();
            FillMechanicIdNumbers();
        }
        //*************************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //*************************************************************************************   
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    this.MechanicTableAdapter.FillByMonth(this.dsTimesheet.Mechanic, CmbMechanicID.Text, CmbMonth.Text);
                    this.rpvMonthlyMechanic.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************    
        public bool Validation()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(CmbMechanicID.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Mehanic ID number",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbMonth.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Month",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //*************************************************************************************     
        public void FillMechanicIdNumbers()
        {
            try
            {
                //Retrieve id numbers from the drivers table in the database
                //Fill all id numbers into combo box
                Database objDatabase = new Database();
                objDatabase.Query = "SELECT MECHANIC_ID FROM Mechanic";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    CmbMechanicID.Items.Add(sqlDR["MECHANIC_ID"]);
                }
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
    }
}
