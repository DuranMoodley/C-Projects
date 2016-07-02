/* Lion.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Stores information about the lion 
 * Generates unique barcode
 * display information
 * Last Modified : 6/7/2015
***********************************************/
using System;
namespace prjZooApplication
{
    public class Lion : Animal, IFood
    {
        private string lionSkinType;
        private string lionSkinColour;
        private string strLionClawLength;
        private string isLionManed;
        //********************************************************
        public Lion()
            :base()
        {
        }
        //********************************************************
        public Lion(string nameOfAnimal, string genderOfAnimal, 
                    string ageOfAnimal, string weightOfLion ,string skinType, 
                    string skinColour, string clawLength, string isManed)
            :base(nameOfAnimal,genderOfAnimal, ageOfAnimal , weightOfLion)
        {
            lionSkinColour = skinColour;
            lionSkinType = skinType;
            strLionClawLength = clawLength;
            isLionManed = isManed;
        }
        //********************************************************
        //Overrider Method From Abstract class
        public override string GenerateAnimalCode()
        {
            return base.GenerateAnimalCode() + "L";
        }
        //*********************************************************
        //Abstract Method in IFood Class
        public string GetFoodType
        {
            get
            {
                return "Meat";
            }          
        }
        //*********************************************************
        public double GetFoodQuantityNeeded
        {
            get
            {
                return 60;
            }
        }
        //**********************************************************
        public override string ToString()
        {
            return base.ToString() + "," + GenerateAnimalCode() + "," +
                        lionSkinColour + "," + 
                        lionSkinType + "," + 
                        strLionClawLength + "," +
                        isLionManed;
        }
        //**************************************************************
        public string MorningFeedingTime(string morning)
        {
            return morning;
        }
        //*********************************************************
        public string AfternoonFeedingTime(string afternoon)
        {
            return afternoon;
        }
        //*********************************************************
        public string EveningFeedingTime(string evening)
        {
            return evening;
        }
    }
}
