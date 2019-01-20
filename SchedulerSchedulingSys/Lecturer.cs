using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSchedulingSys
{
    public class Lecturer
    {
        private string _lecturerUsername;
        private string _lecturerName;
        private string _lecturerPassword;
        private string _lecturerCourse;

        public string lecturerUsername
        {
            get
            {
                return _lecturerUsername;
            }
            set
            {
                _lecturerUsername = value;
            }
        }
        public string lecturerName
        {
            get
            {
                return _lecturerName;
            }
            set
            {
                _lecturerName = value;
            }
        }
        public string lecturerPassword
        {
            get
            {
                return _lecturerPassword;
            }
            set
            {
                _lecturerPassword = value;
            }
        }
        public string lecturerCourse
        {
            get
            {
                return _lecturerCourse;
            }
            set
            {
                _lecturerCourse = value;
            }
        }
        public Lecturer()
        {
            lecturerUsername = "";
            lecturerName = "";
            lecturerPassword = "";
            lecturerCourse = "";
        }
        public Lecturer(string LecturerUsername, string LecturerPassword)
        {
            lecturerUsername = LecturerUsername;
            lecturerName = "";
            lecturerPassword = LecturerPassword;
            lecturerCourse = "";

        }

        public Lecturer(string LecturerUsername, string LecturerName, string LecturerPassword, string LecturerCourse)
        {
            lecturerUsername = LecturerUsername;
            lecturerName = LecturerName;
            lecturerPassword = LecturerPassword;
            lecturerCourse = LecturerCourse;
        }
    }
}
