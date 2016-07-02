using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDurbanArtGalleryApp
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        //*************************************************************
        private void tmr_Tick(object sender, EventArgs e)
        {
            prbSplash.Increment(1);

            if (prbSplash.Value == 100)
            {
                tmr.Stop();
                this.Dispose();
                frmMenu objMenu = new frmMenu();
                objMenu.Visible = true;
            }
        }
    }
}
