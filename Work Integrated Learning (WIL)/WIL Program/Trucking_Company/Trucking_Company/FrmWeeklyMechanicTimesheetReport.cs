﻿/* FrmWeeklyMechanicTimesheetReport.cs    
 * Lecturer : Rajesh Chanderman    
 * Weekly Mechanic Timsheet Report
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmWeeklyMechanicTimesheetReport : Form
    {
        public FrmWeeklyMechanicTimesheetReport()
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
                    this.MechanicTableAdapter.FillByWeek(this.dsTimesheet.Mechanic, CmbMechanicID.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DtpStartDate.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DtpEndDate.Text, typeof(System.DateTime))))));
                    this.rpvWeeklyMehanic.RefreshReport();
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
            DateTime startDate = DateTime.Parse(DtpStartDate.Text);
            DateTime endDate = DateTime.Parse(DtpEndDate.Text);
            int result = DateTime.Compare(startDate, endDate);

            if (result > 0)
            {
                MessageBox.Show("Invalid Start Date.The Start date must be smaller Than the End Date",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            else if (string.IsNullOrEmpty(CmbMechanicID.Text))
            {
                MessageBox.Show("Please Select a Mechanic Id number",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
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
