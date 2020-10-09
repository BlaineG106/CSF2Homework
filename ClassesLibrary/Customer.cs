using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        //properties
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        //FQCTOR
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public Customer() { }//default

        //methods
        public override string ToString()
        {
            return string.Format("Customer Id: {0}\n" +
                "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Contact Information: {3}", CustomerId, FirstName, LastName, ContactInformation);
        }
    }
}
