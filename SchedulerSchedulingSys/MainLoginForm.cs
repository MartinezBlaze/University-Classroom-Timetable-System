using StudentSchedulingSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserSchedulingSystem;

namespace SchedulerSchedulingSys
{
    public partial class MainLoginForm : Form
    {
        // Array of Objects of the Students
        public static Student[] student_list = new Student[15];

        // Array of Objects of the Lecturers
        public static Lecturer[] lecturer_list = new Lecturer[15];

        // Array of Objects of the Schedulers
        public static Scheduler[] scheduler_list = new Scheduler[15];

        // Array of Objects of the Classroom
        public static Classroom[] classroom_list = new Classroom[9];

        // Array of Objects of the Auditorium
        public static Auditorium[] auditorium_list = new Auditorium[9];

        // Array of Objects of the Computer_Lab
        public static Computer_Lab[] computer_lab_list = new Computer_Lab[9];

        // Array of Objects of the Engineering_Lab
        public static Engineering_Lab[] engineering_lab_list = new Engineering_Lab[9];

        // YOU SHOULD PUT THEM IN THE MAIN FORM
        //Objects of the Students
        public static Student student_0 = new Student("TP000001", "Yoseph", "TP000001", "Object Oriented Programming");
        public static Student student_1 = new Student("TP000002", "Martin", "TP000002", "IoT");
        public static Student student_2 = new Student("TP000003", "Christian", "TP000003", "Virtual Reality");
        public static Student student_3 = new Student("TP000004", "Paramitha", "TP000004", "Web Design");
        public static Student student_4 = new Student("TP000005", "Aryananda", "TP000005", "Concurrent Programming");
        public static Student student_5 = new Student("TP000006", "Tioputri", "TP000006", "Introduction to JavaScript");
        public static Student student_6 = new Student("TP000007", "Muhammad", "TP000007", "Concurrent Programming");
        public static Student student_7 = new Student("TP000008", "Aldy", "TP000008", "Networking");
        public static Student student_8 = new Student("TP000009", "Madani", "TP000009", "Computer Architecture");
        public static Student student_9 = new Student("TP000010", "Saleh", "TP000010", "Deep Dive PHP");
        public static Student student_10 = new Student("TP000011", "Erica", "TP000011", "Introduction to Python");
        public static Student student_11 = new Student("TP000012", "Bella", "TP000012", "Introduction to MySQL");
        public static Student student_12 = new Student("TP044890", "Amelia", "TP044890", "Introduction to Database");
        public static Student student_13 = new Student("TP047067", "Leonardo", "TP047067", "Deep Dive HTML");
        public static Student student_14 = new Student("TP047112", "Dicaprio", "TP047112", "Deep Dive CSS");

        //Objects of the Lecturers
        public static Lecturer lecturer_0 = new Lecturer("lecturer_01", "Jack", "lecturer_01", "Introduction to Database");
        public static Lecturer lecturer_1 = new Lecturer("lecturer_02", "Sparrow", "lecturer_02", "Deep Dive PHP");
        public static Lecturer lecturer_2 = new Lecturer("lecturer_03", "Ethan", "lecturer_03", "Deep Dive HTML");
        public static Lecturer lecturer_3 = new Lecturer("lecturer_04", "Hunt", "lecturer_04", "Deep Dive CSS");
        public static Lecturer lecturer_4 = new Lecturer("lecturer_05", "James", "lecturer_05", "Introduction to JavaScript");
        public static Lecturer lecturer_5 = new Lecturer("lecturer_06", "Bond", "lecturer_06", "Introduction to MySQL");
        public static Lecturer lecturer_6 = new Lecturer("lecturer_07", "Bill", "lecturer_07", "Introduction to Python");
        public static Lecturer lecturer_7 = new Lecturer("lecturer_08", "Gates", "lecturer_08", "Concurrent Programming");
        public static Lecturer lecturer_8 = new Lecturer("lecturer_09", "Steve", "lecturer_09", "Introduction to C#");
        public static Lecturer lecturer_9 = new Lecturer("lecturer_10", "Jobs", "lecturer_10", "Object Oriented Programming");
        public static Lecturer lecturer_10 = new Lecturer("lecturer_11", "Michael", "lecturer_11", "Web Design");
        public static Lecturer lecturer_11 = new Lecturer("lecturer_12", "Jackson", "lecturer_12", "Networking");
        public static Lecturer lecturer_12 = new Lecturer("lecturer_13", "Peter", "lecturer_13", "Computer Architecture");
        public static Lecturer lecturer_13 = new Lecturer("lecturer_14", "Parker", "lecturer_14", "Virtual Reality");
        public static Lecturer lecturer_14 = new Lecturer("lecturer_15", "Charles", "lecturer_15", "IoT");

        //Objects of the Schedulers
        public static Scheduler scheduler_0 = new Scheduler("scheduler_01", "Fayu", "scheduler01");
        public static Scheduler scheduler_1 = new Scheduler("scheduler_02", "Rani", "scheduler02");
        public static Scheduler scheduler_2 = new Scheduler("scheduler_03", "Aishah", "scheduler03");
        public static Scheduler scheduler_3 = new Scheduler("scheduler_04", "Mulan", "scheduler04");
        public static Scheduler scheduler_4 = new Scheduler("scheduler_05", "Felicia", "scheduler05");
        public static Scheduler scheduler_5 = new Scheduler("scheduler_06", "Eugene", "scheduler06");
        public static Scheduler scheduler_6 = new Scheduler("scheduler_07", "Albert", "scheduler07");
        public static Scheduler scheduler_7 = new Scheduler("scheduler_08", "Sandy", "scheduler08");
        public static Scheduler scheduler_8 = new Scheduler("scheduler_09", "Newton", "scheduler09");
        public static Scheduler scheduler_9 = new Scheduler("scheduler_10", "Alex", "scheduler10");
        public static Scheduler scheduler_10 = new Scheduler("scheduler_11", "Sam", "scheduler11");
        public static Scheduler scheduler_11 = new Scheduler("scheduler_12", "Christ", "scheduler12");
        public static Scheduler scheduler_12 = new Scheduler("scheduler_13", "Shouta", "scheduler13");
        public static Scheduler scheduler_13 = new Scheduler("scheduler_14", "Kazehaya", "scheduler14");
        public static Scheduler scheduler_14 = new Scheduler("scheduler_15", "Sadako", "scheduler15");

        public static Classroom Block_B_Classroom_1 = new Classroom("Block_B_Classroom_1", "B", "Classroom", 30);
        public static Classroom Block_B_Classroom_2 = new Classroom("Block_B_Classroom_2", "B", "Classroom", 30);
        public static Classroom Block_B_Classroom_3 = new Classroom("Block_B_Classroom_3", "B", "Classroom", 30);
        public static Classroom Block_D_Classroom_1 = new Classroom("Block_D_Classroom_1", "D", "Classroom", 30);
        public static Classroom Block_D_Classroom_2 = new Classroom("Block_D_Classroom_2", "D", "Classroom", 30);
        public static Classroom Block_D_Classroom_3 = new Classroom("Block_D_Classroom_3", "D", "Classroom", 30);
        public static Classroom Block_E_Classroom_1 = new Classroom("Block_E_Classroom_1", "E", "Classroom", 30);
        public static Classroom Block_E_Classroom_2 = new Classroom("Block_E_Classroom_2", "E", "Classroom", 30);
        public static Classroom Block_E_Classroom_3 = new Classroom("Block_E_Classroom_3", "E", "Classroom", 30);

        public static Auditorium Block_B_Auditorium_1 = new Auditorium("Block_B_Auditorium_1", "B", "Auditorium", 150);
        public static Auditorium Block_B_Auditorium_2 = new Auditorium("Block_B_Auditorium_2", "B", "Auditorium", 150);
        public static Auditorium Block_B_Auditorium_3 = new Auditorium("Block_B_Auditorium_3", "B", "Auditorium", 150);
        public static Auditorium Block_D_Auditorium_1 = new Auditorium("Block_B_Auditorium_1", "D", "Auditorium", 150);
        public static Auditorium Block_D_Auditorium_2 = new Auditorium("Block_B_Auditorium_2", "D", "Auditorium", 150);
        public static Auditorium Block_D_Auditorium_3 = new Auditorium("Block_B_Auditorium_3", "D", "Auditorium", 150);
        public static Auditorium Block_E_Auditorium_1 = new Auditorium("Block_B_Auditorium_1", "E", "Auditorium", 150);
        public static Auditorium Block_E_Auditorium_2 = new Auditorium("Block_B_Auditorium_2", "E", "Auditorium", 150);
        public static Auditorium Block_E_Auditorium_3 = new Auditorium("Block_B_Auditorium_3", "E", "Auditorium", 150);

        public static Computer_Lab Block_B_Computer_Lab_1 = new Computer_Lab("Block_B_Computer_Lab_1", "B", "Computer Lab", 50);
        public static Computer_Lab Block_B_Computer_Lab_2 = new Computer_Lab("Block_B_Computer_Lab_2", "B", "Computer Lab", 50);
        public static Computer_Lab Block_B_Computer_Lab_3 = new Computer_Lab("Block_B_Computer_Lab_3", "B", "Computer Lab", 50);
        public static Computer_Lab Block_D_Computer_Lab_1 = new Computer_Lab("Block_D_Computer_Lab_1", "D", "Computer Lab", 50);
        public static Computer_Lab Block_D_Computer_Lab_2 = new Computer_Lab("Block_D_Computer_Lab_2", "D", "Computer Lab", 50);
        public static Computer_Lab Block_D_Computer_Lab_3 = new Computer_Lab("Block_D_Computer_Lab_3", "D", "Computer Lab", 50);
        public static Computer_Lab Block_E_Computer_Lab_1 = new Computer_Lab("Block_E_Computer_Lab_1", "E", "Computer Lab", 50);
        public static Computer_Lab Block_E_Computer_Lab_2 = new Computer_Lab("Block_E_Computer_Lab_2", "E", "Computer Lab", 50);
        public static Computer_Lab Block_E_Computer_Lab_3 = new Computer_Lab("Block_E_Computer_Lab_3", "E", "Computer Lab", 50);

        public static Engineering_Lab Block_B_Engineering_Lab_1 = new Engineering_Lab("Block_B_Engineering_Lab_1", "B", "Engineering Lab", 50);
        public static Engineering_Lab Block_B_Engineering_Lab_2 = new Engineering_Lab("Block_B_Engineering_Lab_2", "B", "Engineering Lab", 50);
        public static Engineering_Lab Block_B_Engineering_Lab_3 = new Engineering_Lab("Block_B_Engineering_Lab_3", "B", "Engineering Lab", 50);
        public static Engineering_Lab Block_D_Engineering_Lab_1 = new Engineering_Lab("Block_D_Engineering_Lab_1", "D", "Engineering Lab", 50);
        public static Engineering_Lab Block_D_Engineering_Lab_2 = new Engineering_Lab("Block_D_Engineering_Lab_2", "D", "Engineering Lab", 50);
        public static Engineering_Lab Block_D_Engineering_Lab_3 = new Engineering_Lab("Block_D_Engineering_Lab_3", "D", "Engineering Lab", 50);
        public static Engineering_Lab Block_E_Engineering_Lab_1 = new Engineering_Lab("Block_E_Engineering_Lab_1", "E", "Engineering Lab", 50);
        public static Engineering_Lab Block_E_Engineering_Lab_2 = new Engineering_Lab("Block_E_Engineering_Lab_2", "E", "Engineering Lab", 50);
        public static Engineering_Lab Block_E_Engineering_Lab_3 = new Engineering_Lab("Block_E_Engineering_Lab_3", "E", "Engineering Lab", 50);

        public MainLoginForm()
        {
            InitializeComponent();
        }

        private void mainLoginSchedulerButton_Click(object sender, EventArgs e)
        {
            SchedulerLoginForm schedulerLogin = new SchedulerLoginForm();
            this.Hide();
            schedulerLogin.Show();
        }

        private void mainLoginUserButton_Click(object sender, EventArgs e)
        {
            UserLoginForm userLoginForm = new UserLoginForm();
            this.Hide();
            userLoginForm.Show();
        }

        private void mainLoginCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainLoginForm_Load(object sender, EventArgs e)
        {
            // ADD THE OBJECT TO THE LIST
            // add student to the student_list
            student_list[0] = student_0;
            student_list[1] = student_1;
            student_list[2] = student_2;
            student_list[3] = student_3;
            student_list[4] = student_4;
            student_list[5] = student_5;
            student_list[6] = student_6;
            student_list[7] = student_7;
            student_list[8] = student_8;
            student_list[9] = student_9;
            student_list[10] = student_10;
            student_list[11] = student_11;
            student_list[12] = student_12;
            student_list[13] = student_13;
            student_list[14] = student_14;

            // add lecturer to the lecturer_list
            lecturer_list[0] = lecturer_0;
            lecturer_list[1] = lecturer_1;
            lecturer_list[2] = lecturer_2;
            lecturer_list[3] = lecturer_3;
            lecturer_list[4] = lecturer_4;
            lecturer_list[5] = lecturer_5;
            lecturer_list[6] = lecturer_6;
            lecturer_list[7] = lecturer_7;
            lecturer_list[8] = lecturer_8;
            lecturer_list[9] = lecturer_9;
            lecturer_list[10] = lecturer_10;
            lecturer_list[11] = lecturer_11;
            lecturer_list[12] = lecturer_12;
            lecturer_list[13] = lecturer_13;
            lecturer_list[14] = lecturer_14;

            // add scheduler to the scheduler_list
            scheduler_list[0] = scheduler_0;
            scheduler_list[1] = scheduler_1;
            scheduler_list[2] = scheduler_2;
            scheduler_list[3] = scheduler_3;
            scheduler_list[4] = scheduler_4;
            scheduler_list[5] = scheduler_5;
            scheduler_list[6] = scheduler_6;
            scheduler_list[7] = scheduler_7;
            scheduler_list[8] = scheduler_8;
            scheduler_list[9] = scheduler_9;
            scheduler_list[10] = scheduler_10;
            scheduler_list[11] = scheduler_11;
            scheduler_list[12] = scheduler_12;
            scheduler_list[13] = scheduler_13;
            scheduler_list[14] = scheduler_14;

            // add classroom to the classroom_list
            classroom_list[0] = Block_B_Classroom_1;
            classroom_list[1] = Block_B_Classroom_2;
            classroom_list[2] = Block_B_Classroom_3;
            classroom_list[3] = Block_D_Classroom_1;
            classroom_list[4] = Block_D_Classroom_2;
            classroom_list[5] = Block_D_Classroom_3;
            classroom_list[6] = Block_E_Classroom_1;
            classroom_list[7] = Block_E_Classroom_2;
            classroom_list[8] = Block_E_Classroom_3;

            // add auditorium to the auditorium_list
            auditorium_list[0] = Block_B_Auditorium_1;
            auditorium_list[1] = Block_B_Auditorium_2;
            auditorium_list[2] = Block_B_Auditorium_3;
            auditorium_list[3] = Block_D_Auditorium_1;
            auditorium_list[4] = Block_D_Auditorium_2;
            auditorium_list[5] = Block_D_Auditorium_3;
            auditorium_list[6] = Block_E_Auditorium_1;
            auditorium_list[7] = Block_E_Auditorium_2;
            auditorium_list[8] = Block_E_Auditorium_3;

            // add computer lab to the computer_lab_list
            computer_lab_list[0] = Block_B_Computer_Lab_1;
            computer_lab_list[1] = Block_B_Computer_Lab_2;
            computer_lab_list[2] = Block_B_Computer_Lab_3;
            computer_lab_list[3] = Block_D_Computer_Lab_1;
            computer_lab_list[4] = Block_D_Computer_Lab_2;
            computer_lab_list[5] = Block_D_Computer_Lab_3;
            computer_lab_list[6] = Block_E_Computer_Lab_1;
            computer_lab_list[7] = Block_E_Computer_Lab_2;
            computer_lab_list[8] = Block_E_Computer_Lab_3;

            // add engineering lab to the engineering_lab_list
            engineering_lab_list[0] = Block_B_Engineering_Lab_1;
            engineering_lab_list[1] = Block_B_Engineering_Lab_2;
            engineering_lab_list[2] = Block_B_Engineering_Lab_3;
            engineering_lab_list[3] = Block_D_Engineering_Lab_1;
            engineering_lab_list[4] = Block_D_Engineering_Lab_2;
            engineering_lab_list[5] = Block_D_Engineering_Lab_3;
            engineering_lab_list[6] = Block_E_Engineering_Lab_1;
            engineering_lab_list[7] = Block_E_Engineering_Lab_2;
            engineering_lab_list[8] = Block_E_Engineering_Lab_3;
        }
    }
}
