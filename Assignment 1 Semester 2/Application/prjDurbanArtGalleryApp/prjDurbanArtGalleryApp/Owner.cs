/* Owner.cs    Author: Duran Moodley 13016335
 * Lecturer : Rajesh Chanderman     Assignment Number : 3
 * Store information about a specific owner
 * Last Modified : 19/10/2015
***********************************************/
using System;

namespace prjDurbanArtGalleryApp
{
    public class Owner
    {
        private string ownerID;
        private string ownerName;
        private string ownerSurname;
        private string ownerCellNumber;     
        //***************************************************************************
        public string OwnerID
        {
            get
            {
                return ownerID;
            }
            set
            {
                ownerID = value;
            }
        }
        //***************************************************************************
        public string OwnerName
        {
            get
            {
                return ownerName;
            }
            set
            {
                ownerName = value;
            }
        }
        //***************************************************************************
        public string OwnerSurname
        {
            get
            {
                return ownerSurname;
            }
            set
            {
                ownerSurname = value;
            }
        }
        //***************************************************************************
        public string OwnerCellNumber
        {
            get
            {
                return ownerCellNumber;
            }
            set
            {
                ownerCellNumber = value;
            }
        }
    }
}
