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
using StudentSchedulingSystem;
using SchedulerSchedulingSys;

namespace UserSchedulingSystem
{
    public partial class UserLoginForm : Form
    {
        public static BookingDetails bookingDetails;

        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLoginButton_Click_1(object sender, EventArgs e)
        {
            int count;
            int flagFound = 0;
            for (count = 0; count < MainLoginForm.student_list.Length; count++)
            {
                if (userUsernameTextBox.Text == MainLoginForm.student_list[count].studentUsername.ToString() && userPasswordTextBox.Text == MainLoginForm.student_list[count].studentPassword.ToString())
                {
                    flagFound = 1;
                    bookingDetails.Name = MainLoginForm.student_list[count].studentName;
                    bookingDetails.Username = MainLoginForm.student_list[count].studentUsername;
                    MessageBox.Show("Welcome, " + bookingDetails.Name);

                    UserClassroomBookingSystemForm userClassroomBookingSystemForm = new UserClassroomBookingSystemForm();
                    this.Hide();
                    userClassroomBookingSystemForm.Show();
                }
            }
            for (count = 0; count < MainLoginForm.lecturer_list.Length; count++)
            {
                if (userUsernameTextBox.Text == MainLoginForm.lecturer_list[count].lecturerUsername.ToString() && userPasswordTextBox.Text == MainLoginForm.lecturer_list[count].lecturerPassword.ToString())
                {
                    flagFound = 1;
                    
                    bookingDetails.Name = MainLoginForm.lecturer_list[count].lecturerName;
                    bookingDetails.Username = MainLoginForm.lecturer_list[count].lecturerUsername;
                    MessageBox.Show(bookingDetails.Name);

                    UserClassroomBookingSystemForm userClassroomBookingSystemForm = new UserClassroomBookingSystemForm();
                    this.Hide();
                    userClassroomBookingSystemForm.Show();
                }
            }

            // if after iterating the array and user not found
            if (flagFound == 0)
            {
                MessageBox.Show("You put either incorrect username or password.");
            }
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            bookingDetails = new BookingDetails();
        }

        private void userBackButton_Click_1(object sender, EventArgs e)
        {
            bookingDetails = new BookingDetails();

            MainLoginForm mainLoginForm = new MainLoginForm();
            this.Hide();
            mainLoginForm.Show();
        }
    }
}