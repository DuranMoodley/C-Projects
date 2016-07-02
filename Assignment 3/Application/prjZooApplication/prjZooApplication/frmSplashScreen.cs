/* frmSplashScreen.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Takes a string and sends to a text file
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace prjZooApplication
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        //*******************************************************
        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            prbSplashScreen.Increment(1);

            if(prbSplashScreen.Value == 100)
            {
                tmrSplashScreen.Stop();
                this.Dispose();
                frmMenu objMenu = new frmMenu();
                objMenu.Visible = true;
            }
        }
        //*******************************************************
    }
}
