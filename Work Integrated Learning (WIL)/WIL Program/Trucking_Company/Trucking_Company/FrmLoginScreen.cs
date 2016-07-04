/* FrmLogin.cs    
 * Lecturer : Rajesh Chanderman    
 * Allows the User to Login to the system by entering in their login details
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmLoginScreen : Form
    {
        public string username, password;

        public FrmLoginScreen()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void PicExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            loadSignUp_frm();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Open Database Connection
                string username = TxtUsername.Text;
                string password = TxtPassword.Text;
                string columnUsername = "";
                string columnPassword = "";
                Database objDatabase = new Database();
                objDatabase.dbConnection();

                //Check password to determine the type of employee 
                if (password.StartsWith("DR"))
                {
                    objDatabase.Query = "SELECT * FROM Driver";
                    columnUsername = "DRIVER_NAME";
                    columnPassword = "DRIVER_PASSWORD";
                }
                else if (password.StartsWith("ME"))
                {
                    objDatabase.Query = "SELECT * FROM Mechanic";
                    columnUsername = "MECHANIC_NAME";
                    columnPassword = "MECHANIC_PASSWORD";
                }
                else
                {
                    objDatabase.Query = "SELECT * FROM Employee";
                    columnUsername = "EmployeeUsername";
                    columnPassword = "EmployeePassword";
                }

                //Create reader
                //Search through the database looking for the correct login details                
                bool isEmployeeValid = SearchEmployeeDetails(username, password,
                                        objDatabase, columnUsername, columnPassword);
                objDatabase.CloseDbConnection();

                //_______________________________________________________________________________________________________________________________________________________________
                // Validation for error & checked messages, these also display tips if you hover over the icon
                if (string.IsNullOrEmpty(TxtPassword.Text))
                {
                    ErrUsername.Icon = Properties.Resources.error;
                    ErrUsername.SetError(TxtPassword, "Username error, try entering in something");
                }
                else
                {
                    ErrUsername.Icon = Properties.Resources.check;
                    ErrUsername.SetError(TxtPassword, "Vaild input");
                }

                if (string.IsNullOrEmpty(TxtUsername.Text))
                {
                    ErrPassword.Icon = Properties.Resources.error;
                    ErrPassword.SetError(TxtUsername, "Password error, try entering in something");
                }
                else
                {
                    ErrPassword.Icon = Properties.Resources.check;
                    ErrPassword.SetError(TxtUsername, "Vaild input");
                }
                //_______________________________________________________________________________________________________________________________________________________________

                if (isEmployeeValid)
                {
                    MessageBox.Show("You have successfully Logged in", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMainMenu MainMenu = new FrmMainMenu(password);
                    MainMenu.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Log in Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //_______________________________________________________________________________________________________________________________________________________________
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //______________________________________________________________________________________________________________________________________________________________________________
        public void loadSignUp_frm()
        {
            FrmSignUp signUP = new FrmSignUp();
            signUP.Show();        
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            // Validation for error & checked messages, these also display tips if you hover over the icon
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                ErrUsername.Icon = Properties.Resources.error;
                ErrUsername.SetError(TxtPassword, "Username error, try entering in something");
            }
            else
            {
                ErrUsername.Icon = Properties.Resources.check;
                ErrUsername.SetError(TxtPassword, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            // Validation for error & checked messages, these also display tips if you hover over the icon
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                ErrPassword.Icon = Properties.Resources.error;
                ErrPassword.SetError(TxtUsername, "Password error, try entering in something");
            }
            else
            {
                ErrPassword.Icon = Properties.Resources.check;
                ErrPassword.SetError(TxtUsername, "Vaild input");
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void LblForgotPassword_Click(object sender, EventArgs e)
        {
            FrmPasswordRecovery objPasswordReovery = new FrmPasswordRecovery();
            objPasswordReovery.Visible = true;         
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void ChkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
        //_______________________________________________________________________________________________________________________________________________________________
        public bool SearchEmployeeDetails(string userName, string password, Database objData, string colUsername, string colPassword)
        {
            SqlDataReader sqlDR = objData.GetDataReader();
            bool found = false;

            while (sqlDR.Read() && found == false)
            {
                if ((userName.Equals(sqlDR[colUsername].ToString()) &&
                    password.Equals(sqlDR[colPassword].ToString())))
                {
                    found = true;
                    if (!password.StartsWith("DR") && !password.StartsWith("ME"))
                    {
                        if (sqlDR["EmployeeStatus"].ToString().Equals("Disabled"))
                        {
                            MessageBox.Show("Access Denied. Your Employee Status has been Disabled",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            found = false;
                        }
                    }
                }
            }

            return found;
        }
    }
}
