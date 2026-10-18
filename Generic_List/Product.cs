using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    public class Product : IComparable //implementation of Icomparable interface
    {
        private string code;
        private string name;
        private double price;

        public Product(string cod, string nam, double pric)
        {
            this.code = cod; //set input variable to local private one
            this.name = nam; //set input variable to local private one
            this.price = pric; //set input variable to local private one
        }

        public override string ToString() //override the ToString method
        {
            return code + "->" + name.ToUpper(); //converts to upper case
        }

        public string Code
        {
            get { return code; } 
        }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }

        public int CompareTo(object obj)
        {
            Product anotherProd = (Product)obj; //set new variable and convert it to type product
            if (this.name != anotherProd.Name) //comparison between new name and previous saved
            {
                return this.name.CompareTo(anotherProd.Name); //use compareto and name property of anotherprod object as argument
            }
            else //if the other product name is the same
            {
                return this.price.CompareTo(anotherProd.Price); //compare and sort by prices
            }
        }

    }
}
