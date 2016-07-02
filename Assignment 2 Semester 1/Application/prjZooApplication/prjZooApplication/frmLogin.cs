using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prjZooApplication
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread objThread = new Thread(new ThreadStart(SplashScreenStart));
            objThread.Start();
            Thread.Sleep(3000);
            objThread.Abort();
            InitializeComponent();
        }
        //********************************************************************
        public void SplashScreenStart()
        {
            Application.Run(new frmSplashScreen());
        }
        //********************************************************************
        private void btnLogin_Click(object sender, EventArgs e)
        {
           if(txtUserName.Text.Equals("Administrator") && txtPassword.Text.Equals("5"))
           {
               MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               this.Hide();
               frmMenu objMenu = new frmMenu();
               objMenu.Visible = true;
           }
           else
           {
               MessageBox.Show("Incorrect Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        //********************************************************************
    }
}
