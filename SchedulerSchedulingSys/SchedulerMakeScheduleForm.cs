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

    public partial class SchedulerMakeScheduleForm : Form
    {

        // ESTABLISH DATABASE CONNECTION
        OleDbConnection cnnOLEDB = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();

        public SchedulerMakeScheduleForm()
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

            // Add Time to the schedulerTimeComboBox
            schedulerTimeComboBox.Items.Add("08:30 - 09:30");
            schedulerTimeComboBox.Items.Add("09:30 - 10:30");
            schedulerTimeComboBox.Items.Add("10:30 - 11:30");
            schedulerTimeComboBox.Items.Add("11:30 - 12:30");
            schedulerTimeComboBox.Items.Add("12:30 - 13:30");
            schedulerTimeComboBox.Items.Add("13:30 - 14:30");
            schedulerTimeComboBox.Items.Add("14:30 - 15:30");
            schedulerTimeComboBox.Items.Add("15:30 - 16:30");
            schedulerTimeComboBox.Items.Add("16:30 - 18:00");

        }

        private void schedulerLecturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add Course to the schedulerLecturerComboBox
            for (int i = 0; i < MainLoginForm.lecturer_list.Length; i++)
            {
                schedulerCourseComboBox.Items.Add(MainLoginForm.lecturer_list[i].lecturerCourse);
            }
        }

        private void schedulerLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Add Date to the schedulerDateComboBox
            // replace the space to underscore to match the database name
            string location = (schedulerLocationComboBox.Text).Replace(' ', '_');
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Date FROM " + location + ";", cnnOLEDB);
            reader = command.ExecuteReader();
            schedulerDateComboBox.Items.Clear();

            while (reader.Read())
            {
                schedulerDateComboBox.Items.Add(reader[0].ToString());
            }
        }

        private void schedulerCourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SchedulerDayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            SchedulerSeeTimetableForm seeTimetableForm = new SchedulerSeeTimetableForm();
            this.Hide();
            seeTimetableForm.Show();
        }

        private void schedulerSubmitButton_Click(object sender, EventArgs e)
        {
            // UPDATE THE DATA IN THE DATABASE
            string location = (schedulerLocationComboBox.Text).Replace(' ', '_');

            if (schedulerTimeComboBox.Text != "" && schedulerCourseComboBox.Text != "" && schedulerDateComboBox.Text != "")
            {
                cmdUpdate.CommandText = "UPDATE [" + location + "] SET [" + schedulerTimeComboBox.Text + "] = '" + schedulerCourseComboBox.Text + "' WHERE Date = '" + schedulerDateComboBox.Text + "';";
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.Connection = cnnOLEDB;
                cmdUpdate.ExecuteNonQuery();

                SchedulerSeeTimetableForm seeTimetableForm = new SchedulerSeeTimetableForm();
                this.Hide();
                seeTimetableForm.Show();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }   
        }

        private void SchedulerMakeScheduleForm_Load(object sender, EventArgs e)
        {
            // ESTABLISH CONNECTION
            cnnOLEDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOLEDB.Open();

            // Add Lecturer to the schedulerLecturerComboBox
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT Lecturer_Name FROM Lecturer", cnnOLEDB);
            reader = command.ExecuteReader();
            schedulerLecturerComboBox.Items.Clear();

            while (reader.Read())
            {

                schedulerLecturerComboBox.Items.Add(reader[0].ToString());
            }

        }

        private void schedulerStartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedulerEndTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
