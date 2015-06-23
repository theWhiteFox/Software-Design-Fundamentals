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

        public string Make
        {
            get { return _make; }
            set { _make = value; }

            // more control, filter out values using the set statement
            //set
            //{
            //    if ((value == "DeLorean") || (value == "Ecto-1"))
            //    {
            //        _make = value;
            //    }
            //    else
            //    {
            //        _make = "not assigned";
            //    }
            //}
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
    }
}

