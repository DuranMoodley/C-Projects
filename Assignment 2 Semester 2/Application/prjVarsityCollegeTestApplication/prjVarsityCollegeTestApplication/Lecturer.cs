/* Lecturer.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * stores details about a lecturer
 * Last Modified : 19/10/2015
***********************************************/
using System;

namespace prjVarsityCollegeTestApplication
{
    public class Lecturer
    {
        private string lecturerName;
        private string lecturerIdNumber;
        //**********************************************************
        public string LecturerName
        {
            get
            {
                return lecturerName;
            }
            set
            {
                lecturerName = value;
            }
        }
        //**********************************************************
        public string LecturerIdNumber
        {
            get
            {
                return lecturerIdNumber;
            }
            set
            {
                lecturerIdNumber = value;
            }
        }
    }
}
