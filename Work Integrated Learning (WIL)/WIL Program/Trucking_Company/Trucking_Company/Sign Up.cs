using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Trucking_Company
{
    public partial class frm_SignUp : Form
    {
        public string username, password;

        public frm_SignUp()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_AboutVacationHub_Click(object sender, EventArgs e)
        {
            loadAbout_frm();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            // Validation for error & checked messages, these also display tips if you hover over the icon
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                err_Username.Icon = Properties.Resources.error;
                err_Username.SetError(txt_Username, "Username error, try entering in something");
            }
            else
            {
                err_Username.Icon = Properties.Resources.check;
                err_Username.SetError(txt_Username, "Vaild input");
            }

            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                err_Password.Icon = Properties.Resources.error;
                err_Password.SetError(txt_Password, "Password error, try entering in something");
            }
            else
            {
                err_Password.Icon = Properties.Resources.check;
                err_Password.SetError(txt_Password, "Vaild input");
            }
            //_______________________________________________________________________________________________________________________________________________________________
            // Writing the username & password and saving it to the BaseDirectory which can be found in \Trucking_Company\Trucking_Company\bin\Debug
            try
            {
                var sw = new System.IO.StreamWriter(@"\Express Cor Employees Credentials " + txt_Username.Text + "\\login.ID");
                sw.Write(txt_Username.Text + "\n" + txt_Password.Text);
                sw.Close();
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Express Cor Employees Credentials " + "(" + txt_Username.Text + ")");
                var sw = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Express Cor Employees Credentials " + "(" + txt_Username.Text + ")" + "\\login.ID");
                sw.Write(txt_Username.Text + "\n" + txt_Password.Text);
                sw.Close();
                loadSignUpLoadingScreen_frm();
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            loadLogin_frm();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadSignUpLoadingScreen_frm()
        {
            frm_SignUpLoadingScreen signUpLoadingScreen = new frm_SignUpLoadingScreen();
            signUpLoadingScreen.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadAbout_frm() 
        {
            frm_About about = new frm_About();
            about.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadLogin_frm()
        {
            frm_Login login = new frm_Login();
            login.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        // Validation for error & checked messages, these also display tips if you hover over the icon
        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                err_Username.Icon = Properties.Resources.error;
                err_Username.SetError(txt_Username, "Username error, try entering in something");
            }
            else
            {
                err_Username.Icon = Properties.Resources.check;
                err_Username.SetError(txt_Username, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        // Validation for error & checked messages, these also display tips if you hover over the icon
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                err_Password.Icon = Properties.Resources.error;
                err_Password.SetError(txt_Password, "Password error, try entering in something");
            }
            else
            {
                err_Password.Icon = Properties.Resources.check;
                err_Password.SetError(txt_Password, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
    }
}
