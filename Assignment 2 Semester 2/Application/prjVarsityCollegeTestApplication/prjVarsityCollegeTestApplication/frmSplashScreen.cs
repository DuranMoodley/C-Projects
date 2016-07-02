/* frmSplashScreen.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Opens a Splash Screen
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        //****************************************************
        private void tmr_Tick(object sender, EventArgs e)
        {
            prb.Increment(1);

            if (prb.Value == 100)
            {
                tmr.Stop();
                this.Dispose();
                frmLogin objLogin = new frmLogin();
                objLogin.Visible = true;
            }
        }
        //****************************************************      
    }
}
