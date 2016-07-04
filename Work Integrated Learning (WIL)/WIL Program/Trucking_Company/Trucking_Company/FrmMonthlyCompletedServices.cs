/* FrmMonthlyCompletedServices.cs    
 * Lecturer : Rajesh Chanderman    
 * Montly report on all the completed services
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmMonthlyCompletedServices : Form
    {
        public FrmMonthlyCompletedServices()
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
                    this.VehicleServiceTableAdapter.FillBy(this.dsMonthlyCompletedVehicleService.VehicleService, CmbMonth.Text);
                    this.rpvMonthlyReport.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Please Select a Month",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
