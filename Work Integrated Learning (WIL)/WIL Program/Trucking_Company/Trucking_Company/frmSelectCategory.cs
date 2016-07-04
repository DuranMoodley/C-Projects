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
    public partial class frmSelectCategory : Form
    {
        public frmSelectCategory()
        {
            InitializeComponent();
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Menu objMenu = new frm_Menu();
            this.Dispose();
            objMenu.Visible = true;
        }
        //_______________________________________________________________________________________________________________________________________________________________
        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            FrmAddEmployee objAddEmp = new FrmAddEmployee();
            this.Dispose();
            objAddEmp.Visible = true;
        }
    }
}
