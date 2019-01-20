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
    public partial class SchedulerReleaseScheduleForm : Form
    {
        OleDbConnection cnnOLEDB = new OleDbConnection();

        public SchedulerReleaseScheduleForm()
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
        }

        private void schedulerBackButton_Click(object sender, EventArgs e)
        {
            SchedulerSeeTimetableForm seeTimetableForm = new SchedulerSeeTimetableForm();
            this.Hide();
            seeTimetableForm.Show();
        }

        private void scheduleReleaseScheduleButton_Click(object sender, EventArgs e)
        {
            string location = (schedulerLocationComboBox.Text).Replace(' ', '_');

            if (location != "")
            {
                // RELEASE THE SCHEDULE FOR SELECTED LOCATION
                // iterate through the classroom_list
                for (int i = 0; i < MainLoginForm.classroom_list.Length; i++)
                {
                    if (MainLoginForm.classroom_list[i].name == location)
                    {
                        MainLoginForm.classroom_list[i].released = 1;
                        break;
                    }
                }

                // iterate through the auditorium_list
                for (int i = 0; i < MainLoginForm.auditorium_list.Length; i++)
                {
                    if (MainLoginForm.auditorium_list[i].name == location)
                    {
                        MainLoginForm.auditorium_list[i].released = 1;
                        break;
                    }
                }

                // iterate through the computer_lab_list
                for (int i = 0; i < MainLoginForm.computer_lab_list.Length; i++)
                {
                    if (MainLoginForm.computer_lab_list[i].name == location)
                    {
                        MainLoginForm.computer_lab_list[i].released = 1;
                        break;
                    }
                }

                // iterate through the engineering_lab_list
                for (int i = 0; i < MainLoginForm.engineering_lab_list.Length; i++)
                {
                    if (MainLoginForm.engineering_lab_list[i].name == location)
                    {
                        MainLoginForm.engineering_lab_list[i].released = 1;
                        break;
                    }
                }

                SchedulerSeeTimetableForm seeScheduleForm = new SchedulerSeeTimetableForm();
                this.Hide();
                seeScheduleForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose a location before releasing the schedule");
            }
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
        }

        private void SchedulerReleaseScheduleForm_Load(object sender, EventArgs e)
        {
            cnnOLEDB.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IOOPAssignmentDatabase.accdb";
            cnnOLEDB.Open();
        }
    }
}
