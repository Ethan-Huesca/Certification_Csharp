using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>(); //creates new instance of a list
            myList.Add("23");
            myList.Add("hello hello baby");
            myList.Insert(0, "one");
            myList.Add("string");
            myList.Add("lastItem");

            List<Product> ListPro = new List<Product>(); //instance a new list with product class type of object
            ListPro.Add(new Product("A01196533", "Me", 96.97));
            ListPro.Add(new Product("A01196564", "tavo", 92.97));
            ListPro.Add(new Product("A01196483", "Mau", 95.97));
            ListPro.Add(new Product("A01196456", "Mau", 93.97));
            foreach (string item in myList) //Print the whole list
            {
                Console.WriteLine(item);
            }
            myList[1] = "24"; //change value of an item by index
            for(int i = 2; i < myList.Count; i++) //change values of items by more index
            {
                myList[i] = i.ToString(); //set number to string in list
            }
            myList.Sort(); //sorts ascendant/alphabetically
            Console.WriteLine();
            Console.WriteLine("list after modifying by index:");
            Console.WriteLine();
            foreach (string items in myList) //print new list
            {
                Console.WriteLine(items);
            }
            myList.Capacity = 5;
            Console.WriteLine();
            Console.WriteLine("Capacity of the list: {0}",myList.Capacity.ToString());
            Console.WriteLine();
            ListPro.Sort(); //sorts list alphabetically 
            foreach(Product p in ListPro)
            {
                Console.WriteLine(p + ", "+p.Price.ToString()); //print product along with price
            }
            Console.ReadKey();
        }
    }
}
