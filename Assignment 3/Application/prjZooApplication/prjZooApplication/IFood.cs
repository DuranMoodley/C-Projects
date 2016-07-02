/* IFood.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * class that creates method signatures for food methods
 * Last Modified : 6/7/2015
***********************************************/
using System;
namespace prjZooApplication
{
    public interface IFood
    {
        string GetFoodType
        {
            get;
        }
        string MorningFeedingTime(string morningTime);
        string AfternoonFeedingTime(string afternoonTime);
        string EveningFeedingTime(string eveningTime);
        double GetFoodQuantityNeeded 
        { 
            get;
        }
    }
}
