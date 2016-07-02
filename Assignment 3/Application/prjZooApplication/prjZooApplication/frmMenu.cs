/* frmMenu.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Provides a user with a list of options
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.Threading;
using System.Windows.Forms;

namespace prjZooApplication
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {           
            InitializeComponent();
        }
        //******************************************************************************************
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //******************************************************************************************
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelectCategory objCategory = new frmSelectCategory();
            objCategory.Visible = true;
        }
        //******************************************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDelete objDelete = new frmDelete();
            objDelete.Visible = true;
        }
        //******************************************************************************************       
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddNewZooKeeper objAddZookeeper = new frmAddNewZooKeeper();
            objAddZookeeper.Visible = true;
        }
        //*****************************************************************************************
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport objReport = new frmReport();
            objReport.Visible = true;
        }
        //******************************************************************************************
      
    }
}
