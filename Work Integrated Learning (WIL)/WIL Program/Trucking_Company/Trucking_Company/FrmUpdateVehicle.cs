/* FrmUpdateVehicle.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a Vehicle in the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmUpdateVehicle : Form
    {
        public FrmUpdateVehicle()
        {
            InitializeComponent();
        }
        //**************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //**************************************************************
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CheckNullValues(TxtVehicleNumber.Text) == false)
            {
                try
                {
                    Database objDatabase = new Database();
                    SqlDataReader sqlDR;
                    objDatabase.dbConnection();
                    objDatabase.Query = "SELECT * FROM Vehicle WHERE VEHICLE_NUMBER = '" + TxtVehicleNumber.Text + "'";
                    sqlDR = objDatabase.GetDataReader();

                    while (sqlDR.Read())
                    {
                        TxtVehicleRegistration.Text = sqlDR["VEHICLE_REG"].ToString();
                        TxtVehicleManufacture.Text = sqlDR["VEHICLE_MANUFACTURER"].ToString();
                        TxtVehicleType.Text = sqlDR["VEHICLE_TYPE"].ToString();
                        TxtEngineSize.Text = sqlDR["ENGINE_SIZE"].ToString();
                        TxtCurrentOdometerReading.Text = sqlDR["CURRENT_ODOMETER_READING"].ToString();
                        DtpNextOdometerReading.Text = sqlDR["NEXT_ODOMETER_READING"].ToString();
                    }

                    //Check if the Owner Exists
                    if (CheckVehicleExists() == false)
                    {
                        MessageBox.Show("This Record does not Exit.Please Re-Enter Vehicle Number eg. H101",
                                        "Error",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChangeControlProperties(true, false, false, true, true, true, true, true, true);
                    }
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
                MessageBox.Show("Please Enter a Vehicle Number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //**************************************************************
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
        public void ChangeControlProperties(bool updateIsEnabled, bool searchIsEnabled,
                                          bool vehicleNumIsEnabled, bool regIsEnabled,
                                          bool vTypeIsEnabled , bool manuIsEnabled,
                                          bool engineSizeIsEnabled, bool currOdoIsEnabled,
                                          bool nextOdoIsEnabled)
        {
            //Change the properties of controls
            BtnUpdate.Enabled = updateIsEnabled;
            BtnSearch.Enabled = searchIsEnabled;
            TxtVehicleNumber.Enabled = vehicleNumIsEnabled;
            TxtVehicleRegistration.Enabled = regIsEnabled;
            TxtVehicleType.Enabled = vTypeIsEnabled;
            TxtVehicleManufacture.Enabled = manuIsEnabled;
            TxtEngineSize.Enabled = engineSizeIsEnabled;
            TxtCurrentOdometerReading.Enabled = currOdoIsEnabled;
            DtpNextOdometerReading.Enabled = nextOdoIsEnabled;          
        }
        //************************************************************
        public void ClearFields()
        {
            TxtVehicleNumber.Clear();
            TxtVehicleRegistration.Clear();
            TxtVehicleType.Clear();
            TxtCurrentOdometerReading.Clear();
            TxtEngineSize.Clear();
            TxtVehicleManufacture.Clear();
        }
        //************************************************************
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                Vehicle objVehicle = new Vehicle();
                GetFieldValues(objVehicle);
                objDatabase.Query = "UPDATE Vehicle"
                + " SET VEHICLE_REG = @vReg, VEHICLE_TYPE = @vType, VEHICLE_MANUFACTURER = @vManu, ENGINE_SIZE ="
                + " @vEngineSize, CURRENT_ODOMETER_READING = @vCurrOdoReadings, NEXT_ODOMETER_READING = @vNextOdoRead"
                + " WHERE VEHICLE_NUMBER LIKE @vNum";
                objDatabase.UpdateVehicleTable(objVehicle.VehicleNumber, objVehicle.VehicleRegistration, objVehicle.VehicleType,
                                               objVehicle.VehicleManufacturer, objVehicle.VehicleEngineSize,
                                               objVehicle.CurrentOdometerReading, objVehicle.NextOdometerReading);
                objDatabase.CloseDbConnection();
                ClearFields();
                ChangeControlProperties(false, true, true, false, false, false, false, false, false);
            }
        }
        //************************************************************
        public void GetFieldValues(Vehicle vehObj)
        {
            vehObj.VehicleNumber = TxtVehicleNumber.Text;
            vehObj.VehicleRegistration = TxtVehicleRegistration.Text;
            vehObj.VehicleManufacturer = TxtVehicleManufacture.Text;
            vehObj.VehicleType = TxtVehicleType.Text;
            vehObj.VehicleEngineSize = TxtEngineSize.Text;
            vehObj.CurrentOdometerReading = TxtCurrentOdometerReading.Text;
            vehObj.NextOdometerReading = DtpNextOdometerReading.Text;
        }
        //*************************************************************************
        public bool Validation()
        {
            bool isValid = true;
            double temporaryValue;

            if (string.IsNullOrEmpty(TxtVehicleManufacture.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter in a Manufacturer",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleRegistration.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter in a Registration Number",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtEngineSize.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Engine Size.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleType.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter the Type of Vehicle",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtCurrentOdometerReading.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect Format in Current Odometer Ready",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists() == false)
            {
                isValid = false;
                MessageBox.Show("The Vehicle Number does not Exist. Operation Failed. ", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtEngineSize.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in an Engine Size.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtCurrentOdometerReading.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in a Current Odometer Reading",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //************************************************************
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
