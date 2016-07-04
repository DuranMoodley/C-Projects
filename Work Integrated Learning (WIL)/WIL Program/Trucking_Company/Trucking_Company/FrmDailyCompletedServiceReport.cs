/* FrmDailyCompletedService.cs    
 * Lecturer : Rajesh Chanderman    
 * Displays a daily completed Service
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmDailyCompletedServiceReport : Form
    {
        public FrmDailyCompletedServiceReport()
        {
            InitializeComponent();
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
                this.VehicleServiceTableAdapter.FillBy(this.dsDailyVehicleServiceCompleted.VehicleService, ((System.DateTime)(System.Convert.ChangeType(DtpServiceDate.Text, typeof(System.DateTime)))));
                this.rpvDailyCompletedService.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************
    }
}
