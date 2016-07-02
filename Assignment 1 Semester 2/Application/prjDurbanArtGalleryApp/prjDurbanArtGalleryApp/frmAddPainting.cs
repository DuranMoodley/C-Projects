/* frmAddPainting.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Adds a painting in the database
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjDurbanArtGalleryApp
{
    public partial class frmAddPainting : Form
    {
        public frmAddPainting()
        {
            InitializeComponent();
        }
        //***************************************************************
        private void btnNext_Click(object sender, EventArgs e)
        {
            Painting objPaintings = new Painting();
                       
            if (Validation())
            {
                GetFields(objPaintings);
                string paintingIdNum = objPaintings.PaintingID;
                DatabaseInsertPainting(objPaintings);
                this.Dispose();
                frmAddArtist objOwnerDetails = new frmAddArtist(paintingIdNum);
                objOwnerDetails.Visible = true;
            }
        }
        //***************************************************************
        public void GetFields(Painting objPainting)
        {           
            objPainting.PaintingID = txtPaintingID.Text;
            objPainting.PaintingName = txtPaintingName.Text;
            objPainting.PaintingCostPrice = txtCostPrice.Text;
            objPainting.PaintingSection = char.Parse(cmbxSectionCode.Text);
            objPainting.PaintingStatus = cmbxPaintingStatus.Text;
        }
        //***************************************************************
        public bool CheckNullValues(string field)
        {
            bool isNull = false;

            if (string.IsNullOrEmpty(field))
            {
                isNull = true;
            }

            return isNull;
        }
        //***************************************************************
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
            else if (CheckNullValues(cmbxSectionCode.Text))
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
        //***************************************************************
        private void txtPaintingID_MouseEnter(object sender, EventArgs e)
        {
            string paintingID;
            GenerateRandomPaintingID(out paintingID);
            txtPaintingID.Text = paintingID;
            txtPaintingID.Enabled = false;
        }
        //***************************************************************
        public void GenerateRandomPaintingID(out string randomPaintingID)
        {
            randomPaintingID = "";
            try
            {
                Random objRandomID = new Random();
                char randomCharacter;
               
                //Generate 2 Random Characters
                for (int count = 0; count < 2; count++)
                {
                    randomCharacter = (char)objRandomID.Next(65, 90);
                    randomPaintingID += randomCharacter;
                }

                //Generate a 5 digit random Number
                randomPaintingID += objRandomID.Next(10000, 99999).ToString();
            }
            catch (FormatException exe)
            {
                MessageBox.Show(exe.Message);              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }          
        }
        //****************************************************************
        private void mnuItemBack_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }
        //****************************************************************
        public void DatabaseInsertPainting(Painting objPainting)
        {
            string outputToUser = "Painting Information has been Saved";
            DbConnect objDatabase = new DbConnect();
            objDatabase.dbConnection();
            objDatabase.Query = "INSERT INTO Paintings(PaintingID,PaintingName,CostPrice,PaintingStatus,PaintingSection) VALUES(@paintingId,@paintingName,@paintingCost,@paintingStatus,@paintingSection)";
            objDatabase.InsertIntoDatabase(objPainting.PaintingID.Trim(), objPainting.PaintingName,
                                           objPainting.PaintingCostPrice.Trim(), objPainting.PaintingSection, 
                                           objPainting.PaintingStatus.Trim(),outputToUser);
                                          
            objDatabase.CloseDbConnection();
        }
    }
}
