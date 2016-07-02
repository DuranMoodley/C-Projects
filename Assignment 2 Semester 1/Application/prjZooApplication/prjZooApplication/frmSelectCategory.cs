/* frmSelectCategory.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Allows user to select from a category 
 * Last Modified : 6/7/2015
***********************************************/
using System;
using System.Windows.Forms;
namespace prjZooApplication
{
    public partial class frmSelectCategory : Form
    {
        public frmSelectCategory()
        {
            InitializeComponent();
        }
        //********************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //********************************************************
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //********************************************************
        private void btnLion_Click(object sender, EventArgs e)
        {
            this.Dispose();      
            frmAddLion objAddLion = new frmAddLion();
            objAddLion.Visible = true;       
        }
        //********************************************************
        private void btnElephant_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmAddElephant objAddElephant = new frmAddElephant();
            objAddElephant.Visible = true;
        }
        //*******************************************************
        private void btnBirds_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmAddBirds objBirds = new frmAddBirds();
            objBirds.Visible = true;
        }
        //********************************************************
    }
}
