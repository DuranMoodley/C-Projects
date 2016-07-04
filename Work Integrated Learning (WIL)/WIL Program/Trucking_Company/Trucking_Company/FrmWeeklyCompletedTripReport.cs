/* FrmWeeklyCompletedTrip.cs    
 * Lecturer : Rajesh Chanderman    
 * The requirements for the services
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmWeeklyCompletedTripReport : Form
    {
        public FrmWeeklyCompletedTripReport()
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
                if (Validation())
                {
                    this.TripTableAdapter.FillByCompletedWeekly(this.dsTrip.Trip, ((System.DateTime)(System.Convert.ChangeType(DtpStartDate.Text, typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(DtpEndDate.Text, typeof(System.DateTime)))));
                    this.rpvWeeklyComTrip.RefreshReport();
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

            return isValid;
        }

        
    }
}
