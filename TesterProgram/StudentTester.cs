using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class StudentTester
    {
        static void Main(string[] args)
        {

            string firstName = "John";
            string lastName = "Johnson";
            string id = "JohnJonhnson05";
            float gpa = 3.84f;
            Student studentInfo1 = new Student(firstName, lastName, id, gpa);
            Console.WriteLine(studentInfo1);

            Student studentInfo2 = new Student(firstName, lastName, id, gpa);
            Console.WriteLine(studentInfo2);
        
        }
    }
}
