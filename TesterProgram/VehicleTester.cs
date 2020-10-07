using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class VehicleTester
    {
        static void Main(string[] args)
        {


            string make = "Ford";
            string model = "Fusion";
            int year = 2008;
            float weight = 2.3f;

            Vehicle fusion1 = new Vehicle( make, model, year, weight);
            Console.WriteLine(fusion1);

            Vehicle fusion2 = new Vehicle( make, model, year, weight);
            Console.WriteLine(fusion2);
        }
    }
}
