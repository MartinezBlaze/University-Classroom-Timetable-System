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
    public partial class SchedulerAdditionalFeaturesAVBForm : Form
    {
        public SchedulerAdditionalFeaturesAVBForm()
        {
            InitializeComponent();
        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            SchedulerManageBookingForm manageBookingForm = new SchedulerManageBookingForm();
            this.Hide();
            manageBookingForm.Show();
        }

        private void schedulerSubmitButton_Click(object sender, EventArgs e)
        {
            // store the chosen options in the global
            if (schedulerProjectorCheckBox.Checked)
            {
                SchedulerLoginForm.bookingDetails.BookedAvb.Add("Projector. ");
            }
            if (schedulerProjectorScreenCheckBox.Checked)
            {
                SchedulerLoginForm.bookingDetails.BookedAvb.Add("Projector Screen. ");
            }
            if (schedulerSoundSystemCheckBox.Checked)
            {
                SchedulerLoginForm.bookingDetails.BookedAvb.Add("Sound System. ");
            }
            if (schedulerMicrophoneCheckBox.Checked)
            {
                SchedulerLoginForm.bookingDetails.BookedAvb.Add("Microphone. ");
            }

            SchedulerConfirmationForm confirmationForm = new SchedulerConfirmationForm();
            this.Hide();
            confirmationForm.Show();
        }

        private void SchedulerAdditionalFeaturesAVBForm_Load(object sender, EventArgs e)
        {
            schedulerAudioVisualGroupBox.Enabled = false;

        }

        private void schedulerNoneRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Disable and remove the option chosen if the user choose none for the AVB
            if (schedulerNoneRadioButton.Checked == true)
            {
                schedulerAudioVisualGroupBox.Enabled = false;
                schedulerProjectorCheckBox.Checked = false;
                schedulerProjectorScreenCheckBox.Checked = false;
                schedulerSoundSystemCheckBox.Checked = false;
                schedulerMicrophoneCheckBox.Checked = false;
            }
        }

        private void schedulerYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            schedulerAudioVisualGroupBox.Enabled = true;
        }
    }
}
