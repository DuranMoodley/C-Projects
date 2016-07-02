/* Database.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Displays report of all painting
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Reporting.WinForms;


namespace prjDurbanArtGalleryApp
{
    public partial class frmPaintingReport : Form
    {
        public frmPaintingReport()
        {
            InitializeComponent();
        }
        //*********************************************************8
        private void frmPaintingReport_Load(object sender, EventArgs e)
        {           
            DisplayReport();          
        }
        //*********************************************************8
        public void DisplayReport()
        {
            try
            {
                //https://www.youtube.com/watch?v=LFMtBKpv9Nc&list=WL&index=39
                PaintingdsTableAdapters.PaintingsTableAdapter adapter = new PaintingdsTableAdapters.PaintingsTableAdapter();
                Paintingds.PaintingsDataTable table = new Paintingds.PaintingsDataTable();
                adapter.Fill(table);

                ReportDataSource dataSource = new ReportDataSource("Paintings", (DataTable)table);
                this.rpvPaintings.LocalReport.DataSources.Clear();
                this.rpvPaintings.LocalReport.DataSources.Add(dataSource);
                this.rpvPaintings.LocalReport.Refresh();
                this.rpvPaintings.RefreshReport();
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
        //*********************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {          
            this.Dispose();
        }
    }
}
