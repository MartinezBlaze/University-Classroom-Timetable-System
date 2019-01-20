using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerSchedulingSys
{
    public class BookingDetails
    {
        // PROPERTIES FIELDS
        private string _username;
        private string _name;
        private string _event;
        private string _location;
        private List<string> _bookedAvb = new List<string>();
        private string _date;
        private string _time;
        private string _previousDate;
        private string _previousTime;

        // GETTER AND SETTER
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Event
        {
            get
            {
                return _event;
            }
            set
            {
                _event = value;
            }
        }

        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        public List<string> BookedAvb
        {
            get
            {
                return _bookedAvb;
            }
            set
            {
                _bookedAvb = value;
            }
        }

        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        public string Time
        {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }

        public string PreviousDate
        {
            get
            {
                return _previousDate;
            }
            set
            {
                _previousDate = value;
            }
        }

        public string PreviousTime
        {
            get
            {
                return _previousTime;
            }
            set
            {
                _previousTime = value;
            }
        }
    }
}
