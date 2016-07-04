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
    public partial class FrmMonthlyDriverTimesheetReport : Form
    {
        public FrmMonthlyDriverTimesheetReport()
        {
            InitializeComponent();
            FillDriverIdNumbers();
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
                    this.DriverTableAdapter.FillBy1(this.dsTimesheet.Driver, CmbDriverD.Text, CmbMonth.Text);
                    this.rpvMonthly.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************
        public void FillDriverIdNumbers()
        {
            try
            {
                //Retrieve id numbers from the drivers table in the database
                //Fill all id numbers into combo box
                Database objDatabase = new Database();
                objDatabase.Query = "SELECT DRIVER_ID FROM Driver";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    CmbDriverD.Items.Add(sqlDR["DRIVER_ID"]);
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
        //*************************************************************************************
        public bool Validation()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(CmbDriverD.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Driver ID number",
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
    }
}
