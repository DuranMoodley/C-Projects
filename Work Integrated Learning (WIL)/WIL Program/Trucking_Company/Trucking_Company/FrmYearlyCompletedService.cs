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
    public partial class FrmYearlyCompletedService : Form
    {
        public FrmYearlyCompletedService()
        {
            InitializeComponent();
        }
        //*************************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //*************************************************************************************      
        private void BtnGernerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    this.VehicleServiceTableAdapter.FillBy(this.dsServiceCompletedYearly.VehicleService, TxtYear.Text);
                    this.rpvYearReport.RefreshReport();
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
            double temporaryValue;
            if (string.IsNullOrEmpty(TxtYear.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in a Year",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtYear.Text.Length != 4)
            {
                isValid = false;
                MessageBox.Show("Please Enter the full Year eg. 2010",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtYear.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Year.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }

        
    }
}
