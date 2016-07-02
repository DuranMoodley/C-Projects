/* SaveRecords.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * sends a string to a textfile
 * Last Modified : 6/16/2015
***********************************************/
using System.IO;
using System.Windows.Forms;
using System;
namespace prjZooApplication
{
    public sealed class SaveRecords
    {
        private string record;
        private string fileName;

        public SaveRecords(string entireRecord, string nameOfFile)
        {
            record = entireRecord;
            fileName = nameOfFile;
        }
        //*********************************************************************************
        public void WriteToTextFile(string feedbackOption)
        {
            try
            {
                //Getting Values From Text file
                StreamWriter outputFile = File.AppendText(fileName);
                
                //sends records to TextFile 
                outputFile.Write(record);
                outputFile.Close();
                
                if (feedbackOption.Equals("yes"))
                {
                    MessageBox.Show("Record Successfully Saved", "Information",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
            }
            catch (System.IO.IOException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
