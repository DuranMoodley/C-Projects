/* Database.cs    
 * Lecturer : Rajesh Chanderman    
 * Sends, Updates, Deletes records from the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public class Database
    {
        private SqlConnection dbconn;
        private SqlCommand sqlcmd;
        private SqlDataReader sqlDR;
        private string query;
        //****************************************************************************
        public Database()
        {
        }
        //****************************************************************************
        public void dbConnection()
        {
            try
            {
                string sConnection = ("Data Source = localhost;  Initial Catalog = TruckingCompany; Integrated Security = SSPI");
                dbconn = new SqlConnection(sConnection);
                dbconn.Open();              
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //****************************************************************************
        public void CloseDbConnection()
        {
            dbconn.Close();
        }
        //****************************************************************************
        public void InsertIntoEmployeeTable(string uniqueID, string name, string surname, string title,
                                            string username, string password , string status , string outputToUser)
        {
            try
            {             
                //Sql injection to Insert data to employee table
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@uniqueID", uniqueID);
                sqlcmd.Parameters.AddWithValue("@name",name);
                sqlcmd.Parameters.AddWithValue("@surname",surname);
                sqlcmd.Parameters.AddWithValue("@title", title);
                sqlcmd.Parameters.AddWithValue("@username", username);
                sqlcmd.Parameters.AddWithValue("@password", password);
                sqlcmd.Parameters.AddWithValue("@status", status);

               
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(outputToUser
                              , "Success", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }         
        }
        //*******************************************************************************************
        public void InsertIntoDriverTable(string uniqueID, string name, string surname,
                                         string password,string outputToUser)
        {
            try
            {
                //Sql injection to database data to Driver table
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@uniqueID", uniqueID);
                sqlcmd.Parameters.AddWithValue("@name", name);
                sqlcmd.Parameters.AddWithValue("@surname", surname);              
                sqlcmd.Parameters.AddWithValue("@password", password);               
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(outputToUser
                              , "Success", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //*******************************************************************************************
        public void InsertIntoVehicleTable(string vehicleNum, string vehicleReg, string vehicleType, string vehicleManufacturer,
                                       string engineSize, string currentOdometerReading, string nextOdometerReading,string output)
        {
            try
            {
            //Sql injection to database data to Vehicle table
            sqlcmd = new SqlCommand(query, dbconn);
            sqlcmd.Parameters.AddWithValue("@vehicleNum", vehicleNum);
            sqlcmd.Parameters.AddWithValue("@vehicleReg", vehicleReg);
            sqlcmd.Parameters.AddWithValue("@vehicleType", vehicleType);
            sqlcmd.Parameters.AddWithValue("@vehicleManufacturer", vehicleManufacturer);
            sqlcmd.Parameters.AddWithValue("@engineSize", double.Parse(engineSize));
            sqlcmd.Parameters.AddWithValue("@currentOdometerReading", double.Parse(currentOdometerReading));
            sqlcmd.Parameters.AddWithValue("@nextOdometerReading", DateTime.Parse(nextOdometerReading));
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show(output
                             , "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
        //*******************************************************************************************
        public void InsertIntoTripTable(string tripId, string tripDestination,
                                        string estimatedKilometersTravelled, string tripDate, string tripStatus, string vehicleNumber,
                                        string output)
        {
            try
            {
            //Sql injection to database data to Trip table
            sqlcmd = new SqlCommand(query, dbconn);
            sqlcmd.Parameters.AddWithValue("@tripId",int.Parse(tripId));
            sqlcmd.Parameters.AddWithValue("@vehicleNumber", vehicleNumber);           
            sqlcmd.Parameters.AddWithValue("@estimatedKilometersTravelled",double.Parse(estimatedKilometersTravelled));
            sqlcmd.Parameters.AddWithValue("@tripDate", DateTime.Parse(tripDate));
            sqlcmd.Parameters.AddWithValue("@tripDestination", tripDestination);
            sqlcmd.Parameters.AddWithValue("@tripStatus", tripStatus);           
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show(output
                             , "Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
        //*******************************************************************************************
        public void InsertIntoVehicleServiceTable(string vehicleNum,  string serviceCode, string serviceDate,
                                                  string output, string cost)
        {
            try
            {
                //Sql injection to database data to Vehicle Service table
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@vehicleNum",  vehicleNum);
                sqlcmd.Parameters.AddWithValue("@serviceCode", int.Parse(serviceCode));               
                sqlcmd.Parameters.AddWithValue("@serviceDate", DateTime.Parse(serviceDate));
                sqlcmd.Parameters.AddWithValue("@cost", double.Parse(cost));              
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(output
                                 , "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
        //*******************************************************************************************
        public bool CheckEmployeeLoginDetails(string username , string password)
        {
            bool found = false;

            try
            {
                //Search for employee login details in the Employee Table
                //Once found Check the employee Status.
                query = "SELECT * FROM Employee";
                sqlcmd = new SqlCommand();
                sqlcmd.CommandText = query;
                sqlcmd.Connection = dbconn;
                sqlDR = sqlcmd.ExecuteReader();
                
                while (sqlDR.Read() && found == false)
                {
                    if ((username.Equals(sqlDR["EmployeeUsername"].ToString()) &&
                        password.Equals(sqlDR["EmployeePassword"].ToString())))
                    {
                        found = true;
                        if (sqlDR["EmployeeStatus"].ToString().Equals("Disabled"))
                        {
                            MessageBox.Show("Access Denied. Your Employee Status has been Disabled",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            found = false;
                        }
                    }
                }
               
                sqlDR.Close();            
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message); 
            }
            return found;
        }
        //*******************************************************************************************
        public string Query
        {
            get
            {
                return query;
            }
            set
            {
                query = value;
            }
        }
        //*******************************************************************************************
        public void UpdateEmpHoursDatabase(string empType , string employeeID, double hoursWorkedByEmployee)
        {
            //check if employee ID  is DRivers ID
            if (empType.StartsWith("Driver"))
            {
                try
                {
                    //Update Driver hours completed in driver table
                    Query = "UPDATE Driver SET DRIVER_HOURS_COMPLETED = (DRIVER_HOURS_COMPLETED + @hoursWorkedByEmployee) WHERE UNIQUE_DRIVER_ID LIKE @employeeID";
                    sqlcmd = new SqlCommand(query, dbconn);
                    sqlcmd.Parameters.AddWithValue("@employeeID", employeeID);
                    sqlcmd.Parameters.AddWithValue("@hoursWorkedByEmployee", hoursWorkedByEmployee);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Record Has Been Updated"
                                  , "Successfully", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }            
            }
            //check if employee ID is Mechanic ID 
            else if (empType.StartsWith("Mechanic"))
            {
                try
                {
                    Query = "UPDATE Mechanic SET MECHANIC_HOUR_WORKED = (MECHANIC_HOUR_WORKED + @hoursWorkedByEmployee) WHERE MECHANIC_ID LIKE @employeeID";        
                    sqlcmd = new SqlCommand(query, dbconn);
                    sqlcmd.Parameters.AddWithValue("@employeeID", employeeID);
                    sqlcmd.Parameters.AddWithValue("@hoursWorkedByEmployee", hoursWorkedByEmployee);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Record Has Been Updated"
                                  , "Successfully", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }              
            }
        }
        //*******************************************************************************************
        public void UpdateEmployeesDatabase(string EmpID, string EmpName, string EmpSurname, string EmpStat)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@empName", EmpName);
                sqlcmd.Parameters.AddWithValue("@employeeSurname", EmpSurname);
                sqlcmd.Parameters.AddWithValue("@employeeStatus", EmpStat);
                sqlcmd.Parameters.AddWithValue("@employeeIdNumber", EmpID);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Has Been Updated"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //*******************************************************************************************
        public void UpdateVehicleServiceDatabase(string serviceCode, string vNum, string serviceStat)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@code", int.Parse(serviceCode));
                sqlcmd.Parameters.AddWithValue("@vNum", vNum);
                sqlcmd.Parameters.AddWithValue("@serviceStat", serviceStat);           
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Has Been Updated"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //*******************************************************************************************
        public void UpdateVehicleTable(string vNum, string vReg, string vType, string vManufacturer,
                                       string vEngineSize , string vCurrOdomReading , string vNextOdoReading)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@vReg", vReg);
                sqlcmd.Parameters.AddWithValue("@vNum", vNum);
                sqlcmd.Parameters.AddWithValue("@vType", vType);
                sqlcmd.Parameters.AddWithValue("@vManu", vManufacturer);
                sqlcmd.Parameters.AddWithValue("@vEngineSize", double.Parse(vEngineSize));
                sqlcmd.Parameters.AddWithValue("@vCurrOdoReadings", double.Parse(vCurrOdomReading));
                sqlcmd.Parameters.AddWithValue("@vNextOdoRead", DateTime.Parse(vNextOdoReading));
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Has Been Updated"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //*******************************************************************************************
        public void GiveCommand()
        {
            try
            {
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = dbconn;
                sqlcmd.CommandText = query;
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //****************************************************************************
        public SqlDataReader GetDataReader()
        {
            try
            {
                dbConnection();
                GiveCommand();
                sqlDR = sqlcmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sqlDR;
        }
        //****************************************************************************
        public void DisableEmployee(string emp)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@empId", emp);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Has been Disabled From Database"
                              , "Success", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //****************************************************************************
        public void UpdateTripTable(string tripId, string tripStat, string kmActuallyTravelled , string hours)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@tripId", int.Parse(tripId));
                sqlcmd.Parameters.AddWithValue("@tripStat", tripStat);
                sqlcmd.Parameters.AddWithValue("@kmtravelled", double.Parse(kmActuallyTravelled));
                sqlcmd.Parameters.AddWithValue("@hours", double.Parse(hours));
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Record Has Been Updated"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //*******************************************************************************************
        public void UpdateTripTable(string oldVehicle, string newVehicle)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@oldVehicle", oldVehicle);
                sqlcmd.Parameters.AddWithValue("@newVehicle", newVehicle);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Vehicle Has Been Replaced"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //*******************************************************************************************
        public void DeleteVehicle(string vNum, bool output)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@vNum", vNum);
                sqlcmd.ExecuteNonQuery();
                if (output)
                {
                    MessageBox.Show("Record Has been Deleted From Database"
                                  , "Success", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        //*******************************************************************************************
        public void UpdateDriversTrips(string driverId, string tripId)
        {
            try
            {
                sqlcmd = new SqlCommand(query, dbconn);
                sqlcmd.Parameters.AddWithValue("@driverId", driverId);
                sqlcmd.Parameters.AddWithValue("@tripId", int.Parse(tripId));
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Driver Trip Has Been Updated"
                              , "Successfully", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (SqlException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
  }

