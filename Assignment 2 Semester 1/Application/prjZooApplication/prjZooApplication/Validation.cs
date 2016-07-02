/* Validation.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * checks each fields and validates it
 * Last Modified : 6/7/2015
***********************************************/
using System;
using System.Windows.Forms;
namespace prjZooApplication
{
    public sealed class Validation 
    {       
        private string animalName;
        private string animalGender;
        private string animalAge;
        private dynamic animalWeight;
        private string feedingTimeMorning;
        private string feedingTimeAfternoon;
        private string feedingTimeEvening;
        //****************************************************************************
        public Validation()
        {
        }
        public Validation(string name , string gender , string weight,
                          string age , string feedTimeMorning , 
                          string feedTimeAfternoon,
                          string feedTimeEvening )
        {           
            animalName = name;
            animalGender = gender;
            animalWeight = weight;
            animalAge = age;
            feedingTimeMorning = feedTimeMorning;
            feedingTimeAfternoon = feedTimeAfternoon;
            feedingTimeEvening = feedTimeEvening;
        }
        //****************************************************************************
        public bool CheckInformation()
        {
            bool isValid = true;           
          
            string [] arrAnimalField = new string[7];
            

            arrAnimalField[0] = animalName;
            arrAnimalField[1] = animalGender;
            arrAnimalField[2] = animalWeight;
            arrAnimalField[3] = animalAge;
            arrAnimalField[4] = feedingTimeMorning;
            arrAnimalField[5] = feedingTimeAfternoon;
            arrAnimalField[6] = feedingTimeEvening;

            for (int counter = 0; counter < arrAnimalField.Length; counter++ )
            {
                if (isValid == false)
                {
                    break;
                }
                else
                {
                    if (counter == 2)
                    {
                        CheckFormatting(ref isValid, arrAnimalField[counter]);
                        continue;
                    }
                    else if (counter == 3)
                    {
                        CheckFormatting(ref isValid, arrAnimalField[counter]);
                        continue;
                    }
                    CheckNull(ref isValid, arrAnimalField[counter]);
                    counter++;
                }
            }

            return isValid;
        }
        //**************************************************************************
        public void CheckNull(ref bool isNull, string field)
        {
            if (string.IsNullOrEmpty(field))
            {
                isNull = false;           
            }           
        }
        //**************************************************************************
        public void CheckFormatting(ref bool isFormated, string value )
        {
            double temporaryValue;

            if (double.TryParse(value, out temporaryValue) == false ||
                     double.Parse(value) < 0)
            {
                isFormated = false;
            }
        }
    }
}
