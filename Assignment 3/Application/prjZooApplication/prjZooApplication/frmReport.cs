/* frmReport.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Displays a report of all the different types of animals
 * Displays a report of all employee schedules every week
 * Last Modified : 6/7/2015
***********************************************/
using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace prjZooApplication
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }
        //*************************************************************
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //*************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMenu objMenu = new frmMenu();
            objMenu.Visible = true;
        }
        //*************************************************************
        private void btnElephant_Click(object sender, EventArgs e)
        {        
            FetchData objFetch = new FetchData();
            string[,] arrElephant = objFetch.LoadArrayFromFile("Elephant.txt", 15);
            ArrayList elephantDisplayHeadings = HeadingValues();

            //Add Additional Headings for the Elephant
            elephantDisplayHeadings.Add("Tusk Length");
            elephantDisplayHeadings.Add("Tusk Weight");
            elephantDisplayHeadings.Add("Tusk Shape");
            elephantDisplayHeadings.Add("Trunk Length");
            elephantDisplayHeadings.Add("Ear Length");

            elephantDisplayHeadings = FoodHeadings(elephantDisplayHeadings);

            Display(arrElephant, elephantDisplayHeadings , lstvAnimals);
        }
        //*************************************************************
        public ArrayList HeadingValues()
        {
            ArrayList headings = new ArrayList();
            headings.Add("Name");
            headings.Add("Age");
            headings.Add("Gender");
            headings.Add("Weight");
            headings.Add("Unique Id");

            return headings;
        }
        //*************************************************************
        public void Display(string [,] arrAllAnimals , ArrayList columnHeadings , ListView lstvAnimals)
        {
            lstvAnimals.Columns.Clear();
            lstvAnimals.Items.Clear();

            ListViewItem objListViewItems = new ListViewItem("");          
            lstvAnimals.View = View.Details;

            //Add Columns headings to the list view     
            for (int count = 0; count < columnHeadings.Count; count++)
            {
                lstvAnimals.Columns.Add(columnHeadings[count].ToString(), 65);
            }
          
            for(int row = 0 ; row< arrAllAnimals.GetLength(0); row++)
            {
                objListViewItems = new ListViewItem(arrAllAnimals[row,0]);
                for(int col = 1 ; col< arrAllAnimals.GetLength(1);col++)
                {
                    objListViewItems.SubItems.Add(arrAllAnimals[row, col]);
                }
                lstvAnimals.Items.AddRange(new ListViewItem[] { objListViewItems });
            }          
        }
        //*************************************************************************
        public ArrayList FoodHeadings(ArrayList animalHeadings)
        {
            animalHeadings.Add("Food Type");
            animalHeadings.Add("Food Quantity");
            animalHeadings.Add("Morning Feed Time");
            animalHeadings.Add("Afternoon Feed Time");
            animalHeadings.Add("Evening Feed Time");

            return animalHeadings;
        }
        //************************************************************************
        private void btnLion_Click(object sender, EventArgs e)
        {            
            FetchData objFetchData = new FetchData();
            string [,] arrLion = objFetchData.LoadArrayFromFile("Lion.txt", 14);
            ArrayList arrLionHeadings = HeadingValues();

            //Add Additional Animal headings
            arrLionHeadings.Add("Skin Colour");
            arrLionHeadings.Add("Skin Type");
            arrLionHeadings.Add("Claw Length");
            arrLionHeadings.Add("Mane");

            //Add the food headings
            arrLionHeadings = FoodHeadings(arrLionHeadings);

            Display(arrLion, arrLionHeadings , lstvAnimals);
        }
        //**********************************************************************
        private void btnBirds_Click(object sender, EventArgs e)
        {
            FetchData objFetchData = new FetchData();
            string[,] arrBirds = objFetchData.LoadArrayFromFile("Birds.txt", 14);
            ArrayList arrBirdsHeadings = HeadingValues();

            //Add Additional Animal headings
            arrBirdsHeadings.Add("Wing Span");
            arrBirdsHeadings.Add("Wing Colour");
            arrBirdsHeadings.Add("Beak Length");
            arrBirdsHeadings.Add("Feather Type");

            //Add the food headings
            arrBirdsHeadings = FoodHeadings(arrBirdsHeadings);

            Display(arrBirds, arrBirdsHeadings , lstvAnimals);
        }
        //**********************************************************************
        public void EmployeeHeadings(ref ArrayList headings)
        {     
            headings.Add("Animal ID");
            headings.Add("Employee Id");
            headings.Add("Employee Name");
        }
        //*********************************************************************
        private void btnMorning_Click(object sender, EventArgs e)
        {
            string [,] arrEmployeeData;
            string [,] arrLion;
            string [,] arrBirds;
            string[,] arrElephant;
            string[,] arrZooEmployeeSchedules;
            ArrayList columnHeadings = new ArrayList();

            columnHeadings = FoodHeadings(columnHeadings);
            EmployeeHeadings(ref columnHeadings);
            GetTextFileData(out arrEmployeeData , out arrLion, out arrElephant, out arrBirds);
            arrZooEmployeeSchedules = LoadAnimalsArr(arrLion, arrElephant, arrBirds , arrEmployeeData);

            Display(arrZooEmployeeSchedules, columnHeadings , lstvSchedules);
        }
        //*********************************************************************
        public void GetTextFileData(out string [,] arrEmp , out string [,] lionArr, 
                                    out string [,] elephantArr, out string [,] birdArr)
        {
            FetchData objFetch = new FetchData();
            arrEmp = objFetch.LoadArrayFromFile("EmployeeList.txt", 2);
            lionArr = objFetch.LoadArrayFromFile("Lion.txt", 14);
            elephantArr = objFetch.LoadArrayFromFile("Elephant.txt", 15);
            birdArr = objFetch.LoadArrayFromFile("Birds.txt", 14);
        }
        //**********************************************************************
        public string [,] LoadAnimalsArr(string [,] arrLions , string [,] arrElephant , 
                                         string [,] arrBirds, string [,] empData)
        {
            int zooScheduleArrRows = arrLions.GetLength(0) + arrElephant.GetLength(0) + arrBirds.GetLength(0);
            string[,] zooScheduleArr = new string[zooScheduleArrRows, 8];
            int scheduleArrCounter = 0;
            SaveRecords objSave;
            
            //Fill arr lion content into zooScheduleArr
            for(int row = 0 ; row < arrLions.GetLength(0) ; row++)
            {
                for (int scheduleCol = 0, lionCol = 9; scheduleCol < 6 && lionCol < 15; 
                     scheduleCol++, lionCol++)
                {                   
                    if (scheduleCol == 5)
                    {                       
                        zooScheduleArr[scheduleArrCounter, scheduleCol] = arrLions[row, 4];
                        continue;
                    }
                    zooScheduleArr[scheduleArrCounter, scheduleCol] = arrLions[row, lionCol];
                }            
                scheduleArrCounter++;
            }

            //Fill Elephant content into zooScheduleArr
            for (int row = 0; row < arrElephant.GetLength(0); row++)
            {
                for (int scheduleCol = 0, elephantCol = 10; scheduleCol < 6 && elephantCol < 16; 
                     scheduleCol++, elephantCol++)
                {                
                    if(scheduleCol == 5)
                    {
                        zooScheduleArr[scheduleArrCounter, scheduleCol] = arrElephant[row, 4];
                        continue;
                    }
                    zooScheduleArr[scheduleArrCounter, scheduleCol] = arrElephant[row, elephantCol];  
                }               
                scheduleArrCounter++;
            }

            //Fill Birds content into zooScheduleArr
            for (int row = 0; row < arrBirds.GetLength(0); row++)
            {
                for (int scheduleCol = 0, birdsCol = 9; scheduleCol < 6 && birdsCol < 15; 
                    scheduleCol++, birdsCol++)
                {
                    if (scheduleCol == 5)
                    {                        
                        zooScheduleArr[scheduleArrCounter, scheduleCol] = arrBirds[row, 4];
                        continue;
                    }
                    zooScheduleArr[scheduleArrCounter, scheduleCol] = arrBirds[row, birdsCol];
                }     
                scheduleArrCounter++;
            }

            if (CheckNumberOfDays())
            {
                empData = RandomEmpList(empData);
                AddEmployeeData(ref zooScheduleArr, empData);
                File.WriteAllText("RandomEmployeeSchedule.txt", "");
                objSave = new SaveRecords(ConcatenateEmployeeArr(empData), "RandomEmployeeSchedule.txt");
                objSave.WriteToTextFile("no");
            }
            else
            {
                AddEmployeeData(ref zooScheduleArr, empData);
            }
            return zooScheduleArr;
        }
        //***************************************************************************************
        public bool CheckNumberOfDays()
        {
            FetchData objFetch = new FetchData();
            SaveRecords objSaveRecords;
            bool isGreaterThanSevenDays = false;

            //Retrieve last modified date from text file
            string[,] arrDateFromFile = objFetch.LoadArrayFromFile("DateModified.txt", 1);

            //Subtract todays date with date from file
            DateTime todaysDate = DateTime.Now;           
            DateTime dateFromFile = DateTime.Parse(arrDateFromFile[0, 0]);
            TimeSpan difference = todaysDate - dateFromFile;

            if(difference.TotalDays  >= 7 )
            {
                isGreaterThanSevenDays = true;
                File.WriteAllText("DateModified.txt", "");
                objSaveRecords = new SaveRecords(todaysDate.ToString("MM/dd/yyyy"), "DateModified.txt");
                objSaveRecords.WriteToTextFile("no");
            }

            return isGreaterThanSevenDays;
        }
        //****************************************************************************************
        public string [,] RandomEmpList(string [,] employeeData)
        {
            Random objRandomEmployee = new Random();
            string[,] arrRandomEmpList = new string[employeeData.GetLength(0), 
                                                    employeeData.GetLength(1)];
           
            int randomEmpIndex = 0;

            //Generate a random array index, Take Element and insert into arrRandomEmpList
            for(int row = 0 ; row < arrRandomEmpList.GetLength(0) ; row++)
            {
                randomEmpIndex = objRandomEmployee.Next(0, employeeData.GetLength(0));
                for (int col = 0; col < arrRandomEmpList.GetLength(1); col++)
                {                  
                    arrRandomEmpList[row, col] = employeeData[randomEmpIndex, col];
                }
            }

            return arrRandomEmpList;
        }
        //******************************************************************************************
        public void AddEmployeeData(ref string [,] arrZooSchedule , string [,] empInformation)
        {
            int empRowNumber = 0;
            for (int row = 0; row < arrZooSchedule.GetLength(0); row++)
            {
                arrZooSchedule[row, 6] = empInformation[empRowNumber, 0];
                arrZooSchedule[row, 7] = empInformation[empRowNumber, 1];

                empRowNumber++;
                if (empRowNumber == (empInformation.GetLength(0)-1))
                {
                    empRowNumber = 0;
                }
            }
        }
        //******************************************************************************************
        public string ConcatenateEmployeeArr(string [,] employeeData)
        {
            string employeeInformation = "";

            for(int row = 0 ; row < employeeData.GetLength(0) ; row++)
            {
                for(int col = 0 ; col< employeeData.GetLength(1) ; col++)
                {
                    employeeInformation += employeeData[row, col] + ",";
                }
                employeeInformation += Environment.NewLine;
            }

            return employeeInformation;
        }
    }
}
