/* IceTask.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 2
 * Gets and sets the student and lecturer answers and questions
 * Last Modified : 8/26/2015
***********************************************/
using System;

namespace prjVarsityCollegeTestApplication
{
    public class IceTask
    {
        private string[] arrQuestions = new string[20];
        private string[] arrAnswers = new string[20];
        //****************************************************************       
        public IceTask(string [] answers , string [] questions)
        {
            arrAnswers = answers;
            arrQuestions = questions;
        }
        //****************************************************************
         public override string ToString()
         {
             return arrQuestions[0] + "-" + arrAnswers[0] + "\r\n" +
                    arrQuestions[1] + "-" + arrAnswers[1] + "\r\n" +
                    arrQuestions[2] + "-" + arrAnswers[2] + "\r\n" +
                    arrQuestions[3] + "-" + arrAnswers[3] + "\r\n" +
                    arrQuestions[4] + "-" + arrAnswers[4] + "\r\n" +
                    arrQuestions[5] + "-" + arrAnswers[5] + "\r\n" +
                    arrQuestions[6] + "-" + arrAnswers[6] + "\r\n" +
                    arrQuestions[7] + "-" + arrAnswers[7] + "\r\n" +
                    arrQuestions[8] + "-" + arrAnswers[8] + "\r\n" +
                    arrQuestions[9] + "-" + arrAnswers[9] + "\r\n" +
                    arrQuestions[10] + "-" + arrAnswers[10] + "\r\n" +
                    arrQuestions[11] + "-" + arrAnswers[11] + "\r\n" +
                    arrQuestions[12] + "-" + arrAnswers[12] + "\r\n" +
                    arrQuestions[13] + "-" + arrAnswers[13] + "\r\n" +
                    arrQuestions[14] + "-" + arrAnswers[14] + "\r\n" +
                    arrQuestions[15] + "-" + arrAnswers[15] + "\r\n" +
                    arrQuestions[16] + "-" + arrAnswers[16] + "\r\n" +
                    arrQuestions[17] + "-" + arrAnswers[17] + "\r\n" +
                    arrQuestions[18] + "-" + arrAnswers[18] + "\r\n" +
                    arrQuestions[19] + "-" + arrAnswers[19] ;
         }
        //*****************************************************************************************************
        public string[] GetAnswersArr()
        {
            return arrAnswers;
        }      
        //*****************************************************************************************************
        public string[] GetQuestions()
        {
            return arrQuestions;
        }
    }
}
