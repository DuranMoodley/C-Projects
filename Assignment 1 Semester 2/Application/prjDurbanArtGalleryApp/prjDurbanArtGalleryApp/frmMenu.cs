/* frmMenu.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Displays a list of options for the user
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Threading;

namespace prjDurbanArtGalleryApp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            try
            {
                Thread objThread = new Thread(new ThreadStart(SplashScreenStart));
                objThread.Start();
                Thread.Sleep(3000);
                objThread.Abort();
                InitializeComponent();
            }
            catch (ThreadAbortException exec)
            {
                MessageBox.Show(exec.Message);
            }
            catch (ThreadInterruptedException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (ThreadStartException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception execep)
            {
                MessageBox.Show(execep.Message);
            }           
        }
        //********************************************************************
        public void SplashScreenStart()
        {
            Application.Run(new frmSplashScreen());
        }
        //********************************************************************
        private void mnuItemAddPainting_Click(object sender, EventArgs e)
        {
            frmAddPainting objAddPainting = new frmAddPainting();
            objAddPainting.Visible = true;
        }
        //********************************************************************
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        //********************************************************************
        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //********************************************************************
        private void mnuItemPaintingUpdate_Click(object sender, EventArgs e)
        {
            frmUpdatePainting objUpdatePainting = new frmUpdatePainting();
            objUpdatePainting.Visible = true;           
        }
        //********************************************************************
        private void mnuItemOwnerUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateOwner objOwner = new frmUpdateOwner();
            objOwner.Visible = true;          
        }
        //********************************************************************
        private void mnuItemDelete_Click(object sender, EventArgs e)
        {
            frmDeletePainting objDeletePainting = new frmDeletePainting();
            objDeletePainting.Visible = true;          
        }
        //********************************************************************
        private void mnuItemSearch_Click(object sender, EventArgs e)
        {
            frmSearchPainting objSearch = new frmSearchPainting();
            objSearch.Visible = true;          
        }
        //********************************************************************      
        private void mnuItemPaintings_Click(object sender, EventArgs e)
        {
            frmPaintingReport objReport = new frmPaintingReport();
            objReport.Visible = true; 
        }
        //********************************************************************      
        private void mnuItemOwner_Click(object sender, EventArgs e)
        {
            frmArtistReport objArtistReport = new frmArtistReport();
            objArtistReport.Visible = true;
        }
    }
}
