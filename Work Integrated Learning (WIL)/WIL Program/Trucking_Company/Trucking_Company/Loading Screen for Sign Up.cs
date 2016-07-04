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
    public partial class frm_SignUpLoadingScreen : Form
    {
        public frm_SignUpLoadingScreen()
        {
            InitializeComponent();
        }

        private void tmr_Loading_Tick(object sender, EventArgs e)
        {
            prg_Loading.Increment(1);

            if(prg_Loading.Value == 100)
            {
                tmr_Loading.Stop();
                loadSignUpSuccessful_frm();
            }
        }

        public void loadSignUpSuccessful_frm() 
        {
            frm_SignUpSuccessful signUpSuccessful = new frm_SignUpSuccessful();
            signUpSuccessful.Show();
            Hide();
        }
    }
}
