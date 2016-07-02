/* Elephant.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * stores specific information about the eleplant
 * Last Modified : 6/16/2015
***********************************************/
using System;
namespace prjZooApplication
{
    public class Elephant : Animal, IFood
    {
        private dynamic strTuskLength;
        private string strTuskWeight;
        private string tuskShape;
        private dynamic strTrunkLenth;
        private string strEarLength;
        //*************************************************************
        public Elephant()
            :base()
        {
        }
        //*************************************************************
        public Elephant(string nameOfAnimal , string genderOfAnimal, 
                        string ageOfAnimal  , string weigth,
                        string lengthOfTusk , string weightOfTusk,
                        string shapeOfTusk  , string trunklength,
                        string earLength)
            :base(nameOfAnimal,genderOfAnimal,ageOfAnimal,weigth)
        {
            strTuskLength = lengthOfTusk;
            strTuskWeight = weightOfTusk;
            tuskShape = shapeOfTusk;
            strTrunkLenth = trunklength;
            strEarLength = earLength;
        }
        //************************************************************
        //Abtract Method from Animal Class
        public override string GenerateAnimalCode()
        {
            return base.GenerateAnimalCode() + "E";
        }
        //************************************************************
        public string GetFoodType
        {
            get
            {
                return "vegetation";
            }
        }
        //************************************************************
        //Elephants eat about 4 % of their weight
        public double GetFoodQuantityNeeded
        {
            get
            {
                double quantity = double.Parse(base.StrAnimalWeight) * 0.04;
                return quantity;
            }
        }
        //************************************************************
        public override string ToString()
        {
            return base.ToString() + "," + GenerateAnimalCode() + "," +
                        strTuskLength + "," +
                        strTuskWeight + "," +
                        tuskShape + "," +
                        strTrunkLenth + "," +
                        strEarLength;
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
