/* FrmAddTrip.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a trip record in the Trip table in the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmAddTrip : Form
    {
        public FrmAddTrip()
        {
            InitializeComponent();
        }
        //**************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //**************************************************************
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Send object values to the Trip Table in the Database
            Trip objTrip = new Trip();
            
            if (Validation())
            {
                GetFields(objTrip);
                SendToDatabase(objTrip);
            }            
        }
        //**************************************************************
        public void GetFields(Trip tripObj)
        {
            //Set trip object with control values
            tripObj.TripId = TxtTripID.Text;
            tripObj.TripDestination = TxtTripDestination.Text;
            tripObj.EstimatedKilometersTravelled = TxtEstimatedTravelled.Text;           
            tripObj.TripStatus = CmbTripStatus.Text;
            tripObj.VehicleNumber = TxtVehicleNumber.Text;
            tripObj.TripDate = DtpTripDate.Text;        
        }
        //**************************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;

            if (string.IsNullOrEmpty(TxtTripID.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter in a Trip ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtTripDestination.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter in a Trip Destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtEstimatedTravelled.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Estimated Travelled Field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleNumber.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in the Vehicle Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbTripStatus.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Trip Status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists() == false)
            {
                isValid = false;
                MessageBox.Show("The Vehicle Number does not Exist. Operation Failed. ", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //**************************************************************
        public void SendToDatabase(Trip obj)
        {
            //Send object values to the Trip table in the database
            string output = "Trip Information Saved Successfully";
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            objDatabase.Query = "INSERT INTO Trip(TRIP_ID,VEHICLE_NUMBER,TRIP_KILOMETRESESTIMATEDTRAVELLED,TRIP_DATE,TRIP_DESTINATION,TRIP_STATUS)" +
                "VALUES(@tripId,@vehicleNumber,@estimatedKilometersTravelled,@tripDate,@tripDestination,@tripStatus)";
            objDatabase.InsertIntoTripTable(obj.TripId, obj.TripDestination,
                                            obj.EstimatedKilometersTravelled, obj.TripDate, obj.TripStatus, 
                                            obj.VehicleNumber, output);
            objDatabase.CloseDbConnection();
        }
        //**************************************************************
        public bool CheckVehicleExists()
        {
            //Searches for the Vehicle number entered in the the Vehicle Table in the Database
            //If not found. Display and Error.
            bool isExists = false;
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            objDatabase.Query = "SELECT VEHICLE_NUMBER FROM Vehicle";
            SqlDataReader sqlDR = objDatabase.GetDataReader();

            while (sqlDR.Read() && isExists == false)
            {
                if (TxtVehicleNumber.Text.Equals(sqlDR["VEHICLE_NUMBER"].ToString()))
                {
                    isExists = true;
                }
            }         
            return isExists;
        }
        //**************************************************************
        private void TxtTripID_MouseHover(object sender, EventArgs e)
        {
            TxtTripID.Text = GeneratePassword();
        }
        //**************************************************************
        public string GeneratePassword()
        {
            //Sets a 5 digit random number
            Random objRandomNum = new Random();
            string tripId = objRandomNum.Next(10000, 99999).ToString();
            return tripId;
        } 
    }
}
