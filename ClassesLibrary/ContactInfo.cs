using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {
        //fields
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;
        //properties
        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end StreetAddress
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }//end City
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }//end State
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }//end Zip
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end Phone
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }//end Email
        //constructors
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }//end fully qualified constructor
        public ContactInfo() { }//end default constructor

        //methods
        public override string ToString()
        {
            return string.Format("Street Address: {0}\n" +
                "City: {1}\n" +
                "State: {2}\n" +
                "Zip: {3}\n" +
                "Phone: {4}\n" +
                "Email: {5}", StreetAddress, City, State, Zip, Phone, Email);
        }
    }
}
