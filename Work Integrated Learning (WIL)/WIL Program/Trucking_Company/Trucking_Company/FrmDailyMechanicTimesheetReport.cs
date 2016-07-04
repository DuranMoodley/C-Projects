/* FrmDailyMechanicTimesheetReport.cs    
 * Lecturer : Rajesh Chanderman    
 * Daily time sheet report
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmDailyMechanicTimesheetReport : Form
    {
        public FrmDailyMechanicTimesheetReport()
        {
            InitializeComponent();
            FillMechanicIdNumbers();
        }
        //_____________________________________________________________________________________________________________________________________________________________________________________________
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //_____________________________________________________________________________________________________________________________________________________________________________________________
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CmbMechanicID.Text) == false)
                {
                    this.MechanicTableAdapter.FillBy(this.dsTimesheet.Mechanic, CmbMechanicID.Text, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(DtpTripDate.Text, typeof(System.DateTime))))));
                    this.rpvDailyTimesheet.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Please Select a Mechanic Id",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //_____________________________________________________________________________________________________________________________________________________________________________________________
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
        //_____________________________________________________________________________________________________________________________________________________________________________________________
    }
}
