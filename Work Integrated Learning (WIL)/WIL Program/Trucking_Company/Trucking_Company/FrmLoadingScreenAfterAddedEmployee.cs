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
    public partial class FrmLoadingScreenAfterAddedEmployee : Form
    {
        public FrmLoadingScreenAfterAddedEmployee()
        {
            InitializeComponent();
        }
        //________________________________________________________________________________________________________________
        private void tmr_Loading_Tick(object sender, EventArgs e)
        {
            PrgLoading.Increment(1);

            if (PrgLoading.Value == 100)
            {
                TmrLoading.Stop();
                loadSignUpSuccessful_frm();
            }
        }
        //________________________________________________________________________________________________________________
        public void loadSignUpSuccessful_frm()
        {
            Dispose();
        }
        //________________________________________________________________________________________________________________
    }
}
