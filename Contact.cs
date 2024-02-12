using Address_Book_System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Address_Book_System
{
    class Contact
    {
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private string phonenumber;
        private long zipcode;
        private string email;

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Phonenumber
        {
            get { return phonenumber; }
            set { phonenumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public long Zipcode
        {
            get { return zipcode; }
            set { zipcode = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Contact other = (Contact)obj;
            return Firstname.Equals(other.Firstname, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Firstname.GetHashCode();
        }
        public Contact()
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
            this.Phonenumber = phonenumber;
            this.Email = email;
        }
    }
}