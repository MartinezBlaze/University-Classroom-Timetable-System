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
    public partial class SchedulerManageBookingForm : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdDelete = new OleDbCommand();

        public SchedulerManageBookingForm()
        {
            InitializeComponent();

            // ADD ITEMS TO THE LOCATION COMBOBOX
            // Insert Classroom inside the combobox
            schedulerLocationComboBox.Items.Add("Block B Classroom 1");
            schedulerLocationComboBox.Items.Add("Block B Classroom 2");
            schedulerLocationComboBox.Items.Add("Block B Classroom 3");
            schedulerLocationComboBox.Items.Add("Block D Classroom 1");
            schedulerLocationComboBox.Items.Add("Block D Classroom 2");
            schedulerLocationComboBox.Items.Add("Block D Classroom 3");
            schedulerLocationComboBox.Items.Add("Block E Classroom 1");
            schedulerLocationComboBox.Items.Add("Block E Classroom 2");
            schedulerLocationComboBox.Items.Add("Block E Classroom 3");

            // Insert Auditorium inside the combobox
            schedulerLocationComboBox.Items.Add("Block B Auditorium 1");
            schedulerLocationComboBox.Items.Add("Block B Auditorium 2");
            schedulerLocationComboBox.Items.Add("Block B Auditorium 3");
            schedulerLocationComboBox.Items.Add("Block D Auditorium 1");
            schedulerLocationComboBox.Items.Add("Block D Auditorium 2");
            schedulerLocationComboBox.Items.Add("Block D Auditorium 3");
            schedulerLocationComboBox.Items.Add("Block E Auditorium 1");
            schedulerLocationComboBox.Items.Add("Block E Auditorium 2");
            schedulerLocationComboBox.Items.Add("Block E Auditorium 3");

            // Insert Computer Lab inside the combobox
            schedulerLocationComboBox.Items.Add("Block B Computer Lab 1");
            schedulerLocationComboBox.Items.Add("Block B Computer Lab 2");
            schedulerLocationComboBox.Items.Add("Block B Computer Lab 3");
            schedulerLocationComboBox.Items.Add("Block D Computer Lab 1");
            schedulerLocationComboBox.Items.Add("Block D Computer Lab 2");
            schedulerLocationComboBox.Items.Add("Block D Computer Lab 3");
            schedulerLocationComboBox.Items.Add("Block E Computer Lab 1");
            schedulerLocationComboBox.Items.Add("Block E Computer Lab 2");
            schedulerLocationComboBox.Items.Add("Block E Computer Lab 3");

            // Insert Engineering Lab inside the combobox
            schedulerLocationComboBox.Items.Add("Block B Engineering Lab 1");
            schedulerLocationComboBox.Items.Add("Block B Engineering Lab 2");
            schedulerLocationComboBox.Items.Add("Block B Engineering Lab 3");
            schedulerLocationComboBox.Items.Add("Block D Engineering Lab 1");
            schedulerLocationComboBox.Items.Add("Block D Engineering Lab 2");
            schedulerLocationComboBox.Items.Add("Block D Engineering Lab 3");
            schedulerLocationComboBox.Items.Add("Block E Engineering Lab 1");
            schedulerLocationComboBox.Items.Add("Block E Engineering Lab 2");
            schedulerLocationComboBox.Items.Add("Block E Engineering Lab 3");

            // Add Time to the schedulerBookingPreviousTimeComboBox
            schedulerBookingPreviousTimeComboBox.Items.Add("08:30 - 09:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("09:30 - 10:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("10:30 - 11:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("11:30 - 12:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("12:30 - 13:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("13:30 - 14:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("14:30 - 15:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("15:30 - 16:30");
            schedulerBookingPreviousTimeComboBox.Items.Add("16:30 - 18:00");

            // Add Time to the schedulerBookingNewTimeComboBox
            schedulerBookingNewTimeComboBox.Items.Add("08:30 - 09:30");
            schedulerBookingNewTimeComboBox.Items.Add("09:30 - 10:30");
            schedulerBookingNewTimeComboBox.Items.Add("10:30 - 11:30");
            schedulerBookingNewTimeComboBox.Items.Add("11:30 - 12:30");
            schedulerBookingNewTimeComboBox.Items.Add("12:30 - 13:30");
            schedulerBookingNewTimeComboBox.Items.Add("13:30 - 14:30");
            schedulerBookingNewTimeComboBox.Items.Add("14:30 - 15:30");
            schedulerBookingNewTimeComboBox.Items.Add("15:30 - 16:30");
            schedulerBookingNewTimeComboBox.Items.Add("16:30 - 18:00");

            // Add Time to the schedulerCancelBookingTimeComboBox
            schedulerBookingCancelationTimeComboBox.Items.Add("08:30 - 09:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("09:30 - 10:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("10:30 - 11:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("11:30 - 12:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("12:30 - 13:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("13:30 - 14:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("14:30 - 15:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("15:30 - 16:30");
            schedulerBookingCancelationTimeComboBox.Items.Add("16:30 - 18:00");
        }

        private void schedulerLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DECLARE CONNECTION TO DATAGRID
            // replace the space to underscore to match the database name
            string location = (schedulerLocationComboBox.Text).Replace(' ', '_');
            // execute the query
            string strSql = "SELECT * FROM " + location + ";";
            OleDbConnection con = new OleDbConnection(cnnOLEDB.ConnectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable timetable = new DataTable();
            da.Fill(timetable);
            schedulerDataGridView.DataSource = timetable;

            // CHECK THE CONDITION WHETHER THE TIMETABLE HAS BEEN RELEASED OR NOT
            // iterate through the classroom_list

            // CHECK THE TYPE OF THE VENUE
            for (int i = 0; i < MainLoginForm.classroom_list.Length; i++)
            {
                if (MainLoginForm.classroom_list[i].name.Equals(location))
                {
                    // check released status of the timetable
                    if (MainLoginForm.classroom_list[i].released == 1)
                    {
                        // if the timetable is released, show the timetable
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        schedulerReleasedStatusDisplayLabel.Text = "Unreleased";
                        break;
                    }
                }
            }

            for (int i = 0; i < MainLoginForm.auditorium_list.Length; i++)
            {
                if (MainLoginForm.auditorium_list[i].name.Equals(location))
                {
                    // check released status of the timetable
                    if (MainLoginForm.auditorium_list[i].released == 1)
                    {
                        // if the timetable is released, show the timetable
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        schedulerReleasedStatusDisplayLabel.Text = "Unreleased";
                        break;
                    }
                }
            }

            for (int i = 0; i < MainLoginForm.computer_lab_list.Length; i++)
            {
                if (MainLoginForm.computer_lab_list[i].name.Equals(location))
                {
                    // check released status of the timetable
                    if (MainLoginForm.computer_lab_list[i].released == 1)
                    {
                        // if the timetable is released, show the timetable
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        schedulerReleasedStatusDisplayLabel.Text = "Unreleased";
                        break;
                    }
                }
            }

            for (int i = 0; i < MainLoginForm.engineering_lab_list.Length; i++)
            {
                if (MainLoginForm.engineering_lab_list[i].name.Equals(location))
                {
                    // check released status of the timetable
                    if (MainLoginForm.engineering_lab_list[i].released == 1)
                    {
                        // if the timetable is released, show the timetable
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        schedulerReleasedStatusDisplayLabel.Text = "Unreleased";
                    }
                }
            }

            // Add Date to the schedulerBookingPreviousDateComboBox
            // replace the space to underscore to match the database name
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Date FROM " + location + ";", cnnOLEDB);
            reader = command.ExecuteReader();
            schedulerBookingPreviousDateComboBox.Items.Clear();

            while (reader.Read())
            {
                schedulerBookingPreviousDateComboBox.Items.Add(reader[0].ToString());
            }

            // Add Date to the schedulerBookingNewDateComboBox
            // replace the space to underscore to match the database name
            reader = null;
            command = new OleDbCommand("SELECT Date FROM " + location + ";", cnnOLEDB);
            reader = command.ExecuteReader();
            schedulerBookingNewDateComboBox.Items.Clear();

            while (reader.Read())
            {
                schedulerBookingNewDateComboBox.Items.Add(reader[0].ToString());
            }

            // Add Date to the schedulerBookingCancelationDateComboBox
            // replace the space to underscore to match the database name
            reader = null;
            command = new OleDbCommand("SELECT Date FROM " + location + ";", cnnOLEDB);
            reader = command.ExecuteReader();
            schedulerBookingCancelationDateComboBox.Items.Clear();

            while (reader.Read())
            {
                schedulerBookingCancelationDateComboBox.Items.Add(reader[0].ToString());
            }
        }

        private void schedulerBookingEventNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedulerCancelBookingProcessButton_Click(object sender, EventArgs e)
        {

        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            SchedulerSeeTimetableForm seeTimetableForm = new SchedulerSeeTimetableForm();
            this.Hide();
            seeTimetableForm.Show();
        }

        private void schedulerBookButton_Click(object sender, EventArgs e)
        {
            if (schedulerBookingUsernameTextBox.Text != "" && schedulerBookingEventNameTextBox.Text != "" && schedulerBookingPreviousDateComboBox.Text != "" && schedulerBookingPreviousTimeComboBox.Text != "" && schedulerBookingNewTimeComboBox.Text != "" && schedulerBookingNewDateComboBox.Text != "")
            {
                // store the value in GlobalConfirmation variable
                SchedulerLoginForm.bookingDetails.Username = schedulerBookingUsernameTextBox.Text;
                SchedulerLoginForm.bookingDetails.Event = schedulerBookingEventNameTextBox.Text;
                SchedulerLoginForm.bookingDetails.Location = schedulerLocationComboBox.Text;
                SchedulerLoginForm.bookingDetails.Date = schedulerBookingNewDateComboBox.Text;
                SchedulerLoginForm.bookingDetails.Time = schedulerBookingNewTimeComboBox.Text;
                SchedulerLoginForm.bookingDetails.PreviousDate = schedulerBookingPreviousDateComboBox.Text;
                SchedulerLoginForm.bookingDetails.PreviousTime = schedulerBookingPreviousTimeComboBox.Text;

                // search and add the name of the student
                for (int i = 0; i < MainLoginForm.student_list.Length; i++)
                {
                    if (MainLoginForm.student_list[i].studentUsername == SchedulerLoginForm.bookingDetails.Username)
                    {
                        SchedulerLoginForm.bookingDetails.Name = MainLoginForm.student_list[i].studentName;
                    }
                }

                SchedulerAdditionalFeaturesAVBForm additionalFeaturesAVBForm = new SchedulerAdditionalFeaturesAVBForm();
                this.Hide();
                additionalFeaturesAVBForm.Show();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }

        private void schedulerBookingPreviousTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SchedulerManageBookingForm_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOLEDB.Open();
        }

        private void schedulerBookingPreviousDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedulerBookingNewDateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedulerBookingNewTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedulerBookingUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void schedulerCancelBookingButton_Click(object sender, EventArgs e)
        {
            string location = (schedulerLocationComboBox.Text).Replace(" ", "_");

            // REMOVE THE DATA FROM BOOKINGCONFIMATION
            if (schedulerBookingCancelationTimeComboBox.Text != "" && schedulerBookingCancelationDateComboBox.Text != "" && schedulerBookingCancelationUsernameTextBox.Text != "")
            {
                cmdDelete.CommandText = "DELETE FROM BookingConfirmation WHERE Username = '" + schedulerBookingCancelationUsernameTextBox.Text + "' AND Date = '" + schedulerBookingCancelationDateComboBox.Text + "' AND Time = '" + schedulerBookingCancelationTimeComboBox.Text + "';";
                cmdDelete.CommandType = CommandType.Text;
                cmdDelete.Connection = cnnOLEDB;
                cmdDelete.ExecuteNonQuery();

                // UPDATE THE TIMETABLE
                cmdUpdate.CommandText = "UPDATE [" + location + "] SET [" + schedulerBookingCancelationTimeComboBox.Text + "] = 'Available' WHERE Date = '" + schedulerBookingCancelationDateComboBox.Text + "';";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Please fill in all the required fields");
            }
        }

        private void schedulerBookingCancelationUsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
