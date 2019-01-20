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
    public partial class userAudioVisualBookingForm : Form
    {
        OleDbConnection cnnOleDb = new OleDbConnection();
        OleDbCommand cmdTimeRange = new OleDbCommand();

        public userAudioVisualBookingForm()
        {
            InitializeComponent();
        }

        private void userBackButton_Click(object sender, EventArgs e)
        {
            UserBookingProcessForm userBookingProcessForm = new UserBookingProcessForm();
            this.Hide();
            userBookingProcessForm.Show();
        }

        private void userSubmitButton_Click(object sender, EventArgs e)
        {
            if (userProjectorCheckBox.Checked == true)
            {
                UserLoginForm.bookingDetails.BookedAvb.Add("Projector. ");
            }
            if (userProjectorScreenCheckBox.Checked == true)
            {
                UserLoginForm.bookingDetails.BookedAvb.Add("Projector Screen. ");
            }
            if (userSoundSystemCheckBox.Checked == true)
            {
                UserLoginForm.bookingDetails.BookedAvb.Add("Sound System. ");
            }
            if (userMicrophoneCheckBox.Checked == true)
            {
                UserLoginForm.bookingDetails.BookedAvb.Add("Microphone. ");
            }
            if (userNoneRadioButton.Checked == false && userYesRadioButton.Checked == false)
            {
                MessageBox.Show("Please select !");
            }
            else
            {
                UserConfirmationForm userConfirmationForm = new UserConfirmationForm();
                this.Hide();
                userConfirmationForm.Show();
            }
        }

        private void UserAudioVisualBookingForm_Load(object sender, EventArgs e)
        {
            string Date = UserLoginForm.bookingDetails.Date;
            DateTime selectedDate = DateTime.ParseExact(Date, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string nowDate = DateTime.Now.ToString("dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.ParseExact(nowDate, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan dayInterval = selectedDate - currentDate;
            int days = dayInterval.Days;
            if (days < 5)
            {
                userYesRadioButton.Enabled = false;
                userWarningLabel.Text = "Unable to place audio visual equipment \n reservation since it less than 5 days";
            }
            else
            {
                userWarningLabel.Text = "";
            }
            

            userAudioVisualGroupBox.Enabled = false;
            cnnOleDb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOleDb.Open();
        }

        private void userYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            string location = (UserLoginForm.bookingDetails.Location).Replace(' ', '_');
            cmdTimeRange.CommandText = "SELECT Date FROM " + location + " WHERE Date ='" + UserLoginForm.bookingDetails.Date + "';";
            cmdTimeRange.Connection = cnnOleDb;
            OleDbDataReader dr = cmdTimeRange.ExecuteReader();
            dr.Read();
            string Date = UserLoginForm.bookingDetails.Date;
            DateTime selectedDate = DateTime.ParseExact(Date, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string nowDate = DateTime.Now.ToString("dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime currentDate = DateTime.ParseExact(nowDate, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);

            TimeSpan dayInterval = selectedDate - currentDate;
            int days = dayInterval.Days;
            if (days < 5)
            {
                MessageBox.Show("Please change the date of your booking to move to the next page!");
            }
            dr.Close();


            if (userYesRadioButton.Checked)
            {
                userAudioVisualGroupBox.Enabled = true;
            }
        }

        private void userNoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userNoneRadioButton.Checked)
            {
                userAudioVisualGroupBox.Enabled = false;
                userProjectorCheckBox.Checked = false;
                userProjectorScreenCheckBox.Checked = false;
                userSoundSystemCheckBox.Checked = false;
                userMicrophoneCheckBox.Checked = false;
            }
        }

        private void userWarningLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
