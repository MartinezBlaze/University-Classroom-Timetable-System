using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSchedulingSystem
{
    public class Computer_Lab
    {
        // ATTRIBUTE FIELDS
        private string _name;
        private string _block;
        private string _type;
        private int _capacity;
        private string _availability;
        private int _released;
        //public string CheckAvailability();

        // GETTER AND SETTER
        public string name
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

        public string block
        {
            get
            {
                return _block;
            }
            set
            {
                _block = value;
            }
        }

        public string type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public int capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
            }
        }

        public string availability
        {
            get
            {
                return _availability;
            }
            set
            {
                _availability = value;
            }
        }

        public int released
        {
            get
            {
                return _released;
            }
            set
            {
                _released = value;
            }
        }

        /* METHODS
        public string CheckAvailability()
        {
            return _availability;
        }

        public void BookClassroom()
        {
            if (CheckAvailability() == "Available")
            {
                availability = "Booked";
            }
            else
            {

            }
        }
        */

        // CONSTRUCTOR
        public Computer_Lab(string Name, string Block, string Type, int Capacity)//checkavalability
        {
            name = Name;
            block = Block;
            type = Type;
            capacity = Capacity;
            availability = "Available";
            released = 0;
        }
    }
}
