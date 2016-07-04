/* FrmDailyServiceAppointmentList.cs    
 * Lecturer : Rajesh Chanderman    
 * Daily Service Appointment list
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmDailyServiceAppointmentListReport : Form
    {
        public FrmDailyServiceAppointmentListReport()
        {
            InitializeComponent();
        }
        //_________________________________________________________________________________________________________________________________________________________________________________________
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //_________________________________________________________________________________________________________________________________________________________________________________________
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                this.VehicleServicesTableAdapter.FillByDailyWaiting(this.dsDailyServiceAppointmentList.VehicleServices, ((System.DateTime)(System.Convert.ChangeType(DtpServiceDate.Text, typeof(System.DateTime)))));
                this.rpvDailyServiceAppointmentList.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //_________________________________________________________________________________________________________________________________________________________________________________________
    }
}
