/* Painting.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Stores all information required for a painting
 * Last Modified : 19/10/2015
***********************************************/
using System;

namespace prjDurbanArtGalleryApp
{
    public class Painting
    {
        private string paintingID;
        private string paintingName;
        private string paintingCostPrice;
        private string paintingStatus;
        private char   paintingSection;       
        //******************************************************************************************
        public string PaintingID
        {
            get
            {
                return paintingID;
            }
            set
            {
                paintingID = value;
            }
        }
        //******************************************************************************************
        public string PaintingName
        {
            get
            {
                return paintingName;
            }
            set
            {
                paintingName = value;
            }
        }
        //******************************************************************************************
        public string PaintingCostPrice
        {
            get
            {
                return paintingCostPrice;
            }
            set
            {
                paintingCostPrice = value;
            }
        }
        //******************************************************************************************
        public string PaintingStatus
        {
            get
            {
                return paintingStatus;
            }
            set
            {
                paintingStatus = value;
            }
        }
        //******************************************************************************************
        public char PaintingSection
        {
            get
            {
                return paintingSection;
            }
            set
            {
                paintingSection = value;
            }
        }
    }
}
