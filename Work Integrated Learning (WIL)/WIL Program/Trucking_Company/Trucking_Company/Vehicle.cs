/* Vehicle.cs    
 * Lecturer : Rajesh Chanderman    
 * Stores Vehicle Details
 * Last Modified : 10/11/2015
***********************************************/
using System;
namespace Trucking_Company
{
    public class Vehicle
    {
        private string vehicleNumber;
        private string vehicleRegistration;
        private string vehicleType;
        private string vehicleManufacturer;
        private string vehicleEngineSize;
        private string currentOdometerReading;
        private string nextOdometerReadings;
        //************************************************************
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
        //************************************************************
        public string VehicleRegistration
        {
            get
            {
                return vehicleRegistration;
            }
            set
            {
                vehicleRegistration = value;
            }
        }
        //************************************************************
        public string VehicleManufacturer
        {
            get
            {
                return vehicleManufacturer;
            }
            set
            {
                vehicleManufacturer = value;
            }
        }
        //************************************************************
        public string VehicleType
        {
            get
            {
                return vehicleType;
            }
            set
            {
                vehicleType = value;
            }
        }
        //************************************************************
        public string VehicleEngineSize
        {
            get
            {
                return vehicleEngineSize;
            }
            set
            {
                vehicleEngineSize = value;
            }
        }
        //************************************************************
        public string CurrentOdometerReading
        {
            get
            {
                return currentOdometerReading;
            }
            set
            {
                currentOdometerReading = value;
            }
        }
        //************************************************************
        public string NextOdometerReading
        {
            get
            {
                return nextOdometerReadings;
            }
            set
            {
                nextOdometerReadings = value;
            }
        }
    }
}
