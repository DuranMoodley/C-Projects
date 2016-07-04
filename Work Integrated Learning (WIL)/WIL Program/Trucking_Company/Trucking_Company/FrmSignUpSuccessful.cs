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
    public partial class FrmSignUpSuccessful : Form
    {
        public FrmSignUpSuccessful()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            FrmMainMenu mainMenu = new FrmMainMenu();
            mainMenu.Show();
            Hide(); 
        }
        //_______________________________________________________________________________________________________________________________________________________________
    }
}
