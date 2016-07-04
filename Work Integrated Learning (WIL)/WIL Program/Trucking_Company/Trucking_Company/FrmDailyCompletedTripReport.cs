/* FrmDailyCompletedService.cs    
 * Lecturer : Rajesh Chanderman    
 * Displays a daily completed Trip
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;


namespace Trucking_Company
{
    public partial class FrmDailyCompletedTripReport : Form
    {
        public FrmDailyCompletedTripReport()
        {
            InitializeComponent();
        }
        //*************************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                this.CompletedDailyTripTableAdapter.FillBy(this.dsCompletedDailyTrip.CompletedDailyTrip, ((System.DateTime)(System.Convert.ChangeType(DtpTripDate.Text, typeof(System.DateTime)))));
                this.rpvDailyCompletedTrip.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************
        
    }
}
