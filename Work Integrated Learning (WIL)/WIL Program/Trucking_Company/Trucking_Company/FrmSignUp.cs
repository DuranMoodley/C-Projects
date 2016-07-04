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
    public partial class FrmSignUp : Form
    {
        public string username, password;

        public FrmSignUp()
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
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                ErrUsername.Icon = Properties.Resources.error;
                ErrUsername.SetError(TxtUsername, "Username error, try entering in something");
            }
            else
            {
                ErrUsername.Icon = Properties.Resources.check;
                ErrUsername.SetError(TxtUsername, "Vaild input");
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                ErrPassword.Icon = Properties.Resources.error;
                ErrPassword.SetError(TxtPassword, "Password error, try entering in something");
            }
            else
            {
                ErrPassword.Icon = Properties.Resources.check;
                ErrPassword.SetError(TxtPassword, "Vaild input");
            }
            //_______________________________________________________________________________________________________________________________________________________________
            // Writing the idNum & password and saving it to the BaseDirectory which can be found in \Trucking_Company\Trucking_Company\bin\Debug
            try
            {
                var sw = new System.IO.StreamWriter(@"\Express Cor Employees Credentials " + TxtUsername.Text + "\\login.ID");
                sw.Write(TxtUsername.Text + "\n" + TxtPassword.Text);
                sw.Close();
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\Express Cor Employees Credentials " + "(" + TxtUsername.Text + ")");
                var sw = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\Express Cor Employees Credentials " + "(" + TxtUsername.Text + ")" + "\\login.ID");
                sw.Write(TxtUsername.Text + "\n" + TxtPassword.Text);
                MessageBox.Show(ex.Message);
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
            FrmLoginScreen signUpLoadingScreen = new FrmLoginScreen();
            signUpLoadingScreen.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadAbout_frm() 
        {
            FrmAbout about = new FrmAbout();
            about.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadLogin_frm()
        {
            FrmLoginScreen login = new FrmLoginScreen();
            login.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        // Validation for error & checked messages, these also display tips if you hover over the icon
        private void txt_Username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                ErrUsername.Icon = Properties.Resources.error;
                ErrUsername.SetError(TxtUsername, "Username error, try entering in something");
            }
            else
            {
                ErrUsername.Icon = Properties.Resources.check;
                ErrUsername.SetError(TxtUsername, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        // Validation for error & checked messages, these also display tips if you hover over the icon
        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                ErrPassword.Icon = Properties.Resources.error;
                ErrPassword.SetError(TxtPassword, "Password error, try entering in something");
            }
            else
            {
                ErrPassword.Icon = Properties.Resources.check;
                ErrPassword.SetError(TxtPassword, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
    }
}
