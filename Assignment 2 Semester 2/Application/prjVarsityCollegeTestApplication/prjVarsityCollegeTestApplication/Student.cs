/* Student.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Save student record
 * Last Modified : 8/26/2015
***********************************************/
using System;

namespace prjVarsityCollegeTestApplication
{
    class Student
    {
        private string studentNumber;
        private double finalPercentage;
        //********************************************************
        public Student(string studNumber , double percentageMark)
        {
            studentNumber = studNumber;
            finalPercentage = percentageMark;
        }
        //********************************************************
        public override string ToString()
        {
            return studentNumber + "," + finalPercentage;
        }
    }
}
