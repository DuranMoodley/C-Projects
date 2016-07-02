/* frmDeletePainting.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Delete painting and owner of that painting from database
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjDurbanArtGalleryApp
{
    public partial class frmDeletePainting : Form
    {
        public frmDeletePainting()
        {
            InitializeComponent();
            PopulateComboBox();
        }
        //*******************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Retrieve Id number.
            string paintingIdNum = cmbxPaintingID.Text;
                    
            if (Validation())
            {
                if (CheckIDExists(paintingIdNum) == false)
                {
                    MessageBox.Show("This ID Number does not Exist. Please Re-Enter the ID Number", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Delete ID number from Database
                    DeleteOwner(paintingIdNum);
                    DeletePainting(paintingIdNum);                    
                }
            }
        }
        //*******************************************************
        public bool CheckIDExists(string idNum)
        {
            bool isExists = false;

            //Check if the Id number exists
            DbConnect objDatabase = new DbConnect();
            SqlDataReader sqlDR;
            objDatabase.dbConnection();
            objDatabase.Query = "SELECT * FROM Paintings WHERE PaintingID = @idnum";
            objDatabase.SearchIdNumber(idNum);
            sqlDR = objDatabase.GetIdNumbers();

            while (sqlDR.Read() && isExists == false)
            {
                if (sqlDR["PaintingID"].Equals(idNum))
                {
                    isExists = true;
                }
            }

            objDatabase.CloseDbConnection();
            return isExists;
        }
        //*******************************************************
        public bool Validation()
        {
            bool isValid = true;

            //Validate the user entry
            if (string.IsNullOrEmpty(cmbxPaintingID.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Value", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbxPaintingID.Text.Length != 7)
            {
                isValid = false;
                MessageBox.Show("ID Number must be 7 characters eg. AE14537", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {           
            this.Dispose();
        }
        //************************************************************
        public void DeleteOwner(string idNumPainting)
        {
            //Delete Owner of the Painting from the Database
            DbConnect objDatabase = new DbConnect();
            objDatabase.dbConnection();
            objDatabase.Query = "DELETE FROM Owner WHERE PaintingID = @IdNumber";
            objDatabase.DeleteRecord(idNumPainting , false);
            objDatabase.CloseDbConnection();          
        }
        //************************************************************
        public void DeletePainting(string idNumberPainting)
        {
            //Delete Painting From the Database
            DbConnect objDatabase = new DbConnect();
            objDatabase.dbConnection();
            objDatabase.Query = "DELETE FROM Paintings WHERE PaintingID = @IdNumber";
            objDatabase.DeleteRecord(idNumberPainting , true);
            objDatabase.CloseDbConnection();
        }
        //************************************************************
        public void PopulateComboBox()
        {
            try
            {
                DbConnect objDatabase = new DbConnect();
                SqlDataReader sqlDataRead;
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT PaintingID FROM Paintings";
                sqlDataRead = objDatabase.GetDataReader();

                while (sqlDataRead.Read())
                {
                    cmbxPaintingID.Items.Add(sqlDataRead["PaintingID"].ToString());
                }

                objDatabase.CloseDbConnection();
            }
            catch (SqlException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
