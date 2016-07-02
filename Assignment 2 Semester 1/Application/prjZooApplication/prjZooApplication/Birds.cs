/* Birds.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * stores specific information about the bird
 * Last Modified : 6/16/2015
***********************************************/
using System;
namespace prjZooApplication
{
    public class Birds : Animal
    {
        private dynamic strWingLength;
        private string wingColour;
        private dynamic strBeakLength;
        private string featherType;
        //************************************************
        public Birds()
            :base()
        {
        }
        //************************************************
        public Birds(string nameOfAnimal, string genderOfAnimal, 
                     string ageOfAnimal, string weightOfBird ,
                     string wingLength, string colourOfWing,
                     string beakLength , string typeOfFeather)
            :base(nameOfAnimal,genderOfAnimal,ageOfAnimal,weightOfBird)
        {
            strWingLength = wingLength;
            strBeakLength = beakLength;
            wingColour = colourOfWing;
            featherType = typeOfFeather;
        }
        //************************************************
        public string GetFoodType
        {
            get
            {
                return "nectar fruit plants seeds carrion";
            }
        }
        //************************************************
        public string GetFoodQuantityNeeded
        {
            get
            {
                return base.StrAnimalWeight;
            }
        }
        //************************************************
        public string GetFeedingTimeMorning(string morning)
        {
            return morning;
        }
        //*********************************************************
        public string GetFeedingTimeAfternoon(string afternoon)
        {
            return afternoon;
        }
        //*********************************************************
        public string GetFeedingTimeEvening(string evening)
        {
            return evening;
        }
        //************************************************
        public override string GenerateAnimalCode()
        {
            //Appends the base class animal code method 
            //Add a B to identify the animal
            return base.GenerateAnimalCode() + "B";
        }
        //************************************************
        public override string ToString()
        {
            return base.ToString() + "," + GenerateAnimalCode() + "," +
                        strWingLength  + "," +
                        wingColour + "," +     
                        strBeakLength + "," +
                        featherType;
        }
    }
}
