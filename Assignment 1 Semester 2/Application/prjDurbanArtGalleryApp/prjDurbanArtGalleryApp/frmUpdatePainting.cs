/* frmUpadatePainting.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Update a painting
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjDurbanArtGalleryApp
{
    public partial class frmUpdatePainting : Form
    {
        public frmUpdatePainting()
        {
            InitializeComponent();
            PopulateListBox();
        }
        //*************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckNullValues(txtPaintingID.Text) == false)
                {
                    //Connect to Database, Display Search Results in Text boxs                                
                    DbConnect objDatabase = new DbConnect();
                    SqlDataReader sqlDR;
                    objDatabase.dbConnection();
                    objDatabase.Query = "SELECT * FROM Paintings WHERE PaintingID = @idnum";
                    objDatabase.SearchIdNumber(txtPaintingID.Text);
                    sqlDR = objDatabase.GetIdNumbers();

                    while (sqlDR.Read())
                    {
                        txtPaintingName.Text = sqlDR["PaintingName"].ToString();
                        txtCostPrice.Text = sqlDR["CostPrice"].ToString();
                        txtSectionCode.Text = sqlDR["PaintingSection"].ToString();
                        cmbxPaintingStatus.Text = sqlDR["PaintingStatus"].ToString();
                    }

                    //Check if the Painting Exists
                    if (CheckRecordExists() == false)
                    {
                        MessageBox.Show("This Record does not Exit. Please Re-Enter Painting Id Number",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChangeControlProperties(true, false, false, true, true, true, true,false);
                    }

                    objDatabase.CloseDbConnection();
                }
                else
                {
                    MessageBox.Show("Please Enter Painting Id Number",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //*************************************************************
        public void ChangeControlProperties(bool updateIsEnabled, bool searchIsEnabled,
                                            bool paintingIsEnabled, bool paintingNameIsEnabled,
                                            bool priceIsEnabled , bool sectionIsEnabled,
                                            bool statusIsEnabled , bool lstBoxEnabled)
        {
            //Change the properties of controls
            btnUpdate.Enabled = updateIsEnabled;
            btnSearch.Enabled = searchIsEnabled;
            txtPaintingID.Enabled = paintingIsEnabled;
            txtPaintingName.Enabled = paintingNameIsEnabled;
            txtCostPrice.Enabled = priceIsEnabled;
            txtSectionCode.Enabled = sectionIsEnabled;
            cmbxPaintingStatus.Enabled = statusIsEnabled;
            lstPaintingIdNumbers.Enabled = lstBoxEnabled;
        }
        //*************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //Updates a record in the database,
                //Resets form to its original state
                DbConnect objDatabase = new DbConnect();
                objDatabase.dbConnection();
                Painting objPainting = new Painting();
                GetFieldValues(ref objPainting);
                objDatabase.Query = "UPDATE Paintings"
                + " SET PaintingName = @paintingName , CostPrice = @costPrice,"
                + " PaintingStatus = @paintingStatus , PaintingSection = @paintingSection"
                + " WHERE PaintingID = @paintingId";
                objDatabase.UpdateDatabase(objPainting.PaintingID, objPainting.PaintingName,
                                                   objPainting.PaintingCostPrice, objPainting.PaintingStatus,
                                                   objPainting.PaintingSection);
                objDatabase.CloseDbConnection();
                ClearFieldValues();
                ChangeControlProperties(false, true, true, false, false, false, false,true);
            }        
        }
        //*************************************************************
        public void GetFieldValues(ref Painting paintingObj)
        {
            //Sets object values from text boxes
            paintingObj.PaintingName = txtPaintingName.Text;
            paintingObj.PaintingStatus = cmbxPaintingStatus.Text;
            paintingObj.PaintingSection = char.Parse(txtSectionCode.Text);
            paintingObj.PaintingCostPrice = txtCostPrice.Text;
            paintingObj.PaintingID = txtPaintingID.Text;
        }
        //*************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {           
            this.Dispose();
        }
        //*************************************************************
        public void ClearFieldValues()
        {
            txtPaintingID.Clear();
            txtCostPrice.Clear();
            txtPaintingName.Clear();
            txtSectionCode.Clear();
            cmbxPaintingStatus.Text = "";
        }
        //*************************************************************
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
        public bool CheckRecordExists()
        {
            bool isExists = true;

            //Check Text box values After the Search button has been Clicked
            //if nothing is returned, text boxs will be null, showing that the record does not Exist.
            if (CheckNullValues(txtCostPrice.Text) && CheckNullValues(txtPaintingName.Text) &&
                CheckNullValues(txtSectionCode.Text) && CheckNullValues(cmbxPaintingStatus.Text))
            {
                isExists = false;
            }

            return isExists;
        }
        //***********************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;
            string outputMessage = "";

            if (CheckNullValues(txtCostPrice.Text))
            {
                isValid = false;
                outputMessage = "Please Enter the Selling Price for the Painting";                             
            }
            else if (CheckNullValues(txtPaintingName.Text))
            {
                isValid = false;
                outputMessage = "Please Enter the Name of the Painting";                             
            }
            else if (CheckNullValues(txtSectionCode.Text))
            {
                isValid = false;
                outputMessage = "Please Enter the Section Code of the Painting";                               
            }
            else if (CheckNullValues(cmbxPaintingStatus.Text))
            {
                isValid = false;
                outputMessage = "Please Select a Painting Status";                              
            }
            else if (double.TryParse(txtCostPrice.Text, out temporaryValue) == false)
            {
                isValid = false;
                outputMessage = "Selling Price is in an Incorrect Format. eg 200 Instead of R200";                          
            }

            if (isValid == false)
            {
                MessageBox.Show(outputMessage, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //***********************************************************
        public void PopulateListBox()
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
                    lstPaintingIdNumbers.Items.Add(sqlDataRead["PaintingID"].ToString());
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
        //********************************************************************************88
        private void lstPaintingIdNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPaintingID.Text = lstPaintingIdNumbers.Text;
        }
    }
}
