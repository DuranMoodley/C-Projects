/* SaveRecords.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Save a record to a text file
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.IO;
using System.Windows.Forms;

namespace prjVarsityCollegeTestApplication
{
    class SaveRecords
    {
        private string record;
        //*********************************************************************
        public SaveRecords(string recs)
        {
            record = recs;
        }
        //*********************************************************************
        public void WriteToTextFile(string filename, bool showOutputMessage)
        {
            try
            {
                StreamWriter outputFile = new StreamWriter(filename);

                //sends records to TextFile             
                outputFile.WriteLine(record);
                outputFile.Close();

                if (showOutputMessage)
                {
                    OutputMessage();
                }                
            }
            catch (FileNotFoundException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
        }
        //*********************************************************************
        public void OutputMessage()
        {
            MessageBox.Show("Record Has Been Saved"
                                 , "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
        }
        //*********************************************************************
        public void WriteToTextFile()
        {
            try
            {
                StreamWriter outputFile = new StreamWriter("StudentReport.txt",true);

                //sends records to TextFile             
                outputFile.WriteLine(record);
                outputFile.Close();             
            }
            catch (FileNotFoundException exes)
            {
                MessageBox.Show(exes.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
        }
    }
}
