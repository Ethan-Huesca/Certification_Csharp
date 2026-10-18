using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism1
{
    class Calculator
    {
        //Attributes
        private double _number1;
        private double _number2;

        public Calculator(double num1,  double num2)
        {
            this._number1 = num1;
            this._number2 = num2;
        }

        public Calculator() { }

        //Overloard the Addition method

        public int Addition(int value1, int value2, int value3)
        {
            return (value1 + value2 + value3); //output of the method
        }

        public double Addition(double value1, double value2)
        {
            return (value1 + value2);
        }

        public double Addition(double number)
        {
            double answ = _number1 + _number2;
            return answ + number;
        }
    }
}
