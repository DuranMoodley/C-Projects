/* Employee.cs    
 * Lecturer : Rajesh Chanderman    
 * Stores Employee Details
 * Last Modified : 10/11/2015
***********************************************/
using System;

namespace Trucking_Company
{
    public class Employee
    {
        private string employeeID;
        private string employeeName;
        private string employeeSurname;
        private string employeeTitle;
        private string employeePassword;
        private string employeeUsername;
        private string employeeStatus;
        //********************************************************************
        public Employee(string empID, string empName, string empSurname, string empTitle,
                        string empUsername,string empStatus)
        {
            employeeID = empID;
            employeeName = empName;
            employeeSurname = empSurname;
            employeeTitle = empTitle;            
            employeeUsername = empUsername;
            employeeStatus = empStatus;
        }
        //********************************************************************
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeTitle = value;
            }
        }
        //********************************************************************
        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }
        //********************************************************************
        public string EmployeeSurname
        {
            get
            {
                return employeeSurname;
            }
            set
            {
                employeeSurname = value;
            }
        }
        //********************************************************************
        public string EmployeeTitle
        {
            get
            {
                return employeeTitle;
            }
            set
            {
                employeeTitle = value;
            }
        }
        //********************************************************************
        public string EmployeePassword
        {
            get
            {
                return employeePassword;
            }
            set
            {
                employeePassword = value;
            }
        }
        //********************************************************************
        public string EmployeeUsername
        {
            get
            {
                return employeeUsername;
            }
            set
            {
                employeeUsername = value;
            }
        }
        //********************************************************************
        public string EmployeeStatus
        {
            get
            {
                return employeeStatus;
            }
            set
            {
                employeeStatus = value;
            }
        }
        //********************************************************************
        public void GeneratePassword()
        {
            //Set a 5 digit random number
            Random objRandomNum = new Random();
            
            //Split Employee title into char array array
            Char [] arrTitle = employeeTitle.ToUpper().ToCharArray();
          
            //Append to password variable
            employeePassword = arrTitle[0] + "" + arrTitle[1];
            employeePassword += objRandomNum.Next(10000, 99999).ToString();               
        }
    }
}
