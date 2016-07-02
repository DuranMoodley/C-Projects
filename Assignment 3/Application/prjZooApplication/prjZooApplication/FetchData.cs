/* FetchData.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Fetches contents from textfile and loads content into array
 * Last Modified : 6/16/2015
***********************************************/
using System;
using System.IO;
using System.Windows.Forms;
namespace prjZooApplication
{
    public sealed class FetchData
    {
        public string[,] LoadArrayFromFile(string fileName, int columnIndex)
        {
            string[] tempArray;
            dynamic recordsofPerson = "";
            StreamReader objRecords;
            int numberOfLines = CountLinesInFile(fileName);
            string[,] arrFromFile = new string[numberOfLines, columnIndex];

            try
            {
                objRecords = new StreamReader(fileName);
                arrFromFile = new string[numberOfLines, columnIndex];

                //Fills 2 Dimensional Array using 1 D array
                for (int row = 0; row < arrFromFile.GetLength(0); row++)
                {
                    //Fills One Dimensional Array
                    recordsofPerson = objRecords.ReadLine();
                    tempArray = recordsofPerson.Split(',');

                    for (int col = 0; col < arrFromFile.GetLength(1); col++)
                    {
                        arrFromFile[row, col] = tempArray[col];
                    }
                }
                objRecords.Close();
            }
            catch(IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return arrFromFile;
        }
        //****************************************************************************
        public int CountLinesInFile(string nameOfFile)
        {
            StreamReader objRead;
            string records = "";
            dynamic numOfLines = 0;

            try
            {
                objRead = new StreamReader(nameOfFile);
                //Count number of lines in file
                while ((records = objRead.ReadLine()) != null)
                {
                    numOfLines++;
                }
                objRead.Close();
            }
            catch (System.IO.IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return numOfLines;
        }
        //*****************************************************************************
    }
}
