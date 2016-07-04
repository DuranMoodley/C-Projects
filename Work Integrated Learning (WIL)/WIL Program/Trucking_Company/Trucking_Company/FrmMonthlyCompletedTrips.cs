/* FrmMonthlyCompletedTrips.cs    
 * Lecturer : Rajesh Chanderman    
 * Monthly Completed Trips
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;


namespace Trucking_Company
{
    public partial class FrmMonthlyCompletedTrips : Form
    {
        public FrmMonthlyCompletedTrips()
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
                if (!string.IsNullOrEmpty(CmbMonth.Text))
                {
                    this.TripMonthlyTableAdapter.FillByMontlyCompleted(this.dsMonthlyTrip.TripMonthly, CmbMonth.Text);
                    this.rpvMonthReport.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************      
    }
}
