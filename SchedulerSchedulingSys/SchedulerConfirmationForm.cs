using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerSchedulingSys
{
    public partial class SchedulerConfirmationForm : Form
    {

        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdDelete = new OleDbCommand();
        OleDbCommand cmdInsert = new OleDbCommand();

        public SchedulerConfirmationForm()
        {
            InitializeComponent();
        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            SchedulerAdditionalFeaturesAVBForm additionalFeaturesAVBForm = new SchedulerAdditionalFeaturesAVBForm();
            this.Hide();
            additionalFeaturesAVBForm.Show();
        }

        private void schedulerConfirmButton_Click(object sender, EventArgs e)
        {
            string location = (SchedulerLoginForm.bookingDetails.Location).Replace(" ", "_");

            // UPDATE THE TIMETABLE
            cmdUpdate.CommandText = "UPDATE [" + location + "] SET [" + SchedulerLoginForm.bookingDetails.PreviousTime + "] = 'Available' WHERE Date = '" + SchedulerLoginForm.bookingDetails.PreviousDate + "';";
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.Connection = cnnOLEDB;
            cmdUpdate.ExecuteNonQuery();

            // REMOVE THE DATA FROM BOOKINGCONFIMATION
            cmdDelete.CommandText = "DELETE FROM BookingConfirmation WHERE Username = '" + SchedulerLoginForm.bookingDetails.Username + "' AND Date = '" + SchedulerLoginForm.bookingDetails.PreviousDate + "' AND Time = '" + SchedulerLoginForm.bookingDetails.PreviousTime + "';";
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.Connection = cnnOLEDB;
            cmdDelete.ExecuteNonQuery();

            // ADD THE NEW DATA TO THE TIMETABLE
            cmdUpdate.CommandText = "UPDATE [" + location + "] SET [" + SchedulerLoginForm.bookingDetails.Time + "] = '" + SchedulerLoginForm.bookingDetails.Username + "' WHERE Date = '" + SchedulerLoginForm.bookingDetails.Date + "';";
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.Connection = cnnOLEDB;
            cmdUpdate.ExecuteNonQuery();

            // ADD THE DATA TO BOOKINGCONFRIMATION
            cmdInsert.CommandText = "Insert Into BookingConfirmation Values('" + SchedulerLoginForm.bookingDetails.Username + "','" + SchedulerLoginForm.bookingDetails.Name + "','" + SchedulerLoginForm.bookingDetails.Event + "','" + SchedulerLoginForm.bookingDetails.Location + "','" + schedulerAdditionalRequestDisplayLabel.Text + "','" + SchedulerLoginForm.bookingDetails.Date + "','" + SchedulerLoginForm.bookingDetails.Time + "')";
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.Connection = cnnOLEDB;
            cmdInsert.ExecuteNonQuery();

            SchedulerCompletedForm completedForm = new SchedulerCompletedForm();
            this.Hide();
            completedForm.Show();
        }

        private void SchedulerConfirmationForm_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOLEDB.Open();

            schedulerUsernameDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Username;
            schedulerNameDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Name;
            schedulerEventNameDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Event;
            schedulerBookedClassroomDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Location;


            // add the item to the AdditionalRequestDisplayLabel
            // modify the content of the label if the user choose any option of the additional features
            if (SchedulerLoginForm.bookingDetails.BookedAvb.Count > 0)
            {
                schedulerAdditionalRequestDisplayLabel.Text = "";
                for (int i = 0; i < SchedulerLoginForm.bookingDetails.BookedAvb.Count; i++)
                {
                    schedulerAdditionalRequestDisplayLabel.Text += SchedulerLoginForm.bookingDetails.BookedAvb[i] + "\n";
                }
            }

            schedulerDateDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Date;
            schedulerTimeDisplayLabel.Text = SchedulerLoginForm.bookingDetails.Time;


        }
    }
}
