/* frmUpdateOwner.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Update an owner in the database
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjDurbanArtGalleryApp
{
    public partial class frmUpdateOwner : Form
    {
        public frmUpdateOwner()
        {
            InitializeComponent();
            FillComboBox();
        }
        //***********************************************************
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNullValues(cmbxOwnerId.Text) == false)
                {
                    DbConnect objDatabase = new DbConnect();
                    SqlDataReader sqlDR;
                    objDatabase.dbConnection();
                    objDatabase.Query = "SELECT * FROM Owner WHERE OwnerID = @idnum";
                    objDatabase.SearchIdNumber(cmbxOwnerId.Text);
                    sqlDR = objDatabase.GetIdNumbers();

                    while (sqlDR.Read())
                    {
                        txtOwnerName.Text = sqlDR["OwnerName"].ToString();
                        txtSurname.Text = sqlDR["OwnerSurname"].ToString();
                        txtOwnerCellNumber.Text = sqlDR["OwnerCellNumber"].ToString();
                    }

                    //Check if the Owner Exists
                    if (CheckRecordExists() == false)
                    {
                        MessageBox.Show("This Record does not Exit.Please Re-Enter Id Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChangeControlProperties(true, false, false, true, true, true);
                    }
                    objDatabase.CloseDbConnection();
                }
                else
                {                   
                    MessageBox.Show("Please Enter Artist Id number. The Click Search", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
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
        //***********************************************************
        public void ChangeControlProperties(bool updateIsEnabled, bool searchIsEnabled,
                                            bool ownerIdIsEnabled, bool ownerNameIsEnabled,
                                            bool cellNumberIsEnabled , bool surnameIsEnabled)
                                           
        {
            //Change the properties of controls
            btnUpdate.Enabled = updateIsEnabled;
            btnSearch.Enabled = searchIsEnabled;
            cmbxOwnerId.Enabled = ownerIdIsEnabled;
            txtOwnerName.Enabled = ownerNameIsEnabled;
            txtSurname.Enabled = surnameIsEnabled;
            txtOwnerCellNumber.Enabled = cellNumberIsEnabled;         
        }
        //***********************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DbConnect objDatabase = new DbConnect();
                objDatabase.dbConnection();
                Owner objOwner = new Owner();
                GetFieldValues(objOwner);
                objDatabase.Query = "UPDATE Owner"
                + " SET OwnerName = @OwnerName , OwnerSurname = @OwnerSurname,"
                + " OwnerCellNumber = @OwnerCellNumber"
                + " WHERE OwnerId = @ownerId";
                objDatabase.UpdateDatabase(objOwner.OwnerID, objOwner.OwnerName,
                                           objOwner.OwnerSurname, objOwner.OwnerCellNumber);

                objDatabase.CloseDbConnection();
                ClearFields();
                ChangeControlProperties(false, true, true, false, false, false);
            }
        }
        //***********************************************************
        public void GetFieldValues(Owner ownerObj)
        {
            ownerObj.OwnerID = cmbxOwnerId.Text;
            ownerObj.OwnerName = txtOwnerName.Text;
            ownerObj.OwnerSurname = txtSurname.Text;
            ownerObj.OwnerCellNumber = txtOwnerCellNumber.Text;
        }
        //***********************************************************
        public void ClearFields()
        {
            cmbxOwnerId.Text = "";
            txtOwnerName.Clear();
            txtSurname.Clear();
            txtOwnerCellNumber.Clear();
        }
        //***********************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {         
            this.Dispose();
        }
        //***********************************************************
        public bool CheckRecordExists()
        {
            bool isExists = true;

            //Check Text box values
            if (CheckNullValues(txtOwnerName.Text) && CheckNullValues(txtSurname.Text) && 
                CheckNullValues(txtOwnerCellNumber.Text))
            {
                isExists = false;              
            }

            return isExists;
        }
        //***********************************************************
        public bool CheckNullValues(string field)
        {
            bool isNull = false;

            if (string.IsNullOrEmpty(field))
            {
                isNull = true;
            }

            return isNull;
        }
        //***********************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;
            string outputMessage = "";

            if (CheckNullValues(txtOwnerName.Text))
            {
                isValid = false;
                outputMessage = "Please Enter in the Artists Name";         
            }
            else if (CheckNullValues(txtOwnerCellNumber.Text))
            {
                isValid = false;
                outputMessage = "Please Enter Artists Cell Number";              
            }
            else if (txtOwnerCellNumber.Text.Length != 10)
            {
                isValid = false;
                outputMessage = "Artist Cell Number is Incorrect. Please enter 10 digits";
               
            }
            else if (double.TryParse(txtOwnerCellNumber.Text, out temporaryValue) == false)
            {
                isValid = false;
                outputMessage = "Artist Cell Number is not in the correct Format.";            
            }
            else if (CheckNullValues(txtSurname.Text))
            {
                isValid = false;
                outputMessage = "Please Enter Artist Surname";             
            }

            if (isValid == false)
            {
                MessageBox.Show(outputMessage, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return isValid;
        }
        //***********************************************************
        public void FillComboBox()
        {
            try
            {
                DbConnect objDatabase = new DbConnect();
                SqlDataReader sqlDataRead;
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT OwnerID FROM Owner";
                sqlDataRead = objDatabase.GetDataReader();

                while (sqlDataRead.Read())
                {
                    cmbxOwnerId.Items.Add(sqlDataRead["OwnerID"].ToString());
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
