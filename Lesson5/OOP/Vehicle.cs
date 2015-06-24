using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Vehicle
    {
        // defined fields
        private string _make;
        private string _model;
        private int _elapsedMilage;

        // properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int ElapsedMilage
        {
            get { return _elapsedMilage; }
            set { _elapsedMilage = value; }
        }

        public string Drive(int kilometers)
        {
            _elapsedMilage += kilometers;

            // could preform some additional calculations here
            // for determining fuel consumption and wear and tear
            // costs

            // friendly string 
            string result;
            result = "The " + Make + " " + _model + " now has " + _elapsedMilage + " kilometers.";
            return result;

        }
    }
}


