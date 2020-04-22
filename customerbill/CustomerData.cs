using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerbill
{
    class CustomerData
    {
        // private data
        private int number;
        private string name;
        private string type;
        private double charge;
 

        // public properties

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0) number = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
        
            }
        }

        public double Charge
        {
            get { return charge; }
            set
            {
                if (value >= 0) charge = value;
                
            }
        }

        // constructor
        public CustomerData(int nu  , string na ,  string t, double c)
        {
            number = nu;
            name = na;
            type = t;
            charge = c;
        }


        // public operations (methods)
        public double chargeAmount()
        {
            return charge;
        }

        public override string ToString()
        {
            return number.ToString() + ": " + name + ", " + type + ", " + "$"+ charge.ToString();
        }
    } // end class Customer Data
}

