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
    public partial class FrmServiceRequirementJobSheet : Form
    {
        public FrmServiceRequirementJobSheet()
        {
            InitializeComponent();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmServiceRequirementJobSheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsServiceJobSheet.ServiceJobsheet' table. You can move, or remove it, as needed.
            this.ServiceJobsheetTableAdapter.Fill(this.dsServiceJobSheet.ServiceJobsheet);
            this.reportViewer1.RefreshReport();
        }
    }
}
