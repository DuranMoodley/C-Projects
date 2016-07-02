/* Animal.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Stores general information about the animal
 * Last Modified : 6/16/2015
***********************************************/
using System;
namespace prjZooApplication
{
    public abstract class Animal
    {
        private string animalName;
        private string animalCode;
        private string animalGender;
        private string animalAge;
        private dynamic strAnimalWeight;
        //*************************************************************
        protected Animal()
        {
        }
        //*************************************************************
        protected Animal (string nameOfAnimal, string genderOfAnimal, 
                       string ageOfAnimal , string weight)
        {
            animalName = nameOfAnimal;          
            animalGender = genderOfAnimal;
            animalAge = ageOfAnimal;
            strAnimalWeight = weight;
        }
       //***************************************************************
        public virtual string GenerateAnimalCode()
        {
            Random objRandomCode = new Random();
            Char[] arrName = animalName.ToCharArray();

            //Randomly generates 3 digit number.
            //Concatenates first 2 characters of the name.
            animalCode = objRandomCode.Next(100, 999).ToString();
            animalCode += arrName[0] + arrName[1];

            return animalCode;
        }
        //**************************************************************
        public override string ToString()
        {
            return animalName + "," +  
                   animalAge + "," + 
                   animalGender + "," +
                   strAnimalWeight;
        }
        //*********************************************************
        public string StrAnimalWeight
        {
            get
            {
                return strAnimalWeight;
            }
        }
    }
}
