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
    public partial class UserSeeTimetableForm : Form
    {
        OleDbConnection cnnOleDb = new OleDbConnection();
        OleDbCommand cmdInsert = new OleDbCommand();
        OleDbCommand cmdDelete = new OleDbCommand();

        public UserSeeTimetableForm()
        {
            InitializeComponent();

            // ADD ITEMS TO THE LOCATION COMBOBOX
            //Insert Classroom inside the ComboBox
            userLocationSeeTimetableComboBox.Items.Add("Block B Classroom 1");
            userLocationSeeTimetableComboBox.Items.Add("Block B Classroom 2");
            userLocationSeeTimetableComboBox.Items.Add("Block B Classroom 3");
            userLocationSeeTimetableComboBox.Items.Add("Block D Classroom 1");
            userLocationSeeTimetableComboBox.Items.Add("Block D Classroom 2");
            userLocationSeeTimetableComboBox.Items.Add("Block D Classroom 3");
            userLocationSeeTimetableComboBox.Items.Add("Block E Classroom 1");
            userLocationSeeTimetableComboBox.Items.Add("Block E Classroom 2");
            userLocationSeeTimetableComboBox.Items.Add("Block E Classroom 3");

            //Insert Auditorium inside the ComboBox
            userLocationSeeTimetableComboBox.Items.Add("Block B Auditorium 1");
            userLocationSeeTimetableComboBox.Items.Add("Block B Auditorium 2");
            userLocationSeeTimetableComboBox.Items.Add("Block B Auditorium 3");
            userLocationSeeTimetableComboBox.Items.Add("Block D Auditorium 1");
            userLocationSeeTimetableComboBox.Items.Add("Block D Auditorium 2");
            userLocationSeeTimetableComboBox.Items.Add("Block D Auditorium 3");
            userLocationSeeTimetableComboBox.Items.Add("Block E Auditorium 1");
            userLocationSeeTimetableComboBox.Items.Add("Block E Auditorium 2");
            userLocationSeeTimetableComboBox.Items.Add("Block E Auditorium 3");

            //Insert Computer Lab inside the ComboBox
            userLocationSeeTimetableComboBox.Items.Add("Block B Computer Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block B Computer Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block B Computer Lab 3");
            userLocationSeeTimetableComboBox.Items.Add("Block D Computer Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block D Computer Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block D Computer Lab 3");
            userLocationSeeTimetableComboBox.Items.Add("Block E Computer Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block E Computer Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block E Computer Lab 3");

            //Insert Engineering Lab inside the ComboBox
            userLocationSeeTimetableComboBox.Items.Add("Block B Engineering Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block B Engineering Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block B Engineering Lab 3");
            userLocationSeeTimetableComboBox.Items.Add("Block D Engineering Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block D Engineering Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block D Engineering Lab 3");
            userLocationSeeTimetableComboBox.Items.Add("Block E Engineering Lab 1");
            userLocationSeeTimetableComboBox.Items.Add("Block E Engineering Lab 2");
            userLocationSeeTimetableComboBox.Items.Add("Block E Engineering Lab 3");
        }

        private void userHomeButton_Click(object sender, EventArgs e)
        {
            UserClassroomBookingSystemForm userClassroomBookingSystemForm = new UserClassroomBookingSystemForm();
            this.Hide();
            userClassroomBookingSystemForm.Show();
        }

        private void UserSeeTimetableForm_Load(object sender, EventArgs e)
        {
            cnnOleDb.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOleDb.Open();
            cnnOleDb.Close();
        }

        private void userLocationSeeTimetableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string location = (userLocationSeeTimetableComboBox.Text).Replace(' ', '_');
            string strSql = "SELECT * FROM " + location;
            OleDbConnection con = new OleDbConnection(cnnOleDb.ConnectionString);
            OleDbCommand cmd = new OleDbCommand(strSql, con);
            cmd.CommandType = CommandType.Text;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable timetable = new DataTable();

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
                        userTimetableDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationSeeTimetableComboBox.Text + " has not been released yet");
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
                        userTimetableDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationSeeTimetableComboBox.Text + " has not been released yet");
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
                        userTimetableDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationSeeTimetableComboBox.Text + " has not been released yet");
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
                        userTimetableDataGridView.DataSource = timetable;
                        schedulerReleasedStatusDisplayLabel.Text = "Released";
                        break;
                    }
                    else
                    {
                        MessageBox.Show("The schedule for " + userLocationSeeTimetableComboBox.Text + " has not been released yet");
                        schedulerReleasedStatusDisplayLabel.Text = "Not yet released";
                        break;
                    }
                }
            }
        }
    }
}
