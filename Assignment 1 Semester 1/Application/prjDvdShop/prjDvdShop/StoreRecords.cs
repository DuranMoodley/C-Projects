/*StoreRecords.cs           Author: Duran Moodley
 * Saves a set of records to a Text File
 * Date Modified: 6/24/2015
 * 
*/
using System;
using System.IO;

namespace prjDvdShop
{
    sealed class StoreRecords
    {
        //Declarations
        public string dvdRecords;
        private string customerRecords;
        //***************************************************************************
        public StoreRecords(string recs , string custRecs)
        {
            dvdRecords = recs;
            customerRecords = custRecs;
        }
        //***************************************************************************
        public void WriteToTextFile()
        {
            try
            {
                //Instantiation and Declaration
                StreamWriter outputFile = File.AppendText("Dvd Records.txt");

                //write to text file
                outputFile.WriteLine(dvdRecords);
                outputFile.WriteLine(customerRecords);
                outputFile.WriteLine(File.GetLastWriteTime("Dvd Records.txt"));
                outputFile.Close();

                //Message to User
                Console.WriteLine("Records Successfully Saved");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
