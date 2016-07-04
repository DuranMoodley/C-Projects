/* FrmAddService.cs    
 * Lecturer : Rajesh Chanderman    
 * Records the service number and adds the vehicle to the service.
 * This is sent to the database
 * Last Modified : 10/12/2015
***********************************************/
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmAddService : Form
    {
        public FrmAddService()
        {
            InitializeComponent();
            PopulateComboBoxs();
        }
        //*****************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //*****************************************************************
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Service objService = new Service();
           
            if (Validation(objService))
            {
                GetFields(objService);
                SendToDatabase(objService);
                ClearFields();
            }           
        }
        //***************************************************************
        public void GetFields(Service ServiceObj)
        {
            ServiceObj.serviceCode = CmbServiceCode.Text;
            ServiceObj.serviceType = TxtServiceType.Text;
            ServiceObj.workNeeded = TxtWorkNeeded.Text;
            ServiceObj.vehicleNumber = TxtVehicleNumber.Text;
            ServiceObj.serviceAppointmentTime = DtpServiceAppointmentTime.Text;
            ServiceObj.serviceCost = TxtServiceCost.Text;
        }
        //***************************************************************
        public bool Validation(Service ServiceObje)
        {
          
            bool isValid = true;
            double temporaryValue;

            if (CmbServiceCode.Text.Equals("Please select a Service Code"))
            {
                isValid = false;
                MessageBox.Show("Please Select a Service Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtServiceType.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Service Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtWorkNeeded.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Service Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtVehicleNumber.Text))
            {
                isValid = false;
                MessageBox.Show("Please Enter in the Vehicle Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CheckVehicleExists() == false)
            {
                isValid = false;
                MessageBox.Show("The Vehicle number does not Exist.Operation Failed ", "Error", 
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.TryParse(TxtServiceCost.Text, out temporaryValue) == false)
            {
                isValid = false;
                MessageBox.Show("Incorrect format in Service Cost Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isValid;
        }
        //***************************************************************
        public void PopulateComboBoxs()
        {
            //Read all service codes and populate into combo box
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            objDatabase.Query = "SELECT * FROM Service";
            SqlDataReader sqlDR = objDatabase.GetDataReader();

            while (sqlDR.Read())
            {
                CmbServiceCode.Items.Add(sqlDR["SERVICE_CODE"]);                
            }

            objDatabase.CloseDbConnection();
        }
        //***************************************************************
        public void SendToDatabase(Service serviceObje)
        {
            //Send object values into database
            string outputToUser = "Service has been Successfully Added";
            Database objDatabase = new Database();
            objDatabase.dbConnection();
            objDatabase.Query = "INSERT INTO VehicleService(VEHICLE_NUM,SERVICE_CODE,SERVICE_APPOINTMENT_DATE_AND_TIME,SERVICE_COST)" +
                "VALUES(@vehicleNum,@serviceCode,@serviceDate,@cost)";
            objDatabase.InsertIntoVehicleServiceTable(serviceObje.vehicleNumber, serviceObje.serviceCode,
                                                      serviceObje.serviceAppointmentTime, outputToUser,
                                                      serviceObje.serviceCost);
            objDatabase.CloseDbConnection();
        }
        //***************************************************************
        private void CmbxServiceCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the text box values based on the combo box value
            try
            {
                Service objService = new Service();
                objService.serviceCode = CmbServiceCode.Text;
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                objDatabase.Query = "SELECT * FROM Service WHERE SERVICE_CODE =" + int.Parse(objService.serviceCode) + "";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    TxtWorkNeeded.Text = sqlDR["WORK_NEEDED"].ToString();
                    TxtServiceType.Text = sqlDR["SERVICE_TYPE"].ToString();
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
        //*******************************************************************************
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
        //*******************************************************************************
        public void ClearFields()
        {
            CmbServiceCode.Text = "";
            TxtServiceType.Clear();
            TxtVehicleNumber.Clear();
            TxtServiceCost.Clear();
            TxtWorkNeeded.Clear();
        }
    }
}
