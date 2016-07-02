/* FetchData.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Fetches data from text file
 * Last Modified : 8/26/2015
***********************************************/
using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace prjVarsityCollegeTestApplication
{
    class FetchData
    {
         public string[,] LoadArrayFromFile(string fileName, int columnIndex)
        {
            string[] tempArray;
            string recordsofPerson = "";
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
            catch(IndexOutOfRangeException exe)
            {
                MessageBox.Show(exe.Message);
            }
            catch(FileNotFoundException exec)
            {
                MessageBox.Show(exec.Message);
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
            StreamReader objRead = new StreamReader(nameOfFile);
            string records = "";
            int numOfLines = 0;

            try
            {
                //Count number of lines in file
                while (string.IsNullOrEmpty(records = objRead.ReadLine()) == false)
                {
                    numOfLines++;
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            objRead.Close();
            return numOfLines;
        }
        //*************************************************************
        public void ConcatenateArrayContents(string[,] studentArr, out string records)
        {
            records = "Student Numbers\t\tStudent Mark" + Environment.NewLine;
            try
            {
                for (int row = 0; row < studentArr.GetLength(0); row++)
                {
                    for (int col = 0; col < studentArr.GetLength(1); col++)
                    {
                        records += studentArr[row, col] + "\t\t\t";
                    }

                    if (row != (studentArr.GetLength(0) - 1))
                    {
                        records += Environment.NewLine;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
 }

