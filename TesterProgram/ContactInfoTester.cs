using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class ContactInfoTester
    {
        static void Main(string[] args)
        {
            string streetAddress = "123 jefferson street";
            string city = "Kansas City";
            string state = "Missouri";
            string zip = "12435";
            string phone = "816 222 3333";
            string email = "MikeH@gmail.com";

            ContactInfo person1 = new ContactInfo(streetAddress, city, state, zip, phone, email);
            Console.WriteLine(person1);

            ContactInfo person2 = new ContactInfo(streetAddress, city, state, zip, phone, email);
            Console.WriteLine(person2);
        }
    }
}
