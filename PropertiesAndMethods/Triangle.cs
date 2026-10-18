 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    public class Triangle //make class public to manipulate from main program
    {
        double _base;
        double _height;

        //properties
        public double Base
        {
            get { return _base; } //get is for returning value
            set { _base = value; } //set is for setting value
        }

        public double Height
        {
            get { return _height; } //get is for returning value
            set { _height = value; } //set is for setting value
        }

        public double Area() //method for calculating area
        {
            double area;
            area = (_base * _height) / 2;
            return area;
        }

        public void ReadMeasures() //void methodd doesnt return any values
        {
            Console.WriteLine("base: "+_base);
            Console.WriteLine("height: "+_height);
        }

        public double SquaredNumber(int number)
        {
            double answer;
            answer = number * number;
            return answer;
        }

        public double SquaredNumber(double number)
        {
            double answer;
            answer = number * number;
            return answer;
        }
    }
}
