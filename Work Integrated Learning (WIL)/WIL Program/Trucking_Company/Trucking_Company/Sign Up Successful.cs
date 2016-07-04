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
    public partial class frm_SignUpSuccessful : Form
    {
        public frm_SignUpSuccessful()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
    }
}
