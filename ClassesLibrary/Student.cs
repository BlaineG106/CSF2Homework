using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }//end Id
        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value;  }
        }//end GPA

        //constructors
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            GPA = gpa;
        }//Fully qualified constructor

        public Student() { }//end of default constructor
        //methods
        public override string ToString()
        {
            return string.Format("firstName-{0}\n" +
                "lastName-{1}\n" +
                "id-{2}\n" +
                "gpa-{3}\n", FirstName, LastName, Id, GPA);
        }//end ToString()

    }//end class
}//end namespace
