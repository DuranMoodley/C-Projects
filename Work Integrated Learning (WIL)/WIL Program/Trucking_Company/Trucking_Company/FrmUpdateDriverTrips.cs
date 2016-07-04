/* FrmUpdateDriverTrips.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a drivers trip
 * Last Modified : 10/13/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmUpdateDriverTrips : Form
    {
        public FrmUpdateDriverTrips()
        {
            InitializeComponent();
            FillDriverIdNumbers();
            FillTripIds();
        }
        //***********************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //***********************************************
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string driverId = CmbDriverID.Text;
                string tripId = CmbTrip.Text;
                Database objDatabase = new Database();
                objDatabase.dbConnection();
                objDatabase.Query = "UPDATE Driver SET TRIP_ID = @tripId " +
                                    "WHERE DRIVER_ID = @driverId";
                objDatabase.UpdateDriversTrips(driverId, tripId);
                objDatabase.CloseDbConnection();
            }
        }
        //***********************************************
        public bool Validation()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(CmbDriverID.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Driver Id number",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(CmbTrip.Text))
            {
                isValid = false;
                MessageBox.Show("Please Select a Trip Id",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isValid;
        }
        //***********************************************
        public void FillDriverIdNumbers()
        {
            try
            {
                //Retrieve id numbers from the drivers table in the database
                //Fill all id numbers into combo box
                Database objDatabase = new Database();
                objDatabase.Query = "SELECT DRIVER_ID FROM Driver";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {
                    CmbDriverID.Items.Add(sqlDR["DRIVER_ID"]);
                }
                objDatabase.CloseDbConnection();
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
        //***********************************************
        public void FillTripIds()
        {
            try
            {
                Database objDatabase = new Database();
                objDatabase.Query = "SELECT TRIP_ID FROM Trip";
                SqlDataReader sqlDR = objDatabase.GetDataReader();

                while (sqlDR.Read())
                {                   
                    CmbTrip.Items.Add(sqlDR["TRIP_ID"]);
                }
                objDatabase.CloseDbConnection();
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
    }
}
