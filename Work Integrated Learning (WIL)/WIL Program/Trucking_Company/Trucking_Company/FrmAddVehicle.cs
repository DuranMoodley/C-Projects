/* FrmAddVehicle.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a trip record in the Trip table in the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Trucking_Company
{
    public partial class FrmAddVehicle : Form
    {
        public FrmAddVehicle()
        {
            InitializeComponent();
        }
        //**************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //**************************************************************
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Vehicle objVehicle = new Vehicle();
            GetFields(objVehicle);

            if (Validation(objVehicle))
            {
                SendVehicleToDatabase(objVehicle);
            }
        }
        //**************************************************************
        public void GetFields(Vehicle vehicleObj)
        {
            vehicleObj.VehicleNumber = TxtVehicleNumber.Text;
            vehicleObj.VehicleRegistration = TxtVehicleRegistration.Text;
            vehicleObj.VehicleType = TxtVehicleType.Text;
            vehicleObj.VehicleManufacturer = TxtVehicleManufacture.Text;
            vehicleObj.VehicleEngineSize = TxtEngineSize.Text;
            vehicleObj.CurrentOdometerReading = TxtCurrentOdometerReading.Text;
            vehicleObj.NextOdometerReading = DtpNextOdometerReading.Text;
        }
        //**************************************************************
        public bool Validation(Vehicle vehicleObject)
        {
            bool isValid = true;
            double temporaryValue;

            if (TxtVehicleNumber.Text.Length != 4)
            {
                isValid = false;
                MessageBox.Show("Vehicle Number Must be 4 Character eg.H101", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleManufacture.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Manufacturer", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleType.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Type", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleRegistration.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Registration Number",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleType.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Type",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtEngineSize.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Engine Size.", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtCurrentOdometerReading.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Current Odometer Reading.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists())
            {
                isValid = false;
                MessageBox.Show("This Vehicle already Exists in the Database. Operation Failed",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //**************************************************************
        public void SendVehicleToDatabase(Vehicle vehicleObje)
        {
            string outputToUser = "Vehicle Information has been Saved";
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            objDatabase.Query = "INSERT INTO Vehicle(VEHICLE_NUMBER,VEHICLE_REG,VEHICLE_TYPE,VEHICLE_MANUFACTURER,ENGINE_SIZE,CURRENT_ODOMETER_READING,NEXT_ODOMETER_READING)" +
                                "VALUES(@vehicleNum,@vehicleReg,@vehicleType,@vehicleManufacturer,@engineSize,@currentOdometerReading,@nextOdometerReading)";
            objDatabase.InsertIntoVehicleTable(vehicleObje.VehicleNumber, vehicleObje.VehicleRegistration, 
                                           vehicleObje.VehicleType, vehicleObje.VehicleManufacturer,
                                           vehicleObje.VehicleEngineSize, vehicleObje.CurrentOdometerReading, 
                                           vehicleObje.NextOdometerReading, outputToUser);
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
    }
}
