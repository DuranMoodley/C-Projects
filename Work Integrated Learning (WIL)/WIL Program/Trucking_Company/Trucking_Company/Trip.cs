/* Trip.cs    
 * Lecturer : Rajesh Chanderman    
 * Stores Trip Details
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucking_Company
{
    public class Trip
    {
        private string tripId;
        private string tripDestination;
        private string kilometersActuallyTravelled;
        private string estimatedKilometersTravelled;
        private string tripDate;
        private string tripStatus;
        private string vehicleNumber;
        private string tripHours;
        //***********************************************************
        public string TripId
        {
            get
            {
                return tripId;
            }
            set
            {
                tripId = value;
            }
        }
        //***********************************************************
        public string TripHours
        {
            get
            {
                return tripHours;
            }
            set
            {
                tripHours = value;
            }
        }
        //***********************************************************
        public string TripDestination
        {
            get
            {
                return tripDestination;
            }
            set
            {
                tripDestination = value;
            }
        }
        //***********************************************************
        public string TripStatus
        {
            get
            {
                return tripStatus;
            }
            set
            {
                tripStatus = value;
            }
        }
        //***********************************************************
        public string KilometersActuallyTravelled
        {
            get
            {
                return kilometersActuallyTravelled;
            }
            set
            {
                kilometersActuallyTravelled = value;
            }
        }
        //***********************************************************
        public string EstimatedKilometersTravelled
        {
            get
            {
                return estimatedKilometersTravelled;
            }
            set
            {
                estimatedKilometersTravelled = value;
            }
        }
        //***********************************************************
        public string VehicleNumber
        {
            get
            {
                return vehicleNumber;
            }
            set
            {
                vehicleNumber = value;
            }
        }
        //***********************************************************
        public string TripDate
        {
            get
            {
                return tripDate;
            }
            set
            {
                tripDate = value;
            }
        }
    }
}
