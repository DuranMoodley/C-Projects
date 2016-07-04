﻿/* FrmWeeklyPlannedTripReport.cs    
 * Lecturer : Rajesh Chanderman    
 * Weekly Planned Timsheet Report
 * Last Modified : 10/11/2015
***********************************************/
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trucking_Company
{
    public partial class FrmWeeklyServiceAppointmentList : Form
    {
        public FrmWeeklyServiceAppointmentList()
        {
            InitializeComponent();
        }
        //*************************************************************************************
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        //*************************************************************************************       
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    this.ServiceAppointmentListTableAdapter.FillBy1(this.dsWeeklyServiceAppointmentList.ServiceAppointmentList, ((System.DateTime)(System.Convert.ChangeType(DtpStartDate.Text, typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(DtpEndDate.Text, typeof(System.DateTime)))));
                    this.rpvWeeklyReport.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //*************************************************************************************
        public bool Validation()
        {
            bool isValid = true;
            DateTime startDate = DateTime.Parse(DtpStartDate.Text);
            DateTime endDate = DateTime.Parse(DtpEndDate.Text);
            int result = DateTime.Compare(startDate, endDate);

            if (result > 0)
            {
                MessageBox.Show("Invalid Start Date.The Start date must be smaller Than the End Date",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;
        }
    }
}