/* Database.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Displays all the Students Marks to the Lecturer
 * Last Modified : 19/10/2015
***********************************************/
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjDurbanArtGalleryApp
{
    public class DbConnect
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
                string sConnection = ("Data Source = localhost;  Initial Catalog = DurbanArtGallery; Integrated Security = SSPI");
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
        public void InsertIntoDatabase(string paintingId, string paintingName, string paintingCost, char paintingSection,
                                       string paintingStatus , string output)
        {
            try
            {           
                sqlcmd = new SqlCommand(this.query, dbconn);

                sqlcmd.Parameters.AddWithValue("@paintingId", paintingId);
                sqlcmd.Parameters.AddWithValue("@paintingName", paintingName);
                sqlcmd.Parameters.AddWithValue("@paintingCost", Convert.ToDouble(paintingCost));
                sqlcmd.Parameters.AddWithValue("@paintingStatus", paintingStatus);
                sqlcmd.Parameters.AddWithValue("@paintingSection", paintingSection);

                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(output
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
        public void InsertIntoDatabase(string ownerId, string ownerName, string ownerSurname, string ownerContactNum,
                                       string paintingId,string output)
        {
            try
            {
                sqlcmd = new SqlCommand(this.query, dbconn);
                sqlcmd.Parameters.AddWithValue("@ownerId",ownerId);
                sqlcmd.Parameters.AddWithValue("@ownerName",ownerName);
                sqlcmd.Parameters.AddWithValue("@ownerSurname", ownerSurname);
                sqlcmd.Parameters.AddWithValue("@ownerContactNum",ownerContactNum);
                sqlcmd.Parameters.AddWithValue("@paintingId", paintingId);
               
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show(output
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
        public void DeleteRecord(string idNumber , bool output)
        {
            try
            {              
                sqlcmd = new SqlCommand(this.query, dbconn);
                sqlcmd.Parameters.AddWithValue("@IdNumber", idNumber);
                sqlcmd.ExecuteNonQuery();

                if (output == true)
                {
                    MessageBox.Show("Record has Deleted from the Database"
                              , "Success", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
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
            catch(Exception e)
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
        public void UpdateDatabase(string paintingId, string paintingName, string costPrice, 
                                           string paintingStat , char paintingSection)
        {
            try
            {
                sqlcmd = new SqlCommand(this.query, dbconn);
                sqlcmd.Parameters.AddWithValue("@paintingName", paintingName);
                sqlcmd.Parameters.AddWithValue("@costPrice", double.Parse(costPrice));
                sqlcmd.Parameters.AddWithValue("@paintingStatus", paintingStat);              
                sqlcmd.Parameters.AddWithValue("@paintingSection", paintingSection);
                sqlcmd.Parameters.AddWithValue("@paintingId", paintingId);
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
        //****************************************************************************
        public void UpdateDatabase(string ownerId, string ownerName, string ownerSurname,
                                           string ownerCellNumber)
        {
            try
            {
                sqlcmd = new SqlCommand(this.query, dbconn);
                sqlcmd.Parameters.AddWithValue("@OwnerName", ownerName);
                sqlcmd.Parameters.AddWithValue("@OwnerSurname", ownerSurname);
                sqlcmd.Parameters.AddWithValue("@OwnerCellNumber", ownerCellNumber);
                sqlcmd.Parameters.AddWithValue("@ownerId", ownerId);
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
        //****************************************************************************    
        public void SearchIdNumber(string idnum)
        {
            sqlcmd = new SqlCommand(query, dbconn);
            sqlcmd.Parameters.AddWithValue("@idNum", idnum);
            sqlcmd.ExecuteNonQuery();
        }
        //****************************************************************************    
        public SqlDataReader GetIdNumbers()
        {            
            sqlDR = sqlcmd.ExecuteReader();
            return sqlDR;
        }
    }
}
