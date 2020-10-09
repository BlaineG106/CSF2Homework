using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //properties
        public float LoadCapacityLbs { get; set; }

        //CTOR
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs):base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        public Truck()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format(base.ToString() + "Load Capacity in Lbs: {0}\n", LoadCapacityLbs);
        }
    }
}
