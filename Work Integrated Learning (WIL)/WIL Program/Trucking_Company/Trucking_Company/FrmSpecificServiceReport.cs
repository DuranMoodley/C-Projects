/* FrmWeeklyServiceAppointmentList.cs    
 * Lecturer : Rajesh Chanderman    
 * Weekly Service appointment list
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmSpecificServiceReport : Form
    {
        public FrmSpecificServiceReport()
        {
            InitializeComponent();
            FillServiceCodes();
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
                if (string.IsNullOrEmpty(CmbServiceCode.Text) == false)
                {
                    this.VehicleServiceTableAdapter.FillBy(this.dsSpecificService.VehicleService, ((int)(System.Convert.ChangeType(CmbServiceCode.Text, typeof(int)))));
                    this.rpvSpecificService.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }  
        //*************************************************************************************       
        public void FillServiceCodes()
        {
            try
            {
                //Retrieve id numbers from the drivers table in the database
                //Fill all id numbers into combo box
                Database objDatabase = new Database();
                objDatabase.Query = "SELECT SERVICE_CODE FROM Service";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    CmbServiceCode.Items.Add(sqlDR["SERVICE_CODE"]);
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
