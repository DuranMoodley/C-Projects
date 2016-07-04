/* FrmDailyDriverTimesheetReport.cs    
 * Lecturer : Rajesh Chanderman    
 * Daily time sheet report
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmDailyDriverTimsheetReport : Form
    {
        public FrmDailyDriverTimsheetReport()
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
                if (!string.IsNullOrEmpty(CmbDriverID.Text) == true)
                {
                    this.DriverTableAdapter.FillBy(this.dsTimesheet.Driver, CmbDriverID.Text, ((System.DateTime)(System.Convert.ChangeType(DtpTripDate.Text, typeof(System.DateTime)))));
                    this.rpvDailyDriver.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Select a Driver Id",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    CmbDriverID.Items.Add(sqlDR["DRIVER_ID"]);
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
