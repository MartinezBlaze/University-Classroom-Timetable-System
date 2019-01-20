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
    public partial class UserClassroomBookingSystemForm : Form
    {
        public UserClassroomBookingSystemForm()
        {
            InitializeComponent();
        }

        private void userSeeTimetableButton_Click(object sender, EventArgs e)
        {
            UserSeeTimetableForm userSeeTimetableForm = new UserSeeTimetableForm();
            this.Hide();
            userSeeTimetableForm.Show();
        }

        private void userSeeAvailableSlotsButton_Click(object sender, EventArgs e)
        {
            UserBookingProcessForm seeAvailableSlots = new UserBookingProcessForm();
            this.Hide();
            seeAvailableSlots.Show();
        }

        private void userLogoutButton_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            this.Hide();
            userLoginForm.Show();
        }

        private void UserClassroomBookingSystemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
