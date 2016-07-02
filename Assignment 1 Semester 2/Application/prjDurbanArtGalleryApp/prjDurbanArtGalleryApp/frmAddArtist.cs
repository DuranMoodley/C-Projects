/* frmAddPaintingContinued.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh ChandArman     Assignment Number : 3
 * Add owner for that painting
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;

namespace prjDurbanArtGalleryApp
{
    public partial class frmAddArtist : Form
    {
        string paintingID;
        public frmAddArtist(string idNumOfPainting)
        {
            InitializeComponent();
            paintingID = idNumOfPainting;
        }
        //**********************************************************
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Owner objOwner = new Owner();
           
            if (Validation())
            {
                GetFields(objOwner);
                DatabaseInsertOwner(objOwner);
                this.Dispose();
                frmAddPainting objAddPainting = new frmAddPainting();
                objAddPainting.Visible = true;
            }
        }
        //**********************************************************
        public void GetFields(Owner objOwner)
        {            
            objOwner.OwnerID = txtOwnerId.Text;
            objOwner.OwnerName = txtOwnerName.Text;
            objOwner.OwnerSurname = txtSurname.Text;
            objOwner.OwnerCellNumber = txtOwnerCellNumber.Text;
        }
        //**********************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;
            string outputMessage = "";

            if (CheckNullValues(txtOwnerId.Text))
            {
                isValid = false;
                outputMessage = "Please Enter an Artist Id Number";
            }
            else if (txtOwnerId.Text.Length != 11)
            {
                isValid = false;
                outputMessage = "ID Number must be 11 Digits";                           
            }
            else if (CheckNullValues(txtOwnerName.Text))
            {
                isValid = false;
                outputMessage = "Please Enter in A Name";
                            
            }
            else if (CheckNullValues(txtSurname.Text))
            {
                isValid = false;
                outputMessage = "Please Enter in Artist Surname";                          
            }
            else if(CheckNullValues(txtOwnerCellNumber.Text))
            {
                isValid = false;
                outputMessage = "Please Enter in Artist Cell Number";
                           
            }
            else if (txtOwnerCellNumber.Text.Length != 10)
            {
                isValid = false;
                outputMessage = "Cell Number must be 10 digits";                          
            }
            else if (double.TryParse(txtOwnerCellNumber.Text, out temporaryValue) == false)
            {
                isValid = false;
               outputMessage = "Artist Cell Number is not in the correct Format.";
               
            }
            else if (double.TryParse(txtOwnerId.Text, out temporaryValue) == false)
            {
                isValid = false;
                outputMessage = "Artist Id Number is not in the correct Format.";              
            }

            if (isValid == false)
            {
                MessageBox.Show(outputMessage, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //**********************************************************
        public bool CheckNullValues(string field)
        {
            bool isNull = false;

            if (string.IsNullOrEmpty(field))
            {
                isNull = true;
            }

            return isNull;
        }
        //**********************************************************
        public void DatabaseInsertOwner(Owner objOwner)
        {
            string outputToUser = "Owner Details have been Saved";
            DbConnect objDatabase = new DbConnect();
            objDatabase.dbConnection();
            objDatabase.Query = "INSERT INTO Owner(OwnerID,OwnerName,OwnerSurname,OwnerCellNumber,PaintingID)"+
                                "VALUES(@ownerId,@ownerName,@ownerSurname,@ownerContactNum,@paintingId)";
            objDatabase.InsertIntoDatabase(objOwner.OwnerID.Trim(),objOwner.OwnerName.Trim(),
                                           objOwner.OwnerSurname.Trim(),objOwner.OwnerCellNumber.Trim(),
                                           paintingID.Trim(),outputToUser);
            objDatabase.CloseDbConnection();           
        }
        //**********************************************************           
    }
}
