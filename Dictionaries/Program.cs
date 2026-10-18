using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable(); //create object for hashtable
            bool found;
            bool found2;
            table.Add("1", 34.45);
            table.Add("2", 55.44);
            table.Add("3", 34.55);
            table.Add("4", 4.44);

            found = table.Contains("three"); //search by key
            found2 = table.ContainsValue(34.55); //search by value
            foreach(DictionaryEntry dic in table) //dictionaryentry gives a pair key-value
            {
                Console.WriteLine("key = {0}, value = {1}",dic.Key.ToString(),dic.Value.ToString()); //print each key and value
            }
            Console.WriteLine();
            SortedList sort = new SortedList(); //similar to hashtable, but values are ordered by key ascending
            sort.Add("1", "name");
            sort.Add("5", "lastname");
            sort.Add("3", "address");
            foreach(DictionaryEntry dic2 in sort)
            {
                Console.WriteLine("key = {0}, value = {1}", dic2.Key.ToString(), dic2.Value.ToString()); //print each key and value
            }
            sort.SetByIndex(1, "nickname"); //set new value in a specific index
            Console.WriteLine();
            Console.WriteLine("new sorted list after changing a value by index: ");
            Console.WriteLine();
            foreach (DictionaryEntry dic2 in sort)
            {
                Console.WriteLine("key = {0}, value = {1}", dic2.Key.ToString(), dic2.Value.ToString()); //print each key and value
            }
            Console.WriteLine("element is: "+table["2"].ToString()); //print a value by its key
            Console.WriteLine("found 'three' key? : "+found.ToString());
            Console.WriteLine("found 34.55 value? :"+found2.ToString());
            Console.ReadKey(); //wait for enter 
        }
    }
}
