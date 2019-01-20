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
using System.Data.SqlClient;

namespace UserSchedulingSystem
{
    public partial class UserBookingProcessForm : Form
    {
        //Using Global Variable to access it in another form
        
        OleDbConnection cnnOleDb = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdTimeRange = new OleDbCommand();
        OleDbCommand cmdUpdate = new OleDbCommand();
        OleDbCommand cmdCheck = new OleDbCommand();

        public UserBookingProcessForm()
        {
            InitializeComponent();

            // ADD ITEMS TO THE LOCATION COMBOBOX
            //Insert Classroom inside the ComboBox
            userLocationBookingProcessComboBox.Items.Add("Block B Classroom 1");
            userLocationBookingProcessComboBox.Items.Add("Block B Classroom 2");
            userLocationBookingProcessComboBox.Items.Add("Block B Classroom 3");
            userLocationBookingProcessComboBox.Items.Add("Block D Classroom 1");
            userLocationBookingProcessComboBox.Items.Add("Block D Classroom 2");
            userLocationBookingProcessComboBox.Items.Add("Block D Classroom 3");
            userLocationBookingProcessComboBox.Items.Add("Block E Classroom 1");
            userLocationBookingProcessComboBox.Items.Add("Block E Classroom 2");
            userLocationBookingProcessComboBox.Items.Add("Block E Classroom 3");

            //Insert Auditorium inside the ComboBox
            userLocationBookingProcessComboBox.Items.Add("Block B Auditorium 1");
            userLocationBookingProcessComboBox.Items.Add("Block B Auditorium 2");
            userLocationBookingProcessComboBox.Items.Add("Block B Auditorium 3");
            userLocationBookingProcessComboBox.Items.Add("Block D Auditorium 1");
            userLocationBookingProcessComboBox.Items.Add("Block D Auditorium 2");
            userLocationBookingProcessComboBox.Items.Add("Block D Auditorium 3");
            userLocationBookingProcessComboBox.Items.Add("Block E Auditorium 1");
            userLocationBookingProcessComboBox.Items.Add("Block E Auditorium 2");
            userLocationBookingProcessComboBox.Items.Add("Block E Auditorium 3");

            //Insert Computer Lab inside the ComboBox
            userLocationBookingProcessComboBox.Items.Add("Block B Computer Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block B Computer Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block B Computer Lab 3");
            userLocationBookingProcessComboBox.Items.Add("Block D Computer Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block D Computer Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block D Computer Lab 3");
            userLocationBookingProcessComboBox.Items.Add("Block E Computer Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block E Computer Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block E Computer Lab 3");

            //Insert Engineering Lab inside the ComboBox
            userLocationBookingProcessComboBox.Items.Add("Block B Engineering Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block B Engineering Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block B Engineering Lab 3");
            userLocationBookingProcessComboBox.Items.Add("Block D Engineering Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block D Engineering Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block D Engineering Lab 3");
            userLocationBookingProcessComboBox.Items.Add("Block E Engineering Lab 1");
            userLocationBookingProcessComboBox.Items.Add("Block E Engineering Lab 2");
            userLocationBookingProcessComboBox.Items.Add("Block E Engineering Lab 3");


            //Insert Day inside the ComboBox
            userDateBookingProcessComboBox.Items.Add("18/06/2018");
            userDateBookingProcessComboBox.Items.Add("19/06/2018");
            userDateBookingProcessComboBox.Items.Add("20/06/2018");
            userDateBookingProcessComboBox.Items.Add("21/06/2018");
            userDateBookingProcessComboBox.Items.Add("22/06/2018");
            userDateBookingProcessComboBox.Items.Add("23/06/2018");
            userDateBookingProcessComboBox.Items.Add("24/06/2018");
            userDateBookingProcessComboBox.Items.Add("25/06/2018");
            userDateBookingProcessComboBox.Items.Add("26/06/2018");
            userDateBookingProcessComboBox.Items.Add("27/06/2018");
            userDateBookingProcessComboBox.Items.Add("28/06/2018");
            userDateBookingProcessComboBox.Items.Add("29/06/2018");
            userDateBookingProcessComboBox.Items.Add("30/06/2018");

            //Insert Time inside the ComboBox
            userTimeBookingProcessComboBox.Items.Add("08:30 - 09:30");
            userTimeBookingProcessComboBox.Items.Add("09:30 - 10:30");
            userTimeBookingProcessComboBox.Items.Add("10:30 - 11:30");
            userTimeBookingProcessComboBox.Items.Add("11:30 - 12:30");
            userTimeBookingProcessComboBox.Items.Add("12:30 - 13:30");
            userTimeBookingProcessComboBox.Items.Add("13:30 - 14:30");
            userTimeBookingProcessComboBox.Items.Add("14:30 - 15:30");
            userTimeBookingProcessComboBox.Items.Add("15:30 - 16:30");
            userTimeBookingProcessComboBox.Items.Add("16:30 - 18:00");


            userBookingProcessGroupBox.Enabled = false;

        }

        private void userHomeButton_Click(object sender, EventArgs e)
        {
            UserClassroomBookingSystemForm userClassroomBookingSystemForm = new UserClassroomBookingSystemForm();
            this.Hide();
            userClassroomBookingSystemForm.Show();
        }

        private void userNextButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            string location = (userLocationBookingProcessComboBox.Text).Replace(" ", "_");

            if (location != "" && userEventNameTextBox.Text != "" && userTimeBookingProcessComboBox.Text != "" && userDateBookingProcessComboBox.Text != "")
            {
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM [BookingConfirmation] WHERE NOT [Username] = 'Available' AND [Booked_Location] = '" + userLocationBookingProcessComboBox.Text + "' AND [Time] = '" + userTimeBookingProcessComboBox.Text + "' AND [Date] = '" + userDateBookingProcessComboBox.Text + "';", cnnOleDb);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    count++;
                }

                OleDbDataReader reader1 = null;
                OleDbCommand command1 = new OleDbCommand("SELECT [" + userTimeBookingProcessComboBox.Text + "] FROM [" + location + "] WHERE [Date] = '" + userDateBookingProcessComboBox.Text + "';", cnnOleDb);
                reader1 = command1.ExecuteReader();

                while (reader1.Read())
                {
                    // check the value of the selected column whether it is available or not
                    if (reader1[0].ToString() != "Available")
                    {
                        count++;
                    }
                }
                reader1.Close();

                if (count > 0)
                {
                    // matching data found
                    MessageBox.Show("This time slot have already been booked");
                }
                else
                {
                    // available slot
                    UserLoginForm.bookingDetails.Event = userEventNameTextBox.Text;
                    UserLoginForm.bookingDetails.Date = userDateBookingProcessComboBox.Text;
                    UserLoginForm.bookingDetails.Time = userTimeBookingProcessComboBox.Text;
                    UserLoginForm.bookingDetails.Location = userLocationBookingProcessComboBox.Text;

                    userAudioVisualBookingForm userAudioVisualBookingForm = new userAudioVisualBookingForm();
                    this.Hide();
                    userAudioVisualBookingForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }

        }

        private void UserBookingProcessForm_Load(object sender, EventArgs e)
        {
            userBookingProcessGroupBox.Enabled = false;

            // userBookingProcessGroupBox.Enabled = false;
            cnnOleDb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOleDb.Open();

        }

        private void userLocationBookingProcessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Establish connection from the database to the datagrid based on the combobox selection
            string location = (userLocationBookingProcessComboBox.Text).Replace(' ', '_');
            string strSql = "SELECT * FROM " + location;
            OleDbConnection con = new OleDbConnection(cnnOleDb.ConnectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable timetable = new DataTable();

            userBookingProcessGroupBox.Enabled = true;

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
                        da.Fill(timetable);
                        userAvailableSlotsDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationBookingProcessComboBox.Text + " has not been released yet");
                        schedulerReleasedStatusDisplayLabel.Text = "Not yet released";
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
                        da.Fill(timetable);
                        userAvailableSlotsDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationBookingProcessComboBox.Text + " has not been released yet");
                        schedulerReleasedStatusDisplayLabel.Text = "Not yet released";
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
                        da.Fill(timetable);
                        userAvailableSlotsDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationBookingProcessComboBox.Text + " has not been released yet");
                        schedulerReleasedStatusDisplayLabel.Text = "Not yet released";
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
                        da.Fill(timetable);
                        userAvailableSlotsDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationBookingProcessComboBox.Text + " has not been released yet");
                        schedulerReleasedStatusDisplayLabel.Text = "Not yet released";
                        break;
                    }
                }
            }

        }

        private void userDateBookingProcessComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ---------------------------------------------------
                string location = (userLocationBookingProcessComboBox.Text).Replace(' ', '_');
                cmdTimeRange.CommandText = "SELECT [Date] FROM [" + location.ToString() + "] WHERE [Date] ='" + userDateBookingProcessComboBox.SelectedText + "';";
                cmdTimeRange.Connection = cnnOleDb;
                OleDbDataReader dr = cmdTimeRange.ExecuteReader();
                dr.Read();
                string date = userDateBookingProcessComboBox.SelectedItem.ToString();
                DateTime selectedDate = DateTime.ParseExact(date, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string nowDate = DateTime.Now.ToString("dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime currentDate = DateTime.ParseExact(nowDate, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan dayInterval = selectedDate - currentDate;
                int days = dayInterval.Days;
                if (days < 3)
                {
                    userBookingProcessWarningLabel.Text = "Unable to place the booking since it less than 3 days";
                }
                else
                {
                    userBookingProcessWarningLabel.Text = "";
                }
                dr.Close();
            
            
        }

        private void userTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string location = (userTimeBookingProcessComboBox.Text).Replace(' ', '_');
            string strSql = "SELECT * FROM " + userTimeBookingProcessComboBox.Text + ";";
            OleDbConnection con = new OleDbConnection(cnnOleDb.ConnectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            cmd.CommandType = CommandType.Text;

        }

        private void userEventNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
