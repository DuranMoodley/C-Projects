using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmDailyPlannedTripReport : Form
    {
        public FrmDailyPlannedTripReport()
        {
            InitializeComponent();
        }
        //__________________________________________________________________________________________________________________________________________________________________
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //__________________________________________________________________________________________________________________________________________________________________
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                this.TripTableAdapter.FillByNewDaily(this.dsTrip.Trip, ((System.DateTime)(System.Convert.ChangeType(DtpTripDate.Text, typeof(System.DateTime)))));
                this.rptTripInformation.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //__________________________________________________________________________________________________________________________________________________________________       
    }
}
