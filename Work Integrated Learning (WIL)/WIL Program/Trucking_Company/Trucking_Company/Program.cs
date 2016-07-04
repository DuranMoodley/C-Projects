using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trucking_Company
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Clear button in add emp        
        /// Add function restrictions
        /// New user sign up
        /// Add driver form to add trip(WHAT IF MULTIPLE DRIVERS)        
        /// Validation
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLoginScreen());

            /*  Show Duran
             *  Application.Run(new FrmAddTrip());
             *  Application.Run(new FrmUpdateTrip());
             *  Application.Run(new FrmDeleteTrip());
             *  Application.Run(new FrmAddEmployeeHoursWorked());
             *  Application.Run(new FrmUpdateEmployee());
             *  Application.Run(new FrmDeleteEmployee());
             *  Application.Run(new FrmInsertVehicle());
             *  Application.Run(new FrmAddEmployee());
             */

            //Testing** 
            //Application.Run(new FrmAddEmployee());
            //Application.Run(new FrmEmployeeHoursWorked());
            //Application.Run(new FrmAddService());
            //Application.Run(new FrmAddTrip());
            //Application.Run(new FrmAddVehicle());
            //Application.Run(new FrmDailyCompletedServiceReport());
            //Application.Run(new FrmDailyCompletedTripReport());
            //Application.Run(new FrmDeactivateEmployee());
            //Application.Run(new FrmDeleteVehicle());
            //Application.Run(new FrmPasswordRecovery());
            //Application.Run(new FrmSignUpSuccessful());
            //Application.Run(new FrmUpdateEmployee());
            //Application.Run(new FrmUpdatesService());
            //Application.Run(new FrmUpdateTrip());
            //Application.Run(new FrmUpdateVehicle());
            //Application.Run(new FrmDailyDriverTimsheetReport());

            //Application.Run(new FrmSplashScreenLoading());
           // Application.Run(new FrmMainMenu());            
            //Application.Run(new FrmLoadingScreen());
            //Application.Run(new FrmDailyTripReport());
            //Application.Run(new FrmDailyServiceReport());
            //Application.Run(new FrmAddService());
            //Application.Run(new FrmUpdatesService());
            //Application.Run(new FrmUpdateVehicle());
            //Application.Run(new FrmUpdateTrip());
            //Application.Run(new FrmLoadingScreenAfterAddedEmployee());
        }
    }
}
