/* FrmUpdateTrip.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a trip record in the Trip table in the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Trucking_Company
{
    public partial class FrmUpdateTrip : Form
    {
        public FrmUpdateTrip()
        {
            InitializeComponent();
        }
        //************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();         
        }
        //************************************************************
        private void BtnSearch_Click(object sender, EventArgs e)
        {
           
            if ((CheckNullValues(TxtTripID.Text) == false))
            {
                try
                {
                    //Searches for the record using the id number in the database
                    Database objDatabase = new Database();
                    SqlDataReader sqlDR;
                    objDatabase.dbConnection();
                    objDatabase.Query = "SELECT * FROM Trip WHERE TRIP_ID = " + int.Parse(TxtTripID.Text) + "";
                    sqlDR = objDatabase.GetDataReader();

                    while (sqlDR.Read())
                    {
                        CmbTripStatus.Text = sqlDR["TRIP_STATUS"].ToString();
                        TxtKmActuallyTravelled.Text = sqlDR["TRIP_KILOMETRESACTUALLYTRAVELLED"].ToString();
                    }

                    //Check if the record exists in the Trip table
                    if (CheckRecordExists() == false)
                    {
                        MessageBox.Show("This Record does not Exit.Please Re-Enter Id Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChangeControlProperties(true, false, false, true,true,true);
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
            else
            {
                MessageBox.Show("Please Enter Select a Trip Id", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //************************************************************      
        public void ChangeControlProperties(bool updateIsEnabled, bool searchIsEnabled,
                                            bool TripIdIsEnabled, bool tripStatIsEnabled,
                                            bool kmActuallyTravelledIsEnabled, bool hoursIsEnabled)
        {
            //Change the properties of controls
            BtnUpdate.Enabled = updateIsEnabled;
            BtnSearch.Enabled = searchIsEnabled;
            TxtTripID.Enabled = TripIdIsEnabled;
            CmbTripStatus.Enabled = tripStatIsEnabled;
            TxtKmActuallyTravelled.Enabled = kmActuallyTravelledIsEnabled;
            TxtHours.Enabled = hoursIsEnabled;
        }
        //************************************************************      
        public bool CheckRecordExists()
        {
            bool isExists = true;

            //Check Text box values
            if (CheckNullValues(CmbTripStatus.Text))
            {
                isExists = false;
            }

            return isExists;
        }
        //************************************************************
        public bool CheckNullValues(string values)
        {
            bool isNull = false;

            if (string.IsNullOrEmpty(values))
            {
                isNull = true;
            }

            return isNull;
        }
        //************************************************************
        public void GetFieldValues(Trip objTrip)
        {
            //Set values in the Object using the control values
            objTrip.TripId = TxtTripID.Text;
            objTrip.TripStatus = CmbTripStatus.Text;
            objTrip.KilometersActuallyTravelled = TxtKmActuallyTravelled.Text;
            objTrip.TripHours = TxtHours.Text;
        }
        //************************************************************
        public void ClearFields()
        {
            TxtTripID.Text = "";
            CmbTripStatus.SelectedIndex = -1;
            TxtKmActuallyTravelled.Clear();
            TxtHours.Clear();
        }
        //************************************************************
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Update the searched record in the Trip table
            //Using the values from the Object
            if (Validation())
            {
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                Trip objTrip = new Trip();
                GetFieldValues(objTrip);
                objDatabase.Query = "UPDATE Trip"
                + " SET TRIP_STATUS = @tripStat , TRIP_KILOMETRESACTUALLYTRAVELLED = @kmtravelled , TRIP_HOURS = @hours"
                + " WHERE TRIP_ID = @tripId";
                objDatabase.UpdateTripTable(objTrip.TripId, objTrip.TripStatus, objTrip.KilometersActuallyTravelled, objTrip.TripHours);
                objDatabase.CloseDbConnection();
                ClearFields();
                ChangeControlProperties(false, true, true, false,false,false);
            }
        }
        //************************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;

            //Validate all control values
            if (CheckNullValues(CmbTripStatus.Text))
            {
                isValid = false;
                MessageBox.Show("Please select a Trip Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtKmActuallyTravelled.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format for Kilometers Travelled", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (double.TryParse(TxtHours.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format for Total Hours", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            return isValid;
        }

        
        //************************************************************
       
    }
}
