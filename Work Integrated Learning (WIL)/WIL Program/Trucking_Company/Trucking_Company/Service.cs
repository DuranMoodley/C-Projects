/* Vehicle.cs    
 * Lecturer : Rajesh Chanderman    
 * Stores Service Details
 * Last Modified : 10/11/2015
***********************************************/
using System;

namespace Trucking_Company
{
    public class Service
    {
        private string ServiceCode;
        private string ServiceType;
        private string ServiceAppointmentTime;
        private string WorkNeeded;
        private string VehicleNumber;
        private string ServiceStatus;
        private string ServiceCost;
        //________________________________________________________________________________________________________________
        public string serviceCost
        {
            get
            {
                return ServiceCost;
            }
            set
            {
                ServiceCost = value;
            }
        }
        //________________________________________________________________________________________________________________
        public string serviceCode
        {
            get
            {
                return ServiceCode;
            }
            set
            {
                ServiceCode = value;
            }
        }
        //________________________________________________________________________________________________________________
        public string serviceStatus
        {
            get
            {
                return ServiceStatus;
            }
            set
            {
                ServiceStatus = value;
            }
        }
        //________________________________________________________________________________________________________________
        public string serviceType 
        { 
            get
            {
                return ServiceType;
            }
            set 
            {
                ServiceType = value;
            }
        }
        //________________________________________________________________________________________________________________
        public string serviceAppointmentTime
        {
            get 
            {
                return ServiceAppointmentTime;
            }
            set 
            {
                ServiceAppointmentTime = value;
            } 
        }
        //________________________________________________________________________________________________________________
        public string workNeeded 
        {
            get 
            {
                return WorkNeeded;
            }
            set 
            {
                WorkNeeded = value;
            }
        }
        //________________________________________________________________________________________________________________
        public string vehicleNumber 
        {
           get
           {
               return VehicleNumber;
           }
           set 
           {
                VehicleNumber = value;
           }
        }
        //________________________________________________________________________________________________________________
    }
}
