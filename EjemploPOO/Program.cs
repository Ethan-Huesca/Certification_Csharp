using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BootsontheHood ew = new BootsontheHood(); //instance bootsonthehood class, create a new object
            ew.Barking();
            ew.ChangeName("mlpdrZola");
            ew.Barking();*/
            Cafetera coffeeObject = new Cafetera();
            if (coffeeObject.FillCoffee(20))
                Console.WriteLine("Successfully filled coffee. Value: "+coffeeObject.ActualCoffeeQuantity().ToString());
            else
                Console.WriteLine("Cannot fill coffee");
            coffeeObject.ServeCoffee();
            Console.WriteLine("Actual coffee qtity is: "+coffeeObject.ActualCoffeeQuantity().ToString());
            Console.ReadKey(); //Stop class until a key is pressed
        }
    }

    class BootsontheHood
    {
        public int age; //var for age
        public string name = "jorgito"; //var for name

        public void ChangeName(string newName)
        {
            this.name = newName; //set new value to name variable
        }

        public void Barking()
        {
            Console.WriteLine(name + " woof"); //print message
        }
    }
}
