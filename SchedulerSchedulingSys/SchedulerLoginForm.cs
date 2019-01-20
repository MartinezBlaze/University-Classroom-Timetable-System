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
    public partial class SchedulerLoginForm : Form
    {
        // INITIALIZE THE OBJECT
        public static BookingDetails bookingDetails;

        public SchedulerLoginForm()
        {
            InitializeComponent();
        }

        private void schedulerLoginButton_Click(object sender, EventArgs e)
        {
            int flagFound = 0;
            // validate the data
            for (int i = 0; i < MainLoginForm.scheduler_list.Length; i++)
            {
                // If the user successfully login to the system
                // add the username and name to global variable
                if ((MainLoginForm.scheduler_list[i].schedulerUsername.ToString() == schedulerUsernameTextBox.Text) && (MainLoginForm.scheduler_list[i].schedulerPassword.ToString() == schedulerPasswordTextBox.Text))
                {
                    bookingDetails.Name = MainLoginForm.scheduler_list[i].schedulerName.ToString();

                    flagFound = 1;
                    MessageBox.Show("Welcome, " + bookingDetails.Name);
                    SchedulerSeeTimetableForm homeForm = new SchedulerSeeTimetableForm();
                    this.Hide();
                    homeForm.Show();
                    break;
                }
            }

            if (flagFound == 0)
            {
                MessageBox.Show("Invalid Username/Password");
            }
        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            MainLoginForm mainLoginForm = new MainLoginForm();
            this.Hide();
            mainLoginForm.Show();
        }

        private void SchedulerLoginForm_Load(object sender, EventArgs e)
        {
            bookingDetails = new BookingDetails();
        }

        private void schedulerUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
