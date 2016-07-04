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
    public partial class frm_Login : Form
    {
        public string username, password;

        public frm_Login()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void pic_ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            loadSignUp_frm();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Reading the username & password from the BaseDirectory which can be found in \Trucking_Company\Trucking_Company\bin\Debug and then checking to see if its all correct to login.
            try
            {
                string username = txt_Username.Text;
                string password = txt_Password.Text;
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                bool isEmployeeValid = objDatabase.CheckEmployeeLoginDetails(username,password);
                objDatabase.CloseDbConnection();

                /*var sr = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory + @"\Express Cor Employees Credentials " + "(" + txt_Username.Text + ")" + "\\login.ID");
                username = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
                 */

                //_______________________________________________________________________________________________________________________________________________________________
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

                if (isEmployeeValid)
                {                 
                    MessageBox.Show("You have successfully Logged in"
                              , "Success", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                    frm_Menu objMenu = new frm_Menu();
                    this.Hide();
                    objMenu.Visible = true;
                }
                else
                {
                    MessageBox.Show("Log in Unsuccessful"
                              , "Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
                //_______________________________________________________________________________________________________________________________________________________________
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }           
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public void loadSignUp_frm()
        {
            frm_SignUp signUP = new frm_SignUp();
            signUP.Show();
            Hide();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void txt_Username_Leave(object sender, EventArgs e) 
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
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void txt_Password_Leave(object sender, EventArgs e) 
        {
            // Validation for error & checked messages, these also display tips if you hover over the icon
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
