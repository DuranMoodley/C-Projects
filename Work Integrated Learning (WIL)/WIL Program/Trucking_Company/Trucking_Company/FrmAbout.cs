/* FrmAbout.cs    
 * Lecturer : Rajesh Chanderman    
 * Display output to the user
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }
        //_____________________________________________________________________________________________________________________________________________________________
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            mainMenu_Frm();
        }
        //_____________________________________________________________________________________________________________________________________________________________
        public void mainMenu_Frm() 
        {
            Dispose();
        }
        //_____________________________________________________________________________________________________________________________________________________________
    }
}
