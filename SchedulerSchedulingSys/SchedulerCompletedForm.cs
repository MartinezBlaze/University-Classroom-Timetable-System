using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulerSchedulingSys
{
    public partial class SchedulerCompletedForm : Form
    {
        public SchedulerCompletedForm()
        {
            InitializeComponent();
        }

        private void schedulerBackToHomeButton_Click(object sender, EventArgs e)
        {
            // if back to home, go back to the schedulerSeeTimeTableForm but keeping the Name and Username
            SchedulerSeeTimetableForm seeTimetableForm = new SchedulerSeeTimetableForm();
            this.Hide();
            seeTimetableForm.Show();
        }

        private void schedulerLogoutButton_Click(object sender, EventArgs e)
        {
            SchedulerLoginForm loginForm = new SchedulerLoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void schedulerExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SchedulerCompletedForm_Load(object sender, EventArgs e)
        {
            // reset the value of the form
            SchedulerLoginForm.bookingDetails.Username = "";
            SchedulerLoginForm.bookingDetails.Name = "";
            SchedulerLoginForm.bookingDetails.Event = "";
            SchedulerLoginForm.bookingDetails.Location = "";
            SchedulerLoginForm.bookingDetails.Date = "";
            SchedulerLoginForm.bookingDetails.Time = "";
            SchedulerLoginForm.bookingDetails.BookedAvb.Clear();
        }
    }
}
