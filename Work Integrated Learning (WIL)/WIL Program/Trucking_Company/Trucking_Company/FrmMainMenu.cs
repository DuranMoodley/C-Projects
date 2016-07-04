/* FrmMainMenu.cs    
 * Lecturer : Rajesh Chanderman    
 * Updates a trip record in the Trip table in the Database
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trucking_Company
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        //**************************************************************
        public FrmMainMenu(string password)
        {
            InitializeComponent();
            UserRestrictions(password);
        }
        //**************************************************************
        public void UserRestrictions(string userPassword)
        {
            if (userPassword.StartsWith("DR"))
            {
                ChangeMenuOptions(false, false, false, false, false, false, false, true);
            }
            else if (userPassword.StartsWith("ME"))
            {
                ChangeMenuOptions(false, false, false, false, true, false, false, false);
            }
            else if (userPassword.StartsWith("VE"))
            {
                ChangeMenuOptions(false, false, false, true, false, false, false, false);
            }
            else if (userPassword.StartsWith("TR"))
            {
                //GO BACK TO ADD DRIVER
                ChangeMenuOptions(true, true, false, false, false, false, false, true);
            }
            else if (userPassword.StartsWith("TI"))
            {
                ChangeMenuOptions(false, false, true, false, false, false, false, false);
            }
            else if (userPassword.StartsWith("SE"))
            {
                ChangeMenuOptions(false, false, false, false, true, true, true, false);
            }
            else
            {
                ChangeMenuOptions(true, true, true, true, true, true, true, true);
            }
        }
        //**************************************************************
        public void ChangeMenuOptions(bool addTripIsVisible, bool updateTripIsVisible, bool employeeIsVisible,
                                      bool vehiclesIsVisible, bool serviceIsVisible, bool serviceAddIsVisible,
                                      bool serviceUpdateIsVisible, bool tripIsVisible)
        {
            TsmiTripsAdd.Visible = addTripIsVisible;
            TsmiTripsUpdate.Visible = updateTripIsVisible;
            TsmiEmployeeDropDown.Visible = employeeIsVisible;
            TsmiVehiclesDropDown.Visible = vehiclesIsVisible;
            TsmiServiceDropDown.Visible = serviceIsVisible;
            TsmiServiceAdd.Visible = serviceAddIsVisible;
            TsmiServiceUpdate.Visible = serviceUpdateIsVisible;
            TsmiTripsDropDown.Visible = tripIsVisible;
        }
        //**************************************************************
        private void TsmiEmployeeAdd_Click(object sender, EventArgs e)
        {
            FrmAddEmployee addEmployee = new FrmAddEmployee();
            addEmployee.Show();
            
        }
        //**************************************************************
        private void TsmiEmployeeDelete_Click(object sender, EventArgs e)
        {
            FrmDeactivateEmployee deleteEmployee = new FrmDeactivateEmployee();
            deleteEmployee.Show();
            
        }
        //**************************************************************
        private void TsmiEmployeeUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateEmployee updateEmployee = new FrmUpdateEmployee();
            updateEmployee.Show();
           
        }
        //**************************************************************
        private void TsmiVehiclesAdd_Click(object sender, EventArgs e)
        {
            FrmAddVehicle insertVehicles = new FrmAddVehicle();
            insertVehicles.Show();
           
        }
        //**************************************************************
        private void TsmiVehiclesDelete_Click(object sender, EventArgs e)
        {
            FrmDeleteVehicle objDeleteVehice = new FrmDeleteVehicle();
            objDeleteVehice.Visible = true;
            
        }
        //**************************************************************
        private void TsmiServiceAdd_Click(object sender, EventArgs e)
        {
            FrmAddService objAddService = new FrmAddService();
            objAddService.Show();
            
        }
        //**************************************************************
        private void TsmiServiceUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdatesService objUpdateService = new FrmUpdatesService();
            objUpdateService.Visible = true;
            
        }
        //**************************************************************
        private void TsmiTripsAdd_Click(object sender, EventArgs e)
        {
            FrmAddTrip addTrip = new FrmAddTrip();
            addTrip.Show();
           
        }
        //************************************************************** 
        private void TsmiTripsUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateTrip updateTrip = new FrmUpdateTrip();
            updateTrip.Show();
            
        }
        //**************************************************************
        private void mnuItemHoursWorked_Click(object sender, EventArgs e)
        {
            
            FrmEmployeeHoursWorked objAddHoursWorked = new FrmEmployeeHoursWorked();
            objAddHoursWorked.Visible = true;
        }
        //**************************************************************
        private void mnuItemVreport_Click(object sender, EventArgs e)
        {
            
            FrmVehicleReport objVehicleReport = new FrmVehicleReport();
            objVehicleReport.Visible = true;           
        }
        //**************************************************************
        private void PicExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //**************************************************************
        private void TsmiUpdateVehicle_Click(object sender, EventArgs e)
        {
            FrmUpdateVehicle updateVehicle = new FrmUpdateVehicle();
            updateVehicle.Show();
          
        }
        //**************************************************************
        private void MnuServiceAppointmentListDaily_Click(object sender, EventArgs e)
        {
            FrmDailyServiceAppointmentListReport dailyServiceReport = new FrmDailyServiceAppointmentListReport();
            dailyServiceReport.Visible = true;
            
        }
        //**************************************************************
        private void MnuServiceReqirements_Click(object sender, EventArgs e)
        {
            FrmServiceRequirementJobSheet objServiceRequirements = new FrmServiceRequirementJobSheet();
            objServiceRequirements.Visible = true;
           
        }
        //**************************************************************        
        private void MnuItemDailyPlannedTrip_Click(object sender, EventArgs e)
        {
            FrmDailyPlannedTripReport objPlannedTripDaily = new FrmDailyPlannedTripReport();
            objPlannedTripDaily.Visible = true;          
        }
        //**************************************************************
        private void MnuDailyCompletedTrip_Click(object sender, EventArgs e)
        {
            FrmDailyCompletedTripReport objCompletedTrip = new FrmDailyCompletedTripReport();
            objCompletedTrip.Visible = true;          
        }
        //**************************************************************
        private void MnuItemMonthComTrip_Click(object sender, EventArgs e)
        {
            FrmMonthlyCompletedTrips objMonthly = new FrmMonthlyCompletedTrips();
            objMonthly.Visible = true;          
        }
        //**************************************************************
        private void MnuVehicleServicesCompletedDaily_Click(object sender, EventArgs e)
        {
            FrmDailyCompletedServiceReport objDailyCompletedService = new FrmDailyCompletedServiceReport();
            objDailyCompletedService.Visible = true;           
        }
        //**************************************************************
        private void MnuVehicleServicesCompletedMonthly_Click(object sender, EventArgs e)
        {
            FrmMonthlyCompletedServices objMonthlyComServices = new FrmMonthlyCompletedServices();
            objMonthlyComServices.Visible = true;          
        }
        //**************************************************************
        private void MnuVehicleServicesCompletedYearly_Click(object sender, EventArgs e)
        {
            FrmYearlyCompletedService objYearlyComServices = new FrmYearlyCompletedService();
            objYearlyComServices.Visible = true;          
        }
        //**************************************************************
        private void MnuItemSpecificService_Click(object sender, EventArgs e)
        {
            FrmSpecificServiceReport objSpecificService = new FrmSpecificServiceReport();
            objSpecificService.Visible = true;        
        }
        //**************************************************************
        private void MnuServiceAppointmentListWeekly_Click(object sender, EventArgs e)
        {
            FrmWeeklyServiceAppointmentList objWeeklyService = new FrmWeeklyServiceAppointmentList();
            objWeeklyService.Visible = true;           
        }
        //**************************************************************
        private void MnuVehicleServicesCompletedWeekly_Click(object sender, EventArgs e)
        {
            FrmWeeklyServiceCompleted objWeeklyComService = new FrmWeeklyServiceCompleted();
            objWeeklyComService.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemWeeklyPlannedTrip_Click(object sender, EventArgs e)
        {
            FrmWeeklyPlannedTripReport objWeeklyPlannedTrip = new FrmWeeklyPlannedTripReport();
            objWeeklyPlannedTrip.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemWeeklyComTrip_Click(object sender, EventArgs e)
        {
            FrmWeeklyCompletedTripReport objWeeklyComTrip = new FrmWeeklyCompletedTripReport();
            objWeeklyComTrip.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemDailyMechanic_Click(object sender, EventArgs e)
        {
            FrmDailyMechanicTimesheetReport objMechanic = new FrmDailyMechanicTimesheetReport();
            objMechanic.Visible = true;
           
        }
        //**************************************************************
        private void MnuDailyDriver_Click(object sender, EventArgs e)
        {
            FrmDailyDriverTimsheetReport objDailyDriverTimesheet = new FrmDailyDriverTimsheetReport();
            objDailyDriverTimesheet.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemWeeklyMechanic_Click(object sender, EventArgs e)
        {
            FrmWeeklyMechanicTimesheetReport objWeeklyMechanicTimesheet = new FrmWeeklyMechanicTimesheetReport();
            objWeeklyMechanicTimesheet.Visible = true;
            
        }
        //**************************************************************
        private void MnuItemWeeklyDriver_Click(object sender, EventArgs e)
        {
            FrmWeeklyDriverTimesheetReport objWeeklyDriverTimesheet = new FrmWeeklyDriverTimesheetReport();
            objWeeklyDriverTimesheet.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemMonthlyMechanic_Click(object sender, EventArgs e)
        {
            FrmMonthlyMechanicTimsheetReport objMonthlyMechanic = new FrmMonthlyMechanicTimsheetReport();
            objMonthlyMechanic.Visible = true;
           
        }
        //**************************************************************
        private void MnuItemMonthlyDriver_Click(object sender, EventArgs e)
        {
            FrmMonthlyDriverTimesheetReport objMonthlyDriver = new FrmMonthlyDriverTimesheetReport();
            objMonthlyDriver.Visible = true;
           
        }
        //_______________________________________________________________________________________________________________________________________________________
        private void TsmiAboutDropDown_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.Show();
          
        }
        //_______________________________________________________________________________________________________________________________________________________
        private void PicMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            if (this.WindowState == FormWindowState.Minimized)
            {
                IcnMinimizedNotifier.Icon = SystemIcons.Application;
                IcnMinimizedNotifier.BalloonTipText = "The Cargo Fleet program has been minimized";
                IcnMinimizedNotifier.ShowBalloonTip(1000);
            }
        }
        //_______________________________________________________________________________________________________________________________________________________
        private void IcnMinimizedNotifier_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
         //_______________________________________________________________________________________________________________________________________________________
        private void FrmMainMenu_Activated(object sender, EventArgs e)
        {
            IcnMinimizedNotifier.BalloonTipText = "Welcome back to Cargo Fleet";
            IcnMinimizedNotifier.ShowBalloonTip(1000);
        }
        //_______________________________________________________________________________________________________________________________________________________
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateEmployee objUpdate = new FrmUpdateEmployee();
            objUpdate.Visible = true;
        }
        //_______________________________________________________________________________________________________________________________________________________
        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateDriverTrips objUpdateDrivers = new FrmUpdateDriverTrips();
            objUpdateDrivers.Visible = true;
        }
        //_______________________________________________________________________________________________________________________________________________________
    }
}
