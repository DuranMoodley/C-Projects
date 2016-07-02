/* frmArtistReport.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh ChandArman     Assignment Number : 3
 * displays a report of all the paintings owned by an artist
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace prjDurbanArtGalleryApp
{
    public partial class frmArtistReport : Form
    {
        public frmArtistReport()
        {
            InitializeComponent();
            FillComboBox();
        }
        //*******************************************************************       
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DisplayReport();
        }
        //*******************************************************************
        public void DisplayReport()
        {
            try
            {
                if (string.IsNullOrEmpty(cmbxArtistId.Text) == false)
                {
                    //Parses the paramter into the table adapter. 
                    //fills the report data source with the table data
                    //Displays report
                    OwnerdsTableAdapters.PaintingsTableAdapter adapter = new OwnerdsTableAdapters.PaintingsTableAdapter();
                    Ownerds.PaintingsDataTable table = new Ownerds.PaintingsDataTable();
                    adapter.FillOwnerIdNumber(table, long.Parse(cmbxArtistId.Text));

                    ReportDataSource dataSource = new ReportDataSource("Owner", (DataTable)table);
                    this.rpvOwners.LocalReport.DataSources.Clear();
                    this.rpvOwners.LocalReport.DataSources.Add(dataSource);
                    this.rpvOwners.LocalReport.Refresh();
                    this.rpvOwners.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Please Select the Owner Id Number from the drop down list",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ReportViewerException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }     
        }
        //******************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //******************************************************************
        public void FillComboBox()
        {
            try
            {
                //Retrieves all id numbers from the database
                //Fills combo box
                DbConnect objDatabase = new DbConnect();
                SqlDataReader sqlDataRead;
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT OwnerID FROM Owner";
                sqlDataRead = objDatabase.GetDataReader();

                while (sqlDataRead.Read())
                {
                    cmbxArtistId.Items.Add(sqlDataRead["OwnerID"].ToString());
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
        }
    }
}
