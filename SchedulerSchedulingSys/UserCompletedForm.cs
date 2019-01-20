using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSchedulingSystem
{
    public partial class UserCompletedForm : Form
    {
        public UserCompletedForm()
        {
            InitializeComponent();
        }

        private void userBackToHomeButton_Click(object sender, EventArgs e)
        {
            // reset the value of the form
            UserLoginForm.bookingDetails.Event = "";
            UserLoginForm.bookingDetails.Location = "";
            UserLoginForm.bookingDetails.Date = "";
            UserLoginForm.bookingDetails.Time = "";
            UserLoginForm.bookingDetails.BookedAvb.Clear();

            UserClassroomBookingSystemForm userClassroomBookingSystemForm = new UserClassroomBookingSystemForm();
            this.Hide();
            userClassroomBookingSystemForm.Show();
        }

        private void userLogoutButton_Click(object sender, EventArgs e)
        {
            // reset the value of the form
            UserLoginForm.bookingDetails.Username = "";
            UserLoginForm.bookingDetails.Name = "";
            UserLoginForm.bookingDetails.Event = "";
            UserLoginForm.bookingDetails.Location = "";
            UserLoginForm.bookingDetails.Date = "";
            UserLoginForm.bookingDetails.Time = "";
            UserLoginForm.bookingDetails.BookedAvb.Clear();

            UserLoginForm userLoginForm = new UserLoginForm();
            this.Hide();
            userLoginForm.Show();
        }

        private void userExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserCompletedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
