using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arli = new ArrayList(); //instantiate arraylist
            arli.Add(2); //add is a function
            arli.Add("mlpDRZOLA");
            arli.Add(12.5);

            arli.Insert(2, true); //insert true value on index number 2

            Console.WriteLine("length of the arraylist: "+arli.Count.ToString());//count is a property
            foreach(object ob in arli)
            {
                Console.WriteLine(ob.ToString()); //print whole list
            }

            arli.RemoveAt(2); //deletes an element in the list
            arli.Remove("mlpDRZOLA"); //deletes a specific element in the list
            Console.WriteLine();
            Console.WriteLine("after deleting elements");
            foreach (object ob in arli)
            {
                Console.WriteLine(ob.ToString()); //print whole list
            }
            Console.WriteLine();
            Clients cli = new Clients();
            cli.Addd("jorge es vieja");
            cli.addList(new string[] { "client1", "client2", "client3", "client4" }); //Add new list 
            cli.Edit("client2", "ethan huesca"); //call for the edit function and change value
            cli.Deletee("client1"); //deletes the specific string in the arraylist
            cli.SelectClients();

            Console.WriteLine("");
            cli.Sorting();
            cli.SelectClients();

            Console.WriteLine("");
            cli.Sortingdesc();
            cli.SelectClients();
            Console.ReadKey();

        }
    }
}
