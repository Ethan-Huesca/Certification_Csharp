using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Clients
    {
        private ArrayList db = new ArrayList();

        public void Addd(string name) //add new element to arraylist
        {
            db.Add(name); //adds element to arrayilst
        }

        public void addList(string[] clients)
        {
            db.AddRange(clients); //Adds a full collection of elements
        }

        public void Edit(string edit, string newelement) //edit an element with old string and new one
        {
            db[db.IndexOf(edit)] = newelement; //select specific index by string and replace it 
        }

        public void Deletee(string element) //delete a specific element
        {
            db.Remove(element); //removes element from arraylist
        }

        public void SelectClients() //Print the list of clients
        {
            foreach(object ob in db)
            {
                Console.WriteLine(ob.ToString());
            }
        }

        public void Sorting()
        {
            db.Sort(); //sorts elements in ascending way
        }
        
        public void Sortingdesc()
        {
            db.Sort(new SortDesc()); //call for sorting descending class
        }
    }

    class SortDesc : IComparer //implement interface
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer().Compare(y, x)); //compare 2 objects for equivalence, ignoring case of strings
        }
    }
}
