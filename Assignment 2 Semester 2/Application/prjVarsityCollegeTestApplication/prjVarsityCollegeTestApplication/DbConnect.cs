/* DbConnect.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Does database functions
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    class DbConnect
    {
        private SqlConnection dbconn;
        private SqlCommand sqlcmd;
        private SqlDataReader sqlDR;
        private string query;
        //****************************************************************************
        public DbConnect()
        {
        }
        //****************************************************************************
        public SqlConnection Dbconn
        {
            get
            {
                return dbconn;
            }
        }
        public void dbConnection()
        {
            try
            {
                string sConnection = ("Data Source = localhost;  Initial Catalog = VarsityCollege; Integrated Security = SSPI");
                dbconn = new SqlConnection(sConnection);
                dbconn.Open();
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
        //****************************************************************************
        public void CloseDbConnection()
        {
            dbconn.Close();
        }
        //****************************************************************************
        public void InsertIntoDatabase(string lecturerId, string lecturerName)
        {
            try
            {
                sqlcmd = new SqlCommand(this.query, dbconn);

                sqlcmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                sqlcmd.Parameters.AddWithValue("@lecturerName", lecturerName);
                
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Lecturer Has been Saved"
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
        //****************************************************************************
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
        //****************************************************************************
        public void GiveCommand()
        {
            try
            {
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = dbconn;
                sqlcmd.CommandText = this.query;
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
    }
}
