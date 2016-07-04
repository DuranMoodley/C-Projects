/* FrmPasswordRecovery.cs    
 * Lecturer : Rajesh Chanderman    
 * Allows the user to retrieve their forgotten password.
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmPasswordRecovery : Form
    {
        public FrmPasswordRecovery()
        {
            InitializeComponent();
        }
        //***************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //***************************************************
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //Retrieve values
                string idNum = TxtIdNumber.Text;
                string emailAddress = TxtEmailAdd.Text;
                string passwordOfUser = "";
                string emailMessage = "Your Password is ";
                string typeOfEmployee = CmbTypeOfEmployee.Text;

                if (CheckUsernameExists(idNum,typeOfEmployee))
                {
                    passwordOfUser = SearchPasswordInDatabase(typeOfEmployee,idNum);
                    emailMessage += passwordOfUser;
                    SendEmails(emailAddress, emailMessage);
                }
            }
        }
        //***************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;
            if (string.IsNullOrEmpty(TxtIdNumber.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Id number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtIdNumber.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in ID number.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtIdNumber.Text.Length != 11)
            {
                isValid = false;
                MessageBox.Show("ID number must be 11 digits.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEmailAdd.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter an Email Address", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TxtEmailAdd.Text.Contains("@") || !TxtEmailAdd.Text.Contains("."))
            {
                isValid = false;
                MessageBox.Show("Incorrect Email Address. Please Re-Enter", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbTypeOfEmployee.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter type of Employee", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //***************************************************
        public void SendEmails(string personEmailAddress, string message)
        {
            try
            {
                //Sends an email to people.
                MailMessage mail = new MailMessage("duranmoodley97@gmail.com", personEmailAddress);
                SmtpClient client = new SmtpClient();
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("duranmoodley97@gmail.com", "ecsxvrkt");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                mail.Subject = "Password";
                mail.Body = message;
                client.Send(mail);
                MessageBox.Show("Email Have Been Sent");              
            }
            catch (SmtpFailedRecipientException exec)
            {
                MessageBox.Show(exec.Message + "Please Check your Internet Connection");
            }
            catch (SmtpException exes)
            {
                MessageBox.Show(exes.Message + "Please Check your Internet Connection");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************
        public string SearchPasswordInDatabase(string typeEmp, string idnumber)
        {
            string password = "";
            try
            {                
                Database objDatabase = new Database();
                objDatabase.dbConnection();

                if (typeEmp.Equals("Manager/Administrator"))
                {
                    objDatabase.Query = "SELECT EmployeePassword FROM Employee WHERE EmployeeIdNumber ='" + idnumber + "'";
                }
                else if (typeEmp.Equals("Mechanic"))
                {
                    objDatabase.Query = "SELECT MECHANIC_PASSWORD FROM Mechanic WHERE MECHANIC_ID ='" + idnumber + "'";
                }
                else if (typeEmp.Equals("Driver"))
                {
                    objDatabase.Query = "SELECT DRIVER_PASSWORD FROM Driver WHERE DRIVER_ID  ='" + idnumber + "'";
                }

                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    password = sqlDR[0].ToString();
                }
                objDatabase.CloseDbConnection();
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return password;
        }
        //*************************************************************
        public bool CheckUsernameExists(string idNumber , string typeEmp)
        {
            bool isFound = false;
            try
            {               
                Database objDatabase = new Database();
                objDatabase.dbConnection();

                if (typeEmp.Equals("Manager/Administrator"))
                {
                    objDatabase.Query = "SELECT EmployeeIdNumber FROM Employee";
                }
                else if (typeEmp.Equals("Mechanic"))
                {
                    objDatabase.Query = "SELECT MECHANIC_ID FROM Mechanic";
                }
                else if (typeEmp.Equals("Driver"))
                {
                    objDatabase.Query = "SELECT DRIVER_ID FROM Driver";
                }
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read() && isFound == false)
                {
                    if (idNumber.Equals(sqlDR[0]))
                    {
                        isFound = true;
                        MessageBox.Show("ID number Has been Found. Email Has been Sent");
                    }
                }

                if (isFound == false)
                {
                    MessageBox.Show("Id number Cannot be Found. Please Try Again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                objDatabase.CloseDbConnection();
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                     
            return isFound;
        }
    }
}
