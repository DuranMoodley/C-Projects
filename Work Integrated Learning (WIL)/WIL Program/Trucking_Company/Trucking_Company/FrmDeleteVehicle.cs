/* FrmDeleteVehicle.cs    
 * Come back to this form(Update Trip table, Trip vnum)
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmDeleteVehicle : Form
    {
        public FrmDeleteVehicle()
        {
            InitializeComponent();
        }
        //********************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //********************************************************************************
        public bool Validation()
        {
            bool isValid = true;

            //Validate the user entry
            if (string.IsNullOrEmpty(TxtVehicleNumber.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Number", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TxtVehicleNumber.Text.Length != 4)
            {
                isValid = false;
                MessageBox.Show("ID Number must be 4 characters eg. H107", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists(TxtVehicleNumber.Text) == false)
            {
                isValid = false;
                MessageBox.Show("This Vehicle Does not Exist.Please Re-Enter Vehicle Number", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleNumberReplacement.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter a Vehicle Number to Replace the Deleted Vehicle for Trips",
                                "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists(TxtVehicleNumberReplacement.Text) == false)
            {
                isValid = false;
                MessageBox.Show("This Vehicle Does not Exist.Please Re-Enter Vehicle Number", "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //********************************************************************************
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string oldVehicle = TxtVehicleNumber.Text;
                string replacement = TxtVehicleNumberReplacement.Text;
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                ReplaceDeletedVehicle(oldVehicle, replacement, objDatabase);
                DeleteVehiceleFromVehicleServices(oldVehicle, objDatabase);
                DeleteVehicleFromVehicleTable(oldVehicle, objDatabase);
            }
        }
        //************************************************************
        public bool CheckVehicleExists(string vehicleNum)
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
                if (vehicleNum.Equals(sqlDR["VEHICLE_NUMBER"].ToString()))
                {
                    isExists = true;
                }
            }
            return isExists;
        }
        public void DeleteVehiceleFromVehicleServices(string vehicleNum, Database objData)
        {
            objData.Query = "DELETE FROM VehicleService WHERE VEHICLE_NUM = @Vnum";
            objData.DeleteVehicle(vehicleNum, false);
        }
        //********************************************************************************
        public void DeleteVehicleFromVehicleTable(string vehicleNumber, Database obj)
        {
            obj.Query = "DELETE FROM Vehicle WHERE VEHICLE_NUMBER = @vNum";
            obj.DeleteVehicle(vehicleNumber, true);
            obj.CloseDbConnection();
        }
        //********************************************************************************
        public void ReplaceDeletedVehicle(string vNumber, string newVehicle, Database databaseObj)
        {
            databaseObj.Query = "UPDATE Trip SET VEHICLE_NUMBER = @newVehicle " +
                                "WHERE VEHICLE_NUMBER = @oldVehicle";
            databaseObj.UpdateTripTable(vNumber, newVehicle);
        }
    }
}
