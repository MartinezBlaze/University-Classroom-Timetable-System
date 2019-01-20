using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSchedulingSys
{
    public class Scheduler
    {
        // PROPERTIES FIELDS
        private string _schedulerUsername;
        private string _schedulerName;
        private string _schedulerPassword;

        // GETTER AND SETTER
        public string schedulerUsername
        {
            get
            {
                return _schedulerUsername;
            }
            set
            {
                _schedulerUsername = value;
            }
        }

        public string schedulerName
        {
            get
            {
                return _schedulerName;
            }
            set
            {
                _schedulerName = value;
            }
        }

        public string schedulerPassword
        {
            get
            {
                return _schedulerPassword;
            }
            set
            {
                _schedulerPassword = value;
            }
        }

        // CONSTRUCTOR
        public Scheduler()
        {
            schedulerUsername = "";
            schedulerName = "";
            schedulerPassword = "";
        }

        public Scheduler(string SchedulerUsername, string SchedulerPassword)
        {
            schedulerUsername = SchedulerUsername;
            schedulerName = "";
            schedulerPassword = SchedulerPassword;
        }

        public Scheduler(string SchedulerUsername, string SchedulerName, string SchedulerPassword)
        {
            schedulerUsername = SchedulerUsername;
            schedulerName = SchedulerName;
            schedulerPassword = SchedulerPassword;
        }
    }
}
