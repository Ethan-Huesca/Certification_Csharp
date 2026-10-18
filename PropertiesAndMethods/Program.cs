using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker coffee = new CoffeeMaker(); //create object
            coffee.Coffee = 50; //set value to send to property
            coffee.Code = "3";
            Console.WriteLine(  "coffee is at a level of: " +coffee.Coffee.ToString());
            Console.WriteLine("Coffee code: " +coffee.Code);

            Triangle tria = new Triangle(); //create object
            tria.Height = 5; //set values to properties
            tria.Base = 2.5; //set values to properties

            Console.WriteLine("Area of the triangle is: "+ tria.Area().ToString());
            tria.ReadMeasures(); //its not necessary to asign method to variable because it is a void type

            Console.WriteLine("Squared number {0} is: {1}",8,tria.SquaredNumber(8).ToString());
            Console.WriteLine("Squared number {0} is: {1}", 8.57, tria.SquaredNumber(8.57).ToString());

            Console.ReadKey();
        }
    }
}
