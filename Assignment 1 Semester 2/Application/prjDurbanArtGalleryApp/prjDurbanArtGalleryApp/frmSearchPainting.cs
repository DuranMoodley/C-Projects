/* frmSearchPainting.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Search Painting
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace prjDurbanArtGalleryApp
{
    public partial class frmSearchPainting : Form
    {
        public frmSearchPainting()
        {
            InitializeComponent();
        }
        //*******************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string paintingName = txtPaintingName.Text;

                if (Validation())
                {
                    if (CheckIDExists(paintingName) == false)
                    {
                        MessageBox.Show("This Painting does not Exist. Please make sure its spelt correctly", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ViewDataInGrid(paintingName);
                    }
                }
            }
            catch (SqlException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            
        }
        //*******************************************************************
        public bool CheckIDExists(string name)
        {
            bool isExists = false;
            try
            {
                //Check if the Id number exists
                DbConnect objDatabase = new DbConnect();
                SqlDataReader sqlDR;
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT * FROM Paintings WHERE PaintingName LIKE '" + name + "'";
                sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read() && isExists == false)
                {
                    if (sqlDR["PaintingName"].Equals(name))
                    {
                        isExists = true;
                    }
                }
                objDatabase.CloseDbConnection();
            }
            catch (SqlException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
                   
            return isExists;
        }
        //*******************************************************
        public bool Validation()
        {
            bool isValid = true;

            //Validate the user entry
            if (string.IsNullOrEmpty(txtPaintingName.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Value", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //************************************************************
        public void ViewDataInGrid(string nameOfPainting)
        {
            try
            {
                dgvPainting.Visible = true;
                DbConnect objDatabase = new DbConnect();
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT * FROM Paintings WHERE PaintingName LIKE '" + nameOfPainting + "'";
                DataSet dsPainting = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(objDatabase.Query, objDatabase.Dbconn);
                da.Fill(dsPainting, "Painting");
                dgvPainting.DataSource = dsPainting;
                dgvPainting.DataMember = "Painting";
                objDatabase.dbConnection();
            }
            catch (SqlException exes)
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
