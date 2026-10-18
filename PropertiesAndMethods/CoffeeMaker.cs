using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class CoffeeMaker
    {
        int _id;
        double _mincoffee;
        double _coffee;

        //Properties
        public string Code //property should be the same type as origin. Name can be anything
        {
            get { return "COFFEE000"+_id; } //get = return info from the property
            set { _id = int.Parse(value); } //set info to the property
        }

        public double MinCoffee //no set field cuz it only returns info, it doesnt assign
        {
            get { return _mincoffee; } //get = return info from the property
        }

        public double Coffee
        {
            get { return _coffee; } //get = return info from the variable
            set { _coffee = value; } //set info to the variablee
        }


    }
}
