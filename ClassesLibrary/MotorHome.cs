using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //properties
        public int NumberOfBeds { get; set; }

        //CTOR
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds) :base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }

        public MotorHome()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format(base.ToString() + "Number of Beds: {0}", NumberOfBeds);
        }
    }
}
