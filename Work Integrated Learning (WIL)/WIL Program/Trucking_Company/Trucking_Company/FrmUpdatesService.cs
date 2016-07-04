/* FrmUpdateService.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a service in the business
 * Last Modified : 10/13/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmUpdatesService : Form
    {
        public FrmUpdatesService()
        {
            InitializeComponent();
        }
        //************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //************************************************************      
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if ((CheckNullValues(TxtServiceCode.Text) || CheckNullValues(TxtVehicleNumber.Text)) == false)
            {
                try
                {
                    Database objDatabase = new Database();
                    SqlDataReader sqlDR;
                    objDatabase.dbConnection();
                    objDatabase.Query = "SELECT * FROM VehicleService WHERE SERVICE_CODE = " + int.Parse(TxtServiceCode.Text) +
                                        " AND VEHICLE_NUM LIKE '" + TxtVehicleNumber.Text + "'";
                    sqlDR = objDatabase.GetDataReader();

                    while (sqlDR.Read())
                    {
                        CmbServiceStatus.Text = sqlDR["SERVICE_STATUS"].ToString();
                    }

                    //Check if the Owner Exists
                    if (CheckRecordExists() == false)
                    {
                        MessageBox.Show("This Record does not Exit.Please Re-Enter Id Number", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ChangeControlProperties(true, false, false, true, false);
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
                MessageBox.Show("Please Enter Select a Service Code and Enter a Vehicle Number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //************************************************************      
        public void ChangeControlProperties(bool updateIsEnabled, bool searchIsEnabled,
                                            bool vehicleIsEnabled, bool serviceStatusIsEnabled,
                                            bool serviceCodeIsEnabled)
        {
            //Change the properties of controls
            BtnUpdate.Enabled = updateIsEnabled;
            BtnSearch.Enabled = searchIsEnabled;
            TxtVehicleNumber.Enabled = vehicleIsEnabled;
            CmbServiceStatus.Enabled = serviceStatusIsEnabled;
            TxtServiceCode.Enabled = serviceCodeIsEnabled;
        }
        //************************************************************      
        public bool CheckRecordExists()
        {
            bool isExists = true;

            //Check Text box values
            if (CheckNullValues(TxtVehicleNumber.Text) && CheckNullValues(CmbServiceStatus.Text))
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
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //Connect to database
                //Update the service based on the service code and Vehicle Number
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                Service objService = new Service();
                GetFieldValues(objService);
                objDatabase.Query = "UPDATE VehicleService"
                + " SET SERVICE_STATUS = @serviceStat"
                + " WHERE SERVICE_CODE = @code AND VEHICLE_NUM = @vNum";
                objDatabase.UpdateVehicleServiceDatabase(objService.serviceCode, objService.vehicleNumber, objService.serviceStatus);
                objDatabase.CloseDbConnection();
                ClearFields();
                ChangeControlProperties(false, true, true, false, true);
            }
        }
        //************************************************************
        public void GetFieldValues(Service objService)
        {
            objService.serviceCode = TxtServiceCode.Text;
            objService.vehicleNumber = TxtVehicleNumber.Text;
            objService.serviceStatus = CmbServiceStatus.Text;
        }
        //************************************************************
        public void ClearFields()
        {
            TxtServiceCode.Clear();
            TxtVehicleNumber.Clear();
            CmbServiceStatus.Text = "";
        }
        //************************************************************
        public bool Validation()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(CmbServiceStatus.Text))
            {
                isValid = false;
                MessageBox.Show("Please enter a Service Status",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                  
            return isValid;
        }

        
    }
}
