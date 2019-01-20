using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSchedulingSys
{
    public class Student
    {
        private string _studentUsername;
        private string _studentName;
        private string _studentPassword;
        private string _studentCourse;

        public string studentUsername
        {
            get
            {
                return _studentUsername;
            }
            set
            {
                _studentUsername = value;
            }
        }
        public string studentName
        {
            get
            {
                return _studentName;
            }
            set
            {
                _studentName = value;
            }
        }
        public string studentPassword
        {
            get
            {
                return _studentPassword;
            }
            set
            {
                _studentPassword = value;
            }
        }
        public string studentCourse
        {
            get
            {
                return _studentCourse;
            }
            set
            {
                _studentCourse = value;
            }
        }
        public Student()
        {
            studentUsername = "";
            studentName = "";
            studentPassword = "";
            studentCourse = "";
        }
        public Student(string StudentUsername, string StudentPassword)
        {
            studentUsername = StudentUsername;
            studentName = "";
            studentPassword = StudentPassword;
            studentCourse = "";

        }

        public Student(string StudentUsername, string StudentName, string StudentPassword, string StudentCourse)
        {
            studentUsername = StudentUsername;
            studentName = StudentName;
            studentPassword = StudentPassword;
            studentCourse = StudentCourse;
        }
    }
}
