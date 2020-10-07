using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;
        //properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end Make
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end Make
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end Year
        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end Weight

        //constructors
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }//end Fully Qualified constructor

        public Vehicle() { }//end default constructor

        //methods
        public override string ToString()
        {
            return string.Format("make-{0}\n" +
               "model-{1}\n" + Year + "\n" + Weight + "\n", Make, Model);
                
        }


    }//end class
}//end namespace
