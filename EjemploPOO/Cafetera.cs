using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    public class Cafetera
    {
        public int minCoffee = 2;
        public int maxCoffee = 35;
        private int coffee = 7;

        public bool FillCoffee(int quantity)
        {
            if((coffee + quantity) < maxCoffee) //if coffee and quant is less than max capacity
            {
                coffee += quantity; //pour some coffee
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ServeCoffee()
        {
            if(coffee > minCoffee) //if coffee greater than minimum capacity
            {
                coffee -= 2; //substract some coffee
                Console.WriteLine("served some coffee");
            }
            else
            {
                Console.WriteLine("!! No more coffee to serve");
            }
        }

        public int ActualCoffeeQuantity()
        {
            return coffee;
        }
    }
}
