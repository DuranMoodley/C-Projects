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
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }
        //_____________________________________________________________________________________________________________________________________________________________
        private void btn_Return_SignUp_Click(object sender, EventArgs e)
        {
            loadSignUp_frm();
        }
        //_____________________________________________________________________________________________________________________________________________________________
        public void loadSignUp_frm() 
        {
            frm_SignUp signUp = new frm_SignUp();
            signUp.Show();
            Hide();
        }
        //_____________________________________________________________________________________________________________________________________________________________
    }
}
