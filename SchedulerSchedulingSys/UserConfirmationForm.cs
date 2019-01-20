using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SchedulerSchedulingSys;

namespace UserSchedulingSystem
{
    public partial class UserConfirmationForm : Form
    {
        OleDbConnection cnnOleDb = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();

        public UserConfirmationForm()
        {
            InitializeComponent();
        }

        private void userBackButton_Click(object sender, EventArgs e)
        {
            userAudioVisualBookingForm userAudioVisualBookingForm = new userAudioVisualBookingForm();
            this.Hide();
            userAudioVisualBookingForm.Show();
        }

        private void userConfirmButton_Click(object sender, EventArgs e)
        {
            string location = (UserLoginForm.bookingDetails.Location).Replace(" ", "_");

            // INSERT INTO BookingConfirmation database table
            cmdInsert.CommandText = "Insert Into BookingConfirmation Values('" + userUsernameDisplayLabel.Text + "','" + userNameDisplayLabel.Text + "','" + userEventNameDisplayLabel.Text + "','" + userBookedLocationDisplayLabel.Text + "','" + userAudioVisualRequestDisplayLabel.Text + "','" + userDateDisplayLabel.Text + "','" + userTimeDisplayLabel.Text + "')";
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.Connection = cnnOleDb;
            cmdInsert.ExecuteNonQuery();

            // UPDATE Location database table
            cmdUpdate.CommandText = "UPDATE [" + location + "] SET [" + UserLoginForm.bookingDetails.Time + "] = '" + UserLoginForm.bookingDetails.Username + "' WHERE Date = '" + UserLoginForm.bookingDetails.Date + "';";
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.Connection = cnnOleDb;
            cmdUpdate.ExecuteNonQuery();

            UserCompletedForm userCompletedForm = new UserCompletedForm();
            this.Hide();
            userCompletedForm.Show();
        }

        private void UserConfirmationForm_Load(object sender, EventArgs e)
        {
            cnnOleDb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOleDb.Open();

            userNameDisplayLabel.Text = UserLoginForm.bookingDetails.Name;
            userUsernameDisplayLabel.Text = UserLoginForm.bookingDetails.Username;
            userTimeDisplayLabel.Text = UserLoginForm.bookingDetails.Time;
            userDateDisplayLabel.Text = UserLoginForm.bookingDetails.Date;
            userBookedLocationDisplayLabel.Text = UserLoginForm.bookingDetails.Location;
            userEventNameDisplayLabel.Text = UserLoginForm.bookingDetails.Event;
            if (UserLoginForm.bookingDetails.BookedAvb.Count > 0)
            {
                userAudioVisualRequestDisplayLabel.Text = "";
                for (int i = 0; i < UserLoginForm.bookingDetails.BookedAvb.Count; i++)
                {
                    userAudioVisualRequestDisplayLabel.Text += UserLoginForm.bookingDetails.BookedAvb[i] + "\n";
                }
            }
        }

        private void userAudioVisualRequestDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void userEventNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userBookedLocationDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void userUsernameDisplayLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
